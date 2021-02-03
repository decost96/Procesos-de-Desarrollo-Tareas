using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowTest.Features
{
    [Binding]
    public class CalculadoraSteps
    {
        Calculadora calculadora = new Calculadora();
        [Given(@"que el primer numero es (.*)")]
        public void DadoQueElPrimerNumeroEs(int numero)
        {
            calculadora.PrimerNumero = numero;
        }
        
        [Given(@"el segundo número es (.*)")]
        public void DadoElSegundoNumeroEs(int numero)
        {
            calculadora.SegundoNumero = numero;
        }
        
        [Given(@"que el multiplicando es (.*)")]
        public void DadoQueElMultiplicandoEs(int numero)
        {
            calculadora.Multiplicando = numero;
        }
        
        [Given(@"el multiplicador es (.*)")]
        public void DadoElMultiplicadorEs(int numero)
        {
            calculadora.Multiplicador = numero;
        }
        
        [When(@"lo dos números son sumados")]
        public void CuandoLoDosNumerosSonSumados()
        {
            calculadora.Sumar();
        }
        
        [When(@"lo dos números son multiplicados")]
        public void CuandoLoDosNumerosSonMultiplicados()
        {
            calculadora.Multiplicar();
        }
        
        [Then(@"el resultado de la suma debe ser (.*)")]
        public void EntoncesElResultadoDeLaSumaDebeSer(int esperado)
        {
            Assert.AreEqual(esperado, calculadora.Resultado);
        }
        
        [Then(@"el resultado dela multipliacion debe ser (.*)")]
        public void EntoncesElResultadoDelaMultipliacionDebeSer(int esperado)
        {
            Assert.AreEqual(esperado, calculadora.Resultado);
        }
    }
}
