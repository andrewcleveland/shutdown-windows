using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace Cattv.ShutdownWindows.Tests.Utilties.WpfTest
{
    internal partial class MainWindowViewModel : ObservableObject
    {
        [ObservableProperty]
        private string message = "Shutdown Test Message";

        [ObservableProperty]
        private int delaySeconds = 10;

        [ObservableProperty]
        private bool force;

        [ObservableProperty]
        private bool restart;

        [ObservableProperty]
        private string reason = "OtherUnplanned";

        public string[] ReasonList { get; init; }

        [ObservableProperty]
        private string? status;

        [ObservableProperty]
        private ICommand shutdownCommand;

        [ObservableProperty]
        private ICommand abortCommand;

        public MainWindowViewModel()
        {
            ReasonList = GetReasons().ToArray();
            ShutdownCommand = new ShutdownCommand(this);
            AbortCommand = new AbortCommand(this);
        }

        private static IEnumerable<string> GetReasons()
        {
            return from name in Enum.GetNames<ShutdownReason>()
                where !name.StartsWith("Major") && !name.StartsWith("Minor") && !name.StartsWith("Flag")
                orderby name
                select name;
        }
    }
}
