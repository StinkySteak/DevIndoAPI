namespace DevIndoAPI.Models
{
    public class Rural
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string Population { get; set; }
        public string Image { get; set; }

        public Rural(string _name, string _location, string _population)
        {
            Name = _name;
            Population = _population;  
            Location = _location;
        }
    }
}
