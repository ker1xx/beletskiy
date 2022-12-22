using Newtonsoft.Json;

namespace beletskiy
{
    internal static class Class2
    {

        public static T MyDeserialize<T>(string FileName)
        {
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string json = "";
            if (File.Exists(desktop + "\\" + FileName))
                json = File.ReadAllText(desktop + "\\" + FileName);
            else
            {
                File.Create(desktop + "\\" + FileName);
                json = File.ReadAllText(desktop + "\\" + FileName);
            }
            T Human = JsonConvert.DeserializeObject<T>(json);
            return Human;
        }
        public static List<Class1> Human = MyDeserialize<List<Class1>>("Human.json");
        public static void MySerialize<T>(T humans, string FileName)
        {
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string json = JsonConvert.SerializeObject(Human);
            if (File.Exists(desktop + "\\" + FileName))
                File.WriteAllText(desktop + "\\" + FileName, json);
            else
            {
                File.Create(desktop + "\\" + FileName);
                File.WriteAllText(desktop + "\\" + FileName, json);
            }
        }
    }
}