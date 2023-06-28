using semana14.Models;
using semana14.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Xamarin.Forms;

namespace semana14
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            ProductService service = new ProductService();
            List<Product> product = new List<Product>();

            for (int i = 0; i < 3; i++)
                product.Add(new Product { name = txtName.Text, description = txtDescription.Text, fechaVencimiento = txtFechaVencimiento.Text, precio = txtPrecio.Text });

            //service.Create(new Person { LastName = txtLastName.Text, FirstName = txtName.Text });

            service.CreateRange(product);


        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            ProductService service = new ProductService();
            lvProduct.ItemsSource = service.Get();
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            ProductService service = new ProductService();
            lvProduct.ItemsSource = service.GetByText(txtFilter.Text.Trim());
        }
    }
}
