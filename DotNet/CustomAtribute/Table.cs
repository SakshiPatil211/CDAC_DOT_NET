namespace CustomAtribute
{
    [AttributeUsage(AttributeTargets.Class)]
    public class TableAtrribute:Attribute
    {
        private string _tableName;

        public string TableName
        {
            set { _tableName = value; }
            get { return _tableName; }
        }
    }

    [AttributeUsage (AttributeTargets.Class)]
    public class ColumnAttribute : Attribute
    {
        private string _columnName;
        private string _columnType;

        public string ColumnName
        {
            set { _columnName = value; }
            get { return _columnName; }
        }

        public string ColumnType
        {
            set { _columnType = value; }
            get { return _columnType; }
        }
    }
}
