namespace GradeCalculator
{
    public class Demo1
    {
        public void RunThis()
        {
            // whitout any validation and user input
            Console.WriteLine("GARDES of Alice");
            int sub1 = 85;
            int sub2 = 90;
            int sub3 = 78;
            int totalMarks = sub1 + sub2 + sub3;
            double averageMarks = totalMarks / 3.0;
            Console.WriteLine("Total Marks: " + totalMarks);

            if (averageMarks >= 90 && averageMarks <= 100)
            {
                Console.WriteLine("Grade of Alice:A");
            }
            else if (averageMarks >= 80 && averageMarks <= 89)
            {
                Console.WriteLine("Grade of Alice:B");
            }
            else if (averageMarks >= 70 && averageMarks <= 79)
            {
                Console.WriteLine("Grade of Alice:C");
            }
            else if (averageMarks >= 60 && averageMarks <= 69)
            {
                Console.WriteLine("Grade of Alice:D");
            }
            else
            {
                Console.WriteLine("Grade of Alice:F");


            }
        }
    }
}
