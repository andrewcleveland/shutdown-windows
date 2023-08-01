using System;

namespace Cattv.ShutdownWindows.Tests.Utilties.WpfTest
{
    internal class ShutdownCommand : ShutdownCommandBase
    {
        public ShutdownCommand(MainWindowViewModel viewModel) : base(viewModel) { }

        public override void ExecuteBase(object? parameter)
        {
            ShutdownWindows.Shutdown(
                message: ViewModel.Message,
                delay: TimeSpan.FromSeconds(ViewModel.DelaySeconds),
                force: ViewModel.Force,
                restart: ViewModel.Restart,
                reason: Enum.Parse<ShutdownReason>(ViewModel.Reason)
                );
            ViewModel.Status = "Shutdown initiated";
        }
    }
}
