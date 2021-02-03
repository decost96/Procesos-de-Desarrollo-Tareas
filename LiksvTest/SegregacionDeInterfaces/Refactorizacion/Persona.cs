using System;
using System.Collections.Generic;
using System.Text;

namespace SegregacionDeInterfaces.Refactorizacion
{
    class Persona : IElectoral, IServiciosBasicos
    {
        public string Afiliar(PartidoPolito partidoPolitico)
        {
            throw new NotImplementedException();
        }

        public double PagoAgua(DateTime fecha, Propiedad propiedad)
        {
            throw new NotImplementedException();
        }

        public double PagoLuz(DateTime fecha, Propiedad propiedad)
        {
            throw new NotImplementedException();
        }

        public string Postular(Candidatura candidatura)
        {
            throw new NotImplementedException();
        }

        public string Sufragar(Votacion votacion)
        {
            throw new NotImplementedException();
        }
    }
}
