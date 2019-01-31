# MasivianTest
Test arbol binario David Serrano

La solucion esta hecha en vs2017, c#. Al abrir el proyecto se ejecuta la solucion y este levantara el iis express con el servicio del Arbol binario.


El servicio expone dos metodos:

- CrearYDevolverArbol: 
Crea un arbol binario con un algoritmo propio (no se especifico como debia crearse el arbol). Recibe como parametro un arreglo de enteros.
La llamada puede realizarse desde cualquier aplicacion que permita hacer llamadas a servicios REST (soapui, CrearYDevolverArbol, RestClient)
El ejemplo de llamada seria--> http://localhost:62576/api/Arbol/CrearYDevolverArbol?valores=67&valores=39&valores=76&valores=28&valores=44&valores=74&valores=85&valores=29&valores=83&valores=87

- ObtenerAncestroComunMasBajo: Obtiene el ancestro mas bajo de un arbol dado. El metodo recibe tres parametros: un arbol (string en formato json), el nodo 1 (entero) y el nodo 2 (entero).
La llamada puede realizarse desde cualquier aplicacion que permita hacer llamadas a servicios REST (soapui, CrearYDevolverArbol, RestClient).
El ejemplo de llamada para el arbol dado en el documento seria-->

http://localhost:62576/api/Arbol/ObtenerAncestroComunMasBajo?arbol= { "ValorNodo":67, "ArbolIzquierdo": { 	"ValorNodo":39, 	"ArbolIzquierdo": { 		"ValorNodo":28,         "ArbolIzquierdo": null, 		"ArbolDerecho":{ 			"ValorNodo":29, 			 "ArbolDerecho": null,             "ArbolIzquierdo": null 		} 	}, 	"ArbolDerecho":{ 		"ValorNodo":44, 		 "ArbolDerecho": null,           "ArbolIzquierdo": null 	} }, "ArbolDerecho":{ 	"ValorNodo":76, 	"ArbolIzquierdo": { 		"ValorNodo":74, 		 "ArbolDerecho": null,          "ArbolIzquierdo": null 		}, 	"ArbolDerecho":{ 		"ValorNodo":85, 		"ArbolIzquierdo": { 		"ValorNodo":83, 		 "ArbolDerecho": null,             "ArbolIzquierdo": null 		}, 		"ArbolDerecho":{ 			"ValorNodo":87, 			 "ArbolDerecho": null,             "ArbolIzquierdo": null 		} 	} } }&nodo1=29&nodo2=44


