using MtgWpfApplication.Models;
using MtgWpfApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MtgWpfApplication.Commands
{
    public class MakeDeckCommand : CommandBase
    {
        private readonly MakeDeckViewModel _makeDeckViewModel;

        public MakeDeckCommand(ViewModels.MakeDeckViewModel makeDeckViewModel) 
        { 
            _makeDeckViewModel = makeDeckViewModel;

            //subsribing to event handler
            _makeDeckViewModel.PropertyChanged += OnViewPropertyChanged;
        }

        public override bool CanExecute(object? parameter)
        {
            return !string.IsNullOrEmpty(_makeDeckViewModel.DeckName) &&
                   !string.IsNullOrEmpty(_makeDeckViewModel.DeckList) &&
                    base.CanExecute(parameter);
        }

        public override void Execute(object? parameter)
        {
            Deck deck = new Deck(_makeDeckViewModel.DeckName, _makeDeckViewModel.DeckList);
        }

        private void OnViewPropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(MakeDeckViewModel.DeckName) ||
                e.PropertyName == nameof(MakeDeckViewModel.DeckList))
            { 
                OnCanExecutedChanged();
            }
        }
    }
}
