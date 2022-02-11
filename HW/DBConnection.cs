namespace HW
{
    /// <summary>
    /// Class for carrying database connection 
    /// </summary>
    public class DBConnection
    {
        public string DBServer { get; set; }
        public string DBName { get; set; }
        public string DBUser { get; set; }
        public string DBPass { get; set; }
        public bool IntegratedSecurity { get; set; }
    }
}
