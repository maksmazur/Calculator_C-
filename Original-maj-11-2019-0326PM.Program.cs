using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {
     
        
        static void Main(string[] args)
        {
            DateTime date1 = DateTime.Now;
        
            Console.Write(date1);
           


            double a;
            double b;
            double answer;
            string oper;
            
            Console.WriteLine(" \n Cześć jak ci na imię" );
            string imie = Console.ReadLine();

        
          
           

            Console.WriteLine("\t\t\tKalkulator w kosoli\n");
            Console.WriteLine("\t\t\t-------------------\n");

            for (; ; )
            {

                Console.WriteLine("\t\t\tpodaj pierwszą liczbę\n");
                a = Double.Parse(Console.ReadLine());


                Console.WriteLine("\t\t\t Podaj operator: (+, -, *, /,  pow ) \n");
                oper = Console.ReadLine();

                Console.WriteLine("\t\t\tpodaj drugą liczbę\n");
                b = Double.Parse(Console.ReadLine());

                Console.WriteLine("=");

                if (oper == "+")     // dodawanko
                {
                    answer = a + b;
                    Console.Write(answer);
                }
                if (oper == "-")     // odejmowanie
                {
                    answer = a - b;
                    Console.Write(answer);
                }
                if (oper == "*")     // mnożenie
                {
                    answer = a * b;
                    Console.Write(answer);
                }
                if (oper == "/")     // dzielenie
                {

                    answer = a / b;
              
                    
                    
                    Console.Write(answer);
                    
                }
              //  if (oper == "%")     // procentowanie
              //  {
              //    answer = a % b;
              // Console.Write(answer);
              //}

                if (oper == "pow")      // potęgowanie 
                {

                    answer = Math.Pow(a, b);
                    Console.Write(answer);
                }
                
                Console.ReadLine();


                Console.WriteLine(imie + "\t\t\t, Coś bardziej zaawansowanego ;) : \n1. Sinus (stopnie) \n2. Cosinus (stopnie) \n3. Tangens (stopnie) \n4. Silnia \n5. Wyznaczanie n-tego elementu Ciągu Fibonacciego \n6. Największy wspólny dzielnik");

                double num = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Podaj liczbę: ");


                double x = Convert.ToDouble(Console.ReadLine());
                double result = 0;

                switch (num)
                {
                    case 1:
                        result = Math.Sin((Math.PI * x) / 180);      // deklaracja zmiennej matemtycznej math gdzie  konwertowanie wartości do radianów  jednostki miary łukowej i jest to dzielone przez 180 ze wzgledy na to ze musi wyjść w stopniach 
                        break;
                             case 2:
                                 result = Math.Cos((Math.PI * x) / 180);  //
                                     break;
                    case 3:
                            result = Math.Tan((Math.PI * x) / 180);
                                break;
                    case 4:
                        int n = Convert.ToInt32(x);

                            if (n < 0)
                            {
                            Console.WriteLine("Brak mozliwosci wyliczenia silni.");  
                            result = 0;
                            }

                        else if (n == 0 | n == 1)
                        {
                            result = 1;
                        }
                        else
                        {
                            result = 1;
                            for (int i = 1; i <= n; i++)
                                result *= i;                // jest to operaor mnożenia tylko że działa to mnożąc  każda zmienna jaką mamy 
                        }
                        break;


                    case 5:

                        int number = Convert.ToInt32(x) - 1;                             // wczytywanie liczby -1  
                        int[] Fib = new int[number + 1];                                 // number liczba która my podajemy                           // deklaracja tablicy [] jako nowy int plus jeden 
                        Fib[0] = 0;                                                       //- 1 dlatego zeby indeksowac od 1
                        Fib[1] = 1;                                                      // tablica n elemtontowa czyli ile my podajemy zmiennych tyle bedzie
                                                                                        

                        for (int i = 2; i <= number; i++)                                // dla wartości i 2 i większej bądź równej liczbie któreą deklarujemy oraz zwiększonego argumenty i++ czyli o jeden

                        {
                            Fib[i] = Fib[i - 2] + Fib[i - 1];                           // pętla która nam obliczqa wartości 
                        }
                        result = Fib[number];                                            // number jest zmienna lokalna 

                        break;
                    case 6:
                        int nwd1 = Convert.ToInt32(x);

                        Console.WriteLine("\t\t\tPodaj drugą liczbę: ");
                        int nwd2 = Convert.ToInt32(Console.ReadLine());

                        while (nwd2 != 0)   // gdzie NWD musi byc różne od zera 
                        {
                            int tmp = nwd1 % nwd2;
                            nwd1 = nwd2;
                            nwd2 = tmp;  
                        }

                        result = nwd1;

                        break;

                    default:

                        Console.WriteLine(imie + "\t\t\t źle to zrobiłeś");

                        break;
                }

                Console.WriteLine("\t\t\tBrawo ! Wynikim operacji " + num + " jest liczba: " + result);


                Console.Write("\t\t\n\n I cyk od początku \n");

                Console.ReadKey();
                Console.Clear();
            }

        }
    }
}
