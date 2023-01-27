
Console.WriteLine("Введите длину массива");
int len=Convert.ToInt32(Console.ReadLine());
string[] array=new string[len];
Console.WriteLine("введите элементы массива");

 string [] GetArray()
 {
    for (int i = 0; i < array.Length; i++)
    {
        array[i]=Convert.ToString(Console.ReadLine());
        
    }
    return array;
 }
GetArray();

void Poisk()
{
    int lenarray=0;
    for (int i = 0; i < array.Length; i++)
    {
        lenarray=array[i].Length;
        if (lenarray<=3)
        {
        Console.WriteLine(array[i]);
        }
    }
}
Console.WriteLine("Элементы с длинной три символа или меньше:");
Poisk();