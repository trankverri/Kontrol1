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

string[] AR = {"Маi","Даша","М","Дарья","hre","00","qwert","qwe"};
Metod1(AR);
