namespace DatabaseInterpreter;

public static class ProviderTypes
{
    public static string SQLSERVER { get; } = "System.Data.Client";
    public static string SQLCLIENT { get; } = "";
    public static string Oracle { get; } = "";
    public static string ODBC { get; } = "";
    public static string MYSQL { get; } = "";
}

public enum ProviderType
{
    SQLSERVER,
    SQLCLIENT,
    ORACLE,
    ODBC,
    MYSQL,
}