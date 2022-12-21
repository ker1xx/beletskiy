using Newtonsoft.Json;

namespace beletskiy
{
    internal static class Class2
    {

        public static T MyDeserialize<T>(this string FileName)
        {
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string json = File.ReadAllText(desktop + "\\" + FileName);
            T Human = JsonConvert.DeserializeObject<T>(json);
            return Human;
        }
        public static List<Class1> Human = MyDeserialize<List<Class1>>("Human.json");
        public static void MySerialize<T>(T humans, string FileName)
        {
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string json = JsonConvert.SerializeObject(Human);
            File.WriteAllText(desktop + "\\" + FileName, json);
        }
    }
}