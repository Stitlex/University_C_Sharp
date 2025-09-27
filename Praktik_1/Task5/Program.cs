namespace Task5
{
    public class Program
    {
        public static double GetAverage(int[] marks)
        {
            double sum = 0;
            foreach (int mark in marks)
            {
                sum += mark;
            }
            return sum / marks.Length;
        }

        public static int GetMin(int[] marks)
        {
            int min = marks[0];
            foreach (int mark in marks)
            {
                if (mark < min)
                    min = mark;
            }
            return min;
        }

        public static int GetMax(int[] marks)
        {
            int max = marks[0];
            foreach (int mark in marks)
            {
                if (mark > max)
                    max = mark;
            }
            return max;
        }

        public static void PrintGroupStatistics(int[][] groups)
        {
            for (int i = 0; i < groups.Length; i++)
            {
                double average = GetAverage(groups[i]);
                int min = GetMin(groups[i]);
                int max = GetMax(groups[i]);

                Console.WriteLine($"Група {i + 1}: Середній = {average:F0}, Мінімальний = {min}, Максимальний = {max}");
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            
            int[][] studentGroups = new int[][]
            {
                new int[] { 80, 90, 63, 85, 95 },
                new int[] { 70, 50, 75, 95, 65, 80 },
                new int[] { 100, 95, 79, 98, 92 }
            };

            PrintGroupStatistics(studentGroups);
        }
    }
}
