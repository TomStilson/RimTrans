﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using RimTrans.Lite.Controls;

namespace RimTrans.Lite.Windows
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            vm.View = this;
        }

        private void modListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            vm.SelectedMod = (ModListBoxItem)modListBox.SelectedItem;
        }

        private void languageListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            vm.SelectedLanguage = (LanguageListBoxItem)languageListBox.SelectedItem;
        }

        private void Main_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            vm.SaveProjects();
        }

        private void buttonHelp_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/duduluu/RimTrans/wiki");
        }
    }
}
