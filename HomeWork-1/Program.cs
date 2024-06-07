using System.Diagnostics.Contracts;

namespace HomeWork_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] names = { "Rizvan", "Eldar", "Eli" };

            //for (int i = 0; i < names.Length; i++)
            //{
            //    if (names[i] == "Eldar")
            //    {
            //        Console.WriteLine("hello");
            //        break; 
            //    }
            //}
            #region array cemi
            //int[] numbers = { 1, 2, 3, 4, 5 };

            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}

            //Console.WriteLine("Cem: " + sum);

            #endregion

            #region tersine capetme
            //int[] numbers = { 1, 2, 3, 4, 5 };

            //for (int i = numbers.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            #endregion

            #region tek ededlerin cemi
            //int[] numbers = { 1, 2, 3, 4, 5 };

            //int oddSum = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 != 0) 
            //    {
            //        oddSum += numbers[i];
            //    }
            //}

            //Console.WriteLine("tek ededlerin cemi: " + oddSum);
            #endregion

            #region cut ededlerin cemi
            //int[] numbers = { 1, 2, 3, 4, 5 };

            //int evenSum = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        evenSum += numbers[i];
            //    }
            //}

            //Console.WriteLine("tek ededlerin cemi: " + evenSum);

            #endregion

            #region 5e tam bolunenlerin cemi
            //int[] numbers = { 10, 22, 35, 47, 50, 63 };
            //int sumFive = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 5 == 0)
            //    {
            //        sumFive += numbers[i];
            //    }
            //}

            //Console.WriteLine("5e bolunenlerin cemi: " + sumFive);
            #endregion

            #region array minimum
            //int[] numbers = { 10, 22, 35, 47, 5, 63 };

            //int min = numbers[0];

            //for (int i = 1; i < numbers.Length; i++)
            //{
            //    if (numbers[i] < min)
            //    {
            //        min = numbers[i];
            //    }
            //}

            //Console.WriteLine("minimum element: " + min);

            #endregion

            #region array maximum
            //int[] numbers = { 10, 22, 35, 47, 5, 63 };
            //int max = numbers[0];

            //for (int i = 1; i < numbers.Length; i++)
            //{
            //    if (numbers[i] > max)
            //    {
            //        max = numbers[i];
            //    }
            //}

            //Console.WriteLine("maximum element: " + max);

            #endregion

            #region araligdakilarin cemi
            //int[] numbers = { 1, 2, 3, 4, 5 };
            //int first, second;
            //first=int.Parse(Console.ReadLine());
            //second = int.Parse(Console.ReadLine());

            //int sum = 0;
            //while (true)
            //{
            //    if (first == second)
            //    {

            //    }
            //}


            //for (int i = first; i < second; i++)
            //{
            //    sum += numbers[i];
            //}

            //Console.WriteLine("Cem: " + sum);
            #endregion

            #region tersine cevirme
            //int[] numbers = { 1, 2, 3, 4, 5 };
            //int n = numbers.Length;
            //int temp;
            //for (int i = 0; i < n / 2; i++)
            //{
            //    temp = numbers[i];
            //    numbers[i] = numbers[n-i-1];
            //    numbers[n-i-1] = temp;

            //}
            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write(numbers[i]+" ");
            //}



            #endregion

            Student student1=new Student();
            student1.Name = "Abbas";
            student1.Surname = "abbasli";
            student1.Avg = 20;
            Console.WriteLine($"name:{student1.name}\nsurname:{student1.surname}\naverage point:{student1.avg}");


            //int a;
            //while (true)
            //{
            //    a = int.Parse(Console.ReadLine())!;
            //    if (a < 0) Console.WriteLine("musbet eded daxil edilmelidir!");
            //    else if (a == 1 || a == 0) Console.WriteLine("ne sade ne murekkebdir!");
            //    else break;
            //}
            //sade(a);

            //int a;
            //a = int.Parse(Console.ReadLine())!;
            //Console.WriteLine(mukemmel(a));


            //int a;
            //a = int.Parse(Console.ReadLine());
            //for (int i = 0; i < a; i++)
            //{
            //    for (int j = 0; j < i + 1; j++)
            //    {
            //        Console.Write("* ");
            //    }
            //    Console.WriteLine();
            //}
            //for (int i = 0; i < a; i++)
            //{
            //    for (int j = 0; j < a - i - 1; j++)
            //    {
            //        Console.Write("* ");
            //    }
            //    Console.WriteLine();1  
            //}


            //int ay,il;
            //ay = int.Parse(Console.ReadLine())!;
            //il = ay / 12;
            //ay=ay % 12;
            //if (il == 0) Console.WriteLine($"{ay} ay");
            //if(ay==0) Console.WriteLine($"{il} il");
            //if(ay!=0 && il!=0) Console.WriteLine($"{il} il {ay} ay");

            //string a;
            //a = Console.ReadLine();
            //int max = 0,min=1;
            //foreach(char item in a)
            //{
            //    if ((int)item > max) max = (int)item;
            //    if ((int)item < min) min = (int)item;
            //}
            //Console.WriteLine(max * min);

            //int a,max=0,min=10,son;
            //a = int.Parse(Console.ReadLine());
            //while (true)
            //{
            //    son = a % 10; 
            //    a /= 10;
            //    if (son > max) max = son;
            //    if (son < min) min = son;
            //    if (a == 0) break;
            //}
            //Console.WriteLine(min * max);

            //int a,ters=0,son;
            //a = int.Parse(Console.ReadLine());
            //int b = a;
            //while (true)
            //{
            //    son = a % 10;
            //    a /= 10;
            //    ters = ters * 10 + son;
            //    if (a == 0) break;
            //}
            //if (ters == b) Console.WriteLine("polindrom");
            //else Console.WriteLine("polindrom deyil"); 

            //string cumle,duzelis="";
            //cumle = Console.ReadLine();
            //for(int i = 0; i < cumle.Length-1; i++)
            //{

            //    if (cumle[i] == ' ' && cumle[i + 1] != ' ')
            //    {
            //        duzelis += ' ';
            //        int o=(int)cumle[i + 1] - 32;
            //        duzelis += (char)o;
            //        continue;
            //    }
            //    if (cumle[i] != ' ') duzelis += cumle[i];
            //    else continue;
            //}
            //duzelis += cumle[cumle.Length - 1];
            //Console.Write(duzelis);


            //string word = "hello";
            //Console.WriteLine(ters(word));

        }
        private static string ters(string a)
        {
            string b = "";
            for (int i = a.Length - 1; i >= 0; i--)
            {
                b += a[i];
            }
            return b;
        }


        private static bool mukemmel(int a)
        {
            int sum = 0;
            for (int i = 1; i < a; i++)
            {
                if (a % i == 0) sum += i;
            }
            return sum == a;
        }

        
        private static void sade(int a)
        {
            bool sade = true;
            for (int i = 2; i < a; i++)
            {
                if (a % i == 0) sade = false;
            }
            if (sade) Console.WriteLine("sade");
            else if (sade == false) Console.WriteLine("murekkeb");
        }
    }



}