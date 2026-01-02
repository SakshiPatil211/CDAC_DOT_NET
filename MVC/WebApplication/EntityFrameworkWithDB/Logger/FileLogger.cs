namespace EntityFrameworkWithDB.Logger
{
    public class FileLogger
    {
        private static FileLogger _logger = new FileLogger();

        private FileLogger() { }
        
        public static FileLogger CurrentLogger
        {
            get { return _logger; }
        }

        public void Log(string message)
        {
            string path = @"C:\Users\IET\Desktop\250845920071\CDAC_DOT_NET\MVC\WebApplication\EntityFrameworkWithDB\Data\log.txt";

            FileStream fs = null;

            if (File.Exists(path))
            {
                fs = new FileStream(path, FileMode.Append, FileAccess.Write);
            }
            else
            {
                fs = new FileStream(path,FileMode.Create,FileAccess.Write);
            }

            StreamWriter writer = new StreamWriter(fs);
            writer.WriteLine($"Logger at -----> {DateTime.Now.ToString()} - {message}");

            writer.Close();
            fs.Close();
        }
    }
}
