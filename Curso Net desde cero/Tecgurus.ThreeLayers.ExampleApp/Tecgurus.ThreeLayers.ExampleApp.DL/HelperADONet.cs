using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Tecgurus.ThreeLayers.ExampleApp.DL
{
    public class HelperADONet : IDisposable
    {
        protected string _connectionString { get; set; } //es la cadena de conexion

        protected SqlConnection _dbConnection; //define el manejador de la BD

        /// <summary>
        /// Propiedad de solo lectura
        /// Indica los milisegundos de conexión
        /// establece por default 300 ms
        /// </summary>
        public int TimeOut { get { return 500; } }

        /// <summary>
        /// Constructor que toma la coneccion por default en el appconfig
        /// </summary>
        public HelperADONet()
        {
            //ASIGNACIÓN DE CADENA DE CONEXIÓN DESDE APP.CONFIG
            _connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            //E DefaultConnection, se agrega en el App.config, que a su vez se agrega en el explorador de servidores
            ConnectionControl();
        }

        /// <summary>
        /// CONTROL DE CONEXIÓN Y DESCONEXIÓN A BASE DE DATOS 
        /// </summary>
        protected void ConnectionControl()
        {
            if (_dbConnection == null)
            {
                _dbConnection = new SqlConnection(_connectionString);
                _dbConnection.Open();
            }
            else
            {
                if (_dbConnection.State.Equals(ConnectionState.Closed))
                {
                    _dbConnection.Open();
                }

            }
        }

        /// <summary>
        /// MÉTODO PARA CONTROLAR LA DESCONEXIÓN 
        /// AL FINALIZAR UNA OPERACIÓN EN LA BASE
        /// Y REMOVER DE MEMORIA EL OBJETO GENERADO
        /// </summary>
        public void Dispose()
        {
            if (_dbConnection != null)
            {
                _dbConnection.Close();
                _dbConnection.Dispose();
            }
            GC.SuppressFinalize(this);
        }
    }
}
