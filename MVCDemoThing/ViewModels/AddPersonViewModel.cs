using System.ComponentModel.DataAnnotations;

namespace MVCDemoThing.ViewModels
{
    public class AddPersonViewModel
    {
        // We want Name and Color1 to be required fields, but Color2 is optional

        [Required(ErrorMessage = "You didn't put in a name, silly!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "You need to provide at least one favorite color!")]
        public string Color1 { get; set; }

        public string Color2 { get; set; }
    }
}
