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
Console.WriteLine();
Console.WriteLine();
// Task 2 

string []myStringArray = new string [4];
myStringArray[0] = "Linda";
myStringArray[1] = "Irena";
myStringArray[2] = "Julija";
myStringArray[3] = "Violeta";

for (int i = 0; i < myStringArray.Length; i++)
{
    Console.WriteLine($" {myStringArray[i]} ");
}
Console.WriteLine();
Console.WriteLine();
//Task3
string[,] myStringArray2D = new string[2,2];
myStringArray2D[0,0] = "Linda";
myStringArray2D[0,1] = "Irena";
myStringArray2D[1,0] = "Julija";
myStringArray2D[1,1] = "Violeta";


for (int i = 0; i < myStringArray2D.GetLength(0); i++)
{
    for (int k = 0; k < myStringArray2D.GetLength(1); k++)
    { 
     Console.WriteLine ($"{myStringArray2D [i,k]} "); 
    }
}
