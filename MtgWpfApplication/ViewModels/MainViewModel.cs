using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MtgWpfApplication.ViewModels
{
    class MainViewModel : ViewModelBase
    {

        public ViewModelBase MakeDeckViewModel { get; }

        public ViewModelBase AnalyseDeckViewModel { get; }

        public MainViewModel() 
        {
            MakeDeckViewModel = new MakeDeckViewModel();

            AnalyseDeckViewModel = new DeckAnalysisViewModel();
        }

    }
}
