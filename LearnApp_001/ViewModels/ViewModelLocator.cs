using System;
using System.Collections.Generic;
using System.Text;

// 依賴注入區要用的，我們現在要把ViewModel跟View關聯起來
using GalaSoft.MvvmLight.Ioc;

namespace LearnApp_001.ViewModels
{
    public class ViewModelLocator
    {
        /// <summary>
        /// 需要找ViewModel需要透過ViewModelLocator
        /// </summary>
        public ViewModelLocator()
        {
            /// 這東西一定要寫在構造函數內
            /// 這就類似Sprimg 註冊一個 bin
            /// 我們這裡第一步就是註冊一個類
            SimpleIoc.Default.Register<MainPageViewModel>();
        }
        public MainPageViewModel MainPageViewModel => 
                    SimpleIoc.Default.GetInstance<MainPageViewModel>();

       
    }
}
