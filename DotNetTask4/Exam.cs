using System.Text;

namespace DotNetTask4
{
    public class Exam
    {
        public Exam(string subject, int studentsNumber, int duration)
        {
            Subject = subject;
            StudentsNumber = studentsNumber;
            Duration = duration;
        }

        public string Subject { private set; get; }
        public int StudentsNumber { private set; get; }
        public int Duration { private set; get; }

        public virtual double CalculteQuality()
        {
            return StudentsNumber * 1.0 / Duration;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new();
            stringBuilder.AppendLine(base.ToString());
            stringBuilder.AppendLine($"Subject: {Subject}");
            stringBuilder.AppendLine($"Students Number: {StudentsNumber}");
            stringBuilder.Append($"Duration: {Duration}");
            return stringBuilder.ToString();
        }
    }
}
