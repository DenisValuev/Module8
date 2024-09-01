using Module8.Unit3.Models;
using System.Text.Json;

namespace Module8.Unit3
{
    internal class Program
    {
        const string SettingsFileName = "Settings.cfg";
        static void WriteValues()
        {
            //Создаем объект BinaryWriter и указываем, куда будет направлен поток данный
            using (BinaryWriter writer = new BinaryWriter(File.Open(SettingsFileName, FileMode.Create)))
            {
                writer.Write(20.666F);
                writer.Write("Текстовая строка");
                writer.Write(55);
                writer.Write(false);
            }
        }
        static void ReadValues()
        {
            float FloatValue;
            string StringValue;
            int IntValue;
            bool BoolValue;

            if (File.Exists(SettingsFileName))
            {
                //Создаем объект BinaryReader и инициализируем его возвратом метода File.Open
                using (BinaryReader reader = new BinaryReader(File.Open(SettingsFileName, FileMode.Open)))
                {
                    //Применяем специализированные методы Read для считывания соответствующего типа данных
                    FloatValue = reader.ReadSingle();
                    StringValue = reader.ReadString();
                    IntValue = reader.ReadInt32();
                    BoolValue = reader.ReadBoolean();
                }
                Console.WriteLine("Из файла считано:");
                Console.WriteLine("Дробь: " + FloatValue);
                Console.WriteLine("Строка: " + StringValue);
                Console.WriteLine("Целое число: " + IntValue);
                Console.WriteLine("Булево значение: " + BoolValue);
            }
        }
        static void ReadBinaryFile(string path)
        {
            string StringValue;
            if (File.Exists(path))
            {
                using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
                { 
                    StringValue = reader.ReadString();
                }
                Console.WriteLine(StringValue);
            }
        }
        static void WriteBinaryFile(string path)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create)))
            {
                writer.Write($"Файл изменен {DateTime.Now} на компьютере {Environment.OSVersion}");
            }
        }
        static void Main(string[] args)
        {
            //Пишем
            //WriteValues();
            //Считываем
            //ReadValues();
            string BinaryFilePath = "D:\\SkillFactory\\FilesForModule8\\BinaryFile.bin";
            //Task 8.4.2
            //WriteBinaryFile(BinaryFilePath);
            //Task 8.4.1
            //ReadBinaryFile(BinaryFilePath);
            //Объект для сериализации
            var person = new Pet("Rex", 2);
            Console.WriteLine("Объект создан");
            //Сериализация
            var options = new JsonSerializerOptions { WriteIndented = true };
            var jsonString = JsonSerializer.Serialize(person, options);
            File.WriteAllText("myPets.json", jsonString);
            Console.WriteLine("Объект сериализован");
            //Десериализация
            jsonString = File.ReadAllText("myPets.json");
            var newPet = JsonSerializer.Deserialize<Pet>(jsonString);
            Console.WriteLine("Объект десериализован");
            Console.WriteLine($"Имя: {newPet.Name} --- Возраст: {newPet.Age}");

            //Task 8.4.3
            var contact = new Contact("Denis", 89281138992, "dv@mail.ru");
            Console.WriteLine("Объект создан");
            options = new JsonSerializerOptions { WriteIndented = true };
            jsonString = JsonSerializer.Serialize(contact, options);
            File.WriteAllText("myContact.json", jsonString);
            Console.WriteLine("Объект сериализован");
            jsonString = File.ReadAllText("myContact.json");
            var newContact = JsonSerializer.Deserialize<Contact>(jsonString);
            Console.WriteLine("Объект десериализован");
            Console.WriteLine($"Имя: {newContact.Name} --- Телефонный номер: {newContact.PhoneNumber} --- EMail: {newContact.Email}");
        }
    }
}
