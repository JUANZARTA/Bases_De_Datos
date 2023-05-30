using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bases_de_datos___Proyecto_final_v1.accesoDatos;
using System.Data; 

namespace Bases_de_datos___Proyecto_final_v1.logica
{
    class Empresa
    {
        /*Creo un objeto en la clase de datos que esta en la capa de accesosDatos
          para pode manipular los metodo que estan en esa clase*/
        Datos dt = new Datos();
        public int ingresarEmpresa(int empresanit, string empresanombre, string empresafechacreacion)
        {
            int resultado;
            String consulta;
            consulta = "insert into Empresa(empresanit, empresanombre, empresafechacreacion) values(" + 
            empresanit + " , '" + empresanombre + "','" + empresafechacreacion + " ')";
            resultado = dt.ejecutarDML(consulta);
            return resultado;
        }

      
    }
}
