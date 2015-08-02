using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GitCrashReporter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private static ResourceDictionary dict;
        public static string GetDictText(string key)
        {
            foreach (var keys in dict.Keys.Cast<string>().Where(keys => keys == key))
            {
                return (string)dict[keys];
            }
            return key;
        }
        public MainWindow()
        {
            InitializeComponent();
            dict = new ResourceDictionary();
            switch (Thread.CurrentThread.CurrentCulture.ToString())
            {
                case "en-US":
                    dict.Source = new Uri("..\\Language\\English.xaml",
                                  UriKind.Relative);
                    break;
                default:
                    dict.Source = new Uri("..\\Language\\English.xaml",
                                      UriKind.Relative);
                    break;
            }
            Resources.MergedDictionaries.Add(dict);
        }
    }
}
