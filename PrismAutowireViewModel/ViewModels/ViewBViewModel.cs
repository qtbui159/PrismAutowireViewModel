﻿using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismAutowireViewModel.ViewModels
{
    class ViewBViewModel : BindableBase, IDialogAware
    {
        public string Value { get => m_Value; private set => SetProperty(ref m_Value, value); }
        private string m_Value;

        public string Title => string.Empty;
        public event Action<IDialogResult> RequestClose;

        public DelegateCommand LoadedCommand { get; private set; }


        public ViewBViewModel()
        {
            LoadedCommand = new DelegateCommand(LoadedCommandProc);
        }

        private void LoadedCommandProc()
        {
            Value = "Success";
        }

        public bool CanCloseDialog()
        {
            return true;
        }

        public void OnDialogClosed()
        {

        }

        public void OnDialogOpened(IDialogParameters parameters)
        {

        }
    }
}
