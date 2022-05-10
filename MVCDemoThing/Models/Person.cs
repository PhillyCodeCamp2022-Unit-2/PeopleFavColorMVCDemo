namespace MVCDemoThing.Models
{
    public class Person
    {
        // name, color1, color2
        public string Name { get; set; }
        public string Color1 { get; set; }
        public string Color2 { get; set; }

        public Person() { }

        public Person(string name, string color1, string color2)
        {
            Name = name;
            Color1 = color1;
            Color2 = color2;
        }
    }
}
