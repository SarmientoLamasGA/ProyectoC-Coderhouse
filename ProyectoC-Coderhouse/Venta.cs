using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoC_Coderhouse
{
    internal class Venta
    {
        private int _id;
        private string _comentarios;
        private int idUsuario;

        public Venta(int id, string comentarios, int idUsuario)
        {
            this._id = id;
            this._comentarios = comentarios;
            this.idUsuario = idUsuario;
        }

        public void mostrarTodo()
        {
            Console.WriteLine("Id de la venta: " + this._id + ". Comentarios: " + this._comentarios + ". Usuario ID: " + this.idUsuario);
        }
    }
}
