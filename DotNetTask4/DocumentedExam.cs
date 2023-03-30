using System.Text;

namespace DotNetTask4
{
    class DocumentedExam : Exam
    {
        public DocumentedExam(string subject, int studentsNumber, int duration, double failedPercentage) : base(subject, studentsNumber, duration)
        {
            FailedPercentage= failedPercentage;
        }

        public double FailedPercentage { private set; get; }

        public override double CalculteQuality()
        {
            double baseQuality = base.CalculteQuality();
            return baseQuality * (100 - FailedPercentage) / 100;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new();
            stringBuilder.AppendLine(base.ToString());
            stringBuilder.Append($"FailedPercentage: {FailedPercentage}");
            return stringBuilder.ToString();
        }

    }
}
