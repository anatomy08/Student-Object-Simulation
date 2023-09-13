
using Lesson_17_Challenge;



    class program
    {
        static void Main(string[] args)
        {

            Students[] students = new Students[3]; // declared array of 3 students

            int Student_Number = 0;
            for (int i = 0; i < students.Length; i++) // for loop
            {
                
                Console.Write("Enter the first name: ");
                string firstName = Console.ReadLine();

                Console.Write("Enter the last name : ");
                string lastName = Console.ReadLine();

                Console.Write("Enter the Course    : ");
                string course = Console.ReadLine();

                Console.Write("Enter the Section    : ");
                string section = Console.ReadLine();

                Console.Write("Enter the Year      : ");
                string year = Console.ReadLine();

                Console.WriteLine();

                Console.Write("Enter Midterm Grade: ");
                float midtermGrade = Convert.ToSingle(Console.ReadLine());

                Console.Write("Enter Final Grade: ");
                float finalGrade = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine();
                Student_Number++;

                float average = (midtermGrade + finalGrade) / 2f;

                if (average >= 100)
                {
                    Console.WriteLine("Invalid Grade");
                }
                else if (average >= 98 && average <= 100)
                {
                    Console.WriteLine("With Highestt Honor");
                }
                else if (average >= 95 && average <= 97.99)
                {
                    Console.WriteLine("With High Honor");
                }
                else if (average >= 90 && average <= 94.99)
                {
                    Console.WriteLine("With Honors");
                }
                else if (average >= 75 && average <= 89.99)
                {
                    Console.WriteLine("Passed");
                }
                else
                {
                    Console.WriteLine("Failed");
                }

                Students s = new Students(firstName, lastName, course, section, year, midtermGrade, finalGrade);

                
                Console.WriteLine("Student " + Student_Number +" information : ");
                Console.WriteLine("Name of Student     : " + s.firstName + " " + s.lastName);
                Console.WriteLine("Course              : " + s.course);
                Console.WriteLine("Section              : " + s.section);
                Console.WriteLine("Year                : " + s.year);
                Console.WriteLine("Average             : " + average);


                Console.WriteLine();

            }
        }
    }


namespace Lesson_17_Challenge
{
    public class Students
    {
        public string firstName, lastName, course, section, year;
        public float midtermGrade, finalGrade;

        public Students(string firstName, string lastName, string course, string section, string year, float midtermGrade, float finalGrade)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.course = course;
            this.section = section;
            this.year = year;
            this.midtermGrade = midtermGrade;
            this.finalGrade = finalGrade;
        }

    }
}