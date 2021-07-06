namespace PowerfullyPunchyPayPacketApp.Controllers
{
    using System;
    using System.IO;

    public class ReadFromTextFile
    {
        public string readFromText(string textFileLocation)
        {
            return readTextFile(textFileLocation);
        }

        private string readTextFile(string textFileLocation)
        {
            return File.ReadAllText(Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName, "apiURL.txt"));
        }
    }
}
