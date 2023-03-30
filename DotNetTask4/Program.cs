namespace DotNetTask4
{
    class Program
    {
        static void Main()
        {
            List<Exam> examList = new();
            ShowHelp();
            while (true)
            {
                string actionString = Console.ReadLine();
                switch (actionString)
                {
                    case "0":
                        return;
                    case "1":
                    case "2":
                        Console.WriteLine("Enter Subject");
                        string subject = Console.ReadLine();
                        Console.WriteLine("Enter Students Number");
                        int studentsNumber = ReadIntFromIO();
                        if (studentsNumber < 1)
                        {
                            Console.WriteLine("Invalid Students Number");
                            break;
                        }
                        Console.WriteLine("Enter Duration");
                        int duration = ReadIntFromIO();
                        if (duration < 1)
                        {
                            Console.WriteLine("Invalid Duration");
                            break;
                        }
                        if (actionString == "1")
                        {
                            Exam exam = new(subject, studentsNumber, duration);
                            examList.Add(exam);
                        }
                        else
                        {
                            Console.WriteLine("Enter Failed Percentage");
                            double failedPercentage = ReadDoubleFromIO();
                            if (failedPercentage < 0 || failedPercentage > 100)
                            {
                                Console.WriteLine("Invalid Failed Percentage");
                                break;
                            }
                            DocumentedExam exam = new(subject, studentsNumber, duration, failedPercentage);
                            examList.Add(exam);
                        }
                        Console.WriteLine("Added");
                        break;
                    case "3":
                        foreach (var exam in examList)
                        {
                            Console.WriteLine("-------------");
                            Console.WriteLine(exam);
                            Console.WriteLine("-------------");
                        }
                        break;
                    case "4":
                    case "5":
                        Console.WriteLine("Enter exam index");
                        int index = ReadIntFromIO();
                        if (index < 0 || index > examList.Count - 1)
                        {
                            Console.WriteLine("Invalid index");
                            break;
                        }
                        if (actionString == "4")
                        {
                            examList.RemoveAt(index);
                            Console.WriteLine("Removed");
                        }
                        else
                        {
                            double quality = examList[index].CalculteQuality();
                            Console.WriteLine("Quality: {0:0.0#}", quality);
                        }
                        break;
                    default:
                        ShowHelp();
                        break;
                }

            }
        }

        static void ShowHelp()
        {
            Console.WriteLine("0 - Exit");
            Console.WriteLine("1 - Add new ordinary exam");
            Console.WriteLine("2 - Add new documented exam");
            Console.WriteLine("3 - Print all exams");
            Console.WriteLine("4 - Remove exam");
            Console.WriteLine("5 - Calculate exam quality");
        }

        static int ReadIntFromIO()
        {
            try
            {
                return int.Parse(Console.ReadLine());
            }
            catch (Exception e) when (e is ArgumentNullException || e is FormatException || e is OverflowException)
            {
                return -1;
            }
        }

        static double ReadDoubleFromIO()
        {
            try
            {
                return double.Parse(Console.ReadLine());
            }
            catch (Exception e) when (e is ArgumentNullException || e is FormatException || e is OverflowException)
            {
                return -1;
            }
        }
    }
}