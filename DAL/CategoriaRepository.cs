using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;

namespace DAL
{
    public class CategoriaRepository
    {
        private CategoriaRepository BD_Categoria = new CategoriaRepository();

        public List<Categoria> Listar()
        {
            return BD_Categoria.Listar();
        }

        public int Registrar(Categoria obj, out string Mensaje)
        {
            Mensaje = string.Empty;


            if (obj.Descripcion == "")
            {
                Mensaje += "Es necesario la descripcion de la Categoria\n";
            }

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return BD_Categoria.Registrar(obj, out Mensaje);
            }


        }


        public bool Editar(Categoria obj, out string Mensaje)
        {

            Mensaje = string.Empty;

            if (obj.Descripcion == "")
            {
                Mensaje += "Es necesario la descripcion de la Categoria\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return BD_Categoria.Editar(obj, out Mensaje);
            }


        }
        public bool Eliminar(Categoria obj, out string Mensaje)
        {
            return BD_Categoria.Eliminar(obj, out Mensaje);
        }
    }
}
