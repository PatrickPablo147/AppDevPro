using AppDevPro.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AppDevPro.Commands
{
    public class UpdateViewCommand : ICommand
    {
        private MainViewModel viewModel;

        public UpdateViewCommand(MainViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter.ToString() == "TableList")
            {
                viewModel.SelectedViewModel = new TableListViewModel();
            }
            else if (parameter.ToString() == "Quiz")
            {
                viewModel.SelectedViewModel = new QuizViewModel();
            }
            else if (parameter.ToString() == "CreateNewItem")
            {
                viewModel.SelectedViewModel = new CreateItemViewModel();
            }
            else if (parameter.ToString() == "Setting")
            {
                viewModel.SelectedViewModel = new SettingsViewModel();
            }
        }
    }
}
