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

namespace LookslessVsUserControl
{
    public partial class MrWhiteWithCodeBehind : UserControl
    {
        public static readonly DependencyProperty MyContentProperty = DependencyProperty.Register(
            "MyContent", typeof (object), typeof (MrWhiteWithCodeBehind), new PropertyMetadata(default(object)));

        public object MyContent
        {
            get { return (object)GetValue(MyContentProperty); }
            set { SetValue(MyContentProperty, value); }
        }


        public MrWhiteWithCodeBehind()
        {
            InitializeComponent();
        }
    }
}
