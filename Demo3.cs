namespace GradeCalculator
{
    public class Demo3
    {
        //       with validation and user interface but can bulid with a method
        public void RunThis()
        {
            Console.WriteLine("Grades of student");
        // validation of name using goto statement but not recommended to use goto statement because it can make the code hard to read and maintain and can lead to spaghetti code which is difficult to debug and understand but for the sake of demonstration we will use goto statement here but in real world scenario we should avoid using goto statement and use loops or methods instead
        getname: // go back to name from
            Console.WriteLine("Enter the student name:");
            string? name = Console.ReadLine();

            // if (name is not null && name != string.Empty)
            if (!string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Student name is " + name); 
            }
            else
            {
                Console.WriteLine("Invalid input");
                goto getname;  // will loop back to getname
            }



            // Validaton of marks for three subjects

            int sub1 = 0;
            bool isValid = false;  // Flag is used 
            while (!isValid)
            {
                Console.WriteLine("Enter marks for subjects:");
                if (int.TryParse(Console.ReadLine(), out sub1) && sub1 > -1 && sub1 < 101)// use always >-1 for from zero and <101 so that the assign operator which is efficent than <= & >=
                {
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
                }
            }

            int sub2 = 0;
            bool isValid1 = false;
            while (!isValid1)
            {
                if (int.TryParse(Console.ReadLine(), out sub2) && sub2 >= 0 && sub2 <= 100)
                {
                    isValid1 = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number between 0 and 100");
                }
            }

            int sub3 = 0;
            bool isValid2 = false;
            while (!isValid2)
            {
                if (int.TryParse(Console.ReadLine(), out sub3) && sub3 >= 0 && sub3 <= 100)
                {
                    isValid2 = true;
                }
                else
                {
                    Console.WriteLine(" Invalid input. Please enter a number between 0 and 100");
                }
            }



            // Calculate total marks and average marks with grade using if else statement
            int totalMarks = sub1 + sub2 + sub3;
            double averageMarks = totalMarks / 3.0;
            Console.WriteLine("Total Marks: " + totalMarks);
            if (averageMarks > 89 && averageMarks < 101)
            {
                Console.WriteLine("Grade of " + name + " :A");
            }
            else if (averageMarks > 79 && averageMarks < 90)
            {
                Console.WriteLine("Grade of" + name + ":B");
            }
            else if (averageMarks > 69 && averageMarks < 80)
            {
                Console.WriteLine("Grade of " + name + ":C");
            }
            else if (averageMarks > 59 && averageMarks < 70)
            {
                Console.WriteLine("Grade of " + name + ":D");
            }
            else
            {
                Console.WriteLine("Grade of " + name + ":F");

            }
        }
    }
}
