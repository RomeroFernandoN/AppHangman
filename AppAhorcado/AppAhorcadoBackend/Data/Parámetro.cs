using System;
using System.Collections.Generic;
using System.Text;

namespace AppAhorcado.AppAhorcadoBackend.Data
{
    class Parámetro
    {
        public string Nombre { get; set; }
        public object Valor { get; set; }

        public Parámetro(string nombre, object valor)
        {
            Nombre = nombre;
            Valor = valor;
        }
    }
}
