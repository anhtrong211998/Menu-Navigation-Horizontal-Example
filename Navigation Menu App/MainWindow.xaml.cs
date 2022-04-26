using Navigation_Menu_App.ViewModels;
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

namespace Navigation_Menu_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {



        public List<MenuItemModel> MenuItemList { get; set; }


        //===============================



        public MainWindow()
        {
            MenuItemList = new List<MenuItemModel>
            {
                new MenuItemModel{
                    Header="Home",
                    Icon="Home",
                    Foreground="#FF33D41D"
                },

                new MenuItemModel{
                    Header="Music",
                    Icon="Music",
                    Foreground="Red",
                    SubMenuItem=new List<MenuItemModel>
                    {
                       new MenuItemModel{
                            Header="All songs",
                            Icon = "LibraryMusicOutline",
                            Foreground="YellowGreen"
                       },
                       new MenuItemModel{
                            Header="Genres",
                            Icon="LibraryMusicOutline",
                            Foreground="Yellow",
                            SubMenuItem = new List<MenuItemModel>{
                                new MenuItemModel{
                                    Header="Pop",
                                    Icon="Music",
                                    Foreground="Red"
                                },
                                new MenuItemModel{
                                    Header="Rock",
                                    Icon="Music",
                                    Foreground="Red"
                                },
                                new MenuItemModel{
                                    Header="Metal",
                                    Icon="Music",
                                    Foreground="Red"
                                },
                                new MenuItemModel{
                                    Header="Acoustic",
                                    Icon="Music",
                                    Foreground="Red"
                                }
                            }
                        },
                       new MenuItemModel{
                            Header="Albums",
                            Icon="Album",
                            Foreground="OrangeRed"
                        }
                    }
                },
                new MenuItemModel{
                    Header="Movies",
                    Icon="Movie",
                    Foreground="Yellow"
                },
                new MenuItemModel{
                    Header="Folders",
                    Icon="Folder",
                    Foreground="OrangeRed"
                },
                new MenuItemModel{
                    Header="Settings",
                    Icon="Settings",
                    Foreground="LightPink",
                    SubMenuItem=new List<MenuItemModel>
                    {
                       new MenuItemModel{
                            Header="Input/Codes",
                            Icon = "SettingsInputComposite",
                            Foreground="LightYellow"
                       },
                       new MenuItemModel{
                            Header="Hot key",
                            Icon = "Key",
                            Foreground="LightYellow"
                       },
                    }
                },
                new MenuItemModel{
                    Header="About",
                    Icon="About",
                    Foreground="Yellow"
                },
                new MenuItemModel{
                    Header="Exit",
                    Icon="Logout",
                    Foreground="PaleVioletRed"
                }
            };
            InitializeComponent();
            DataContext = this;
        }

        private void closeBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void maximizeBtn_Click(object sender, RoutedEventArgs e)
        {
            if(WindowState != WindowState.Maximized)
            {
                WindowState = WindowState.Maximized;
            }
            else
            {
                WindowState = WindowState.Normal;
            }
        }

        private void minimizeBtn_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState != WindowState.Minimized)
            {
                WindowState = WindowState.Minimized;
            }
            else
            {
                WindowState = WindowState.Normal;
            }
        }
    }
}
