﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace dsTareas_Xamarin.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewTaskUserPages : ContentPage
    {
        public ViewTaskUserPages()
        {
            InitializeComponent();

            comentariosPicker.Items.Add("Último comentario");
            comentariosPicker.Items.Add("Todos los comentarios");

        }

        private void comentariosPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}