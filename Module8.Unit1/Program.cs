namespace Module8.Unit1
{
    internal class Program
    {
        static void GetCatalogs()
        {
            string dirName = @"D:\\Films"; //прописываем путь к корневой директории
            if (Directory.Exists(dirName))//проверим. что директория существует
            {
                Console.WriteLine("Папки:");
                string[] dirs = Directory.GetDirectories(dirName);//получив все директории корневого каталога
                foreach (string d in dirs)//выведем их все
                {
                    Console.WriteLine(d);
                }
                Console.WriteLine();
                Console.WriteLine("Файлы: ");
                string[] files = Directory.GetFiles(dirName);//получим все файлы корневого каталога
                foreach (var s in files)
                {
                    Console.WriteLine(s);
                }
            }
        }
        static void CountObjects(string dir)
        {
            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo(dir);
                if (dirInfo.Exists)
                {
                    Console.WriteLine("Количество объектов в каталоге {0} равно: {1}", dir, dirInfo.GetDirectories().Length + dirInfo.GetFiles().Length);
                }

                DirectoryInfo newDirectory = new DirectoryInfo(dir + "/newDirectory");
                if (!newDirectory.Exists)
                    newDirectory.Create(); //Добавление каталога
                Console.WriteLine("Количество объектов в каталоге {0} равно: {1}", dir, dirInfo.GetDirectories().Length + dirInfo.GetFiles().Length);

                newDirectory.Delete(true);//Удаление каталога с содержимым
                
                Console.WriteLine("Количество объектов в каталоге {0} равно: {1}", dir, dirInfo.GetDirectories().Length + dirInfo.GetFiles().Length);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            
        }
        static void DeleteDirectory()
        {
            string dir = "C:\\Users\\Denis\\Desktop\\";
            DirectoryInfo dirInfo = new DirectoryInfo(dir + "/testFolder");
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
                Console.WriteLine("Каталог testFolder создан");
            }
                
            string trashPath = "C:\\Users\\Denis\\Desktop\\Trash";
            if (dirInfo.Exists && Directory.Exists(trashPath))
            {
                dirInfo.MoveTo(trashPath + "/testFolder");
                Console.WriteLine("Каталог testFolder перенесен в каталог Trash");
            }

        }
        static void Main(string[] args)
        {
            //DriveInfo[] drives = DriveInfo.GetDrives(); //Получим системные диски
            //foreach (DriveInfo drive in drives)
            //{
            //    Console.WriteLine($"Название: {drive.Name}");
            //    Console.WriteLine($"Тип: {drive.DriveType}");
            //    if (drive.IsReady)
            //    {
            //        Console.WriteLine($"Объем: {drive.TotalSize}");
            //        Console.WriteLine($"Свободно: {drive.TotalFreeSpace}");
            //        Console.WriteLine($"Метка: {drive.VolumeLabel}");
            //    }
            //}
            //GetCatalogs();
            //CountObjects("D:\\Films");
            DeleteDirectory();
        }
    }
}
