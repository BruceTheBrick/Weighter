namespace Weighter.Core.Constants
{
    public static class DbConstants
    {
        public static string DbName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "weighter_v01.db");

        public const string UserTable = "User";
        public const string WeightTable = "Weight";
        public const string UserSettingsTable = "UserSettings";
    }
}