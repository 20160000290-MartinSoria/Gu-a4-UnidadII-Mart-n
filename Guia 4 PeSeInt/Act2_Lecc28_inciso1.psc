Algoritmo FeriaBoletos
		Definir tipo, totalBoletos Como Entero
		Definir totalDinero Como Real
		
		totalBoletos <- 0
		totalDinero <- 0
		
		Repetir
			Escribir "Ingrese tipo: 1=Niño ($10), 2=Adulto ($15), 0=Salir"
			Leer tipo
			
			Si tipo = 1 Entonces
				totalBoletos <- totalBoletos + 1
				totalDinero <- totalDinero + 10
			Sino
				Si tipo = 2 Entonces
					totalBoletos <- totalBoletos + 1
					totalDinero <- totalDinero + 15
				Sino
					Si tipo <> 0 Entonces
						Escribir "Opción inválida"
					FinSi
				FinSi
			FinSi
			
			Si tipo <> 0 Entonces
				Escribir "Boletos vendidos: ", totalBoletos
				Escribir "Total cobrado: $", totalDinero
			FinSi
			
		Hasta Que tipo = 0
		
		Escribir "Venta finalizada"
FinAlgoritmo
