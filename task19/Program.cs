// Задача 2: Напишите программу, которая найдёт точку пересечения
// двух прямых, заданных уравнениями у = k1 * х + b1, у = k2 * х + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 =2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// ***Метод Крамера***
// k1 * х + b1-y=0, k2 * х + b2-y=0;
// дельта XY  | 5 -1| 5*(-1)-(-1)*9=4
//            | 9 -1|
// дельта X = |-2 -1| -2*(-1) –(-1)*(-4)=6 (x=-2/4=0.5)
//            |-4 -1|
// дельта Y = | 5 -2| 5*(-4)-(-2)*9= -2    (y=-2/4=-0.5)
//            | 9 -4|


int Prompt(string message)
{
    Console.WriteLine(message);
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}

void NameMethod()
{
    System.Console.WriteLine(
        "Нахождение координат точки пересечения двух прямых в плоскости методом Крамера"
    );
}

NameMethod();

double y = -1.0;
int b1 = Prompt($"Введите b1 ->  ");
int b2 = Prompt($"Введите b2 ->  ");
int k1 = Prompt($"Введите k1 ->  ");
int k2 = Prompt($"Введите k2 ->  ");

double[,] Matrixdelta()
{
    double[,] mat = new double[2, 2];
    mat[0, 0] = k1;
    mat[1, 1] = y;
    mat[0, 1] = y;
    mat[1, 0] = k2;
    return mat;
}

double[,] Matrixdeltax()
{
    double[,] matx = new double[2, 2];
    matx[0, 0] = -b1;
    matx[1, 1] = y;
    matx[0, 1] = y;
    matx[1, 0] = -b2;
    return matx;
}

double[,] Matrixdeltay()
{
    double[,] matty = new double[2, 2];
    matty[0, 0] = k1;
    matty[1, 1] = -b2;
    matty[0, 1] = -b1;
    matty[1, 0] = k2;
    return matty;
}

double MatrixFormula1(double[,] mattr)
{
    double value = mattr[0, 0] * mattr[1, 1] - mattr[0, 1] * mattr[1, 0];
    return value;
}

double value1 = MatrixFormula1(Matrixdelta());
double value2 = MatrixFormula1(Matrixdeltax());
double value3 = MatrixFormula1(Matrixdeltay());

(double, double) MatrixFindCoord()
{
    double valuex = value2 / value1;
    double valuey = value3 / value1;
    return (valuex, valuey);
}

(double coordx, double coordy) = MatrixFindCoord();

Console.WriteLine($"Координаты точки пересечения двух прямых({coordx:f1};{coordy:f1})");
