using System.Collections;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Assignment
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            string id = txtId.Text;
            string name = txtName.Text;
            string gender = cmbGender.Text;
            string semester = cmbSemester.Text;
            string wishlist = "";
            string output = "";

            if (id == "" || name == "" || semester == "")
            {
                output = "Please input all the fields";
            }
            else
            {

                foreach (CheckBox chk in pnlCourses.Children)
                {
                    if (chk.IsChecked == true)
                    {
                        wishlist += chk.Content.ToString() + "\n";
                    }
                }


                //ArrayList list = new ArrayList();

                //if (cbWishList1.IsChecked.Value == true)
                //{
                //    list.Add(cbWishList1.Content);
                //}
                //if (cbWishList2.IsChecked.Value == true) { list.Add(cbWishList2.Content); }
                //if (cbWishList3.IsChecked.Value == true) { list.Add(cbWishList3.Content); }
                //if (cbWishList4.IsChecked.Value == true) { list.Add(cbWishList4.Content); }
                //if (cbWishList5.IsChecked.Value == true) { list.Add(cbWishList5.Content); }

                output = $"ID: {id}\nName:{name}\nGender: {gender}\n" +
                    $"Semester: {semester}\nWishlist:\n{wishlist}";

                //if (list.Count != 0)
                //{
                //    for (int i = 0; i < list.Count - 1; i++)
                //    {
                //        wishlist += $"{list[i]}, ";
                //    }
                //    wishlist += $"{list[list.Count - 1]}";
                //}
            }
            lblDisplay.Content = output;

        }

        private void cmbSemester_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            pnlCourses.Children.Clear();

            string selectedSemester = ((ComboBoxItem)cmbSemester.SelectedItem).Content.ToString();

            if (selectedSemester == "Semester 1")
            {
                pnlCourses.Children.Add(new CheckBox { Content = "MAE" });
                pnlCourses.Children.Add(new CheckBox { Content = "CSI" });
                pnlCourses.Children.Add(new CheckBox { Content = "CEA" });
                pnlCourses.Children.Add(new CheckBox { Content = "PRF" });
                pnlCourses.Children.Add(new CheckBox { Content = "SSL" });
            }
            if (selectedSemester == "Semester 2")
            {
                pnlCourses.Children.Add(new CheckBox { Content = "OSG" });
                pnlCourses.Children.Add(new CheckBox { Content = "PRO" });
                pnlCourses.Children.Add(new CheckBox { Content = "MAD" });
                pnlCourses.Children.Add(new CheckBox { Content = "SSG" });
                pnlCourses.Children.Add(new CheckBox { Content = "NWC" });
            }
            if (selectedSemester == "Semester 3")
            {
                pnlCourses.Children.Add(new CheckBox { Content = "DBI" });
                pnlCourses.Children.Add(new CheckBox { Content = "CSD" });
                pnlCourses.Children.Add(new CheckBox { Content = "LAB" });
                pnlCourses.Children.Add(new CheckBox { Content = "JPD" });
                pnlCourses.Children.Add(new CheckBox { Content = "WED" });
            }
            if (selectedSemester == "Semester 4")
            {
                pnlCourses.Children.Add(new CheckBox { Content = "JPD" });
                pnlCourses.Children.Add(new CheckBox { Content = "MAS" });
                pnlCourses.Children.Add(new CheckBox { Content = "SWE" });
                pnlCourses.Children.Add(new CheckBox { Content = "IOT" });
                pnlCourses.Children.Add(new CheckBox { Content = "PRJ" });
            }
            if (selectedSemester == "Semester 5")
            {
                pnlCourses.Children.Add(new CheckBox { Content = "PRN" });
                pnlCourses.Children.Add(new CheckBox { Content = "SWT" });
                pnlCourses.Children.Add(new CheckBox { Content = "SWP" });
                pnlCourses.Children.Add(new CheckBox { Content = "SWR" });
                pnlCourses.Children.Add(new CheckBox { Content = "ITE" });
            }
            if (selectedSemester == "Semester 6")
            {
                pnlCourses.Children.Add(new CheckBox { Content = "c1" });
                pnlCourses.Children.Add(new CheckBox { Content = "c2" });
                pnlCourses.Children.Add(new CheckBox { Content = "c3" });
                pnlCourses.Children.Add(new CheckBox { Content = "c4" });
                pnlCourses.Children.Add(new CheckBox { Content = "c5" });
            }
            if (selectedSemester == "Semester 7")
            {
                pnlCourses.Children.Add(new CheckBox { Content = "c6" });
                pnlCourses.Children.Add(new CheckBox { Content = "c7" });
                pnlCourses.Children.Add(new CheckBox { Content = "c8" });
                pnlCourses.Children.Add(new CheckBox { Content = "c9" });
                pnlCourses.Children.Add(new CheckBox { Content = "c10" });
            }
            if (selectedSemester == "Semester 8")
            {
                pnlCourses.Children.Add(new CheckBox { Content = "c11" });
                pnlCourses.Children.Add(new CheckBox { Content = "c12" });
                pnlCourses.Children.Add(new CheckBox { Content = "c13" });
                pnlCourses.Children.Add(new CheckBox { Content = "c14" });
                pnlCourses.Children.Add(new CheckBox { Content = "c15" });
            }
            if (selectedSemester == "Semester 9")
            {
                pnlCourses.Children.Add(new CheckBox { Content = "c16" });
                pnlCourses.Children.Add(new CheckBox { Content = "c17" });
                pnlCourses.Children.Add(new CheckBox { Content = "c18" });
                pnlCourses.Children.Add(new CheckBox { Content = "c19" });
                pnlCourses.Children.Add(new CheckBox { Content = "c20" });
            }

        }
    }
}
