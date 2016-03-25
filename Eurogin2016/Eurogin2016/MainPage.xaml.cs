using System;
using System.Collections.Generic;
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
using System.Diagnostics;
// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Eurogin2016
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            frameNavigationPage.Navigate(typeof(PageNavigationTab));
           
            
        }

        private void btnNavigationPage_Click(object sender, RoutedEventArgs e)
        {
            //svNavigationPage.IsPaneOpen = !svNavigationPage.IsPaneOpen;
            Debug.WriteLine("Navigation Button Click");
            Frame.Navigate(typeof(PageNavigationTab));
        }

        private void btnMyVisits_Click(object sender, RoutedEventArgs e)
        {
            //Frame.Navigate(typeof(PageMyVisits));
            Debug.WriteLine("My Visits Button Click");
            Frame.Navigate(typeof(PageNavigationPageHeader));
        }

        private void btnPrograms_Click(object sender, RoutedEventArgs e)
        {
            //Frame.Navigate(typeof(PagePrograms));
            Debug.WriteLine("Programs Button Click");
            Frame.Navigate(typeof(PageNavigationPageHeader));
        }

        private void btnExhibitorFloorPlan_Click(object sender, RoutedEventArgs e)
        {
            //Frame.Navigate(typeof(PageExhibitionFloorPlan));
            Debug.WriteLine("Exhibitoin Floor Plan Button Click");
            Frame.Navigate(typeof(PageNavigationPageHeader));
        }

        private void btnFaculty_Click(object sender, RoutedEventArgs e)
        {
            //Frame.Navigate(typeof(PageFaculty));
            Debug.WriteLine("Faculty Button Click");
            Frame.Navigate(typeof(PageNavigationPageHeader));
        }

        private void btnSponsors_Click(object sender, RoutedEventArgs e)
        {
            //Frame.Navigate(typeof(PageSponsors));
            Debug.WriteLine("Sponsors Button Click");
            Frame.Navigate(typeof(PageNavigationPageHeader));
        }

        private void btnPracticalInformation_Click(object sender, RoutedEventArgs e)
        {
            //Frame.Navigate(typeof(PagePracticalInformation));
            Debug.WriteLine("Practical Information Button Click");
            Frame.Navigate(typeof(PageNavigationPageHeader));
        }
    }
}
