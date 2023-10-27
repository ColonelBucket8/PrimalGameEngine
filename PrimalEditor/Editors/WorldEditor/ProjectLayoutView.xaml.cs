using System.Windows;
using System.Windows.Controls;
using PrimalEditor.GameProject;

namespace PrimalEditor.Editors
{
    /// <summary>
    /// Interaction logic for ProjectLayoutView.xaml
    /// </summary>
    public partial class ProjectLayoutView : UserControl
    {
        public ProjectLayoutView()
        {
            InitializeComponent();
        }

        private void OnAddScene_Button_Click(object sender, RoutedEventArgs e)
        {
            var vm = DataContext as Project;
            vm.AddScene("New Scene" + vm.Scenes.Count);
        }
    }
}
