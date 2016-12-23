using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace KillerAppAbdoAryanzad.Models.ViewModels
{
    public class BestellingToevoegenViewModel
    {
        public DataTable dt = new DataTable();

        public List<string> Products { get; private set; }
        public List<double> Prijzen { get; private set; }
        public List<string> Producten = new List<string>();
        public List<double> prijzen  = new List<double>();

        public BestellingToevoegenViewModel()
        {
            this.Products = Producten;
            this.Prijzen = prijzen;
            DataTableAanmaken();

        }

        private void DataTableAanmaken()
        {
            
            dt.Columns.Add("Product", typeof(string));
            dt.Columns.Add("Prijs", typeof(double));
        }

        public void DataTabletoListProducten(DataTable dt)
        {
            foreach (DataRow i in dt.Rows)
            {
                  Producten.Add(i["Product"].ToString());  
            }
        }

        public void DataTabletoListPrijzen(DataTable dt)
        {
            foreach (DataRow i in dt.Rows)
            {
                 prijzen.Add(Convert.ToDouble(i[1]));
            }
        }


        public void AddToTable(string Product, double Prijs)
        {
            dt.Rows.Add(Product, Prijs);
            DataTabletoListProducten(dt);
            DataTabletoListPrijzen(dt);
        }

        public void TableClearen()
        {
            dt.Clear();
        }
    }
}