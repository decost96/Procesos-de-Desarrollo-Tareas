using Entity;
using System;
using Interfaces;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer;
using System.Composition;

namespace DataAccessLayer
{
    [Export(typeof(IGrabador))]
    public class PersistenciaCsv : IGrabador
    {
        public bool Grabar(Estudiante estudiante)
        {
            try
            {
                estudiante.EstudianteId = new Random().Next(1000,9999);
                System.IO.File.AppendAllLines("Data.csv",
                    new List<string>
                    {
                        string.Format("{{\"EstudianteId\": {0},\"Nombre\":\"{1}\", \"Apellido\":\"{2}\"}}"
                        ,estudiante.EstudianteId.ToString()
                        ,estudiante.Nombre
                        ,estudiante.Apellido)
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
