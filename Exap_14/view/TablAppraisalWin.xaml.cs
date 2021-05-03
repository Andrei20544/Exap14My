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
    public partial class TablAppraisalWin : Window
    {
        private List<DopAppraisal> appelist = new List<DopAppraisal>();

        public TablAppraisalWin()
        {
            InitializeComponent();

            GetData();
        }

        private void GetData(string crit = "")
        {
            GridAppr.ItemsSource = null;

            appelist.Clear();

            using (ModelBD model = new ModelBD())
            {
                if (crit != "")
                {
                    var queryAppr = from a in model.Оценка
                                    join s in model.Студенты on a.Код_студента equals s.Код_студента
                                    join p1 in model.Предметы on a.Код_предмета equals p1.Код_предмета
                                    join p2 in model.Предметы on a.Код_предмета_1 equals p2.Код_предмета
                                    join p3 in model.Предметы on a.Код_предмета_2 equals p3.Код_предмета
                                    where s.ФИО.Contains(crit)
                                    select new
                                    {
                                        FIOStudQ = s.ФИО,
                                        DateExam1Q = a.Дата_экзамена,
                                        Pred1Q = p1.Наименование_предмета,
                                        Appr1Q = a.Оценка_1,
                                        DateExam2Q = a.Дата_эказмена_2,
                                        Pred2Q = p2.Наименование_предмета,
                                        Appr2Q = a.Оценка_2,
                                        DateExam3Q = a.Дата_экзамена_3,
                                        Pred3Q = p3.Наименование_предмета,
                                        Appr3Q = a.Оценка_3,
                                        AvgApprQ = a.Средний_балл
                                    };

                    foreach (var item in queryAppr)
                    {
                        DopAppraisal dop = new DopAppraisal(item.FIOStudQ,
                            item.DateExam1Q, item.Appr1Q, item.Pred1Q,
                            item.DateExam2Q, item.Appr2Q, item.Pred2Q,
                            item.DateExam3Q, item.Appr3Q, item.Pred3Q,
                            item.AvgApprQ);
                        appelist.Add(dop);
                    }
                }
                else
                {
                    var queryAppr = from a in model.Оценка
                                    join s in model.Студенты on a.Код_студента equals s.Код_студента
                                    join p1 in model.Предметы on a.Код_предмета equals p1.Код_предмета
                                    join p2 in model.Предметы on a.Код_предмета_1 equals p2.Код_предмета
                                    join p3 in model.Предметы on a.Код_предмета_2 equals p3.Код_предмета
                                    select new
                                    {
                                        FIOStudQ = s.ФИО,
                                        DateExam1Q = a.Дата_экзамена,
                                        Pred1Q = p1.Наименование_предмета,
                                        Appr1Q = a.Оценка_1,
                                        DateExam2Q = a.Дата_эказмена_2,
                                        Pred2Q = p2.Наименование_предмета,
                                        Appr2Q = a.Оценка_2,
                                        DateExam3Q = a.Дата_экзамена_3,
                                        Pred3Q = p3.Наименование_предмета,
                                        Appr3Q = a.Оценка_3,
                                        AvgApprQ = a.Средний_балл
                                    };

                    foreach (var item in queryAppr)
                    {
                        DopAppraisal dop = new DopAppraisal(item.FIOStudQ,
                        item.DateExam1Q, item.Appr1Q, item.Pred1Q,
                        item.DateExam2Q, item.Appr2Q, item.Pred2Q,
                        item.DateExam3Q, item.Appr3Q, item.Pred3Q,
                        item.AvgApprQ);
                        appelist.Add(dop);
                    }
                }

                GridAppr.ItemsSource = appelist;

            }
        }

        private void GridAppr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (GridAppr.SelectedItem != null)
            {
                Combo.Text = (GridAppr.SelectedItem as DopAppraisal).FIOStud;
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
    }
}
