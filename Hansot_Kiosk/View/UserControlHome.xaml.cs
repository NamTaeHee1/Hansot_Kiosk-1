﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using UIStateManagerLibrary;

namespace Hansot_Kiosk.View
{
    /// <summary>
    /// UserControlHome.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class UserControlHome : CustomControlModel
    {

        public UserControlHome()
        {
            InitializeComponent();
        }

        private void HansotVideoEnded(object sender, RoutedEventArgs e)
        {
            this.HansotVideo.Stop();
            this.HansotVideo.Position = TimeSpan.FromSeconds(0);
            this.HansotVideo.Play();
        }

        private void MoveToOrder(object sender, RoutedEventArgs e)
        {
            ((MainWindow)System.Windows.Application.Current.MainWindow).MoveToOrder(sender, e);
        }
    }
}
