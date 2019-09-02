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

namespace WPFLoginMaterialDesign
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml    
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //textBoxUserName.GotFocus += GotFocus.EventHandle(RemoveText);
            //textBoxUserName.LostFocus += LostFocus.EventHandle(AddText);

            //textBoxPassword.GotFocus += GotFocus.EventHandle(RemoveText);
            //textBoxPassword.LostFocus += LostFocus.EventHandle(AddText);
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        #region --  --
        
        public void RemoveText(object sender, EventArgs e)
        {
            
            if (textBoxUserName.Text == "Enter text here...")
            {
                textBoxUserName.Text = "";
            }

            if (textBoxPassword.Password == "Enter text here...")
            {
                textBoxUserName.Text = "";
            }
        }

        public void AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxUserName.Text))
                textBoxUserName.Text = "Enter text here...";

            if (string.IsNullOrWhiteSpace(textBoxPassword.Password))
                textBoxPassword.Password = "Enter text here...";
        }

        #endregion
    }
}
