using ShoesApp.Business;
using ShoesApp.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoesApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            Manager AS = new Manager();
            SearchShoes insert = new SearchShoes()
            {
                IdType = (int)numericType.Value,
                IdColor =(int)numericColor.Value,
                IdBrand =(int)numericBrand.Value,
                IdProvider =(int)numericProvider.Value,
                IdCatalog = (int)numericCatalog.Value,
                Title = tBoxTitle.Text,
                Nombre =tBoxName.Text,
                Description=tBoxDescr.Text,
                Observations =tBoxObs.Text,
                PriceDistributor =(int)numericPriceD.Value,
                PriceClient = (int)numericPriceC.Value,
                PriceMember = (int)numericPriceM.Value,
                IsEnabled = true,
                Keywords = tBoxKey.Text,
                DateUpdate = dateTimePicker1.Value

            };
            AS.AddShoes(insert);
            
        }
    }
}
