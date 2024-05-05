//class Program
//{
//    static void Main()
//    {
//        int num1 = 3;
//        int num2 = 7;
//        int product = Multiply(num1, num2);
//        Console.WriteLine("ededlerin hasili " + product);
//    }

//    static int Multiply(int num1, int num2)
//    {
//        return num1 * num2;
//    }
//}




//class Program
//{
//    static void Main()
//    {
//        int num1 = 3;
//        int power =FindSquare(num1);
//        Console.WriteLine("ededin kvadrati:  " + power);
//    }


//    static int FindSquare(int num1)
//    {
//        return num1 * num1;
//    }
//}




//class Program
//{
//    static void Main()
//    {
//        int[] array = { 5, 8, 6, 2, 9 };
//        int sum = SumArray(array);
//        Console.WriteLine("elementlerin cemi: " + sum);
//    }

//    static int SumArray(int[] arr)
//    {
//        int sum = 0;
//        foreach (int num in arr)
//        {
//            sum += num;
//        }
//        return sum;
//    }
//}


//public static class program
//{
//    public static void Main(string[] args)
//    {
//        string a = PrintWelcomeMessage("Oqtay", "Babayev");
//        Console.WriteLine(a);
//    }
//    public static string PrintWelcomeMessage(string name, string surname)
//    {
//        return $"xos gelmisen, {name}, {surname}";
//    }
//}


//public static class Program
//{
//    static void Main()
//    {
//        string word = "Salam";
//        Console.WriteLine(ReverseWord(word));
//    }

//    static string ReverseWord(string word)
//    {
//        string reversedWord = string.Empty;
//       for (int i = word.Length - 1;i>=0;i-- )
//        {
//            reversedWord += word[i];

//        }
//        return reversedWord;
//    }
//}





//class Program
//{
//    static void Main()
//    {
//        int parametr = 20;
//        Console.WriteLine(CheckNumber(parametr));
//    }

//    static string CheckNumber(int parametr)
//    {
//        if (parametr % 7 == 0)
//        {
//            return "Daxil edilen ədəd 7-e bolunur";
//        }
//        else
//        {
//            int yaxineded = (parametr / 7 + 1) * 7;
//            return "7-e bolunmur, en yaxın eded: " + yaxineded;
//        }
//    }
//}




//class Program
//{
//    public static void Main()
//    {
//        int a = 6;
//        int b = 3;
//        int c = 9;

//        int perimeter1 = FindPerimetr(a, b, c);
//        Console.WriteLine("Üçbucağın perimetri: " + perimeter1);


//        int perimeter2 = FindPerimetr(a);
//        Console.WriteLine("Kvadratın perimetri: " + perimeter2);
//    }
//    public static int FindPerimetr(int a, int b, int c)
//    {
//        return a + b + c;
//    }
//    public static int FindPerimetr(int a)
//    {
//        return 4 * a;
//    }
//}



//class Program
//{
//    public static void Main()
//    {
//        int sum = FindPerimetr(7, 4, 9);
//        Console.WriteLine(sum);
//    }
//    public static int FindPerimetr(int a, int b, int c)
//    {
//        return a + b + c;
//    }
//    public static int FindPerimetr(int a)
//    {
//        return 4 * a;
//    }
//}




//class Program
//{
//    static void Main()
//    {
//        string sentence = "bu gun bazar gunudur";
//        int bosluqsayi = CountSpaces(sentence);
//        Console.WriteLine("Cumledeki boşluq sayı: " + bosluqsayi);
//    }

//    static int CountSpaces(string sentence)
//    {
//        int bosluqsayi = 0;
//        foreach (var bosluq in sentence)
//        {
//            if (bosluq == ' ')
//            {
//                bosluqsayi++;
//            }
//        }
//        return bosluqsayi;
//    }
//}


