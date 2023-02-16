using System;
using System.Collections.Generic;
using System.Text;

// 先引用這個才能繼承ViewModelBase
using GalaSoft.MvvmLight;

using GalaSoft.MvvmLight.Command;

namespace LearnApp_001.ViewModels
{
    // ViewModeBase实现了INotifyPropertyChanged，可以实现Binding
    public class MainPageViewModel : ViewModelBase
    {
        /// <summary>
        /// 結果。
        /// </summary>
        private string _result;

        /// <summary>
        ///  這樣之後其他人要拿數據就是找Result，
        ///  而不是直接找_result
        /// </summary>
        public string Result
        {
            get => _result;
            set => Set(nameof(Result), ref _result, value);
        }

        /// <summary>
        /// 實踐按鈕點擊事件
        /// </summary>
        private RelayCommand _helloCommand;
        //public RelayCommand HelloCommand => 
        //    _helloCommand ?? 
        //        new RelayCommand(() => Result="Hello word!");

        public RelayCommand HelloCommand
        {
            get
            {
                if (_helloCommand == null)
                {
                    _helloCommand = new RelayCommand(() => { 
                        Result = "Hello Word!"; 
                    });

                }
                return _helloCommand;
            }
        }

    }
}
