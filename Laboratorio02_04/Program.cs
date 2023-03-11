// See https://aka.ms/new-console-template for more information
bool r = false;
// Ejercicio 1
while (!r) {

Console.WriteLine("Ejercicio 1");
Console.WriteLine("Ingrese un numero entero: ");


try
{

    int x = Convert.ToInt32(Console.ReadLine());

    if (x == 0)
    {
        Console.WriteLine("El numero es cero");
            r = true;
    }
    else if (x > 0)
    {
        Console.WriteLine(" El numero es positivo");
            r = true;
        }
    else
    {
        Console.WriteLine(" El numero es negativo");
            r = true;
            
            
        }
}
catch (Exception ex)
{
    Console.WriteLine("no ingreso un numero   " + ex.Message);
        r = false;
        Console.ReadKey();
        Console.Clear();
    }

   

}
Console.ReadKey();
Console.Clear();


//Ejercicio 2

int dia = 0;
bool d = false;

while (!d)
{
    Console.WriteLine("Ejercicio 2");
    Console.WriteLine("Ingrese el numero del dia de la semana que desee");
    try
    {
        dia = Convert.ToInt32(Console.ReadLine());

        if (dia > 0 && dia <= 7)
        {

            if (dia == 1)
            {

                Console.WriteLine("Su dia es lunes");
                d = true;

            }
            else if (dia == 2)
            {
                Console.WriteLine("Su dia es martes");
                d = true;

            }
            else if (dia == 3)
            {
                Console.WriteLine("Su dia es miércoles");
                d = true;

            }
            else if (dia == 4)
            {
                Console.WriteLine("Su dia es jueves");
                d = true;

            }
            else if (dia == 5)
            {
                Console.WriteLine("Su dia es viernes");
                d = true;
            }
            else if (dia == 6)
            {
                Console.WriteLine("Su dia es sábado");
                d = true;
            }
            else if (dia == 7)
            {
                Console.WriteLine("Su dia es domingo");
                d = true;
            }
           

        }else
        {
            Console.WriteLine("Error: el numero a ingresar debe estar contenido entre 1 y 7");
            d = false;
            Console.ReadKey();
            Console.Clear();
        }
        

    }
    catch (Exception ex1)
    {
         Console.WriteLine("Error: Ingrese un numero entero" + ex1.Message);
            d = false;
            Console.ReadKey();
            Console.Clear();
    }
}
Console.ReadKey();
Console.Clear();
double n = 0;
int b1 = 0;
int b2 = 0;
int b3 = 0;
int b4 = 0;
int b5 = 0;
int b6 = 0;
double b7 = 0;
double b8 = 0;

bool y = false;

Console.WriteLine("T4_H.F._1199923_E2");

while (!y)
{
    try
    {


        Console.WriteLine("Ingrese una cantidad de quetzales");
        n = Convert.ToDouble(Console.ReadLine());



        if (n >= 0)
        {



            //la cantidad se divide por 100, y se pasa a entero.
            b1 = (int)n / 100;
            n = n % 100;
            // luego la cantidad "n" se iguala al residuo de la division de "n" y 100, por ejemplo: 198.75/100 = 1   y el residuo seria = 198.75-100 = 98.75
            b2 = (int)n / 50;
            n = n % 50;// entonces siguiendo el ejemplo, se realiza la division del restante de la cantidad, (98.75) entre 50, y luego se calcula el residuo de esta division para asignarlo al valor "n"

            b3 = (int)n / 20;
            n = n % 20;
            // Asi sucesivamente hasta terminar
            b4 = (int)n / 10;
            n = n % 10;

            b5 = (int)n / 5;
            n = n % 5;


            b6 = (int)n / 1;
            n = n % 1;

            n = n*100;
            
            b7 = (int)n / 25;
            n = n % 25;
           
            b8 = (int)n / 1;
           
            if (b8 > 0 && b8 <= 1)
            {
                b8++;
            }else if(b8 > 3 && b8 < 4)
            {
                b8++;

            }else if(b8 > 4 && b8 <5)
            {
                b8++;
            }
            else if(b8 > 18)
            {
                b8++; 
            }

            
            //Condicional si se muestran en pantalla
            if (b1 > 0)
            {
                Console.WriteLine(b1 + " de Q100");
            }
            else
            {

            }
            if (b2 > 0)
            {
                Console.WriteLine(b2 + " de Q50");
            }
            else
            {

            }
            if (b3 > 0)
            {
                Console.WriteLine(b3 + " de Q20");
            }
            else
            {

            }
            if (b4 > 0)
            {
                Console.WriteLine(b4 + " de Q10");
            }
            else
            {

            }
            if (b5 > 0)
            {
                Console.WriteLine(b5 + " de Q5");
            }
            else
            {

            }
            if (b6 > 0)
            {
                Console.WriteLine(b6 + " de Q1");
            }
            else
            {

            }
            if (b7 > 0)
            {
                Console.WriteLine(b7 + " de Q0.25");
            }
            else
            {

            }
            if (b8 > 0)
            {
                Console.WriteLine(b8 + " de Q0.01");
            }
            else
            {

            }


            y = true;
        }
    }catch(Exception e)        
     {
        Console.WriteLine("Debe ingresar una cantidad mayor o igual que 0");
        y = false;
    }
    Console.ReadKey();
    Console.Clear();

}
