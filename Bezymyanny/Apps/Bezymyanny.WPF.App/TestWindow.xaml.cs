using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Windows;

namespace Generic.Host.WPF.App
{
    /// <summary>
    /// Interaction logic for TestWindow.xaml
    /// </summary>
    public partial class TestWindow : Window
    {
        private readonly ILogger<TestWindow> _logger;
        private readonly IConfiguration _configuration; 

        public TestWindow(ILogger<TestWindow> logger, IConfiguration configuration)
        {
            InitializeComponent();

            _logger = logger;
            _configuration = configuration;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _logger.LogDebug("Closing");
            _logger.LogInformation("Connection string: " + _configuration.GetConnectionString("Db"));

            this.Visibility = Visibility.Collapsed; // om te verbergen
            e.Cancel = true; // om te voorkomen dat de WPF app het window toch nog vernietigt
        }
    }
}
