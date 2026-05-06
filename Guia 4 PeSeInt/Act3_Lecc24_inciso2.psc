Algoritmo CuentaRegresiva
		Definir n, suma Como Entero
		
		Escribir "Ingrese un número:"
		Leer n
		
		suma <- 0
		
		Mientras n >= 1 Hacer
			Escribir n
			suma <- suma + n
			n <- n - 1
		FinMientras
		
		Escribir "La suma es: ", suma
FinAlgoritmo
