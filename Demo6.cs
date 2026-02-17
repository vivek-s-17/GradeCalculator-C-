namespace GradeCalculator
{
    public class Demo6
    {

        //for multiple students and Multiple subjects with validation and user input 
        public void RunThis()
        {
            Console.WriteLine("Number of Students Marks to be calculated");
            int numberOfStudents = 0;
            bool isValid = false;
            while (!isValid)
            {
                Console.WriteLine("Enter the number of Students:");
                if (int.TryParse(Console.ReadLine(), out numberOfStudents) && numberOfStudents > -1)
                {
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("'Invalid Input': Enter a Numerical Value ");
                }
            }

            Console.WriteLine("Number of Students Marks to be calculated");
            int numberOfSubjects = 0;
            bool isValid1 = false;
            while (!isValid1)
            {
                Console.WriteLine("Enter the number of Subjects:");
                if (int.TryParse(Console.ReadLine(), out numberOfSubjects) && numberOfSubjects > -1 && numberOfSubjects < 6)
                {
                    isValid1 = true;
                }
                else
                {
                    Console.WriteLine("'Invalid Input': Enter a Numerical Value ");
                }
            }

            String[] studentName = new string[numberOfStudents]; // Array to store student names
            for (int j = 0; j < numberOfStudents; j++)
            {
                Console.Write($"Enter name of student{j + 1}:");
                string? studentname = Console.ReadLine()?.Trim();
                if (studentname is not null)
                {
                    studentName[j] = studentname.Trim(); // Store the student name in the array and remove leading/trailing whitespace
                }
                
            }


            for (int i = 0; i < numberOfStudents; i++)
            {




                double[] subjects = new double[numberOfSubjects];
                for (int j = 0; j < numberOfSubjects; j++)
                {
                    bool isvalid3 = false;
                    while (!isvalid3)
                    {
                        Console.WriteLine($"Enter the marks of student { studentName[i]} Subject{j + 1}: ");
                        if (double.TryParse(Console.ReadLine(), out subjects[j]))
                        {
                            
                            isvalid3 = true;
                        }
                        else
                        {
                            Console.WriteLine("*Invalid Input*");
                        }

                    }

                }


                double totalMarks = 0;
                for (int k = 0; k < numberOfSubjects; k++)
                {
                    totalMarks += subjects[k];
                }
                Console.WriteLine("Total Marks: " + totalMarks);

                double averageMarks = totalMarks / numberOfSubjects;

                char grade = averageMarks switch
                {
                    > 89 and < 101 => 'A',
                    > 79 and < 90 => 'B',
                    > 69 and < 80 => 'C',
                    > 59 and < 70 => 'D',
                    _ => 'F'
                };

                Console.WriteLine($"Grade of {studentName[i]} : {grade}"); 



            }


        }

    }
}
