Algoritmo sumarprimos
	Definir i, j, suma, divisores Como Entero
    
    suma <- 0
    
    Para i <- 1 Hasta 22 Hacer
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
    
    Escribir "La suma de los números primos entre 1 y 22 es: ", suma
FinAlgoritmo
