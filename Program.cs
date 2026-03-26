//for
//example 1
//int sum = 0;

//for(int i = 0; i <= 100; i++)
//{
//    sum += i;

//}
//Console.WriteLine(sum);

// example 2
//Console.WriteLine("Enter the starting value of sum");
//int NumS=Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Enter the finishing value of sum");
//int NumF=Convert.ToInt32(Console.ReadLine());

//int Sum = 0;
//for (; NumS <= NumF; NumS++)
//{
//    Sum += NumS;
//}
//Console.WriteLine(Sum);

//example 3

//string[] Names = { "Ali", "Ahmet", "Can", "Yelda", "Seda", "Mehmet" };

//for (int i = 0; i <= 5; i++)
//{
//    Console.WriteLine(Names[i]);

//}

//example 4

//int[] Nums = { 1, 3, 4, 34, 41, 56, 89 };

//for (int i = 0; i < Nums.Length; i++)
//{
//    if(Nums[i] % 3 ==0 )
//        Console.WriteLine($"Üçe bölünen sayı {Nums[i]}");
//}   


// While

var rnd = new Random();
int Rndmguess = rnd.Next(1,100);

int GuessCounter = 3;

while (GuessCounter > 0)
{
    Console.WriteLine($"Your last guess chance :{GuessCounter}");

    Console.WriteLine("Please enter the your guess:");
    int myguess =Convert.ToInt32(Console.ReadLine());
    if(GuessCounter == 0)
        Console.WriteLine("SORRY!!! You loosed");
    else if (myguess <= Rndmguess)
        Console.WriteLine("Please enter more bigger number");
    else if (myguess >= Rndmguess)
        Console.WriteLine("Please try more lower number ");
    else if (myguess == Rndmguess)
        Console.WriteLine("Congratulations you won");
    

    GuessCounter--;
}

