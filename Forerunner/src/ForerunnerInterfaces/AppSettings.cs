namespace ForerunnerInterfaces
{
    public class AppSettings
    {
        public ServerSettings Reader { get; set; }
        public ServerSettings Writer { get; set; }
    }

    public class ServerSettings
    {
        public string Uri { get; set; }
        public string Credentials { get; set; }
    }
}
