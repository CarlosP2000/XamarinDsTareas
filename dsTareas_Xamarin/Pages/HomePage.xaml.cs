using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace dsTareas_Xamarin.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : TabbedPage
    {
        public HomePage()
        {
            InitializeComponent();

            //Pestañas
            Children.Add(new ListTaskPage());
            Children.Add(new NewTaskUserPage());
            Children.Add(new SupportPage());

        }
    }
}