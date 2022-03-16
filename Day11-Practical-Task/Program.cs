//Day 11 Task 1

int[]myArray =new int[5];
var random = new Random();
for (int i = 0; i < myArray.Length; i++)
{
    myArray[i] = random.Next();
}
Console.WriteLine($"This array consists of numbers");

for (int i = 0; i < myArray.Length; i++)
{ 
    Console.Write($" {myArray[i]} ");
}
Console.WriteLine();
Console.WriteLine("Odd numbers of the array are:");
for (int i = 0; i < myArray.Length; i++)
{
    var oddCondition = myArray[i] % 2 != 0;
    if (oddCondition)
    {
        Console.Write($" {myArray[i]} ");
    }
   
} 