using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bases_de_datos___Proyecto_final_v1.accesoDatos;
using System.Data;

namespace Bases_de_datos___Proyecto_final_v1.logica
{
    public class Portatil
    {
        /*Creo un objeto en la clase de datos que esta en la capa de accesosDatos
         para pode manipular los metodo que estan en esa clase*/
        Datos dt = new Datos();
        public int ingresarPortatil(string portatilserial, string portatilmarca, int portatilcapacidaddiscoduro, int portatilcapacidadmemoriaram, string portatilfechaensamblaje, string portatiltipodiscoduro, int empresanit)
        {
            int resultado;
            string consulta;
            consulta = "insert into Portatil(portatilserial, portatilmarca, portatilcapacidaddiscoduro, portatilcapacidadmemoriaram, portatilfechaensamblaje, portatiltipodiscoduro, empresanit) values(" + "'" +
            portatilserial + "' , '" + portatilmarca + "'," + portatilcapacidaddiscoduro + "," + portatilcapacidadmemoriaram + ",'" + portatilfechaensamblaje + "','" + portatiltipodiscoduro + "'," + empresanit + ")";
            resultado = dt.ejecutarDML(consulta);
            return resultado;
        }

        public DataSet ListarPortatiles()
        {
            DataSet resultado;
            string consulta = "SELECT * FROM PORTATIL";
            resultado = dt.ejecutarSELECT(consulta);
            return resultado;
        }


        public DataSet consultarPortatil(int empresaNit)
        {
            DataSet miDs = new DataSet();
            string consulta;
            consulta = "select * from Portatil where empresaNit =" + empresaNit;
            miDs = dt.ejecutarSELECT(consulta);
            return miDs;
        }

        public DataSet consultarPortatil()
        {
            DataSet miDs = new DataSet();
            string consulta;
            consulta = "select * from portatil";
            miDs = dt.ejecutarSELECT(consulta);
            return miDs;

        }
    }
}
