namespace MtgWpfApplication.Models
{
    public class Card
    {
        public string Name { get; set; }
        private string ScryfallID;
        private string ColorIdentity;
        private string ManaCost;
        private string Type;

        public Card(string name) 
        {
            Name = name;
        }
    }
}
