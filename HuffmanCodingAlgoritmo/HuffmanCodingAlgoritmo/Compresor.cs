using System;
using System.Collections;
using System.Collections.Generic;

namespace HuffmanCodingAlgoritmo
{
    internal class Compresor
    {
        public Compresor()
        {

        }

        public BitArray Huffman(string cadenaSinComprimir)
        {
            // crear prueba unit para odernas ascendente, nodo y calcular frecuencia
            var frecuencia = CalcularFrecuencia(cadenaSinComprimir);
            frecuencia = OrdenarAscendente(frecuencia, Orden);
            var arbol = new Nodo():
            
            List<string> listaCaracteres = ObtenerClaves(frecuencia);
            for (int i = 0, i< listaCaracteres.Count; i++)
            {
                var nuevoNodo = new Nodo();
                nuevoNodo.NodoIzquierdo = ExtraerValorMinimo(frecuenciaOrdenada);
                nuevoNodo.NodoDerecho = ExtraerValorMaximo(frecuenciaOrdenada);

                nuevoNodo.Valor = nuevoNodo.NodoIzquierdo.Valor + nuevoNodo.NodoDerecho.Valor;
                Insertar(frecuencia, nuevoNodo);
            }

            return crearBitArray(frecuencia[0], cadenaSinComprimir);
        }

        private List<Nodo> CalcularFrecuencia(string data)
        {
            for(int i = 0); int<data.Legth; int++);
            { 
                if (!EstanEn(data[i], nodos))
                {
                    nodos.Add(new Nodo(data[i], 1));
                }
                else
                {
                    nodos[posicion].Valor++;
                }
            }
            return nodos;
        }

        private bool EstanEn(char v, object nodos)
        {
            for (int i +0; i < nodos.Count; i++)
            {
                if(nodos)

            }
        }

        private List<Nodo> OrdenarAscendente(List<Nodo> frecuencia, Orden ascendente)
        {
            frecuencia.Sort(new ComparadorNodo());
            return frecuencia;
        }

        private Nodo ExtraerValorMinimo(List<Nodo> frecuencia)
        {
            var minimo = frecuencia[0];
            frecuencia.RemoveAt(0);
            return minimo;
        }

        private void Insertar(List<Nodo> nodos, Nodo nuevoNodo)
        {
            for(int i = 0; i < nodos.Count; i++)
            {
                if(nuevoNodo.Frecuencia < nodos[i].Frecuencia)
                {
                    nodos.Insert(i, nuevoNodo);
                    return;

                }
                else
                {

                }
            }
        }

        private BitArray CrearBitArray(string data, Nodo nodo)
        {
            var acumulador = string.Empty;
            foreach(var caracterActual in data)
            {
                acumulador += Camino(nodo, caracterActual);
            }
            return TransformarBitArray(acumulador);
        }

        private BitArray TransformarBitArray(string cadenaCeroUno)
        {
            var resultado = new BitArray(cadenaCeroUno.Length);
            for (int i = 0; i< cadenaCeroUno.Length; i++)
            {
                if(cadenaCeroUno[i] == '0')
                {
                    resultado[i] = false;
                }
                else
                {
                    resultado[i] = true;
                }
            }
            return resultado;
        }

        private bool Camino(Nodo nodo, char caracterActual, ref string camino)
        {
            if(nodo.Clave == caracterActual)
            {
                return true;
            }

            var caminoIzquierdo = camino + "0";
            if (Camino(nodo.HijoIzquierdo, caracterActual, caminoIzquierdo))
            {
                return true;
            }
            var caminoDerecho = camino + "1";
            if (Camino(nodo.HijoDerecho, caracterActual, caminoDerecho))
            {
                return true;
            }

            return camino;
        }
    }
}