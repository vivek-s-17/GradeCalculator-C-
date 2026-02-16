namespace GradeCalculator
{
    public class Demo5
    {
        //        ## Refactoring the code to avoid repetition and improve readability
        //        ## Using switch statement instead of if-else for grade calculation
        public void RunThis()
        {
            Console.WriteLine("Grades of student");

        getname: // go back to name from
            Console.WriteLine("Enter the student name:");
            string? name = Console.ReadLine()?.Trim(); // ask doubt tommorrow

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





            //int sub1 = 0;
            //bool isValid = false;  // Flag is used 
            //while (!isValid)
            //{
            //    Console.WriteLine("Enter marks for subjects:");
            //    if (int.TryParse(Console.ReadLine(), out sub1) && sub1 > -1 && sub1 < 101)// use always >-1 for from zero and <101 so that the assign operator which is efficent than <= & >=
            //    {
            //        isValid = true;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
            //    }
            //}

            //int sub2 = 0;
            //bool isValid1 = false;
            //while(!isValid1)
            //{
            //    if (int.TryParse(Console.ReadLine(), out sub2)&& sub2 > -1 && sub2 < 101)
            //    {
            //        isValid1 = true;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid input. Please enter a number between 0 and 100");
            //    }
            //}

            //int sub3 = 0;
            //bool isValid2 = false;
            //while(!isValid2)
            //{
            //    if (int.TryParse(Console.ReadLine(), out sub3) && sub3 > -1 && sub3 < 101)
            //    {
            //        isValid2 = true;
            //    }
            //    else
            //    {
            //        Console.WriteLine(" Invalid input. Please enter a number between 0 and 100");
            //    }
            //}


            int sub1 = SubMarks();
            int sub2 = SubMarks();
            int sub3 = SubMarks();

            int totalMarks = sub1 + sub2 + sub3;
            double averageMarks = totalMarks / 3.0;
            Console.WriteLine("Total Marks: " + totalMarks);

            //if (averageMarks > 89 && averageMarks < 101)
            //{
            //    Console.WriteLine("Grade of " + name + " :A");
            //}
            //else if (averageMarks > 79 && averageMarks < 90)
            //{
            //    Console.WriteLine("Grade of" + name + ":B");
            //}
            //else if (averageMarks > 69 && averageMarks < 80)
            //{
            //    Console.WriteLine("Grade of " + name + ":C");
            //}
            //else if (averageMarks > 59 && averageMarks < 70)
            //{
            //    Console.WriteLine("Grade of " + name + ":D");
            //}
            //else
            //{
            //    Console.WriteLine("Grade of " + name + ":F");


            //}
            //switch case for grade calculation c# 8 and above

            char grade = averageMarks switch
            {
                > 89 and < 101 => 'A',
                > 79 and < 90 => 'B',
                > 69 and < 80 => 'C',
                > 59 and < 70 => 'D',
                _ => 'F'
            };


        }

        private static int SubMarks()
        {
            int sub = 0;
            bool isValid = false; // flag is used to control the loop
            while (!isValid)
            {
                Console.WriteLine("Enter marks for subjects:");
                if (int.TryParse(Console.ReadLine(), out sub) && sub > -1 && sub < 101) // use always >-1 for from zero and <101 so that the assign operator which is efficent than <= & >=
                {
                    isValid = true; // valid input, exit loop
                    
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");

                }
            }
            return sub;     // return the valid marks   
        }
    }
}
