string[] CreateArray(int len)
{
  string[] array = new string[len];
  for (int i = 0; i < len; i++)
  {
    Console.Write($"введите элемент {i + 1}: ");
    array[i] = Console.ReadLine();
  }
  return array;
}

int MaxLengthElem3(string[] array)
{
  int count = 0;
  for(int i = 0; i < array.Length; i++)
  {
    if (array[i].Length <= 3)
      count++;
  }
  return count;
}

string[] ShortElemArray(string[] array, int count)
{
  string[] result = new string [count];
  int count2 = 0;
  for(int i = 0; i < array.Length; i++)
  {
    if(array[i].Length <= 3)
      {
        result[count2] = array[i];
        count2 ++;
          if(count2 == count)
            return result;
      }
  }
  return result;
}



Console.Clear();
Console.Write("Введите длину массива: ");
int len = Convert.ToInt32(Console.ReadLine());
string[] StrArray = CreateArray(len);
int count = MaxLengthElem3(StrArray);
string[] ResArray = ShortElemArray(StrArray, count);
Console.WriteLine($"Массив с элементами длиной меньше четырех символов: [{string.Join(", ", ResArray)}]");