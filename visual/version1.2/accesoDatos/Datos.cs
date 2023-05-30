using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bases_de_datos___Proyecto_final_v1.logica;
using System.Data;
//using Oracle.DataAccess.Client;
using Oracle.ManagedDataAccess.Client;
namespace Bases_de_datos___Proyecto_final_v1.accesoDatos
{
    class Datos
    {
        //Creo la cadena de conexion
        string cadenaConexion = "Data Source = localhost; User ID = proyectobases; Password=oracle";
         //Metodo para ejecutar una sentenci insert, update o delete
        public int ejecutarDML(string consulta)
        {
            int filasAfectadas = 0;
            /*paso 1: creo la conexion*/
            OracleConnection miConexion = new OracleConnection(cadenaConexion);
            /*paso 2: creo un objeto comando*/
            OracleCommand miComando = new OracleCommand(consulta, miConexion);
            /*paso 3: abro la conexion*/
            miConexion.Open();
            /*paso 4: ejecuto el comando. Al ejecutar un objeto de tipo
             * comando, este devuelve un valor entero que significa
             * las filas que se afectaron con la operacion DML(insert,update,delete)
             * que llega en la consulta*/
            filasAfectadas = miComando.ExecuteNonQuery();
            /*paso 5: cierro la conexion*/
            miConexion.Close();
            return filasAfectadas;

        }

        //paso 3. creo el método que ejecuta una consulta SELECT
        public DataSet ejecutarSELECT(string consulta)
        {
            /*paso 1: crear un Data Set vacio*/
            DataSet ds = new DataSet();
            /*paso 2: creo un adaptador*/
            OracleDataAdapter miAdaptador = new OracleDataAdapter(consulta, cadenaConexion);
            /*paso 3: el adaptador llena el Data Set */
            miAdaptador.Fill(ds, "ResultadoDatos");
            return ds;

        }
    }
}
