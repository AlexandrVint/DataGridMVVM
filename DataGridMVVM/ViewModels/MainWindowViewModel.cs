using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataGridMVVM.Commands;
using DataGridMVVM.DataBase;
using System.Windows.Input;
using DataGridMVVM.ViewModels.Base;
using DataGridMVVM.Models;
using DataGridMVVM.Views.Window;
using Microsoft.EntityFrameworkCore;

namespace DataGridMVVM.ViewModels
{
    public class MainWindowViewModel:ViewModel
    {
        private ApplicationContext db = new ApplicationContext();
        public ObservableCollection<Multiplier> Multipliers { get; set; }


        public ICommand MultiplicationCommand { get; }

        private void OnMultiplication(object p)
        {
            Multiplier multipliers = new Multiplier();
            multipliers.Multiplication = multipliers.DimentionA * multipliers.DimentionB;
            Multipliers.Add(multipliers);

            SecondWindow secondWindow = new SecondWindow(new Multiplier());
            if (secondWindow.ShowDialog() == true)
            {
                Multiplier multiplier = secondWindow.Multiplier;
                db.Multipliers.Add(multiplier);
                db.SaveChanges();

            }
        }

        private bool CanMultiplication(object p)
        {
            return true;
        }





        public MainWindowViewModel()
        {
            ObservableCollection<Multiplier> matematicFunctions = new ObservableCollection<Multiplier>
            {
                new Multiplier{DimentionA = 5, DimentionB = 5}
            };

            db.Database.EnsureCreated();
            db.Multipliers.Load();
            Multipliers = db.Multipliers.Local.ToObservableCollection();

            MultiplicationCommand = new LambdaCommand(OnMultiplication, CanMultiplication);
        }
    }
}
