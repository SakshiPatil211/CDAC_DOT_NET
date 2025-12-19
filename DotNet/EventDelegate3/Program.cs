namespace EventDelegate2
{
    internal class Program
    {
        public delegate void MyHandler(int mrk);

        static void Main()
        {
            Student student = new Student();

            student.Pass += student.student_Pass;
            student.Fail += student.student_Fail;

            Console.WriteLine("Enter marks:");
            int marks = Convert.ToInt32(Console.ReadLine());

            student.TriggerEvents(marks);
        }
    }

    class Student
    {
        public event Program.MyHandler Pass;
        public event Program.MyHandler Fail;

        public void TriggerEvents(int marks)
        {
            if (marks > 40)
                Pass.Invoke(marks);
            else
                Fail.Invoke(marks);
        }

        public void student_Pass(int marks)
        {
            Console.WriteLine($"Congratulations! Passed with {marks} marks");
        }

        public void student_Fail(int marks)
        {
            Console.WriteLine($"Sorry! Failed with {marks} marks");
        }
    }
}
