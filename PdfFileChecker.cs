class PdfFileChecker
{
    public string FolderPath { get; }

    public PdfFileChecker(string folderPath)
    {
        FolderPath = folderPath;
    }

    public List<int> GetMissingFileNumbers()
    {
        var pdfFiles = Directory.GetFiles(FolderPath, "*.pdf")
                                .Select(file => Path.GetFileNameWithoutExtension(file))
                                .Where(name => int.TryParse(name, out _)) // Sadece sayısal isimleri alır
                                .Select(name => int.Parse(name))
                                .OrderBy(num => num)
                                .ToList();

        if (!pdfFiles.Any())
        {
            Printer.PrintError("Klasörde geçerli sayısal dosya bulunamadı.");
            return new List<int>();
        }

        int firstFile = pdfFiles.First();
        int lastFile = pdfFiles.Last();

        Console.WriteLine($"{firstFile} ve {lastFile} arası dosyalar kontrol ediliyor...");

        return Enumerable.Range(firstFile, lastFile - firstFile + 1).Except(pdfFiles).ToList();
    }
}