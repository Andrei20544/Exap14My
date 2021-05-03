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
using System.Windows.Shapes;

namespace Exap_14.view
{
    public partial class TabSpecWin : Window
    {
        private List<Специальности> speclist = new List<Специальности>();
        public TabSpecWin()
        {
            InitializeComponent();

            GetData();
        }

        private void GetData(string crit = "")
        {
            GridAppr.ItemsSource = null;

            speclist.Clear();

            using (ModelBD model = new ModelBD())
            {
                if (crit != "")
                {
                    var queryAppr = from p in model.Специальности
                                    where p.C_Наименование_специальности.Contains(crit)
                                    select p;

                    foreach (var item in queryAppr)
                    {
                        Специальности spec = new Специальности()
                        {
                            C_Наименование_специальности = item.C_Наименование_специальности,
                            C_Описание_специальности = item.C_Описание_специальности
                        };
                        speclist.Add(spec);
                    }
                }
                else
                {
                    var queryAppr = from p in model.Специальности
                                    select p;

                    foreach (var item in queryAppr)
                    {
                        Специальности spec = new Специальности()
                        {
                            C_Наименование_специальности = item.C_Наименование_специальности,
                            C_Описание_специальности = item.C_Описание_специальности
                        };
                        speclist.Add(spec);
                    }
                }

                GridAppr.ItemsSource = speclist;

            }
        }

        private void Crit_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                GridAppr.SelectedItem = null;
                Combo.Text = "";
                GetData(Crit.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GridAppr_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            if (GridAppr.SelectedItem != null)
            {
                Combo.Text = (GridAppr.SelectedItem as Специальности).C_Наименование_специальности;
            }
        }
    }
}
