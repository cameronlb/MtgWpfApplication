using System.Collections.Generic;
using System.Windows.Documents;

namespace MtgWpfApplication.Models
{
    public class Deck
    {
        public string Name { get; set; }
        public List<string> DeckList { get; set; }

        public string strDeckList { get; set; }
        public List<Card> Cards { get; set; } = new List<Card>();

        public Deck(string name, string decklist)
        {
            Name = name;
            strDeckList = decklist;
        }
        /// <summary>
        /// Add a card to the collection of cards.
        /// </summary>
        /// <param name="card">Card object storing information to that card.</param>
        public void AddCard(Card card) 
        {
            Cards.Add(card);
        }
        /// <summary>
        /// Remove a card from the collection of cards.
        /// </summary>
        /// <param name="card"></param>
        public void RemoveCard(Card card) 
        { 
            Cards.Remove(card);
        }
        /// <summary>
        /// Add a card name to the list of card names.
        /// </summary>
        /// <param name="cardname">Name of magic the gathering card.</param>
        public void AddCardNameToList(string cardname) 
        {
            DeckList.Add(cardname);
        }
        /// <summary>
        /// Remove a card name from the list of card names.
        /// </summary>
        /// <param name="cardname">Name of magic the gathering card.</param>
        public void RemoveCardNameFromList(string cardname) 
        {
            DeckList.Remove(cardname);
        }

    }


}
