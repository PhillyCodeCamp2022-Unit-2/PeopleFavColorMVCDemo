using System.ComponentModel.DataAnnotations;

namespace MVCDemoThing.ViewModels
{
    public class AddFavColorsViewModel
    {
        [Required(ErrorMessage = "This field is required")]
        public string FavColor { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string SecondFavColor { get; set; }
    }
}
