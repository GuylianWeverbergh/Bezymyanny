using Bezymyanny.WPF.App.Languages;
using Microsoft.Extensions.Logging;
using System;
using System.ComponentModel;
using System.Windows;
using System.Collections.ObjectModel;
using Bezymyanny.Db;

namespace Generic.Host.WPF.App
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ILogger<MainWindow>? _logger;
        private readonly TestWindow? _testWindow;
        private readonly BezymyannyDb _repository;

        // We gebruiken DI om het logger singleton te bekomen: parameter van constructor
        public MainWindow(ILogger<MainWindow>? logger, TestWindow testWindow, BezymyannyDb repository) // DI vult singleton invullen, automatisch
        {
            InitializeComponent();

            _logger = logger;
            _testWindow = testWindow;
            _repository = repository;

            var results = _repository.Tankkaart.Query.All();
        }

        /// <summary>
        /// Toegevoegd om te kunnen de applicatie stoppen met het kruisje van MainWindow
        /// </summary>
        /// <param name="e"></param>
        protected override void OnClosing(CancelEventArgs e)
        {
            Application.Current.Shutdown();  // ik neem huidige WPF app en ik vraag deze om te stoppen
            //e.Cancel = true;
        }

        private void OkBtn_Click(object sender, RoutedEventArgs e)
        {
            _testWindow?.Show();
        }

        private void ExitClick(object sender, RoutedEventArgs e)
        {
            //System.Environment.Exit(0); // we stoppen niet proper op deze manier voor Generic Host
            Application.Current.Shutdown(); // ik neem huidige WPF app en ik vraag deze om te stoppen
        }

        private void NewClick(object sender, RoutedEventArgs e)
        {
            var info = GC.GetGCMemoryInfo();
            System.Diagnostics.Debug.WriteLine(Translations.HeapSizeTag + info.HeapSizeBytes);
            var totalMemoryBeforeCleanup = GC.GetTotalMemory(false);
            System.Diagnostics.Debug.WriteLine("Total memory before cleanup: " + totalMemoryBeforeCleanup);
            var totalMemoryAfterCleanup = GC.GetTotalMemory(true); // effectief zoveel mogelijk vrijgeven naar het OS met true
            System.Diagnostics.Debug.WriteLine("Total memory after cleanup: " + totalMemoryAfterCleanup);

            StatusBarTxt.Text = "Memory cleanup: from " + totalMemoryBeforeCleanup + " to " + totalMemoryAfterCleanup + " bytes";
        }
    }
}
