# Readme for Numeric PDF File Checker

## Overview
This program is a C# console application designed to identify missing numeric PDF files in a specified folder. The application assumes that all PDF file names are purely numeric (e.g., `1.pdf`, `2.pdf`, etc.).

---

## How It Works
1. Reads the folder path from a configuration file named `dosya.txt`.
2. Identifies all PDF files in the folder whose names consist only of numbers.
3. Determines the range of files based on the smallest and largest numbers found.
4. Checks for missing file numbers within this range.
5. Outputs the missing file numbers, if any.

---

## Configuration File (`dosya.txt`)
The configuration file should contain the folder path where the PDF files are stored.

### Format
```
<folder_path>
```

### Example
```
C:\Documents\PDF_Files
```

---

## Usage
1. Ensure the program's executable is in the same folder as the `dosya.txt` file.
2. Edit the `dosya.txt` file to include the correct folder path.
3. Run the program from the command line or by double-clicking the executable.
4. The program will display the range of file numbers it found and list any missing numbers.

---

## Example Output
### Scenario 1: Missing Files Detected
- Existing files: `1.pdf`, `2.pdf`, `4.pdf`
- Output:
```
1 ve 4 arası kararlar kontrol ediliyor
Eksik kararlar:
3
```

### Scenario 2: No Missing Files
- Existing files: `1.pdf`, `2.pdf`, `3.pdf`
- Output:
```
1 ve 3 arası kararlar kontrol ediliyor
Eksik Karar bulunamadı.
```

---

## Error Handling
- If the `dosya.txt` file is missing:
  ```
  Klasör yolunu gösteren ayar dosyası bulunamadı: dosya.txt
  ```
- If the folder path in `dosya.txt` is invalid:
  ```
  Dosya yolu bulunamadı: <folder_path>
  ```
- If no valid numeric PDF files are found in the folder:
  ```
  No valid numeric PDF files found in the folder.
  ```

---

## Dependencies
- .NET Framework or .NET Core Runtime.

---

## Future Enhancements
- Add logging to save the output to a file.
- Extend functionality to handle non-numeric filenames more gracefully (e.g., skip and log them).
- Add support for multiple folder paths or configurable file extensions.


