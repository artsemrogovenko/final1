Console.WriteLine("Введите 5 строк");

string[] ReadConsole()
{
    string[] array = new string[5];
    int count = 0;
    while (count < 5)
    {
        string s = Console.ReadLine();
        if (s != "")
        {
            array[count] = s;
            count++;
        }
        else Console.WriteLine("строка не должна быть пустой");
    }
    return array;
}

string[] str = ReadConsole();
string[] result = GetStrings(str);
Console.WriteLine(String.Join(",",str));
Console.WriteLine(String.Join(",",result));

string[] GetStrings (string[] input){
int count=0;
    for (int index = 0; index < input.Length; index++)
    {
        if (input[index].Length <= 3)
        {          
            count++;
        }
    }
    string[] result = new string[count];
    int k = 0;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i].Length <= 3)
        {
            result[k] = input[i];
            k++;
        }
    }
    return result;
}
