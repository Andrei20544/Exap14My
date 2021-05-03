using Exap_14.ViewModel;
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
    public partial class TabStudWin : Window
    {
        private List<DopStud> studlist = new List<DopStud>();
        public TabStudWin()
        {
            InitializeComponent();

            GetData();
        }

        private void GetData(string crit = "")
        {
            GridAppr.ItemsSource = null;

            studlist.Clear();

            using (ModelBD model = new ModelBD())
            {
                if (crit != "")
                {
                    var queryAppr = from p in model.Студенты
                                    join s in model.Специальности on p.Код_специальности equals s.Код_специальности
                                    where p.ФИО.Contains(crit)
                                    select new
                                    {
                                        FIO = p.ФИО,
                                        POL = p.Пол,
                                        DateOfBirth = p.Дата_рождения,
                                        Parents = p.Родители,
                                        Adres = p.Адрес,
                                        Mobile = p.Телефон,
                                        PassData = p.Паспортные_данные,
                                        NumZ = p.Номер_зачётки,
                                        DateInvite = p.Дата_поступления,
                                        Group = p.Группа,
                                        Cours = p.Курс,
                                        Spec = s.C_Наименование_специальности,
                                        OchForm = p.Очная_форма_обучения
                                    };

                    foreach (var item in queryAppr)
                    {
                        DopStud stud = new DopStud(item.FIO, item.POL, item.DateOfBirth,
                            item.Parents, item.Adres, item.Mobile, item.PassData, item.NumZ,
                            item.DateInvite, item.Group, item.Cours, item.Spec, item.OchForm);
                        studlist.Add(stud);
                    }
                }
                else
                {
                    var queryAppr = from p in model.Студенты
                                    join s in model.Специальности on p.Код_специальности equals s.Код_специальности
                                    select new
                                    {
                                        FIO = p.ФИО,
                                        POL = p.Пол,
                                        DateOfBirth = p.Дата_рождения,
                                        Parents = p.Родители,
                                        Adres = p.Адрес,
                                        Mobile = p.Телефон,
                                        PassData = p.Паспортные_данные,
                                        NumZ = p.Номер_зачётки,
                                        DateInvite = p.Дата_поступления,
                                        Group = p.Группа,
                                        Cours = p.Курс,
                                        Spec = s.C_Наименование_специальности,
                                        OchForm = p.Очная_форма_обучения
                                    };

                    foreach (var item in queryAppr)
                    {
                        DopStud stud = new DopStud(item.FIO, item.POL, item.DateOfBirth,
                            item.Parents, item.Adres, item.Mobile, item.PassData, item.NumZ,
                            item.DateInvite, item.Group, item.Cours, item.Spec, item.OchForm);
                        studlist.Add(stud);
                    }
                }

                GridAppr.ItemsSource = studlist;

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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GridAppr_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            if (GridAppr.SelectedItem != null)
            {
                Combo.Text = (GridAppr.SelectedItem as DopStud).FIO;
            }
        }
    }
}
