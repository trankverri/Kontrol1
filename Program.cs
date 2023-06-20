Console.Clear();
Console.WriteLine("Hello, Препод!");

void Metod1(string [] StringArray)
{

    string[] TempArray= {""};

    foreach (var item in StringArray)
    {
        if (item.Length<=3)
        {
            TempArray=TempArray.Append(item).ToArray();
            Console.Write("{0}\t", item);
        }    
    }
}

// string[] AR = {"Маi","Даша","М","Дарья","hre","00","qwert","qwe"};
// Metod1(AR);

string a;
var UserArray = new List<string>();
Console.WriteLine("Для окончания ввода жмакайте Enter");
Console.WriteLine("Введите элементы массива");
//Получаем строку и проверяем ее содержание
while (!string.IsNullOrEmpty((a = Console.ReadLine()))) //..((a = Console.ReadLine()) != "Q")
{
    UserArray.Add(a);
}
Console.Write("Введенный массив: ");
Console.WriteLine(string.Join(" ", UserArray));
string[] UserMassiv = UserArray.ToArray();
Console.WriteLine("Для продолжения нажмите Enter");
Console.ReadKey();

//string[] AR = {"Маi","Даша","М","Дарья","hre","00","qwert","qwe"};
Console.WriteLine($"elemets.length <=3:\t");
Metod1(UserMassiv);