﻿using Livet;
using Livet.Commands;
using Livet.EventListeners;

namespace WpfSample
{
    public class MainWindowViewModel : ViewModel
    {
        public MainWindowMode Mode
        {
            get => _state.Mode;
            set => _state.Mode = value;
        }

        public ViewModelCommand UserScreenCommand { get; }
        public ViewModelCommand ProductScreenCommand { get; }

        private readonly MainWindowState _state;

        public MainWindowViewModel(MainWindowState state)
        {
            _state = state;

            var stateListener = new PropertyChangedEventListener(_state);
            stateListener.RegisterHandler(nameof(_state.Mode), (_, __) => RaisePropertyChanged(nameof(Mode)));
            CompositeDisposable.Add(stateListener);

            UserScreenCommand = new ViewModelCommand(() => Mode = MainWindowMode.User);
            ProductScreenCommand = new ViewModelCommand(() => Mode = MainWindowMode.Product);
        }
    }
}