using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using Prism.Services.Dialogs;
using PrismAutowireViewModel.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismAutowireViewModel.ViewModels
{
    class MainWindowViewModel : BindableBase
    {
        private readonly IDialogService m_DialogService;

        public DelegateCommand ViewACommand { get; private set; }
        public DelegateCommand ViewBCommand { get; private set; }

        public MainWindowViewModel(IDialogService dialogService)
        {
            m_DialogService = dialogService;

            ViewACommand = new DelegateCommand(ViewACommandProc);
            ViewBCommand = new DelegateCommand(ViewBCommandProc);
        }

        private void ViewACommandProc()
        {
            m_DialogService.ShowDialog(nameof(ViewA));
        }

        private void ViewBCommandProc()
        {
            m_DialogService.ShowDialog(nameof(ViewB));
        }
    }
}
