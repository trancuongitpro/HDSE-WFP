using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Practice_Cuong.model;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace HDSE_WFP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private List<Icon> Icons;
        private ObservableCollection<Contact> Contacts;
        public MainPage()
        {
            this.InitializeComponent();
            Icons = new List<Icon>();

            Icons.Add(new Icon { IconPath = "Assets/nha1.jpg" });
            Icons.Add(new Icon { IconPath = "Assets/nha2.jpg" });
            Icons.Add(new Icon { IconPath = "Assets/nha3.jpg" });
            Contacts = new ObservableCollection<Contact>();
            Contacts.Add(new Contact { Product = "House1", Description = "Beauty from home", Image = "Assets/nha1.jpg" });
            Contacts.Add(new Contact { Product = "House2", Description = "Beauty from home", Image = "Assets/nha2.jpg" });
            Contacts.Add(new Contact { Product = "House3", Description = "Beauty from home", Image = "Assets/nha3.jpg" });
        }

        private void NewContactButton_Click(object sender, RoutedEventArgs e)
        {
            string avatar = ((Icon)AvatarComboBox.SelectedValue).IconPath;
            Contacts.Add(new Contact { Product = ProductTextBox.Text, Description = DescriptionTextBox.Text, Image = avatar });
            ProductTextBox.Text = "";
            DescriptionTextBox.Text = "";
            AvatarComboBox.SelectedIndex = -1;
            ProductTextBox.Focus(FocusState.Programmatic);
        }
    }
}
