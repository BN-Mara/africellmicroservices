namespace Africell.Warehouses
{
    public static class WarehousesDbProperties
    {
        public static string DbTablePrefix { get; set; } = "Warehouses";

        public static string DbSchema { get; set; } = null;

        public const string ConnectionStringName = "Warehouses";
    }
}
