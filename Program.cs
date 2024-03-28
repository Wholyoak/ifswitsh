// See https://aka.ms/new-console-template for more information

// Declaramos nuestras variables
int option=0;
Double result=0;
//prueba
//prueba
//prueba
//prueba
//prueba
// Dibujamos el menú para que el usuario pueda ver que opciones tiene.
Console.WriteLine("1 - Calcular el area del cuadrado");
Console.WriteLine("2 - Calcular el volumen del cubo");
Console.WriteLine("3 - Salir");
Console.WriteLine("4 - Sumar");
Console.WriteLine("5 - Restar");

// Guardamos la variable
option = Convert.ToInt32(Console.ReadLine());


// Evaluamos la opción elegida y retornamos los resultados.
switch (option)
{  
       
    case 4:        
    case 5:   
    case 6:
        result = 1;
        break;
    case 7:        
    case 8:        
    case 9:
        result = 2;
        break;
    case 10:       
    case 11:        
    case 12:
        result = 3;
        break;
}

// Imprimimos el mensaje.
Console.WriteLine(result);



