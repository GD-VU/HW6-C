Console.Clear();

const int COEFFICIENT = 0;
const int CONSTANT = 1;
const int X_COORD = 0;
const int Y_COORD = 1;
const int LINE1 = 1;
const int LINE2 = 2;

double lineData1 = InputLineData(LINE1);
double lineData2 = InputLineData(LINE2);

if (ValidateLines(lineData1, lineData2))
{
    double[] coord = FindCoords(lineData1, lineData2);
    System.Console.WriteLine($"Точка пересечения уравнений: y = {lineData1[COEFFICIENT]}*x + {lineData1[CONSTANT]} и y = {lineData2[COEFFICIENT]}*x + {lineData2[CONSTANT]}");
    System.Console.WriteLine($"Имеет координаты: {coord[X_COORD]}, {coord[Y_COORD]}");
}

// ввод чисел пользователем

double input(string message)
{
    System.Console.Write(message);
    string line = System.Console.ReadLine();
    double result = Convert.ToDouble(line);
    return result;
}

// ввод данных для прямой

double[] InputLineData(int numberOfLine)
{
    double[] lineData = new double[2];
    lineData[COEFFICIENT] = input($"Введите кэффициент для {numberOfLine} прямой: ");
    lineData[CONSTANT] = input($"Введите константу для {numberOfLine} прямой: ");
    return lineData;
}

// поиск координат

double[] FindCoords(double[] lineData1, double[] lineData2)
{
    double[] coord = new double[2];
    coord[X_COORD] = (lineData1[CONSTANT]-lineData2[CONSTANT])/(lineData1[COEFFICIENT]-lineData2[COEFFICIENT]);
    coord[Y_COORD] = lineData1[CONSTANT]*coord[X_COORD]+lineData1[CONSTANT];
    return coord;
}

// проверка линий 

bool ValidateLines(double[] lineData1, double[] lineData2)
{
    if (lineData1[COEFFICIENT]==lineData2[COEFFICIENT])
    {
        if (lineData1[CONSTANT]==lineData2[CONSTANT])
        {
            System.Console.WriteLine("Прямые совпадают");
            return false;
        }
        else 
        {
            System.Console.WriteLine("Прямые параллельны");
            return false;
        }
    }
    return true;
}

