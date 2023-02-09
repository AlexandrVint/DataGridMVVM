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
using System.Windows.Shapes;
using DataGridMVVM.Models;

namespace DataGridMVVM.Views.Window
{
    /// <summary>
    /// Логика взаимодействия для SecondWindow.xaml
    /// </summary>
    public partial class SecondWindow : System.Windows.Window
    {
        public Multiplier Multiplier { get; set; }

        public SecondWindow(Multiplier multiplier)
        {
            InitializeComponent();
            Multiplier = multiplier;
            DataContext = Multiplier;

        }
    }
}
