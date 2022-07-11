// Найти точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

double[,] Coff = new double[2, 2];
double[] crossPoint = new double[2];

void InputCofficients()
{
  for (int i = 0; i < Coff.GetLength(0); i++)
  {
    Console.Write($"Введите коэффициенты {i+1}-го уравнения (y = k * x + b):\n");
    for (int j = 0; j < Coff.GetLength(1); j++)
    {
      if(j==0) Console.Write($"Введите коэффициент k{i+1}: ");
      else Console.Write($"Введите коэффициент b{i+1}: ");
      Coff[i,j] = Convert.ToInt32(Console.ReadLine());
    }
  }
}

double[] Decision(double[,] Coff)
{
  crossPoint[0] = (Coff[1,1] - Coff[0,1]) / (Coff[0,0] - Coff[1,0]);
  crossPoint[1] = crossPoint[0] * Coff[0,0] + Coff[0,1];
  return crossPoint;
}

void OutputResponse(double[,] Coff)
{
  if (Coff[0,0] == Coff[1,0] && Coff[0,1] == Coff[1,1]) 
  {
    Console.Write($"\nПрямые совпадают");
  }
  else if (Coff[0,0] == Coff[1,0] && Coff[0,1] != Coff[1,1]) 
  {
    Console.Write($"\nПрямые параллельны");
  }
  else 
  {
    Decision(Coff);
    Console.Write($"\nТочка пересечения прямых: ({crossPoint[0]}; {crossPoint[1]})");
  }
}

InputCofficients();
OutputResponse(Coff);