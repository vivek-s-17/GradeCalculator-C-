namespace GradeCalculator
{
    public class Demo2
    {
        public void RunThis()
        {
            // without any validation and with user input
            Console.WriteLine("Grades of student");
            Console.WriteLine("Enter the studen Name:");
            string? Name = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter marks for subject 1:");
            int sub1 = Convert.ToInt32(Console.ReadLine());
            int sub2 =Convert.ToInt32(Console.ReadLine());
            int sub3= Convert.ToInt32(Console.ReadLine());

            int totalMarks = sub1 + sub2 + sub3;    
            double averageMarks = totalMarks / 3.0;
            Console.WriteLine("Total Marks: " + totalMarks);

            if (averageMarks >= 90 && averageMarks <= 100)
            {
                Console.WriteLine("Grade of " + Name + " :A");
            }
            else if (averageMarks >= 80 && averageMarks <= 89)
            {
                Console.WriteLine("Grade of" + Name + ":B");
            }
            else if (averageMarks >= 70 && averageMarks <= 79)
            {
                Console.WriteLine("Grade of "+ Name +":C");
            }
            else if (averageMarks >= 60 && averageMarks <= 69)
            {
                Console.WriteLine("Grade of "+Name+ ":D");
            }
            else
            {
                Console.WriteLine("Grade of "+ Name +":F");


            }
        }
    }
}
