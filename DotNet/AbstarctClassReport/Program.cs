namespace AbstarctClassReport
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enetr the choice 1. PDF 2. DOCX 3. Excel 4. XML 5. JSON");
                int choice = Convert.ToInt32(Console.ReadLine());
                ReportFactory report = new ReportFactory();
                Report r2 = report.GetReport(choice);
                r2.GenerateReport();

                Console.WriteLine("Do you want to continue");
                string ch = Console.ReadLine();
                if (ch == "n")
                {
                    break;
                }
            }
        }
    }

    public abstract class Report
    {
        protected abstract void Parse();
        protected abstract void Validate();
        protected abstract void Save();
        public virtual void GenerateReport()
        {
            Parse();
            Validate();
            Save();
            Console.WriteLine("Report Generated");
        }
    }

    public abstract class SpecialReport:Report
    {
        protected abstract void ReValidate();
        public override void GenerateReport()
        {
            Parse();
            Validate();
            ReValidate();
            Save();
            Console.WriteLine("Re validate report generated");
        }
    }

    public class ReportFactory
    {
        public Report GetReport(int choice)
        {
            Report r1 = null;
            switch (choice)
            {
                case 1:
                    r1 = new PDF();
                    break;

                case 2:
                    r1 = new DOCX();
                    break;

                case 3:
                    r1 = new EXcel();
                    break;

                case 4:
                    r1 = new XML();
                    break;

                case 5:
                    r1 = new JSON();
                    break;

                default:
                    r1 = null; 
                    break;
            }
            return r1;
        }
    }

    public class PDF : Report
    {
        protected override void Parse()
        {
            Console.WriteLine("pdf parsed");
        }

        protected override void Validate()
        {
            Console.WriteLine("pdf validate");
        }

        protected override void Save()
        {
            Console.WriteLine("pdf saved");
        }
    }

    public class DOCX : Report
    {
        protected override void Parse()
        {
            Console.WriteLine("DOCX parsed");
        }

        protected override void Validate()
        {
            Console.WriteLine("DOCX validate");
        }

        protected override void Save()
        {
            Console.WriteLine("DOCX saved");
        }
    }

    public class EXcel : Report
    {
        protected override void Parse()
        {
            Console.WriteLine("EXcel parsed");
        }

        protected override void Validate()
        {
            Console.WriteLine("EXcel validate");
        }

        protected override void Save()
        {
            Console.WriteLine("EXcel saved");
        }
    }


    public class XML : SpecialReport
    {
        protected override void Parse()
        {
            Console.WriteLine("XML parsed");
        }

        protected override void Validate()
        {
            Console.WriteLine("XML validate");
        }

        protected override void Save()
        {
            Console.WriteLine("XML saved");
        }

        protected override void ReValidate()
        {
            Console.WriteLine("JSON Revalidate");
        }
    }

    public class JSON : SpecialReport
    {
        protected override void Parse()
        {
            Console.WriteLine("JSON parsed");
        }

        protected override void Validate()
        {
            Console.WriteLine("JSON validate");
        }

        protected override void Save()
        {
            Console.WriteLine("JSON saved");
        }

        protected override void ReValidate()
        {
            Console.WriteLine("JSON Revalidate");
        }

    }

}
