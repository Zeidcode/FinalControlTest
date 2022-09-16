string? yesNo = "";
while (yesNo.ToLower() != "yes" && yesNo.ToLower() != "no")
{
  Console.Write("Желаете вводить строки вручную? (yes/no): ");
  yesNo = Console.ReadLine();
}

string[] arrayOfStrings = new string[]  {};

if (yesNo.ToLower() == "yes") {
  int n = InputNumbers("Введите количество элементов массива: ");
  arrayOfStrings = new string[n];
  for (int i = 0; i < arrayOfStrings.Length; i++)
  {
    Console.Write($" Введите {i+1} строку: ");
    arrayOfStrings[i] = Console.ReadLine();
  }
}
else 
{
  arrayOfStrings = new string[]  {"hello", "2", "world", ":-)"};
}

int lengthLimit = 3;

int numbersItems = CheckArray(arrayOfStrings, lengthLimit);

string[] newArrayOfStrings = new string[numbersItems];

FillNewArray(arrayOfStrings, newArrayOfStrings, lengthLimit);

Console.WriteLine($"{PrintArray(newArrayOfStrings)}");