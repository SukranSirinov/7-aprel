using Newtonsoft.Json;
using System;
using System.IO;

namespace _04072022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library()
            {
                Name = "ShukranShirinov",
                Id = 703,
            };
            string path = @"C:\Users\HP\source\repos\04072022\04072022\";
            Directory.CreateDirectory(path+"Files");

            if (!File.Exists(path + @"Files\database.json"))
            {
                File.Create(path + @"Files\database.json");
            }

            string choise=Console.ReadLine();
            bool check = true;

            switch (choise)
            {
                case "0":
                    check = false;
                    break;
                case"1":

                    Book book = new Book()
                    {
                        Id = 32,
                        Name = "Cinayet ve ceza",
                        Price = 20,
                        AuthorName = "Dostoyevski"
                    };
                    library.AddBook(book);
                    var json=JsonConvert.SerializeObject(library);
                    using(StreamWriter sw = new StreamWriter(path + @"Files\database.json"))
                    {
                        sw.Write(json);
                    }
                    break;
                    case"2":

                    int id = int.Parse(Console.ReadLine());
                    using(StreamReader sw = new StreamReader(path + @"Files\database.json"))
                    {
                        var content = sw.ReadToEnd();
                        var jsonDecode=JsonConvert.DeserializeObject<Library>(content);
                        jsonDecode.GetBookById(id).ShowInfo();
                    }
                    break;
                    case"3":
                    int newId = int.Parse(Console.ReadLine());
                    string newLibrary = null;
                    using(StreamReader sw=new StreamReader(path + @"Files\database.json"))
                    {
                        var content = sw.ReadToEnd();
                        var jsonDecode = JsonConvert.DeserializeObject<Library>(content);
                        jsonDecode.RemoveBook(newId);
                        var jsonEncode=JsonConvert.SerializeObject(jsonDecode);
                        newLibrary = jsonEncode;

                    }
                    using(StreamWriter sw=new StreamWriter(path + @"Files\database.json"))
                    {
                        sw.WriteLine(newLibrary);
                    }


                    break;
                    
                       
                    
                default:
                    break;
            }
        }
    }
}
