namespace MVCDemoThing.Models
{
    public class Person
    {
        // this Id property will be used as the primary key for the People table
        public int Id { get; set; }
        // name, color1, color2
        public string Name { get; set; }
        // how do we establish a relationship between Person and FavoriteColors?
        // We have create a FavoriteColors property and a FavoriteColorsId property
        public int FavoriteColorsId { get; set; }
        public FavoriteColors FavoriteColors { get; set; }

        public Person() { }

        public Person(string name, FavoriteColors favColors)
        {
            Name = name;
            FavoriteColors = favColors;
        }
    }
}
