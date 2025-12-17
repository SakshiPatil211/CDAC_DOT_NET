namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter Your Database choice: 1.SqlServer 2.MysqlServer 3.OracleServer");
                int dbchoice = Convert.ToInt32(Console.ReadLine());

                DatabseFactory factory = new DatabseFactory();
                Database dbObject = factory.GetDatabase(dbchoice);
                Console.WriteLine("Enter db operation choice : 1. Insert, 2. Update, 3. Delete");
                int opchoice = Convert.ToInt32(Console.ReadLine());
                switch (opchoice)
                {
                    case 1:
                        dbObject.Insert();
                        break;
                    case 2:
                        dbObject.Update();
                        break;
                    case 3:
                        dbObject.Delete();
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }

                Console.WriteLine("Do you want to continue? y/n");
                string ynChoice = Console.ReadLine();
                if (ynChoice == "n")
                {
                    break;
                }
            }
        }
    }

    public abstract class Database
    {
        public Logger _logger = null;
        public Database()
        {
            _logger = Logger.GetLogger();
        }

        protected abstract void DoInsert();
        protected abstract void DoUpdate();
        protected abstract void DoDelete();
        protected abstract string GetDatabaseName();

        public void Insert()
        {
            DoInsert();
            _logger.Log($"Insert from {GetDatabaseName()} done.");
        }

        public void Update()
        {
            DoUpdate();
            _logger.Log($"Update from {GetDatabaseName()} done.");
        }

        public void Delete()
        {
            DoDelete();
            _logger.Log($"Delete from {GetDatabaseName()} done.");
        }
    }

    public class SqlServer : Database
    {
        protected override string GetDatabaseName()
        {
            return "SQLServer";
        }

        protected override void DoInsert()
        {
            Console.WriteLine("Record Inserted in Sql Successfully");
        }
        protected override void DoUpdate()
        {
            Console.WriteLine("Record Updated in Sql Server Successfully");
        }
        protected override void DoDelete()
        {
            Console.WriteLine("Record Deleted from Sql Server Successfully");
        }
    }
    public class MysqlServer : Database
    {
        protected override string GetDatabaseName()
        {
            return "MySQLServer";
        }

        protected override void DoInsert()
        {
            Console.WriteLine("Record Inserted in MySql Successfully");
        }
        protected override void DoUpdate()
        {
            Console.WriteLine("Record Updated in MySql Server Successfully");
        }
        protected override void DoDelete()
        {
            Console.WriteLine("Record Deleted from MySql Server Successfully");
        }
    }

    public class OracleServer : Database
    {
        protected override string GetDatabaseName()
        {
            return "OracleServer";
        }

        protected override void DoInsert()
        {
            Console.WriteLine("Record Inserted in Oracle Server Successfully");
        }
        protected override void DoUpdate()
        {
            Console.WriteLine("Record Updated in Oracle Server Successfully");
        }
        protected override void DoDelete()
        {
            Console.WriteLine("Record Deleted from Oracle Server Successfully");
        }
    }
    public class DatabseFactory
    {
        public Database GetDatabase(int choice)
        {
            Database db = null;
            switch (choice)
            {
                case 1:
                    db = new SqlServer();
                    break;

                case 2:
                    db = new MysqlServer();
                    break;

                case 3:
                    db = new OracleServer();
                    break;
                default:
                    db = null;
                    break;
            }
            return db;
        }

    }

    public class Logger
    {
        private static readonly Logger _logger = new Logger();

        public Logger()
        {
            Console.WriteLine("Logger object is created first time");
        }

        public static Logger GetLogger()
        {
            return  _logger;
        }

        public void Log(string message)
        {
            Console.WriteLine($"Loggedt at {DateTime.Now.ToString()} , message: {message}");
        }
    } 
}
