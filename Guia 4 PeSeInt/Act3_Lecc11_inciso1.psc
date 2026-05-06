Algoritmo SumarRango
		Definir n1, n2, menor, mayor, i, suma Como Entero
		
		Escribir "Ingrese el primer número:"
		Leer n1
		Escribir "Ingrese el segundo número:"
		Leer n2
		
		Si n1 < n2 Entonces
			menor <- n1
			mayor <- n2
		Sino
			menor <- n2
			mayor <- n1
		FinSi
		
		suma <- 0
		
		Para i <- menor Hasta mayor Hacer
			suma <- suma + i
		FinPara
		
		Escribir "La suma es: ", suma
FinAlgoritmo
