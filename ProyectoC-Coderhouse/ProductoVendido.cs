using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoC_Coderhouse
{
    internal class ProductoVendido
    {
        private int _id;
        private int _idProducto;
        private int _stock;
        private int _idUsuario;

        public ProductoVendido(int id, int idProducto, int stock, int idUsuario)
        {
            this._id = id;
            this._idProducto = idProducto;
            this._stock = stock;
            this._idUsuario = idUsuario;
        }

        public void mostrarTodo()
        {
            Console.WriteLine("Venta de producto ID: " + this._id + ". ID del producto: " + this._idProducto + ". Stock restante: " + this._stock + ". Comprador ID: " + this._id);
        }
    }
}
