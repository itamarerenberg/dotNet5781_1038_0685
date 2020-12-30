﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PLGui.Models
{
    public class ManegerModel
    {
        public ObservableCollection<BO.Bus> Buses { get; set; }

        public ObservableCollection<BO.Line> Lines { get; set; }
    }
}
