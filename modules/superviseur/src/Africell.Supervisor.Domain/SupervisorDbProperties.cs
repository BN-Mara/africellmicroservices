namespace Africell.Supervisor
{
    public static class SupervisorDbProperties
    {
        public static string DbTablePrefix { get; set; } = "Supervisor";

        public static string DbSchema { get; set; } = null;

        public const string ConnectionStringName = "Supervisor";
    }
}
