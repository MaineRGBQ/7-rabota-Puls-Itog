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

namespace WpfApp34
{
    public partial class MainWindow : Window
    {
        private double baseWidth = 200;
        private double baseHeight = 200;
        private bool isGrowing = true;

        public MainWindow()
        {
            InitializeComponent();
            pulseEllipse.MouseLeftButtonDown += PulseEllipse_MouseLeftButtonDown;
            CompositionTarget.Rendering += CompositionTarget_Rendering;
        }

        private void PulseEllipse_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            isGrowing = !isGrowing;
        }

        private void CompositionTarget_Rendering(object sender, EventArgs e)
        {
            if (isGrowing)
            {
                pulseEllipse.Width += 1;
                pulseEllipse.Height += 1;
            }
            else
            {
                pulseEllipse.Width -= 1;
                pulseEllipse.Height -= 1;
            }

            if (pulseEllipse.Width >= baseWidth * 2 || pulseEllipse.Width <= baseWidth)
            {
                isGrowing = !isGrowing;
            }
        }
    }
}