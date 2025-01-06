class ConfigManager
{
    private readonly string _configFilePath;

    public ConfigManager(string configFilePath)
    {
        _configFilePath = configFilePath;
    }

    public bool TryLoadConfig(out string folderPath)
    {
        folderPath = string.Empty;

        if (!File.Exists(_configFilePath))
        {
            Printer.PrintError($"Ayar dosyası bulunamadı: {_configFilePath}");
            Printer.PrintError("Klasör yolunu 'dosya.txt' dosyasına yazınız.");
            return false;
        }

        folderPath = File.ReadAllText(_configFilePath).Trim();
        return true;
    }
}