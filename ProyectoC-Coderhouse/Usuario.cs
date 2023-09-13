using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoC_Coderhouse
{
    internal class Usuario
    {
        private int _id;
        private string _nombre;
        private string _apellido;
        private string _nombreUsuario;
        private string _contrasena;
        private string _mail;

        public Usuario(int id, string nombre, string apellido, string nombreUsuario, string contrasena, string mail)
        {
            this._id = id;
            this._nombre = nombre;
            this._apellido = apellido;
            this._nombreUsuario = nombreUsuario;
            this._contrasena = contrasena;
            this._mail = mail;
        }

        public void mostrarTodo()
        {
            Console.WriteLine("ID: " + this._id + ". Nombre: " + this._nombre + " Apellido: " + this._apellido + ". Nombre de usuario " + this._nombreUsuario + ". Mail de registro: " + this._mail);
        }
    }
}
