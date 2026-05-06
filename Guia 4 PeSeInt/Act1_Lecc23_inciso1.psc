Algoritmo KiloManzanas
		Definir peso, total Como Real
		
		total <- 0
		
		Repetir
			Escribir "Ingrese el peso de la manzana en gramos:"
			Leer peso
			
			total <- total + peso
			
			Escribir "Peso acumulado: ", total, " gramos"
			
		Hasta Que total >= 1000
		
		Escribir "¡Ya tienes 1 kilo o más de manzanas!"
FinAlgoritmo
