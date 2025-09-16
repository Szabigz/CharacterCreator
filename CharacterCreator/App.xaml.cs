using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using CharacterCreator.Model;
using CharacterCreator.ViewModel;

namespace CharacterCreator
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private CharacterModel _model;
        private CharacterViewModel _viewModel;
        private MainWindow _mainWindow;
        public App()
        {
            Startup += App_Startup;
        }
        private void App_Startup(object sender, StartupEventArgs e)
        {
            _model = new CharacterModel();
            _viewModel = new CharacterViewModel(_model);
            _mainWindow = new MainWindow();
            _mainWindow.DataContext = _viewModel;
            _mainWindow.Show();
        }

    }

}
