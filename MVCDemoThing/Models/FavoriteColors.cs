namespace MVCDemoThing.Models
{
    public class FavoriteColors
    {
        // we need an id primary key
        public int Id { get; set; }
        public string FavColor { get; set; }
        public string SecondFavColor { get; set; }

        public FavoriteColors() { }

        public FavoriteColors(string color1, string color2)
        {
            FavColor = color1;
            SecondFavColor = color2;
        }
    }
}
