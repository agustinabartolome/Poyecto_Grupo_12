using System;
using System.Collections.Generic;
using System.Text;

namespace Poyecto_Grupo_12.Datos
{
    public class cliente
    {
        private string nombre;
        private string apellido;
        private int dni;
        private string telefono;
        private string email;
        private string direccion;
        private string apto_fisico;
        private string ficha_medica;
        private int fecha;
        private string categoria;

        public cliente(string nombre, string apellido, int dni, string telefono, string email, string direccion, string apto_fisico, string ficha_medica, int fecha, string categoria)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Dni = dni;
            this.Telefono = telefono;
            this.Email = email;
            this.Direccion = direccion;
            this.Apto_fisico = apto_fisico;
            this.Ficha_medica = ficha_medica;
            this.Fecha = fecha;
            this.categoria = categoria;

        }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Dni { get => dni; set => dni = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Apto_fisico { get => apto_fisico; set => apto_fisico = value; }
        public string Ficha_medica { get => ficha_medica; set => ficha_medica = value; }
        public int Fecha { get => fecha; set => fecha = value; }
        public string Categoria { get => categoria; set => categoria = value; }
    }
}

