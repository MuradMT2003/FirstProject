#region Task-1
//Console.Write("Eded daxil et:");
//int eded=int.Parse(Console.ReadLine());
//Console.WriteLine($"Sizin yasiniz {eded}den boyukdur");
#endregion
#region Task-2
//Console.Write("A ededini daxil et:");
//int a=int.Parse(Console.ReadLine());
//Console.Write("B ededini daxil et:");
//int b = int.Parse(Console.ReadLine());
//Console.WriteLine($"(a+b)^2 neticesi:{(a+b)*(a+b)}");
#endregion
#region Task-3
//Console.Write("Eded daxil et:");
//int number=int.Parse(Console.ReadLine());
//bool statement = number < 0;
//Console.WriteLine(statement);
#endregion
#region Task-4
//Console.Write("Eded 1 daxil et:");
//int number = int.Parse(Console.ReadLine());
//Console.Write("Eded 2 daxil et:");
//int number1 = int.Parse(Console.ReadLine());
//Console.WriteLine((number+number1)>20);
#endregion
#region Task-5
//Console.Write("radius daxil et:");
//int number = int.Parse(Console.ReadLine());
//Console.WriteLine(number*number*3.14);
#endregion
#region Task-6
//Console.Write("eded daxil et:");
//int number = int.Parse(Console.ReadLine());
//int sum = 0;
//while(number > 0)
//{
//    int val=number%10;
//    sum += val;
//    number= number/10;
//}
//Console.WriteLine(sum);
#endregion
#region Task-7
//int n=int.Parse(Console.ReadLine());
//int m = int.Parse(Console.ReadLine());
//while (n <= m)
//{
//    if(n %2== 0) Console.WriteLine(n);
//    n++;
//}

#endregion
#region Task-8
//int num = int.Parse(Console.ReadLine());
//int count = 0;
//while (num>=1)
//{
//    num /= 10;
//    count++;
//}
//Console.WriteLine(count);                                                                                 
#endregion
#region Task-9

//int number = int.Parse(Console.ReadLine());

//if (!(number == 0 || number == 1))
//{
//    string res = "prime";
//    for (int i = 2; i < number; i++)
//    {
//        if (number % i == 0)
//        {
//            res = "murekkeb ededdir";

//        }
//    }
//    Console.WriteLine(res);
//}
//else
//{
//    Console.WriteLine("ne sade,ne de murekkeb ededdir");
//}



#endregion
#region Task-9
//int[] arr = { -5, 91, -55, 87, 100 };
//int num = -5;
//bool some = false;
//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] == num)
//    {
//        Console.WriteLine(num);
//        some = true; 
//        break;
//    }
//}
//if(!some)
//    Console.WriteLine("eded movcud deyil");

#endregion
#region Task-10
//int[] arr = { 3, 1, 8, 5, 0, 9, 12, 2 };
//for (int i = 0; i < arr.Length; i++)
//{
//    for (int j = 0; j < arr.Length-1; j++)
//    {
//        if (arr[j] > arr[j + 1])
//        {
//            int helper = arr[j];
//            arr[j] = arr[j + 1];
//            arr[j + 1] = helper;
//        }

//    }
//}
#endregion
#region Task-11
//int[] arr = { 3, 1, 8, 5, 0, 9, 12, 2 };
//int target = 112;
//for (int i = 0; i < arr.Length; i++)
//{
//    for (int j = 0; j < arr.Length - 1; j++)
//    {
//        if (arr[j] > arr[j + 1])
//        {
//            int helper = arr[j];
//            arr[j] = arr[j + 1];
//            arr[j + 1] = helper;
//        }

//    }
//}
//int start = 0;
//int end = arr.Length - 1;
//bool some = true;
//while(start <= end)
//{
//    int middle = (start + end) / 2;
//    if (arr[middle] == target)
//    {
//        Console.WriteLine("the current position of target is: "+(middle+1));
//        some = false;
//        break;
//    }
//    else if (arr[middle] > target)
//    {
//        end = middle-1;
//    }
//    else
//    {
//        start = middle+1 ;

//    }
//}
//if (some)
//Console.WriteLine("this target is not find in array");
#endregion
