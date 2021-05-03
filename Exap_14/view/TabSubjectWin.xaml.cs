using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Exap_14.view
{
    public partial class TabSubjectWin : Window
    {
        private List<Предметы> predlist = new List<Предметы>();
        public TabSubjectWin()
        {
            InitializeComponent();

            GetData();
        }

        private void GetData(string crit = "")
        {
            GridAppr.ItemsSource = null;

            predlist.Clear();

            using (ModelBD model = new ModelBD())
            {
                if (crit != "")
                {
                    var queryAppr = from p in model.Предметы
                                    where p.Наименование_предмета.Contains(crit)
                                    select p;

                    foreach (var item in queryAppr)
                    {
                        Предметы pred = new Предметы()
                        {
                            Наименование_предмета = item.Наименование_предмета,
                            Описание_предмета = item.Описание_предмета
                        };
                        predlist.Add(pred);
                    }
                }
                else
                {
                    var queryAppr = from p in model.Предметы
                                    select p;

                    foreach (var item in queryAppr)
                    {
                        Предметы pred = new Предметы()
                        {
                            Наименование_предмета = item.Наименование_предмета,
                            Описание_предмета = item.Описание_предмета
                        };
                        predlist.Add(pred);
                    }
                }

                GridAppr.ItemsSource = predlist;

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

        private void GridAppr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (GridAppr.SelectedItem != null)
            {
                Combo.Text = (GridAppr.SelectedItem as Предметы).Наименование_предмета;
            }
        }
    }
}
