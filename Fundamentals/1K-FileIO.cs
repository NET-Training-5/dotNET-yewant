using System.IO;

class FileIO
{
    string folderPath = @"E:\";

    public void CreateFile()
    {
        string fullFilePath = @$"{folderPath}\abc.txt";
        File.WriteAllText(fullFilePath, "This is first text file");
    }

    public void CreateDirectory()
    {
        string newFolderPath = folderPath + "\\abc";
        Directory.CreateDirectory(newFolderPath);
    }

    public void CreateDirectoriesAndFiles()
    {
        // CW - Create ten folders named Folder 1, Folder 2 and so on, inside some root folder
        
    }
}