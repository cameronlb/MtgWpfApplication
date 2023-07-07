using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MtgWpfApplication.ViewModels
{
    class MakeDeckViewModel : ViewModelBase
    {
        private string _decklist;

        public string DeckList 
        {
            get { return _decklist; }

            set
            { 
                _decklist = value;
                OnPropertyChanged(nameof(DeckList));
            }
        }

        private string _deckname;

        public string DeckName
        { 
            get { return _deckname; }

            set
            {
                _deckname = value;
                OnPropertyChanged(nameof(DeckName));
            }
        }

        public ICommand AnalyzeCommand { get; }

        public MakeDeckViewModel() 
        { 
        
        }
    }
}
