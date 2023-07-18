// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

float[] get_coordinate(int num)
{
    float[] coord = new float[3];    
    for (int i = 1; i<=3; i++)
    {
        Console.Write("Введите "+i+" координату "+num+" вектора: ");
        coord[i-1] = (float)Convert.ToDouble(Console.ReadLine());
    }    
    return coord;
}
// Console.WriteLine(get_coordinate()[1]);
double distance = 0;
float[] first_vector = new float[3];
float[] second_vector = new float[3];
first_vector = get_coordinate(1);
second_vector = get_coordinate(2);
for (int i=1; i<=3; i++)
{
    distance = distance + Math.Pow((first_vector[i-1]-second_vector[i-1]),2);
}
distance = Math.Round(Math.Sqrt(distance),2);
Console.WriteLine(distance);