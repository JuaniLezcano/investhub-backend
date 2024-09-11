using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace investhub_backend.DTO
{
    public class RespuestaInterna<T> //T es un tipo de dato generico, puede ser cualquier tipo de dato o una coleccion
    {
        public T Datos { get; set; }
        public bool Exito { get; set; } = false;
        public string Mensaje { get; set; } = "";
    }
}

//Mismo funcionamiento que respuesta externa pero sin usar el JSON