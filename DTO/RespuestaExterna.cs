using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace investhub_backend.DTO
{
    public class RespuestaExterna<T>
    {
        public bool Exito { get; set; } = false; //Sirve como bandera para determinar si la operacion fue exitosa o no
        public string MensajePublico { get; set; } = ""; // Da retroalimentacion del error
        public T Datos { get; set; } // Un tipo de objeto o coleccion, contiene los datos de la respuesta ( que pueden ser de cualquier tipo)
        public override string ToString() //Aca utilizamos un metodo que convierte al objeto en un JSON, esto es util para enviar a APIs o al que tenga que utilizarlo
        {
            return JsonSerializer.Serialize(this);
        }
    }
}

/*
Este seria un ejemplo de uso del DTO que podriamos devolver como JSON a una API
var respuesta = new RespuestaExterna<string>()
{
    Exito = true,
    MensajePublico = "Operación exitosa",
    Datos = "Datos de cliente"
};

*/
