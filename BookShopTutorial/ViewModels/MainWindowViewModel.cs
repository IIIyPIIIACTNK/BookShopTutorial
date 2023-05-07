using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathCore.ViewModels;

namespace BookShopTutorial.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        private string _Title = "Главное окно программы";

        private string Title { get => _Title; set => Set(ref _Title, value); }
    }
}
