using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace lab2
{
    public class Database
    {
        private string connectionString = "Host=localhost; Port=5432; Database=oop2; User Id=postgres; Password=1234;";

        public DataTable GetShapes()
        {
            DataTable dataTable = new DataTable();

            using (var connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "select t.id, s.name as Название, s.color as Цвет, s.type as Тип\r\nfrom triangle t\r\nJOIN shape s on t.shape_id=s.id\r\nUNION\r\nselect r.id, s.name as Название, s.color as Цвет, s.type as Тип\r\nfrom rectangle r\r\nJOIN shape s on r.shape_id=s.id"; // Запрос для получения данных из таблицы Shape

                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        using (var adapter = new NpgsqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable); // Заполнение DataTable данными
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Ошибка при получении данных: " + ex.Message);
                }
            }

            return dataTable;
        }
        public void UpdateTriangle(int triangleId, Triangle triangle)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    // Получаем shape_id по triangleId
                    int shapeId;
                    using (var cmd = new NpgsqlCommand("SELECT shape_id FROM triangle WHERE id = @triangleId", connection, transaction))
                    {
                        cmd.Parameters.AddWithValue("@triangleId", triangleId);
                        shapeId = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    // Обновляем данные в таблице Shape
                    using (var cmd = new NpgsqlCommand(
                        "UPDATE Shape SET color = @color, x_cord = @xCord, y_cord = @yCord, name = @name, description = @description WHERE id = @shapeId",
                        connection, transaction))
                    {
                        cmd.Parameters.AddWithValue("@shapeId", shapeId);
                        cmd.Parameters.AddWithValue("@color", triangle.Color.ToArgb());
                        cmd.Parameters.AddWithValue("@xCord", triangle.X);
                        cmd.Parameters.AddWithValue("@yCord", triangle.Y);
                        cmd.Parameters.AddWithValue("@name", triangle.Name);
                        cmd.Parameters.AddWithValue("@description", triangle.Description);
                        cmd.ExecuteNonQuery();
                    }

                    // Обновляем данные в таблице Triangle
                    using (var cmd = new NpgsqlCommand(
                        "UPDATE Triangle SET side_a = @sideA, side_b = @sideB, side_c = @sideC WHERE id = @triangleId",
                        connection, transaction))
                    {
                        cmd.Parameters.AddWithValue("@triangleId", triangleId);
                        cmd.Parameters.AddWithValue("@sideA", triangle.A);
                        cmd.Parameters.AddWithValue("@sideB", triangle.B);
                        cmd.Parameters.AddWithValue("@sideC", triangle.C);
                        cmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                }
            }
        }

        public void UpdateRectangle(int rectangleId, Rectangle rectangle)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    int shapeId;
                    using (var cmd = new NpgsqlCommand("SELECT shape_id FROM rectangle WHERE id = @rectangleId", connection, transaction))
                    {
                        cmd.Parameters.AddWithValue("@rectangleId", rectangleId);
                        shapeId = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    using (var cmd = new NpgsqlCommand(
                        "UPDATE Shape SET color = @color, x_cord = @xCord, y_cord = @yCord, name = @name, description = @description WHERE id = @shapeId",
                        connection, transaction))
                    {
                        cmd.Parameters.AddWithValue("@shapeId", shapeId);
                        cmd.Parameters.AddWithValue("@color", rectangle.Color.ToArgb());
                        cmd.Parameters.AddWithValue("@xCord", rectangle.X);
                        cmd.Parameters.AddWithValue("@yCord", rectangle.Y);
                        cmd.Parameters.AddWithValue("@name", rectangle.Name);
                        cmd.Parameters.AddWithValue("@description", rectangle.Description);
                        cmd.ExecuteNonQuery();
                    }

                    using (var cmd = new NpgsqlCommand(
                        "UPDATE Rectangle SET width = @width, height = @height WHERE id = @rectangleId",
                        connection, transaction))
                    {
                        cmd.Parameters.AddWithValue("@rectangleId", rectangleId);
                        cmd.Parameters.AddWithValue("@width", rectangle.W);
                        cmd.Parameters.AddWithValue("@height", rectangle.H);
                        cmd.ExecuteNonQuery();
                    }
                    transaction.Commit();
                }
            }
        }

        public void CreateTriangle(int color, int xCord, int yCord, string name, string description, int sideA, int sideB, int sideC)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    int shapeId;
                    using (var cmd = new NpgsqlCommand(
                        "INSERT INTO Shape (color, x_cord, y_cord, name, type, description) " +
                        "VALUES (@color, @xCord, @yCord, @name, 'Triangle', @description) RETURNING id",
                        connection, transaction))
                    {
                        cmd.Parameters.AddWithValue("@color", color);
                        cmd.Parameters.AddWithValue("@xCord", xCord);
                        cmd.Parameters.AddWithValue("@yCord", yCord);
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@description", description);
                        shapeId = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                    using (var cmd = new NpgsqlCommand(
                        "INSERT INTO Triangle (shape_id, side_a, side_b, side_c) " +
                        "VALUES (@shapeId, @sideA, @sideB, @sideC)",
                        connection, transaction))
                    {
                        cmd.Parameters.AddWithValue("@shapeId", shapeId);
                        cmd.Parameters.AddWithValue("@sideA", sideA);
                        cmd.Parameters.AddWithValue("@sideB", sideB);
                        cmd.Parameters.AddWithValue("@sideC", sideC);
                        cmd.ExecuteNonQuery();
                    }
                    transaction.Commit();
                }
            }
        }

        public void CreateRectangle(int color, int xCord, int yCord, string name, string description, int width, int height)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    int shapeId;
                    using (var cmd = new NpgsqlCommand(
                        "INSERT INTO Shape (color, x_cord, y_cord, name, type, description) VALUES (@color, @xCord, @yCord, @name, 'Rectangle', @description) RETURNING id",
                        connection, transaction))
                    {
                        cmd.Parameters.AddWithValue("@color", color);
                        cmd.Parameters.AddWithValue("@xCord", xCord);
                        cmd.Parameters.AddWithValue("@yCord", yCord);
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@description", description);
                        shapeId = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                    using (var cmd = new NpgsqlCommand(
                        "INSERT INTO Rectangle (shape_id, width, height) VALUES (@shapeId, @width, @height)",
                        connection, transaction))
                    {
                        cmd.Parameters.AddWithValue("@shapeId", shapeId);
                        cmd.Parameters.AddWithValue("@width", width);
                        cmd.Parameters.AddWithValue("@height", height);
                        cmd.ExecuteNonQuery();
                    }
                    transaction.Commit();
                }
            }
        }

        public void DeleteTriangle(int triangleId)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Сначала получаем shape_id для удаления из таблицы Triangle
                        int shapeId;
                        string getShapeIdQuery = "SELECT shape_id FROM Triangle WHERE id = @triangleId";
                        using (var command = new NpgsqlCommand(getShapeIdQuery, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@triangleId", triangleId);
                            shapeId = (int)command.ExecuteScalar(); // Получаем shape_id
                        }

                        // Удаляем запись из таблицы Triangle
                        string deleteTriangleQuery = "DELETE FROM Triangle WHERE id = @triangleId";
                        using (var command = new NpgsqlCommand(deleteTriangleQuery, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@triangleId", triangleId);
                            command.ExecuteNonQuery(); 
                        }

                        // Удаляем запись из таблицы Shape
                        string deleteShapeQuery = "DELETE FROM Shape WHERE id = @shapeId";
                        using (var command = new NpgsqlCommand(deleteShapeQuery, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@shapeId", shapeId);
                            command.ExecuteNonQuery();
                        }

                        transaction.Commit(); 
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception("Ошибка при удалении Triangle: " + ex.Message);
                    }
                }
            }
        }

        public void DeleteRectangle(int rectangleId)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Сначала получаем shape_id для удаления из таблицы Rectangle
                        int shapeId;
                        string getShapeIdQuery = "SELECT shape_id FROM Rectangle WHERE id = @rectangleId";
                        using (var command = new NpgsqlCommand(getShapeIdQuery, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@rectangleId", rectangleId);
                            shapeId = (int)command.ExecuteScalar(); // Получаем shape_id
                        }

                        // Удаляем запись из таблицы Rectangle
                        string deleteRectangleQuery = "DELETE FROM Rectangle WHERE id = @rectangleId";
                        using (var command = new NpgsqlCommand(deleteRectangleQuery, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@rectangleId", rectangleId);
                            command.ExecuteNonQuery(); 
                        }

                        // Удаляем запись из таблицы Shape
                        string deleteShapeQuery = "DELETE FROM Shape WHERE id = @shapeId";
                        using (var command = new NpgsqlCommand(deleteShapeQuery, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@shapeId", shapeId);
                            command.ExecuteNonQuery(); 
                        }

                        transaction.Commit(); 
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback(); 
                        throw new Exception("Ошибка при удалении Rectangle: " + ex.Message);
                    }
                }

            }
        }

        public Shape GetTriangleById(int triangleId)
        {
            Shape triangle = null;
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT s.color, s.x_cord, s.y_cord, s.name, s.description, t.side_a, t.side_b, t.side_c " +
                               "FROM Triangle t JOIN Shape s ON t.shape_id = s.id WHERE t.id = @triangleId";

                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@triangleId", triangleId);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int color = reader.GetInt32(0);
                            Color color1 = Color.FromArgb(color);
                            triangle = new Triangle(color1, reader.GetInt32(1), reader.GetInt32(2), reader.GetString(3), reader.GetString(4), reader.GetInt32(5), reader.GetInt32(6), reader.GetInt32(7));
                    }
                    }
                }
            }

            return triangle;
        }

        public Shape GetRectangleById(int rectangleId)
        {
            Shape rectangle = null;
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT s.color, s.x_cord, s.y_cord, s.name, s.description, r.height, r.width " +
                               "FROM rectangle r JOIN Shape s ON r.shape_id = s.id WHERE r.id = @rectangleId";

                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@rectangleId", rectangleId);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int color = reader.GetInt32(0);
                            Color color1 = Color.FromArgb(color);
                            rectangle = new Rectangle(color1, reader.GetInt32(1), reader.GetInt32(2), reader.GetString(3), reader.GetString(4), reader.GetInt32(5), reader.GetInt32(6));
                        }
                    }
                }
            }

            return rectangle;
        }

    }
}
