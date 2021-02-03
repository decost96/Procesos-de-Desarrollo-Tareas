# language: es
Característica: Calculadora
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowTest/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Escenario: Sumar dos números
	Dado que el primer numero es 50
	Y el segundo número es 20
	Cuando lo dos números son sumados
	Entonces el resultado de la suma debe ser 70

Escenario: Multiplicar dos números
	Dado que el multiplicando es 5
	Y el multiplicador es 2
	Cuando lo dos números son multiplicados
	Entonces el resultado dela multipliacion debe ser 10

Esquema del escenario: Calcular la funcion escalonada de un número - tabla
	Dado que el primer numero es <primerNumero>
	Cuando se calcula la funcion escalonada
	Entonces el resultado debe ser <resultado>