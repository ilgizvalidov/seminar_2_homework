
void SecondDigit (int Arg) 
{
    int Result = Arg%10; 
    Console.WriteLine ($" третья цифра будет {Result}");
}
 
try 
{
   Console.WriteLine ("введите  целое положительное число ");
   int Number = Convert.ToInt32(Console.ReadLine ());
   if (Number < 1000 )
        if (Number > 99) SecondDigit (Number);
        else Console.WriteLine("в этом числе второй цифры нет"); 
   else 
   {
         
        while (Number > 1000)
        {
            Number = Number/10;
             
        }
        SecondDigit (Number);
   }
    
}
catch
{
    Console.WriteLine ("Вы ввели не  число");
}