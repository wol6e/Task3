// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве
// A(3,6,8); B(2,1,-7) -> 15,84
// A(7,-5,0); B(1,-1,9) -> 11,53

int XA = Prompt("Введите координату x точки A: ");
int YA = Prompt("Введите координату y точки A: ");
int ZA = Prompt("Введите координату z точки A: ");
int XB = Prompt("Введите координату x точки B: ");
int YB = Prompt("Введите координату y точки B: ");
int ZB = Prompt("Введите координату z точки B: ");

int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}
 double AB = Math.Sqrt((XB-XA)*(XB-XA)+(YB-YA)*(YB-YA)+(ZB-ZA)*(ZB-ZA));
Console.Write($"A({XA},{YA},{ZA}); B({XB},{YB},{ZB} -> {AB})");