namespace Cattv.ShutdownWindows.Tests.Utilties.WpfTest
{
    internal class AbortCommand : ShutdownCommandBase
    {
        public AbortCommand(MainWindowViewModel viewModel) : base(viewModel) { }

        public override void ExecuteBase(object? parameter)
        {
            ShutdownWindows.Abort();
            ViewModel.Status = "Shutdown aborted";
        }
    }
}
