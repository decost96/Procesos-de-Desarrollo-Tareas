using Entity;
using System;
using Interfaces;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public class PersistenciaJson : IGrabador
    {
        public bool Grabar(Estudiante estudiante)
        {
            var Data = string.Format("{{\"EstudianteId\": {0},\"Nombre\":\"{1}\", \"Apellido\":\"{2}\"}}"
                        , estudiante.EstudianteId.ToString()
                        , estudiante.Nombre
                        , estudiante.Apellido);
            try
            {
                estudiante.EstudianteId = new Random().Next(1000, 9999);
                System.IO.File.AppendAllLines("Data.json",
                    new List<string>
                    {
                       Data

                     },
                    Encoding.UTF8);
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
