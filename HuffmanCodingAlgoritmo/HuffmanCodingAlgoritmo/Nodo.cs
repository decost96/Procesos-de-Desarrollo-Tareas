using System;
namespace HuffmanCodingAlgoritmo
{
    internal class Nodo :IComparable<>
    {
        public Nodo(char Clave, int Fracuencia)
        {
            Clave = clave;
            Fracuencia = valor;
        }

        public char Clave { get; set; }
        public int Frecuencia { get; set; }
        public Nodo HijoIzquierdo { get; set; }
        public Nodo HijoDerecho { get; set; }

        public int CompareTo([AllowNull] Nodo other)
        {
            return Frecuencia.CompareTo(other.Frecuencia);
 
        }

    }
}