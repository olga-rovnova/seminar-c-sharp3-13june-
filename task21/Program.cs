//Задача 21: Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

int Input(string output) 
{     
    Console.Write(output);     
    return Convert.ToInt32(Console.ReadLine());
}


int x1 = Input("введите координату x1: ");
int y1 = Input("введите координату y1: ");
int z1 = Input("введите координату z1: ");
int x2 = Input("введите координату x2: ");
int y2 = Input("введите координату y2: ");
int z2 = Input("введите координату z2: ");

int distanceX = CalculateDistance(x1, x2);
int distanceY = CalculateDistance(y1, y2);
int distanceZ = CalculateDistance(z1, z2);

double distance = Math.Sqrt(Quadro(distanceX) + Quadro(distanceY) + Quadro(distanceZ));

Console.WriteLine("расстояние между точками: " + distance);

int CalculateDistance(int a, int b)
{
    return a - b; //метод: разница координат на оси
}

int Quadro(int a)
{
    return a * a; //метод: возведение в квадрат
}