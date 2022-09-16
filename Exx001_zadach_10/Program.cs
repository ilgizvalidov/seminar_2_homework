void SecondDigit (int Arg) 
{
    int Result = (Arg/10)%10; 
    Console.WriteLine ($" вторая цифра числа {Arg} будет {Result}");
}
 

try 
{
   Console.WriteLine ("введите трехзначное целое положительное число ");
   int Number = Convert.ToInt32(Console.ReadLine ());
   if (Number < 1000 )
        if (Number > 99) SecondDigit (Number);
        else Console.WriteLine("вы ввели число содержащее меньше трех знаков"); 
   else Console.WriteLine ("вы ввели число собдержащее более трех знаков");
}
catch
{
    Console.WriteLine ("Вы ввели не  число");
}