namespace EventDelegate1
{
    class Program
    {
        static void Main()
        {
            Student student = new Student();

            Console.WriteLine("Enter marks:");
            int mrk = Convert.ToInt32(Console.ReadLine());

            if (mrk > 40)
            {
                student.student_Pass(mrk);
            }
            else
            {
                student.student_Fail(mrk);
            }
        }
    }

    class Student
    {
        public void student_Pass(int marks)
        {
            Console.WriteLine($"Passed with {marks} marks");
        }

        public void student_Fail(int marks)
        {
            Console.WriteLine($"Failed with {marks} marks");
        }
    }

}