using System;
using System.Text;
using System.Globalization;
using System.Diagnostics;

namespace ConsoleApp1
{
    class Program
    {
           
        static void Main(string[] args)
        {
            Student Tania = new Student();
            
            Console.WriteLine(Tania.ToString());

            Console.WriteLine(Tania[Education.Bachelor]);
            Console.WriteLine(Tania[Education.Master]);
            Console.WriteLine(Tania[Education.SecondEducation]);
            Person ob = new Person("Tania", "Lunyk", new DateTime(1999, 09, 24));
            
            Tania = new Student(ob, Education.Bachelor, 311);
           // Console.WriteLine(Tania.ToString());
            Exam ob1 = new Exam("Math", 5, new DateTime(2018, 12, 16));
            Exam[] ob2 = new Exam[] {ob1};
            Tania.AddExams(ob2);
            Console.WriteLine(Tania.ToString());

            int column = 100;
            int row = 100;

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            String[] exams1 = new string[column*row];
            for (int i = 0; i < column * row; i++)
            {
                exams1[i] = ob1.ToString();
            }
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;

            // Format and display the TimeSpan value. 
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds);
            Console.WriteLine("RunTime1 " + elapsedTime);


            Stopwatch stopWatch2 = new Stopwatch();
            stopWatch2.Start();
            String[,] exams2 = new string[column, row];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    exams2[i, j] = ob1.ToString();
                }
            }
            stopWatch2.Stop();
            TimeSpan ts2 = stopWatch2.Elapsed;

            // Format and display the TimeSpan value. 
            string elapsedTime2 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts2.Hours, ts2.Minutes, ts2.Seconds,
                ts2.Milliseconds);
            Console.WriteLine("RunTime2 " + elapsedTime2);


            Stopwatch stopWatch3 = new Stopwatch();
            stopWatch3.Start();
            String[][] exams3 = new string[row][];
            for (int i = 0; i < row; i++)
            {
                exams3[i] = new string[column];
                for (int j = 0; j < column; j++)
                {
                    exams3[i][j] = ob.ToString();
                }
            }
            stopWatch2.Stop();
            TimeSpan ts3 = stopWatch3.Elapsed;

            // Format and display the TimeSpan value. 
            string elapsedTime3 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts3.Hours, ts3.Minutes, ts3.Seconds,
                ts3.Milliseconds);
            Console.WriteLine("RunTime2 " + elapsedTime3);

            /*string str, str1;
            str = Console.ReadLine();
            int a; 
            int.TryParse(str, out a);
            str1 = Console.ReadLine();
            int b = int.Parse(str1);
            Console.WriteLine(a+b);*/
        }
    }
}
