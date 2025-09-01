namespace Weighter.Core;

public static class DbConstants
{
    public const string UserTable = "User";
    public const string WeightTable = "Weight";
    public const string UserSettingsTable = "UserSettings";

    public static string DbName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "weighter_v01.db");
}