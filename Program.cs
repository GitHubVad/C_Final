void FillArray(string [] array)
{
	
  for (int i = 0;i<array.Length;i++)
  {
     Console.WriteLine($"Введите {i+1} элемент массива");
     array[i] = Console.ReadLine();
  }
}


string [] Symbol(string [] array)
{
  int n = 0;
  for (int i = 0;i<array.Length;i++)
  {
    if(array[i].Length <=3)
    n++;
  }
  string [] rez = new string [n];
  int j = 0;
  for (int i = 0;i<array.Length;i++)
  {
    if(array[i].Length <=3)
    {
        rez[j] = array[i];
        j++;
    }
  }
  return rez;
}

void PrintArray(string [] array)
{
    Console.Write("[");
    for (int i = 0;i<array.Length-1;i++)
    {
    Console.Write($"‘{array[i]}’, ");
    }
    Console.Write ($"‘{array[^1]}’");
    Console.Write("]");
}
Console.Write("Введите количество элементов массива: ");
int m = Convert.ToInt32(Console.ReadLine());


string [] array = new string [m];
FillArray(array);
Symbol(array);
PrintArray(Symbol(array));