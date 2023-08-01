using System;
using System.Windows;
using System.Windows.Input;

namespace Cattv.ShutdownWindows.Tests.Utilties.WpfTest
{
    internal abstract class ShutdownCommandBase : ICommand
    {
        protected MainWindowViewModel ViewModel;

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter) => true;

        protected ShutdownCommandBase(MainWindowViewModel viewModel)
        {
            ViewModel = viewModel ?? throw new ArgumentNullException(nameof(viewModel));
        }

        public void Execute(object? parameter)
        {
            try
            {
                ExecuteBase(parameter);
            }
            catch (ShutdownException ex)
            {
                MessageBox.Show(ex.Message, "WpfTest", MessageBoxButton.OK, MessageBoxImage.Error);
                ViewModel.Status = "Failed";
            }
        }

        public abstract void ExecuteBase(object? parameter);
    }
}
