using FileSystemSimulation;

class Program
{
    static void Main(string[] args)
    {
        var fs = new FileSystem();

        // Creating and adding files to 'innerFolder'
        var innerFolder = new Folder("Inner Folder");
        innerFolder.Add(new FileSystemSimulation.File("InnerFile1.txt", 500));
        innerFolder.Add(new FileSystemSimulation.File("InnerFile2.txt", 600));

        // Creating 'outerFolder', adding 'innerFolder' to it
        var outerFolder = new Folder("Outer Folder");
        outerFolder.Add(innerFolder);

        // Adding 'outerFolder' to the file system
        fs.Add(outerFolder);

        // Existing code
        var saveFiles = new Folder("Save files");
        saveFiles.Add(new FileSystemSimulation.File("Save 1 - The Citadel.data", 2348));
        saveFiles.Add(new FileSystemSimulation.File("Save 2 - Artemis Tau.data", 6378));
        saveFiles.Add(new FileSystemSimulation.File("Save 3 - Serpent Nebula.data", 973));
        fs.Add(saveFiles);

        var newFolder = new Folder("'New folder' is empty!");
        fs.Add(newFolder);

        fs.Add(new FileSystemSimulation.File("AnImage.jpg", 5342));
        fs.Add(new FileSystemSimulation.File("SomeFile.txt", 832));

        // Print the contents of the file system
        fs.PrintContents();
    }
}
