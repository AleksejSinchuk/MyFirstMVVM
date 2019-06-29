using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Proba2.ViewModels
{
    class MainWindowViewModel : Base.ViewModel
    {
        public string BG { set; get; }
        public string bg
        {
            get
            {
                return BG;
            }
            set
            {
                BG = value;
                OnPropertyChanged(nameof(BG));
            }
        }
        public string Text { set; get; }
        public Command Click { set; get; }
       public string text
        {
            get
            {
                return Text;
            }
            set
            {
               
                Text= value ;
                OnPropertyChanged(nameof(Text));
            }

        }
        public MainWindowViewModel()
        {
            Click = new Command(
                () =>
                {
                    text = "QWEREWQWEREWQ";
                    bg = "red";
                }
                );
        }
    }
}
