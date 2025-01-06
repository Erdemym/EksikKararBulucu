using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Program
    {
        static void Main(string[] args)
        {
            Printer.WriteProgramName();

            ConfigManager configManager = new ConfigManager("dosya.txt");
            if (!configManager.TryLoadConfig(out string folderPath))
            {
                return;
            }

            if (!Directory.Exists(folderPath))
            {
                Printer.PrintError($"Dosya yolu bulunamadı: {folderPath}");
                return;
            }

            PdfFileChecker fileChecker = new PdfFileChecker(folderPath);
            List<int> missingFiles = fileChecker.GetMissingFileNumbers();

            if (missingFiles.Any())
            {
                Printer.PrintMissingFiles(missingFiles);
            }
            else
            {
                Printer.PrintNoMissingFiles();
            }

            Printer.ProgramEndMessage();
        }
    }