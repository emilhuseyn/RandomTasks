#region task1
//int eded2 = Convert.ToInt32(Console.ReadLine());
//if (eded1 == eded2)
//{
//    Console.WriteLine("They are equal");
//}
//else
//{
//    Console.WriteLine("Not equal");
//}
#endregion
#region task 2
//int eded1 = Convert.ToInt32(Console.ReadLine());
//int eded2 = Convert.ToInt32(Console.ReadLine());
//int eded3 = Convert.ToInt32(Console.ReadLine());
//if (eded1 > eded2 && eded1 > eded3)
//{
//    Console.WriteLine(eded1);
//}
//else if (eded2 > eded1 && eded2 > eded3)
//{
//    Console.WriteLine(eded2);
//}
//else if (eded3 > eded2 && eded3 > eded1)
//{
//    Console.WriteLine(eded3);
//}
#endregion
#region task 3
//int eded1 = Convert.ToInt32(Console.ReadLine());
//int eded2 = Convert.ToInt32(Console.ReadLine());
//int eded3 = Convert.ToInt32(Console.ReadLine());
//if (eded1 + eded2 + eded3 == 180)
//{
//    Console.WriteLine("This is possible");
//}
//else
//{
//    Console.WriteLine("Not possible");
//}
#endregion
#region task 4
//Console.Write("Eded daxil edin:");
//int eded1 = Convert.ToInt32(Console.ReadLine());
//switch (eded1)
//{
//    case 0:
//        Console.WriteLine("Sifir");
//        break;
//    case 1:
//        Console.WriteLine("Bir");
//        break;
//    case 2:
//        Console.WriteLine("Iki");
//        break;
//    case 3:
//        Console.WriteLine("Uc");
//        break;
//    case 4:
//        Console.WriteLine("Dord");
//        break;
//    case 5:
//        Console.WriteLine("Bes");
//        break;
//    case 6:
//        Console.WriteLine("Alti");
//        break;
//    case 7:
//        Console.WriteLine("Yeddi");
//        break;
//    case 8:
//        Console.WriteLine("Sekkiz");
//        break;
//    case 9:
//        Console.WriteLine("Doqquz");
//        break;
//    default:
//        Console.WriteLine("Dogru emeliyyat edin");
//        break;
//}
#endregion
#region task 5
//Console.Write("First integer");
//int eded1 = Convert.ToInt32(Console.ReadLine());
//Console.Write("Second integer");
//int eded2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Options:Addition, Substraction, Multiplication, Division, Break");
//Console.Write("Option:");
//string option = Console.ReadLine();
//if (option == "Addition")
//{
//    Console.WriteLine(eded1 + eded2);
//}                                   
//else if (option == "Substraction")
//{
//    Console.WriteLine(eded1 - eded2);
//}
//else if (option == "Multiplication")
//{
//    Console.WriteLine(eded1 * eded2);
//}
//else if (option == "Division")
//{
//    Console.WriteLine(eded1 / eded2);
//}
//else if (option == "Break")
//{
//    Console.WriteLine("Thank for using");
//}
#endregion
#region task 6
//int eded1 = Convert.ToInt32(Console.ReadLine());
//switch (eded1)
//{
//    case 1:
//        Console.WriteLine("Monday");
//        break;
//    case 2:
//        Console.WriteLine("Tuesday");
//        break;
//    case 3:
//        Console.WriteLine("Wednesday");
//        break;
//    case 4:
//        Console.WriteLine("Thursday");
//        break;
//    case 5:
//        Console.WriteLine("Friday");
//        break;
//    case 6:
//        Console.WriteLine("Saturday");
//        break;
//    case 7:
//        Console.WriteLine("Sunday");
//        break;
//}

#endregion
#region task 7
//int i =0, cem = 0;
//while (i < 100)
//{
//    if(i%3==0 && i % 7 == 0)
//    {
//        cem += i;
//    }
//    i++;
//}
//Console.Write(cem);
#endregion
#region task 8
//int N, say=0;
//N = Convert.ToInt32(Console.ReadLine());
//while (N > 0)
//{
//    say++;
//    N /= 10;
//}
//Console.WriteLine(say);
#endregion
#region task 9.1
//for (int i = 0; i < 10; i++)
//    {
//        Console.WriteLine(i);
//    }
#endregion
#region task 9.2
////with for
//int cem = 0, i;
//for (i = 0; i < 10; i++)
//    {
//        cem += i;
//    }
//Console.WriteLine(cem);
////with while
//int cem = 0, i = 0;
//while (i < 10)
//{
//    cem = cem + i;
//    i++;
//}
#endregion
#region task 9.3
//for (int i = 0; i < 100; i++)
//{
//    Console.WriteLine("Musbet:" + i + "  Menfi:" + (-i));
//}
#endregion
#region task 9.4 
////with while
//int cem = 0,i = 0;
//while (i < 100)
//{
//    if (i % 15 == 0)
//    {
//        cem = cem + i;

//    }
//    i++;
//}
//Console.WriteLine(cem);
////with for
//int cem = 0, i;
//for (i = 0; i < 100; i++)
//    {
//        if (i % 15 == 0)
//        {
//            cem = cem + i;
//        }
//    }
//Console.WriteLine(cem);
#endregion
#region task 9.5
//Console.WriteLine("10 eded daxil et ve ededi ortasini hesabla:");
//double cem = 0;
//for (int i = 0; i < 10; i++)
//{
//    double number = Convert.ToInt32(Console.ReadLine());
//    cem += number;
//}

//Console.WriteLine("10 ededin cemi:" + cem);
//Console.WriteLine("Ededi orta:" + cem / 10);

#endregion
#region task 10
//int cem = 0;
//int[] numbers = { 1, 4, 2, 6, 9, 9 };
//for(int i = 0; i < 6; i++)
//{
//    cem += numbers[i];
//}
//Console.WriteLine(cem);
#endregion
#region task 11
//int[] numbers = { 1,77,71,93,5 };
//int max = numbers[0];
//for(int i = 0; i < 5; i++)
//{
//    if (numbers[i] > max)
//    {
//        max = numbers[i];
//    }
//}
//Console.WriteLine(max);
#endregion
#region task 12.1
//int[] array = { 23, 32, 92, 529, 2, 3, 12, 16, 4 };
//for(int i = 0; i < array.Length; i++)
//{
//    Console.WriteLine(array[i]);
//}
#endregion
#region task 12.2
//int[] array1 = { 23, -32, 92, -529, 2, -3, 12, -16, 4 };
//int count = 0;
//for (int i = 0; i < array1.Length; i++)
//{
//    if (array1[i] < 0)
//    {
//        count++;
//    }
//}
//Console.WriteLine(count);
#endregion
#region task 12.3
//int[] array2 = { 23, -32, 92, -529, 2, -3, 12, -16, 4 };
//double cem = 0;
//for (int i = 0; i < array2.Length; i++)
//{
//    cem = cem + array2[i];

//}
//Console.WriteLine(cem / array2.Length);
#endregion
#region task 12.4
//int[] numbers = { 23, -32, 92, -529, 2, -3, 12, -16, 4 };
//int min = numbers[0];
//int max = numbers[8];
//for(int i = 0; i < 9; i++)
//{
//    if (numbers[i] > max)
//    {
//        max = numbers[i];
//    }
//    if (numbers[i] < min)
//    {
//        min = numbers[i];
//    }
//}
//Console.WriteLine(max + min);
#endregion
#region task 12.5
//int max, secMax;
//int[] maximums = { -49999, -12, -3045, -46 };
//max = maximums[0];
//int max_index = 0;
//int min_index = 0;
//for (int i = 1; i < maximums.Length; i++)
//{
//    if (maximums[i] > max)
//    {
//        max = maximums[i];
//        max_index = i;
//    }
//}
//if (max_index != maximums.Length - 1)
//{
//    min_index = max_index + 1;
//}
//else
//{
//    min_index = max_index - 1;
//}

//secMax = maximums[min_index];
//for (int j = 0; j < maximums.Length; j++)
//{
//    if (maximums[j] < max && maximums[j] > secMax)
//    {
//        secMax = maximums[j];

//    }
//}
//Console.WriteLine(secMax);

#endregion
#region task 12.6
//Console.WriteLine("10-20 eded daxil edin:");
//int input = Convert.ToInt32(Console.ReadLine());
//if (input >= 10 && input < 20)
//{
//    if (input % 2 == 0)
//    {
//        Console.WriteLine("Cut ededdir");
//    }
//    else
//    {
//        Console.WriteLine("Tek ededdir");
//    }

//}

//else
//{
//    do { 
//        Console.WriteLine("Sehv eded daxil etmisiniz tezden daxil edin");
//        input = Convert.ToInt32(Console.ReadLine());
//        if(input>10 & input < 20)
//        {
//            if (input % 2 == 0)
//            {
//                Console.WriteLine("Cut ededdir");
//            }
//            else
//            {
//                Console.WriteLine("Tek ededdir");
//            }
//            break;
//        }

//    } while (true);

//}

#endregion
