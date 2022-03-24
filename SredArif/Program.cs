class Program
{
    static void Main(string[] args)
    {
        int[,] mass = new int[4, 6];
        Random ran = new Random();

        for (int i = 0; i < mass.GetLength(0); i++)
            for (int j = 0; j < mass.GetLength(1); j++)
                mass[i, j] = ran.Next(0, 100);

        arr a = new arr();
        Console.WriteLine("кол-во эл-тов больших среднего = {0}", a.Kol(mass));
        Console.ReadKey();
    }
}
class arr
{
    public int Kol(int[,] array)
    {
        int sum = 0;
        int sred = 0;
        int kol = 0;

        for (int i = 0; i < array.GetLength(0); i++)
            for (int j = 0; j < array.GetLength(1); j++)
                sum += array[i, j];

        sred = sum / array.Length;

        for (int i = 0; i < array.GetLength(0); i++)
            for (int j = 0; j < array.GetLength(1); j++)
                if (array[i, j] > sred) kol++;

        return kol;
    }
}