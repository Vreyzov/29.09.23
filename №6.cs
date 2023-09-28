Console.WriteLine("Введите отметку");
double x = Convert.ToDouble(Console.ReadLine());
switch (x)
{

    
    case 1:
        Console.WriteLine("плохо");
        break;
    case 2:
        Console.WriteLine("неудовлетворительно");
        break;
    case 3:
        Console.WriteLine("удовлетворительно");
        break;
    case 4:
        Console.WriteLine("хорошо");
        break;
    case 5:
        Console.WriteLine("отлично");
        break;
   
    default:
        Console.WriteLine("Введите отметку от 1 до 5");
        break;

}
