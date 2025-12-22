namespace BVSAttribute
{
    [AttributeUsage(AttributeTargets.Class)]
    public class BVS:Attribute
    {
        private string _company_name;
        private string _developer_name;

        public string CompanyName
        {
            set {  _company_name = value; }
            get { return _company_name; }
        }

        public string DeveloperName
        {
            set { _developer_name = value; }
            get { return _developer_name; }
        }
    }
}
