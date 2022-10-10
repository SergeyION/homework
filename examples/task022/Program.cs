// Найти расстояние между двумя точками в пространстве 2D и 3D. (Теорема ПИФАГОРА).

// 1. Откуда брать значения
// 2. Вычесления
// 3. Печать результата.

// 1. Откуда значения.
double GetValue(string text)
{
  Console.Write(text + ": "); 
  double value = Convert.ToDouble(Console.ReadLine());
  return value;
}

// 3. Печать результата.
void Print(double ax, double ay, double bx, double by, double result)
{
  // |A (1, 2); B(4, 5)| = 6
  string output = "| A(" + ax + ", " + ay + "); B(" + bx + ", " + by + ")| = " + 
                       // result;
                       Math.Round(result, 2);
  Console.WriteLine(output);
}

// Вычисления.
double GetDistance2D(double ax, double ay, double bx, double by)
{
  double x = (ax - bx) * (ax - bx); // возводим в квадрат 1 способ
  double y = Math.Pow(ay + by, 2); // возводим в квадрат 2 способ
  double result = Math.Sqrt(y + x);
  return result;
}

// System.Console.WriteLine(GetDistance(0,0,0,10)); // проверка параметров, вывод в консоль
// System.Console.WriteLine(GetDistance(0,0,10,0)); // проверка параметров, вывод в консоль
// System.Console.WriteLine(GetDistance(0,0,1,1)); // проверка параметров, вывод в консоль


// Пользовательский код.
double ax = GetValue("ax");
double ay = GetValue("ay");
double bx = GetValue("bx");
double by = GetValue("by");

double dis = GetDistance2D(ax, ay, bx, by);
Print(ax, ay, bx, by, dis);