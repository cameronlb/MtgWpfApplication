using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MtgWpfApplication.ViewModels
{
    class DeckAnalysisViewModel : ViewModelBase
    {
        private int _numofdraw;

        public int NumOfDraw
        {
            get { return _numofdraw; }

            set
            {
                _numofdraw = value;
                OnPropertyChanged(nameof(NumOfDraw));
            }
        }

        private int _numoframp;

        public int NumOfRamp 
        { 
            get { return _numoframp;  }

            set
            {
                _numoframp = value;
                OnPropertyChanged(nameof(NumOfRamp));
            }
        }

        private int _numofremoval;

        public int NumOfRemoval
        { 
            get { return _numofremoval; }

            set
            {
                _numofremoval = value;
                OnPropertyChanged(nameof(NumOfRemoval));
            }
        }

        private int _numoftutors;

        public int NumOfTutors
        {
            get { return _numoftutors; }

            set
            {
                _numoftutors = value;
                OnPropertyChanged(nameof(NumOfTutors));
            }
        }


        private int _numofcardadvantage;

        public int NumOfCardAdvantage
        {
            get { return _numofcardadvantage; }

            set
            {
                _numofcardadvantage = value;
                OnPropertyChanged(nameof(NumOfCardAdvantage));
            }
        }

        private int _numofsweepers;

        public int NumOfSweepers
        {
            get { return _numofsweepers; }

            set
            {
                _numofsweepers = value;
                OnPropertyChanged(nameof(NumOfSweepers));
            }
        }

        private int _numoflands;

        public int NumOfLands
        { 
            get { return _numoflands; }

            set
            {
                _numoflands = value;
                OnPropertyChanged(nameof(NumOfLands));
            }
        }

        public DeckAnalysisViewModel() 
        { 
        
        }
    }
}
