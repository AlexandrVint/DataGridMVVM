using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataGridMVVM.ViewModels.Base;

namespace DataGridMVVM.Models
{
    public  class Multiplier:ViewModel
    {
        #region DimentionA : int - первое множитель
        /// <summary>
        /// первое множитель
        /// </summary>
        private int _DimentionA;

        public int DimentionA
        {
            get => _DimentionA;
            set => Set(ref _DimentionA, value);
        }
        #endregion

        #region DimentionB : int - второй множитель
        /// <summary>
        /// второй множитель
        /// </summary>
        private int _DimentionB;

        public int DimentionB
        {
            get => _DimentionB;
            set => Set(ref _DimentionB, value);
        }
        #endregion

        #region Multiplication : int - произведение
        /// <summary>
        /// произведение
        /// </summary>
        private int _Multiplication;

        public int Multiplication
        {
            get => _Multiplication;
            set => Set(ref _Multiplication, value);
        }
        #endregion

        public int Id { get; set; }
    }
}
