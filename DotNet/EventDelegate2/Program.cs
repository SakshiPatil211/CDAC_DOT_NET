namespace EventDelegate2
{
    internal class Program
    {
        public delegate void MyHandler(int mrk);

        static void Main()
        {
            Student student = new Student();

            MyHandler passHandler = student.student_Pass;
            MyHandler failHandler = student.student_Fail;

            Console.WriteLine("Enter marks:");
            int marks = Convert.ToInt32(Console.ReadLine());

            if (marks > 40)
                passHandler(marks);
            else
                failHandler(marks);
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
