﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace RhiultaUI.View
{
    /// <summary>
    /// Interaction logic for TextBoxView.xaml
    /// </summary>
    public partial class GroupBoxView : UserControl
    {
        public Model model { get; set; }
        public GroupBoxView()
        {
            model = new Model();
            this.DataContext = this;
            InitializeComponent();
        }

        public class Model : ValidatableModel, INotifyPropertyChanged
        {

            public event PropertyChangedEventHandler PropertyChanged;
        }
    }

}
