﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ToDo.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CreateTaskPage : ContentPage
	{
		public CreateTaskPage ()
		{
			InitializeComponent ();
		}

        private void createTaskBtn_Clicked(object sender, EventArgs e)
        {
            
        }
    }
}