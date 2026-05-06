Algoritmo factorial1
	Definir n, i Como Entero
    Definir factorial Como Entero
    
    Escribir "Ingrese un número:"
    Leer n
    
    factorial <- 1
    
    Para i <- 1 Hasta n Hacer
        factorial <- factorial * i
    FinPara
    
    Escribir "El factorial es: ", factorial
FinAlgoritmo
