try 
{
 
    Console.WriteLine ("Введите цифру от 1 до 7 соответствующую намеру дня недели, где 1 это понедельник, а 7 - воскресенье");
    int Number = Convert.ToInt32 (Console.ReadLine ());
switch (Number)
{
    case 1: Console.WriteLine ("нет");
        break;
    case 2: Console.WriteLine ("нет");
        break;
    case 3: Console.WriteLine ("нет"); 
        break;
    case 4: Console.WriteLine ("нет");
        break;
    case 5: Console.WriteLine ("нет");
        break;
    case 6: Console.WriteLine ("да");
        break;
    case 7: Console.WriteLine ("lда");
        break;
    default: Console.WriteLine ("введите привильное число");
        break;                       
}
} 
catch 
{
    Console.WriteLine ("вы ввели не цифру");
}
