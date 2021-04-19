using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectorChino.CrudBooks.WindowsForm
{
    public class BookData : HelperADONet
    {

        public bool AddBook(Book book)
        {
            ///Iniciaizar conexión a base dde datos utilizando el método de 
            ///conexión de Helper
            var command = _dbConnection.CreateCommand();

            ///Nombre del SP
            command.CommandText = "sp_add_book";
            command.CommandTimeout = TimeOut;
            command.CommandType = CommandType.StoredProcedure;

            ///EL orden de los parámetros debe de ser igual al orden declarado en el SP
            var parameters = new List<SqlParameter> {
                new SqlParameter { ParameterName = "@NameBook", Value = book.NameBook, DbType = DbType.String },
                new SqlParameter { ParameterName = "@AuthorName", Value = book.AuthorName, DbType = DbType.String },
                new SqlParameter { ParameterName = "@Price", Value = book.Price, DbType = DbType.Decimal },
                new SqlParameter { ParameterName = "@PublishDate", Value = book.PublishDate, DbType = DbType.DateTime}
            };

            //agregar parámetros a commando de ejecución
            command.Parameters.AddRange(parameters.ToArray());

            //ejecutar el comando
            int rowsAffected = command.ExecuteNonQuery();

            return (rowsAffected == 1) ? true : false;
        }

        public bool UpdateBook(int id, Book book)
        {

            var command = _dbConnection.CreateCommand();

            ///Nombre del SP
            command.CommandText = "sp_update_book";
            command.CommandTimeout = TimeOut;
            command.CommandType = CommandType.StoredProcedure;

            ///EL orden de los parámetros debe de ser igual al orden declarado en el SP
            var parameters = new List<SqlParameter> {
                new SqlParameter { ParameterName = "@Id", Value = id, DbType = DbType.Int32 },
                new SqlParameter { ParameterName = "@NameBook", Value = book.NameBook, DbType = DbType.String },
                new SqlParameter { ParameterName = "@AuthorName", Value = book.AuthorName, DbType = DbType.String },
                new SqlParameter { ParameterName = "@Price", Value = book.Price, DbType = DbType.Decimal },
                new SqlParameter { ParameterName = "@PublishDate", Value = book.PublishDate, DbType = DbType.DateTime}
            };

            command.Parameters.AddRange(parameters.ToArray());

            int rowsAffected = command.ExecuteNonQuery();

            return (rowsAffected == 1) ? true : false;

        }

        public bool DeleteBook(int id)
        {

            var command = _dbConnection.CreateCommand();

            ///Nombre del SP
            command.CommandText = "sp_delete_book";
            command.CommandTimeout = TimeOut;
            command.CommandType = CommandType.StoredProcedure;

            ///EL orden de los parámetros debe de ser igual al orden declarado en el SP
            var parameters = new List<SqlParameter> {
                new SqlParameter { ParameterName = "@Id", Value = id, DbType = DbType.Int32 }
            };

            command.Parameters.AddRange(parameters.ToArray());

            int rowsAffected = command.ExecuteNonQuery();

            return (rowsAffected == 1) ? true : false;

        }

        public List<Book> GetAllBooks()
        {
            ///declarar una lista de libros
            var list = new List<Book>();

            var command = _dbConnection.CreateCommand();
            command.CommandText = "sp_get_all_book";
            command.CommandTimeout = TimeOut;
            command.CommandType = CommandType.StoredProcedure;
            
            ///ejecución de una lectura
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new Book
                {
                    Id = Convert.ToInt32(reader["IdBook"]),
                    NameBook = reader["NameBook"].ToString(),
                    AuthorName = reader["AuthorName"].ToString(),
                    Price = Convert.ToDouble(reader["Price"]),
                    PublishDate = Convert.ToDateTime(reader["PublishDate"])
                });

            }

            return list;

        }

        public Book GetBookById(int id)
        {
            var list = new List<Book>();
            var command = _dbConnection.CreateCommand();
            command.CommandText = "sp_get_book_by_id";
            command.CommandTimeout = TimeOut;
            command.CommandType = CommandType.StoredProcedure;
            ///EL orden de los parámetros debe de ser igual al orden declarado en el SP
            var parameters = new List<SqlParameter> {
                new SqlParameter { ParameterName = "@Id", Value = id, DbType = DbType.Int32 }
            };
            command.Parameters.AddRange(parameters.ToArray());

            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new Book
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    NameBook = reader["NameBook"].ToString(),
                    AuthorName = reader["AuthorName"].ToString(),
                    Price = Convert.ToDouble(reader["Price"]),
                    PublishDate = Convert.ToDateTime(reader["PublishDate"])
                });

            }

            return list.FirstOrDefault();

        }


    }
}
