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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SudokuWPF
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Sudoku s = new Sudoku();

            int result;

            if (int.TryParse(tb00.Text, out result))
                s.SetNum(0, 0, result);

            if (int.TryParse(tb01.Text, out result))
                s.SetNum(0, 1, result);

            if (int.TryParse(tb02.Text, out result))
                s.SetNum(0, 2, result);

            if (int.TryParse(tb03.Text, out result))
                s.SetNum(0, 3, result);

            if (int.TryParse(tb04.Text, out result))
                s.SetNum(0, 4, result);

            if (int.TryParse(tb05.Text, out result))
                s.SetNum(0, 5, result);

            if (int.TryParse(tb06.Text, out result))
                s.SetNum(0, 6, result);

            if (int.TryParse(tb07.Text, out result))
                s.SetNum(0, 7, result);

            if (int.TryParse(tb08.Text, out result))
                s.SetNum(0, 8, result);

            if (int.TryParse(tb10.Text, out result))
                s.SetNum(1, 0, result);

            if (int.TryParse(tb11.Text, out result))
                s.SetNum(1, 1, result);

            if (int.TryParse(tb12.Text, out result))
                s.SetNum(1, 2, result);

            if (int.TryParse(tb13.Text, out result))
                s.SetNum(1, 3, result);

            if (int.TryParse(tb14.Text, out result))
                s.SetNum(1, 4, result);

            if (int.TryParse(tb15.Text, out result))
                s.SetNum(1, 5, result);

            if (int.TryParse(tb16.Text, out result))
                s.SetNum(1, 6, result);

            if (int.TryParse(tb17.Text, out result))
                s.SetNum(1, 7, result);

            if (int.TryParse(tb18.Text, out result))
                s.SetNum(1, 8, result);

            if (int.TryParse(tb20.Text, out result))
                s.SetNum(2, 0, result);

            if (int.TryParse(tb21.Text, out result))
                s.SetNum(2, 1, result);

            if (int.TryParse(tb22.Text, out result))
                s.SetNum(2, 2, result);

            if (int.TryParse(tb23.Text, out result))
                s.SetNum(2, 3, result);

            if (int.TryParse(tb24.Text, out result))
                s.SetNum(2, 4, result);

            if (int.TryParse(tb25.Text, out result))
                s.SetNum(2, 5, result);

            if (int.TryParse(tb26.Text, out result))
                s.SetNum(2, 6, result);

            if (int.TryParse(tb27.Text, out result))
                s.SetNum(2, 7, result);

            if (int.TryParse(tb28.Text, out result))
                s.SetNum(2, 8, result);

            if (int.TryParse(tb30.Text, out result))
                s.SetNum(3, 0, result);

            if (int.TryParse(tb31.Text, out result))
                s.SetNum(3, 1, result);

            if (int.TryParse(tb32.Text, out result))
                s.SetNum(3, 2, result);

            if (int.TryParse(tb33.Text, out result))
                s.SetNum(3, 3, result);

            if (int.TryParse(tb34.Text, out result))
                s.SetNum(3, 4, result);

            if (int.TryParse(tb35.Text, out result))
                s.SetNum(3, 5, result);

            if (int.TryParse(tb36.Text, out result))
                s.SetNum(3, 6, result);

            if (int.TryParse(tb37.Text, out result))
                s.SetNum(3, 7, result);

            if (int.TryParse(tb38.Text, out result))
                s.SetNum(3, 8, result);

            if (int.TryParse(tb40.Text, out result))
                s.SetNum(4, 0, result);

            if (int.TryParse(tb41.Text, out result))
                s.SetNum(4, 1, result);

            if (int.TryParse(tb42.Text, out result))
                s.SetNum(4, 2, result);

            if (int.TryParse(tb43.Text, out result))
                s.SetNum(4, 3, result);

            if (int.TryParse(tb44.Text, out result))
                s.SetNum(4, 4, result);

            if (int.TryParse(tb45.Text, out result))
                s.SetNum(4, 5, result);

            if (int.TryParse(tb46.Text, out result))
                s.SetNum(4, 6, result);

            if (int.TryParse(tb47.Text, out result))
                s.SetNum(4, 7, result);

            if (int.TryParse(tb48.Text, out result))
                s.SetNum(4, 8, result);

            if (int.TryParse(tb00.Text, out result))
                s.SetNum(0, 0, result);

            if (int.TryParse(tb51.Text, out result))
                s.SetNum(5, 1, result);

            if (int.TryParse(tb52.Text, out result))
                s.SetNum(5, 2, result);

            if (int.TryParse(tb53.Text, out result))
                s.SetNum(5, 3, result);

            if (int.TryParse(tb54.Text, out result))
                s.SetNum(5, 4, result);

            if (int.TryParse(tb55.Text, out result))
                s.SetNum(5, 5, result);

            if (int.TryParse(tb56.Text, out result))
                s.SetNum(5, 6, result);

            if (int.TryParse(tb57.Text, out result))
                s.SetNum(5, 7, result);

            if (int.TryParse(tb58.Text, out result))
                s.SetNum(5, 8, result);

            if (int.TryParse(tb60.Text, out result))
                s.SetNum(6, 0, result);

            if (int.TryParse(tb61.Text, out result))
                s.SetNum(6, 1, result);

            if (int.TryParse(tb62.Text, out result))
                s.SetNum(6, 2, result);

            if (int.TryParse(tb63.Text, out result))
                s.SetNum(6, 3, result);

            if (int.TryParse(tb64.Text, out result))
                s.SetNum(6, 4, result);

            if (int.TryParse(tb65.Text, out result))
                s.SetNum(6, 5, result);

            if (int.TryParse(tb66.Text, out result))
                s.SetNum(6, 6, result);

            if (int.TryParse(tb67.Text, out result))
                s.SetNum(6, 7, result);

            if (int.TryParse(tb68.Text, out result))
                s.SetNum(6, 8, result);

            if (int.TryParse(tb70.Text, out result))
                s.SetNum(7, 0, result);

            if (int.TryParse(tb71.Text, out result))
                s.SetNum(7, 1, result);

            if (int.TryParse(tb72.Text, out result))
                s.SetNum(7, 2, result);

            if (int.TryParse(tb73.Text, out result))
                s.SetNum(7, 3, result);

            if (int.TryParse(tb74.Text, out result))
                s.SetNum(7, 4, result);

            if (int.TryParse(tb75.Text, out result))
                s.SetNum(7, 5, result);

            if (int.TryParse(tb76.Text, out result))
                s.SetNum(7, 6, result);

            if (int.TryParse(tb77.Text, out result))
                s.SetNum(7, 7, result);

            if (int.TryParse(tb78.Text, out result))
                s.SetNum(7, 8, result);

            if (int.TryParse(tb80.Text, out result))
                s.SetNum(8, 0, result);

            if (int.TryParse(tb81.Text, out result))
                s.SetNum(8, 1, result);

            if (int.TryParse(tb82.Text, out result))
                s.SetNum(8, 2, result);

            if (int.TryParse(tb83.Text, out result))
                s.SetNum(8, 3, result);

            if (int.TryParse(tb84.Text, out result))
                s.SetNum(8, 4, result);

            if (int.TryParse(tb85.Text, out result))
                s.SetNum(8, 5, result);

            if (int.TryParse(tb86.Text, out result))
                s.SetNum(8, 6, result);

            if (int.TryParse(tb87.Text, out result))
                s.SetNum(8, 7, result);

            if (int.TryParse(tb88.Text, out result))
                s.SetNum(8, 8, result);

            s.Solve();

            if (s.GetNum(0, 0).HasValue)
                tb00.Text = s.GetNum(0, 0).ToString();

            if (s.GetNum(0, 1).HasValue)
                tb01.Text = s.GetNum(0, 1).ToString();

            if (s.GetNum(0, 2).HasValue)
                tb02.Text = s.GetNum(0, 2).ToString();

            if (s.GetNum(0, 3).HasValue)
                tb03.Text = s.GetNum(0, 3).ToString();

            if (s.GetNum(0, 4).HasValue)
                tb04.Text = s.GetNum(0, 4).ToString();

            if (s.GetNum(0, 5).HasValue)
                tb05.Text = s.GetNum(0, 5).ToString();

            if (s.GetNum(0, 6).HasValue)
                tb06.Text = s.GetNum(0, 6).ToString();

            if (s.GetNum(0, 7).HasValue)
                tb07.Text = s.GetNum(0, 7).ToString();

            if (s.GetNum(0, 8).HasValue)
                tb08.Text = s.GetNum(0, 8).ToString();

            if (s.GetNum(1, 0).HasValue)
                tb10.Text = s.GetNum(1, 0).ToString();

            if (s.GetNum(1, 1).HasValue)
                tb11.Text = s.GetNum(1, 1).ToString();

            if (s.GetNum(1, 2).HasValue)
                tb12.Text = s.GetNum(1, 2).ToString();

            if (s.GetNum(1, 3).HasValue)
                tb13.Text = s.GetNum(1, 3).ToString();

            if (s.GetNum(1, 4).HasValue)
                tb14.Text = s.GetNum(1, 4).ToString();

            if (s.GetNum(1, 5).HasValue)
                tb15.Text = s.GetNum(1, 5).ToString();

            if (s.GetNum(1, 6).HasValue)
                tb16.Text = s.GetNum(1, 6).ToString();

            if (s.GetNum(1, 7).HasValue)
                tb17.Text = s.GetNum(1, 7).ToString();

            if (s.GetNum(1, 8).HasValue)
                tb18.Text = s.GetNum(1, 8).ToString();

            if (s.GetNum(2, 0).HasValue)
                tb20.Text = s.GetNum(2, 0).ToString();

            if (s.GetNum(2, 1).HasValue)
                tb21.Text = s.GetNum(2, 1).ToString();

            if (s.GetNum(2, 2).HasValue)
                tb22.Text = s.GetNum(2, 2).ToString();

            if (s.GetNum(2, 3).HasValue)
                tb23.Text = s.GetNum(2, 3).ToString();

            if (s.GetNum(2, 4).HasValue)
                tb24.Text = s.GetNum(2, 4).ToString();

            if (s.GetNum(2, 5).HasValue)
                tb25.Text = s.GetNum(2, 5).ToString();

            if (s.GetNum(2, 6).HasValue)
                tb26.Text = s.GetNum(2, 6).ToString();

            if (s.GetNum(2, 7).HasValue)
                tb27.Text = s.GetNum(2, 7).ToString();

            if (s.GetNum(2, 8).HasValue)
                tb28.Text = s.GetNum(2, 8).ToString();

            if (s.GetNum(3, 0).HasValue)
                tb30.Text = s.GetNum(3, 0).ToString();

            if (s.GetNum(3, 1).HasValue)
                tb31.Text = s.GetNum(3, 1).ToString();

            if (s.GetNum(3, 2).HasValue)
                tb32.Text = s.GetNum(3, 2).ToString();

            if (s.GetNum(3, 3).HasValue)
                tb33.Text = s.GetNum(3, 3).ToString();

            if (s.GetNum(3, 4).HasValue)
                tb34.Text = s.GetNum(3, 4).ToString();

            if (s.GetNum(3, 5).HasValue)
                tb35.Text = s.GetNum(3, 5).ToString();

            if (s.GetNum(3, 6).HasValue)
                tb36.Text = s.GetNum(3, 6).ToString();

            if (s.GetNum(3, 7).HasValue)
                tb37.Text = s.GetNum(3, 7).ToString();

            if (s.GetNum(3, 8).HasValue)
                tb38.Text = s.GetNum(3, 8).ToString();

            if (s.GetNum(4, 0).HasValue)
                tb40.Text = s.GetNum(4, 0).ToString();

            if (s.GetNum(4, 1).HasValue)
                tb41.Text = s.GetNum(4, 1).ToString();

            if (s.GetNum(4, 2).HasValue)
                tb42.Text = s.GetNum(4, 2).ToString();

            if (s.GetNum(4, 3).HasValue)
                tb43.Text = s.GetNum(4, 3).ToString();

            if (s.GetNum(4, 4).HasValue)
                tb44.Text = s.GetNum(4, 4).ToString();

            if (s.GetNum(4, 5).HasValue)
                tb45.Text = s.GetNum(4, 5).ToString();

            if (s.GetNum(4, 6).HasValue)
                tb46.Text = s.GetNum(4, 6).ToString();

            if (s.GetNum(4, 7).HasValue)
                tb47.Text = s.GetNum(4, 7).ToString();

            if (s.GetNum(4, 8).HasValue)
                tb48.Text = s.GetNum(4, 8).ToString();

            if (s.GetNum(5, 0).HasValue)
                tb50.Text = s.GetNum(5, 0).ToString();

            if (s.GetNum(5, 1).HasValue)
                tb51.Text = s.GetNum(5, 1).ToString();

            if (s.GetNum(5, 2).HasValue)
                tb52.Text = s.GetNum(5, 2).ToString();

            if (s.GetNum(5, 3).HasValue)
                tb53.Text = s.GetNum(5, 3).ToString();

            if (s.GetNum(5, 4).HasValue)
                tb54.Text = s.GetNum(5, 4).ToString();

            if (s.GetNum(5, 5).HasValue)
                tb55.Text = s.GetNum(5, 5).ToString();

            if (s.GetNum(5, 6).HasValue)
                tb56.Text = s.GetNum(5, 6).ToString();

            if (s.GetNum(5, 7).HasValue)
                tb57.Text = s.GetNum(5, 7).ToString();

            if (s.GetNum(5, 8).HasValue)
                tb58.Text = s.GetNum(5, 8).ToString();

            if (s.GetNum(6, 0).HasValue)
                tb60.Text = s.GetNum(6, 0).ToString();

            if (s.GetNum(6, 1).HasValue)
                tb61.Text = s.GetNum(6, 1).ToString();

            if (s.GetNum(6, 2).HasValue)
                tb62.Text = s.GetNum(6, 2).ToString();

            if (s.GetNum(6, 3).HasValue)
                tb63.Text = s.GetNum(6, 3).ToString();

            if (s.GetNum(6, 4).HasValue)
                tb64.Text = s.GetNum(6, 4).ToString();

            if (s.GetNum(6, 5).HasValue)
                tb65.Text = s.GetNum(6, 5).ToString();

            if (s.GetNum(6, 6).HasValue)
                tb66.Text = s.GetNum(6, 6).ToString();

            if (s.GetNum(6, 7).HasValue)
                tb67.Text = s.GetNum(6, 7).ToString();

            if (s.GetNum(6, 8).HasValue)
                tb68.Text = s.GetNum(6, 8).ToString();

            if (s.GetNum(7, 0).HasValue)
                tb70.Text = s.GetNum(7, 0).ToString();

            if (s.GetNum(7, 1).HasValue)
                tb71.Text = s.GetNum(7, 1).ToString();

            if (s.GetNum(7, 2).HasValue)
                tb72.Text = s.GetNum(7, 2).ToString();

            if (s.GetNum(7, 3).HasValue)
                tb73.Text = s.GetNum(7, 3).ToString();

            if (s.GetNum(7, 4).HasValue)
                tb74.Text = s.GetNum(7, 4).ToString();

            if (s.GetNum(7, 5).HasValue)
                tb75.Text = s.GetNum(7, 5).ToString();

            if (s.GetNum(7, 6).HasValue)
                tb76.Text = s.GetNum(7, 6).ToString();

            if (s.GetNum(7, 7).HasValue)
                tb77.Text = s.GetNum(7, 7).ToString();

            if (s.GetNum(7, 8).HasValue)
                tb78.Text = s.GetNum(7, 8).ToString();

            if (s.GetNum(8, 0).HasValue)
                tb80.Text = s.GetNum(8, 0).ToString();

            if (s.GetNum(8, 1).HasValue)
                tb81.Text = s.GetNum(8, 1).ToString();

            if (s.GetNum(8, 2).HasValue)
                tb82.Text = s.GetNum(8, 2).ToString();

            if (s.GetNum(8, 3).HasValue)
                tb83.Text = s.GetNum(8, 3).ToString();

            if (s.GetNum(8, 4).HasValue)
                tb84.Text = s.GetNum(8, 4).ToString();

            if (s.GetNum(8, 5).HasValue)
                tb85.Text = s.GetNum(8, 5).ToString();

            if (s.GetNum(8, 6).HasValue)
                tb86.Text = s.GetNum(8, 6).ToString();

            if (s.GetNum(8, 7).HasValue)
                tb87.Text = s.GetNum(8, 7).ToString();

            if (s.GetNum(8, 8).HasValue)
                tb88.Text = s.GetNum(8, 8).ToString();






        }
    }
}
