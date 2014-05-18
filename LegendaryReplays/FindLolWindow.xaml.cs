using LegendaryReplays.Properties;
using Microsoft.Win32;
using System;
using System.IO;
using System.Windows;

namespace LegendaryReplays
{
    /// <summary>
    /// Interaction logic for FindLolWindow.xaml
    /// </summary>
    public partial class FindLolWindow : Window
    {
        public FindLolWindow()
        {
            InitializeComponent();

            LocationLabel.Content = Settings.Default.LoLDirectory;
        }

        private void FindLeagueButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "LoL Launcher|lol.launcher.exe";
            if (Directory.Exists(Path.Combine(Path.GetPathRoot(Environment.SystemDirectory), "Riot Games", "League of Legends")))
                openDialog.InitialDirectory = Path.Combine(Path.GetPathRoot(Environment.SystemDirectory), "Riot Games", "League of Legends");
            if (openDialog.ShowDialog().Value)
            {
                LocationLabel.Content = openDialog.FileName.Replace("lol.launcher.exe", "");
                Settings.Default.LoLDirectory = openDialog.FileName.Replace("lol.launcher.exe", "");
                Settings.Default.Save();
            }
        }
    }
}