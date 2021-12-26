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

namespace Практическая__8
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Сompare_Click(object sender, RoutedEventArgs e)
        {
            Sphere sphere = new Sphere(double.Parse(sphereVolume.Text));
            Parallelepiped parallelepiped = new Parallelepiped(int.Parse(parallelepipedVolume.Text));

            if (sphere.CompareTo(parallelepiped) == 1) MessageBox.Show("Объем шара больше объема параллепипеда");
            if (sphere.CompareTo(parallelepiped) == -1) MessageBox.Show("Объем шара меньше объема параллепипеда");
            if (sphere.CompareTo(parallelepiped) == 0) MessageBox.Show("Объем фигур равен");
        }

        private void CalculateSphereVolume_Click(object sender, RoutedEventArgs e)
        {
            if (int.Parse(sphereRadius.Text) < 0 || String.IsNullOrEmpty(sphereRadius.Text))
            {
                MessageBox.Show("Введите корректные значения!");
            }
            else
            {
                sphereVolume.Text = (4 / 3 * (3.14 * Math.Pow(int.Parse(sphereRadius.Text), 3))).ToString();
            }
        }

        private void CalculateParallelepipedVolume_Click(object sender, RoutedEventArgs e)
        {
            if (int.Parse(parallelepipedHeight.Text) <= 0 || int.Parse(parallelepipedLength.Text) <= 0 || int.Parse(parallelepipedWidth.Text) <= 0 ||
                String.IsNullOrEmpty(parallelepipedHeight.Text) || String.IsNullOrEmpty(parallelepipedLength.Text) || String.IsNullOrEmpty(parallelepipedWidth.Text))
            {
                MessageBox.Show("Введите корректные значения!");
            }
            else
            {
                parallelepipedVolume.Text = (int.Parse(parallelepipedLength.Text) * int.Parse(parallelepipedWidth.Text) *
                    int.Parse(parallelepipedHeight.Text)).ToString();
            }
        }

        private void GetSphereInfo_Click(object sender, RoutedEventArgs e)
        {
            Sphere sphere = new Sphere(double.Parse(sphereVolume.Text));
            MessageBox.Show(sphere.GetFigureInformation());
        }

        private void GetParallelepipedInfo_Click(object sender, RoutedEventArgs e)
        {
            Sphere parallelepiped = new Sphere(int.Parse(parallelepipedVolume.Text));
            MessageBox.Show($"{parallelepiped.GetFigureInformation()}");
        }

        private void TaskInfo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Создать интерфейс – фигура (объем). Создать классы - параллелепипед, шар. Классы должны включать " +
              "конструкторы, функцию для формирования строки информации о фигуре. Сравнение производить по объему", "Задание");
        }

        private void DeveloperInfo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Харенко Кирилл  ИСП-34", "Разработчик", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
