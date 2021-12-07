using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace PractRab9
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void addPhone_Clicked(object sender, EventArgs e)
        {

        }

        private void dataBirth_DateSelected(object sender, DateChangedEventArgs e)
        {

        }

        private void save_Clicked(object sender, EventArgs e)
        {
            Application.Current.Properties["familia"] = fam.Text;
            Application.Current.Properties["name"] = name.Text;
            Application.Current.Properties["lastName"] = lastName.Text;
            Application.Current.Properties["age"] = dataBirth.Date;

            Application.Current.SavePropertiesAsync();
        }


        private void ContentPage_Apperating(object sender, EventArgs e)
        {
            object value;
            if(Application.Current.Properties.TryGetValue("familia", out value) == true)
            {
                fam.Text = (String)value;
            }
            if (Application.Current.Properties.TryGetValue("name", out value) == true)
            {
                name.Text = (String)value;
            }
            if (Application.Current.Properties.TryGetValue("lastName", out value) == true)
            {
                lastName.Text = (String)value;
            }
            if (Application.Current.Properties.TryGetValue("age", out value) == true)
            {
                dataBirth.Date = (DateTime)value;
            }
        }
    }
}
