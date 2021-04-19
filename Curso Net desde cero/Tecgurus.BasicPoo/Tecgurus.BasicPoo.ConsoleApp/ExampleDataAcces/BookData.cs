using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tecgurus.ExamplePoo.ConsoleApp.ExampleDataAcces
{
    /// <summary>
    /// CLASE PARA CONTROL DE ACCESO A DATOS
    /// SE RECOMIENDA IMPLEMENTAR UNA CADA ENTIDAD QUE SE REQUIERA
    /// </summary>
    public class BookData : HelperADONet //Se hereda del helperADONet
    {
        public bool AddBook(Book book)
        {
            ///Iniciaizar conexión a base de datos utilizando el método de 
            ///conexión de Helper
            var command = _dbConnection.CreateCommand();

            ///Nombre del SP
            command.CommandText = "sp_add_books";
            command.CommandTimeout = TimeOut;
            command.CommandType = CommandType.StoredProcedure;

            ///EL orden de los parámetros debe de ser igual al orden declarado en el SP
            var parameters = new List<SqlParameter> {
                new SqlParameter { ParameterName = "@NameBook", Value = book.NameBook, SqlDbType = SqlDbType.NVarChar },
                new SqlParameter { ParameterName = "@DatePublish", Value = book.DatePublishBook, SqlDbType = SqlDbType.Date },
                new SqlParameter { ParameterName = "@NumberPages", Value = book.NumberPages, SqlDbType = SqlDbType.SmallInt },
                new SqlParameter { ParameterName = "@SalePrice", Value = book.SalePrice, SqlDbType = SqlDbType.Decimal },
                new SqlParameter { ParameterName = "@PurchasePrice", Value = book.PurchasePrice, SqlDbType = SqlDbType.Decimal},
                new SqlParameter { ParameterName = "@IsAvaible", Value = book.IsAvaible, SqlDbType = SqlDbType.Bit}
            };

            //agregar parámetros a commando de ejecución
            command.Parameters.AddRange(parameters.ToArray());

            //ejecutar el comando, se mando a ejecutar, sin esperar algo a cambio
            int rowsAffected = command.ExecuteNonQuery();

            //if explicito para el valor de retorno
            //if (rowsAffected == 1) {
            //    return true;
            //}
            //else {
            //    return false;
            //}

            //se pone un if implicito, para su valor de retorno
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
                new SqlParameter { ParameterName = "@IdBook", Value = book.IdBook, SqlDbType = SqlDbType.Int },
                new SqlParameter { ParameterName = "@NameBook", Value = book.NameBook, SqlDbType = SqlDbType.NVarChar },
                new SqlParameter { ParameterName = "@DatePublish", Value = book.DatePublishBook, SqlDbType = SqlDbType.Date },
                new SqlParameter { ParameterName = "@NumberPages", Value = book.NumberPages, SqlDbType = SqlDbType.SmallInt },
                new SqlParameter { ParameterName = "@SalePrice", Value = book.SalePrice, SqlDbType = SqlDbType.Decimal },
                new SqlParameter { ParameterName = "@PurchasePrice", Value = book.PurchasePrice, SqlDbType = SqlDbType.Decimal},
                new SqlParameter { ParameterName = "@IsAvaible", Value = book.IsAvaible, SqlDbType = SqlDbType.Bit}
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
                new SqlParameter { ParameterName = "@Id", Value = id, SqlDbType = SqlDbType.Int }
            };

            command.Parameters.AddRange(parameters.ToArray());

            int rowsAffected = command.ExecuteNonQuery();

            return (rowsAffected == 1) ? true : false;

        }

        public List<Book> GetAllBooks()
        {
            ///declarar una lista de libros
            var list = new List<Book>();

            var command = _dbConnection.CreateCommand(); //Crea la conexion
            command.CommandText = "sp_get_all_books"; // se indica el sp a ejecutar
            command.CommandTimeout = TimeOut; // se pone el time out
            command.CommandType = CommandType.StoredProcedure; // se indica que tiepo de comando sera el que se ejecutara

            ///ejecución de una lectura
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new Book
                {
                    IdBook = Convert.ToInt32(reader["IdBook"])
                    ,
                    NameBook = reader["NameBook"].ToString()
                    ,
                    NumberPages = Convert.ToInt16(reader["NumberPages"])
                    ,
                    SalePrice = Convert.ToDouble(reader["SalePrice"])
                    ,
                    PurchasePrice = Convert.ToDouble(reader["PurchasePrice"].ToString())
                    ,
                    DatePublishBook = Convert.ToDateTime(reader["DatePublishBook"])
                    ,
                    IsAvaible = Convert.ToBoolean(reader["IsAvaible"])
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
                new SqlParameter { ParameterName = "@Id", Value = id, SqlDbType = SqlDbType.Int }
            };
            command.Parameters.AddRange(parameters.ToArray());

            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new Book
                {
                    IdBook = Convert.ToInt32(reader["IdBook"])
                    ,
                    NameBook = reader["NameBook"].ToString()
                    ,
                    NumberPages = Convert.ToInt16(reader["NumberPages"])
                    ,
                    SalePrice = Convert.ToDouble(reader["SalePrice"])
                    ,
                    PurchasePrice = Convert.ToDouble(reader["PurchasePrice"].ToString())
                    ,
                    DatePublishBook = Convert.ToDateTime(reader["DatePublishBook"])
                    ,
                    IsAvaible = Convert.ToBoolean(reader["IsAvaible"])
                });

            }

            return list.FirstOrDefault();

        }
    }
}
