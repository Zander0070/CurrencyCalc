// Currency exhange calaculator.

double FixedDollar = 0;
double FixedEuro = 0;
double FixedZar = 0;
double FixedYen = 0;

Console.WriteLine("Hello!!!, Welcome to the most trust worth currency convertor\nWhat currency would you like to exhange in today\n\n");
Console.WriteLine("Please select one of the options : (DOLLAR/ZAR/EURO/YEN)");
string CurrencyType = Console.ReadLine();
string CurrencyAnswer;

if (CurrencyType == "YEN")
{
    FixedDollar = 0.0041;
    FixedZar = 0.076;
    FixedEuro = 0.0036;
}
else if (CurrencyType == "DOLLAR")
{

    FixedYen = 245.10;
    FixedZar = 18.69;
    FixedEuro = 0.88;

} else if (CurrencyType == "EURO")
{

    FixedDollar = 1.33;
    FixedZar = 24.88;
    FixedYen = 326.33;

} else if(CurrencyType == "ZAR")
{
    FixedDollar = 0.054;
    FixedEuro = 0.047;
    FixedYen = 13.11;

}
else
{
    Console.WriteLine("Please make sure of your spelling and try again :)");
}

Console.WriteLine($"\nHow much {CurrencyType} would you like to exchange :");
string Amount = Console.ReadLine();
int RealAmount = Convert.ToInt32(Amount);

if (CurrencyType == "EURO")
{
    Console.WriteLine("\nWhat currency would you like to trafer this to?\nOptions : (DOLLAR,YEN,ZAR)");
    CurrencyAnswer = Console.ReadLine();
    Console.WriteLine("\n\n");
    if (CurrencyAnswer == "Dollar")
    {

        double total = RealAmount * FixedDollar;
        Console.WriteLine($"\nAfter the exhange you will have {total} amount of {CurrencyAnswer}");

    } else if (CurrencyAnswer == "YEN")
    {

        double total = RealAmount * FixedYen;
        Console.WriteLine($"\nAfter the exhange you will have {total} amount of {CurrencyAnswer}");

    } else if (CurrencyAnswer == "ZAR")
    {
        double total = RealAmount * FixedZar;
        Console.WriteLine($"\nAfter the exhange you will have {total} amount of {CurrencyAnswer}");
    }
    else
    {
        Console.WriteLine("Please choose a valid answer");
    }


} else if (CurrencyType == "DOLLAR")
{
    Console.WriteLine("What currency would you like to trafer this to?\nOptions : (EURO,YEN,ZAR)");
    CurrencyAnswer = Console.ReadLine();
    
    if (CurrencyAnswer == "EURO")
    {

        double total = RealAmount * FixedEuro;
        Console.WriteLine($"\nAfter the exhange you will have {total} amount of {CurrencyAnswer}");

    }
    else if (CurrencyAnswer == "YEN")
    {

        double total = RealAmount * FixedYen;
        Console.WriteLine($"\nAfter the exhange you will have {total} amount of {CurrencyAnswer}");

    }
    else if (CurrencyAnswer == "ZAR")
    {
        double total = RealAmount * FixedZar;
        Console.WriteLine($"\nAfter the exhange you will have {total} amount of {CurrencyAnswer}");
    }
    else
    {
        Console.WriteLine("Please choose a valid answer");
    }


} else if (CurrencyType == "YEN"){

    Console.WriteLine("What currency would you like to trafer this to?\nOptions : (DOLLAR,EURO,ZAR)");
    CurrencyAnswer = Console.ReadLine();
    if (CurrencyAnswer == "Dollar")
    {

        double total = RealAmount * FixedDollar;
        Console.WriteLine($"\nAfter the exhange you will have {total} amount of {CurrencyAnswer}");

    }
    else if (CurrencyAnswer == "EURO")
    {

        double total = RealAmount * FixedEuro;
        Console.WriteLine($"\nAfter the exhange you will have {total} amount of {CurrencyAnswer}");

    }
    else if (CurrencyAnswer == "ZAR")
    {
        double total = RealAmount * FixedZar;
        Console.WriteLine($"\nAfter the exhange you will have {total} amount of {CurrencyAnswer}");
    }
    else
    {
        Console.WriteLine("Please choose a valid answer");
    }




} else if (CurrencyType == "ZAR")
{
    Console.WriteLine("What currency would you like to trafer this to?\nOptions : (DOLLAR,YEN,EURO)");
    CurrencyAnswer = Console.ReadLine();
    if (CurrencyAnswer == "Dollar")
    {

        double total = RealAmount * FixedDollar;
        Console.WriteLine($"\nAfter the exhange you will have {total} amount of {CurrencyAnswer}");

    }
    else if (CurrencyAnswer == "YEN")
    {

        double total = RealAmount * FixedYen;
        Console.WriteLine($"\nAfter the exhange you will have {total} amount of {CurrencyAnswer}");

    }
    else if (CurrencyAnswer == "EURO")
    {
        double total = RealAmount * FixedEuro;
        Console.WriteLine($"\nAfter the exhange you will have {total} amount of {CurrencyAnswer}");
    }
    else
    {
        Console.WriteLine("Please choose a valid answer");
    }




} 
