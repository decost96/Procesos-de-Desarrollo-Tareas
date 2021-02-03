namespace SegregacionDeInterfaces
{
    interface IElectoral
    {
        string Sufragar(Votacion votacion);

        string Postular(Candidatura candidatura);

        string Afiliar(PartidoPolito partidoPolitico);


    }
}