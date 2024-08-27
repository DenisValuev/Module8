namespace Module8.Unit0
{
    public class Drive
    {
        public string Name { get;}
        public long TotalSpace { get;}
        public long FreeSpace { get;}
        public Drive(string name, long totalSpace, long freeSpace)
        {
            Name = name;
            TotalSpace = totalSpace;
            FreeSpace = freeSpace;
        }
    }
    public class Folder
    {
        public List<string> Files { get; set; } = new List<string>();
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Folder> Folders = new Dictionary<string, Folder>();
        }
    }
}
