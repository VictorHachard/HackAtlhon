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

namespace HackathonCisco
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Interfaces int01 = new Interfaces(TypeOfInterfaces.FastEthernet, 0, 1, true, "Reseau A", "10.10.10.254", "255.255.255.0");
            Interfaces int02 = new Interfaces();
            int02.AddTypeOfInterfaces(TypeOfInterfaces.Gigabit)
                .AddDescription("Super reseau 2")
                .AddIp("192.168.0.1")
                .AddMask(new IP(255, 255, 0, 0))
                .AddPreInterfaces(1)
                .AddPostInterfaces(0);
            CiscoRouter routeur = new CiscoRouter("routeur001");
            routeur.AddInterfaces(int01, int02)
                .AddBanner("Super Routeur")
                .AddNoIpDomaineLookup(true)
                .AddSecureConsoleMode("cisco")
                .AddSecurePriviledgeMode("cisco");
            MessageBox.Show(routeur.SaveToConf());

        }
    }
}
