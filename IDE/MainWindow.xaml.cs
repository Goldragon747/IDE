﻿using IDELanguages;
using IDELib;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace IDE
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IGenericLanguage IGL = new Language();
        ComponentFactory CF;
        public MainWindow()
        {
           
            InitializeComponent();

            foreach (string languageName in IGL.LanguagesSupported )
            {
                SelectLanguageCB.Items.Add(languageName);
            }
        }

        private void ContinueBtnClicked(object sender, RoutedEventArgs e)
        {
            SelectLanguageSP.Visibility = Visibility.Hidden;
            GUIBuilderSP.Visibility = Visibility.Visible;
            for (int i = 0; i < SelectLanguageCB.Items.Count; i++)
            {
                if (SelectLanguageCB.Items[i] == SelectLanguageCB.SelectedValue)
                {
                   CF = IGL.LanguageFactories[i]; 
                }
            }

        }

        private void CreatComponentBtnClicked(object sender, RoutedEventArgs e)
        {
            string width = WidthTB.Text;
            string height = HeightTB.Text;
            string leftAlign = LeftAlignTB.Text;
            string topAlign = TopAlignTB.Text;
        }
    }
}
