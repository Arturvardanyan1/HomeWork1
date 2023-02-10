namespace HomeWork2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////29
            //Console.Write("a= ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("b= ");
            //int b = int.Parse(Console.ReadLine());
            //Console.Write("c= ");
            //int c = int.Parse(Console.ReadLine());
            //if (a > b && a > c)
            //{
            //    Console.WriteLine(a);
            //    if (b > c)
            //    {
            //        Console.WriteLine(b);
            //        Console.WriteLine(c);
            //    }
            //    else
            //    {
            //        Console.WriteLine(c);
            //        Console.WriteLine(b);
            //    }
            //}
            //else
            //    if (b > a && b > c)
            //{
            //    Console.WriteLine(b);
            //    if (a > c)
            //    {
            //        Console.WriteLine(a);
            //        Console.WriteLine(c);
            //    }
            //    else
            //    {
            //        Console.WriteLine(c);
            //        Console.WriteLine(a);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine(c);
            //    if (a > b)
            //    {
            //        Console.WriteLine(a);
            //        Console.WriteLine(b);
            //    }
            //    else
            //    {
            //        Console.WriteLine(b);
            //        Console.WriteLine(a);
            //    }
            //}



            //31
            //Console.WriteLine("Enter Array Numbers");
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];
            //Console.WriteLine("Enter Array Elements");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = i+1; j < arr.Length; j++)
            //    {
            //        if (arr[i] < arr[j])
            //        {
            //            int k = arr[j];
            //            arr[j]=arr[i];
            //            arr[i] = k;
            //        }
            //    }
            //}
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}


            //34
            //Console.Write("a= ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("b= ");
            //int b = int.Parse(Console.ReadLine());
            //Console.Write("c= ");
            //int c = int.Parse(Console.ReadLine());
            //Console.Write("d= ");
            //int d = int.Parse(Console.ReadLine());
            //if((a + b == c + d) || (a + c == b + d) || (a + d ==b + c))
            //{
            //    Console.WriteLine( "true" );
            //}else
            //    Console.WriteLine("false");

            //58
            //char f;
            //Console.WriteLine("enter a three-digit number");
            //int x=int.Parse(Console.ReadLine());
            //int y = x % 10;
            //x-=y;
            //int z = x % 100;
            //x -= z;
            //z /= 10;            
            //int k = x % 1000;
            //k /= 100;
            //if (z + k < 5)
            //{
            //    f = 'a';
            //}
            //else
            //    f = 'b';
            //Console.WriteLine("f= "+f);

            //69
            //Console.WriteLine("enter a four-digit number");
            //int x = int.Parse(Console.ReadLine());
            //int y = x % 10;
            //x -= y;
            //int z = x % 100;
            //x -= z;
            //z /= 10;
            //int k = x % 1000; 
            //x -= k;
            //k /= 100;
            //int l = x % 10000;
            //l /= 1000;
            //if ((x + z + k + l) > 20)
            //{
            //    Console.WriteLine("Y = 1");
            //}else
            //    Console.WriteLine("Y = 0");

            //159
            //for (int i = 100; i <=999; i++)
            //{
            //    if(i%3==1 && i % 4 == 2)
            //    {
            //        Console.WriteLine(i);   
            //    }
            //}

            //165            
            //Console.WriteLine("import a natural number");
            //int x =int.Parse(Console.ReadLine());
            //bool t=true;            
            //for (int i = 0; i < 100; i++)
            //{
            //    if (x==0)
            //    {
            //        t=false;
            //        break;

            //    }
            //    else { 
            //        if (x % 3 == 0)
            //        {
            //            x /= 3;                       
            //            if(x == 1)
            //            {
            //                t = true;
            //                break;
            //            }
            //        }
            //        else
            //        {                        
            //            t = false;
            //            break;

            //        }
            //    }
            //}
            //Console.WriteLine(t);

            ////245
            //Console.WriteLine("enter the call size");
            //int n=int.Parse(Console.ReadLine());
            //int[] arr =new int[n];
            //int s=0;
            //Console.WriteLine("enter the elements");
            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //for(int i = 0; i < n; i++)
            //{
            //    if((arr[i] + i)%3 == 0)
            //    {
            //        s +=(arr[i]) ^ 2;
            //    }
            //}

            ////258
            //Console.WriteLine("enter the call size");
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];
            //Console.WriteLine("enter the elements");
            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //int k = 0;
            //int max = arr[0];
            //for (      int i = 0; i < n; i++)
            //{

            //    if (max >= arr[i])
            //    {
            //        max= arr[i];
            //        k = i;
            //    }
            //}
            //Console.WriteLine(k);

            //266
            Console.WriteLine("enter the call size");
            int n = int.Parse(Console.ReadLine());
            int[] x = new int[n];
            Console.WriteLine("enter the elements");
            for (int i = 0; i < n; i++)
            {
                x[i] = int.Parse(Console.ReadLine());
            }
            int[] y = new int[n];
            Console.WriteLine("enter the elements");
            for (int i = 0; i < n; i++)
            {
                y[i] = int.Parse(Console.ReadLine());
            }
            int sumx = 0;
            int sumy = 0;
            for (int i = 0; i < n; i++)
            {
                if (x[i] % 2 != 0)
                {
                    sumx += x[i];
                }
                if (y[i] % 2 == 0)
                {
                    sumy += y[i];
                }
            }
            Console.WriteLine(sumx - sumy);



        }
    }
}