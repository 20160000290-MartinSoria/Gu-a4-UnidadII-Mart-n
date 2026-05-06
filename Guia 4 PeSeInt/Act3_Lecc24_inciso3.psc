Algoritmo SumaPrimos1a50
		Definir i, j, divisores, suma Como Entero
		
		suma <- 0
		
		Para i <- 1 Hasta 50 Hacer
			divisores <- 0
			
			Para j <- 1 Hasta i Hacer
				Si i MOD j = 0 Entonces
					divisores <- divisores + 1
				FinSi
			FinPara
			
			Si divisores = 2 Entonces
				suma <- suma + i
			FinSi
		FinPara
		
		Escribir "La suma de los números primos es: ", suma
FinAlgoritmo
