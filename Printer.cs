static class Printer
{
    private static readonly int asteriskCount = 100;

        
    public static void WriteProgramName()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        WriteAsteriskLine();
        WriteAsteriskLineWithText(" Eksik Karar Bulucu V 1.0 ");
        WriteAsteriskLine();
        WriteAsteriskLineWithText(" Coded by Erdem YILMAZ © 2024 ");
        WriteAsteriskLine();
        Console.ForegroundColor = ConsoleColor.White;
    }

    public static void WriteAsteriskLine()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        string asteriskLine = new string('*', asteriskCount);
        Console.WriteLine(asteriskLine);
    }

    public static void WriteAsteriskLineWithText(string text)
    {
        //only one line calculate text length and write text between asterisks
        Console.ForegroundColor = ConsoleColor.Green;
        int textLength = text.Length;
        int calculatedAsteriskCount = asteriskCount / 2 - textLength / 2;
        string asteriskLine = new string('*', calculatedAsteriskCount);
        Console.Write(asteriskLine);
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(text);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(asteriskLine);
        Console.ForegroundColor = ConsoleColor.White;
    }

    public static void PrintError(string message)
    {
        Console.WriteLine($"Hata: {message}");
    }

    public static void PrintMissingFiles(List<int> missingFiles)
    {
        Console.WriteLine("Eksik Dosyalar:");
        foreach (int missingFile in missingFiles)
        {
            Console.WriteLine(missingFile);
        }
    }

    public static void PrintNoMissingFiles()
    {
        Console.WriteLine("Eksik dosya bulunamadı.");
    }

    public static void ProgramEndMessage(){
        Console.WriteLine("Kontrol Tamamlandı.");
        Console.WriteLine("Çıkmak için bir tuşa basınız.");
        Console.Read();
    }
}