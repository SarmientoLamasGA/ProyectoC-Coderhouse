using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoC_Coderhouse
{
    internal class Producto
    {
        private int _id;
        private string _descripcion;
        private float _costo;
        private float _precioVenta;
        private int _stock;
        private int _idUsuario;

        public Producto(int id, string descripcion, float costo, float precioVenta, int stock, int idUsuario)
        {
            this._id = id;
            this._descripcion = descripcion;
            this._costo = costo;
            this._precioVenta = precioVenta;
            this._stock = stock;
            this._idUsuario = idUsuario;
        }

        public void mostrarTodo()
        {
            Console.WriteLine("Objeto id: " + this._id + ". Descripción: " + this._descripcion + ". Costo: " + this._costo + ". Precio de venta: " + this._precioVenta + ". Stock: " + this._stock + ". Del usuario id: " + this._idUsuario);
        }
    }
}
