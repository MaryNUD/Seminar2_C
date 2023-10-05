int [] array = new int [8];
for (int i = 0; i < array.Length; i++)
  array [i] = new Random().Next(-10,11); // [-10, 10]
Console.WriteLine($"[{string.Join(", ", array)}]"); // make a string from our array

//string name = "Maryia";
//int age = 21;
//string city = "Minsk";

//Console.WriteLine($"My name is {name}. I am {age} years old. I am from {city}.");