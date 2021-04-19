using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tecgurus.ThreeLayers.Ent;

namespace Tecgurus.ThreeLayers.DL
{
    /// <summary>
    /// CLASE PARA CONTROL DE ACCESO A DATOS
    /// SE RECOMIENDA IMPLEMENTAR UNA CADA ENTIDAD QUE SE REQUIERA
    /// </summary>
    public class BookData : HelperADONet
    {
        public bool AddBook(BookEnt book)
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

            //ejecutar el comando
            int rowsAffected = command.ExecuteNonQuery();

            return (rowsAffected == 1) ? true : false;
        }

        public bool UpdateBook(int id, BookEnt book)
        {

            var command = _dbConnection.CreateCommand();

            ///Nombre del SP
            command.CommandText = "sp_update_books";
            command.CommandTimeout = TimeOut;
            command.CommandType = CommandType.StoredProcedure;

            ///EL orden de los parámetros debe de ser igual al orden declarado en el SP
            var parameters = new List<SqlParameter> {
                new SqlParameter { ParameterName = "@Id", Value = book.IdBook, SqlDbType = SqlDbType.Int },
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
            command.CommandText = "sp_delete_books";
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

        public List<BookEnt> GetAllBooks()
        {
            ///declarar una lista de libros
            var list = new List<BookEnt>();

            var command = _dbConnection.CreateCommand();
            command.CommandText = "sp_get_all_books";
            command.CommandTimeout = TimeOut;
            command.CommandType = CommandType.StoredProcedure;

            ///ejecución de una lectura
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new BookEnt
                {
                    IdBook = Convert.ToInt32(reader["IdBook"])
                    ,
                    NameBook = reader["NameBook"].ToString()
                    ,
                    NumberPages = Convert.ToInt16(reader["NumberPages"])
                    ,
                    SalePrice = Convert.ToDouble(reader["SalePrice"])
                    ,
                    PurchasePrice = Convert.ToDecimal(reader["PurchasePrice"].ToString())
                    ,
                    DatePublishBook = Convert.ToDateTime(reader["DatePublishBook"])
                    ,
                    IsAvaible = Convert.ToBoolean(reader["IsAvaible"])
                });

            }

            return list;

        }

        public BookEnt GetBookById(int id)
        {
            var list = new List<BookEnt>();
            var command = _dbConnection.CreateCommand();
            command.CommandText = "sp_get_books_by_id";
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
                list.Add(new BookEnt
                {
                    IdBook = Convert.ToInt32(reader["IdBook"])
                    ,
                    NameBook = reader["NameBook"].ToString()
                    ,
                    NumberPages = Convert.ToInt16(reader["NumberPages"])
                    ,
                    SalePrice = Convert.ToDouble(reader["SalePrice"])
                    ,
                    PurchasePrice = Convert.ToDecimal(reader["PurchasePrice"].ToString())
                    ,
                    DatePublishBook = Convert.ToDateTime(reader["DatePublishBook"])
                    ,
                    IsAvaible = Convert.ToBoolean(reader["IsAvaible"])
                });

            }

            return list.FirstOrDefault();

        }

        public List<BookEnt> GetBookByName(string nameBook)
        {
            var list = new List<BookEnt>();
            var command = _dbConnection.CreateCommand();
            command.CommandText = "sp_get_books_by_namebook";
            command.CommandTimeout = TimeOut;
            command.CommandType = CommandType.StoredProcedure;
            ///EL orden de los parámetros debe de ser igual al orden declarado en el SP
            var parameters = new List<SqlParameter> {
                new SqlParameter { ParameterName = "@NameBook", Value = nameBook, SqlDbType = SqlDbType.NVarChar }
            };
            command.Parameters.AddRange(parameters.ToArray());

            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new BookEnt
                {
                    IdBook = Convert.ToInt32(reader["IdBook"])
                    ,
                    NameBook = reader["NameBook"].ToString()
                    ,
                    NumberPages = Convert.ToInt16(reader["NumberPages"])
                    ,
                    SalePrice = Convert.ToDouble(reader["SalePrice"])
                    ,
                    PurchasePrice = Convert.ToDecimal(reader["PurchasePrice"].ToString())
                    ,
                    DatePublishBook = Convert.ToDateTime(reader["DatePublishBook"])
                    ,
                    IsAvaible = Convert.ToBoolean(reader["IsAvaible"])
                });

            }

            return list;

        }

    }
}
