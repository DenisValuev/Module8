namespace Module8.Unit2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "D:\\SkillFactory\\FilesForModule8\\Student.txt"; //Путь к файлу
            //if (!File.Exists(filePath))
            //{
            //    using (StreamWriter sw = File.CreateText(filePath))
            //    {
            //        sw.WriteLine("Олег");
            //        sw.WriteLine("Дмитрий");
            //        sw.WriteLine("Иван");
            //    }
            //}
            //using (StreamReader sr = File.OpenText(filePath))
            //{
            //    string str = "";
            //    while ((str = sr.ReadLine()) != null)
            //    {
            //        Console.WriteLine(str);
            //    }
            //}
            Console.WriteLine("Исходный код программы. Задание 8.3.1");
            filePath = "D:\\SkillFactory\\Module_Practicum\\Module8\\Module8.Unit2\\Program.cs";
            var fileInfo1 = new FileInfo(filePath);
            using (StreamWriter sw = fileInfo1.AppendText())
            {
                sw.WriteLine($"//Время последнего запуска: {DateTime.Now}");
            }
            using (StreamReader sr = File.OpenText(filePath))
            {
                string str = "";
                while ((str = sr.ReadLine()) != null)
                {
                    Console.WriteLine(str);
                }
            }

            //string tempFile = Path.GetTempFileName();// Используем генерацию имени файла
            //Console.WriteLine(tempFile);
            //var fileInfo = new FileInfo(tempFile);// Создаем объект класса FileInfo
            ////Создаем файл и записываем в него
            //using (StreamWriter sw = fileInfo.CreateText())
            //{
            //    sw.WriteLine("Игорь");
            //    sw.WriteLine("Андрей");
            //    sw.WriteLine("Сергей");
            //}
            ////Открываем файл и читаем из него
            //using (StreamReader sr = fileInfo.OpenText())
            //{
            //    string str = "";
            //    while ((str = sr.ReadLine()) != null)
            //    {
            //        Console.WriteLine(str);
            //    }
            //}
            //try
            //{
            //    string tempFile2 = Path.GetTempFileName();
            //    var fileInfo2 = new FileInfo(tempFile2);
            //    fileInfo2.Delete();
            //    fileInfo.CopyTo(tempFile2);
            //    Console.WriteLine($"{tempFile} скопирован в файл {tempFile2}");
            //    fileInfo.Delete();
            //    Console.WriteLine($"Файл {tempFile} удален");
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //    throw;
            //}
        }
    }
}
//Время последнего запуска: 29.08.2024 23:16:56
//Время последнего запуска: 29.08.2024 23:17:05
//Время последнего запуска: 29.08.2024 23:17:12
