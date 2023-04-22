using CommunityToolkit.Mvvm.DependencyInjection;
using DotaCounterPicker.MVVM.ViewModels;
using DotaCounterPicker.Services;
using DotaCounterPicker.Wpf.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DotaCounterPicker.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var services = ConfigureServices(this);
            Ioc.Default.ConfigureServices(services);
            DataContext = new MainViewModel(Ioc.Default.GetRequiredService<IDialogService>());
        }

        private ContentPresenter DialogContainer => container;

        private IServiceProvider ConfigureServices(MainWindow mainWindow)
        {
            var services = new ServiceCollection();

            services.AddSingleton<IDialogService>(new DialogService(mainWindow.DialogContainer));

            return services.BuildServiceProvider();
        }
    }
}
