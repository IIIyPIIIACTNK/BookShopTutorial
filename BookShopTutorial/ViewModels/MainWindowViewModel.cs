using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathCore.ViewModels;

namespace BookShopTutorial.ViewModels
{
    class MainWindowViewModel : ViewModel
    {
        private string _Title = "Главное окно программы";

        public string Title { get => _Title; set => Set(ref _Title, value); }
    }
}
