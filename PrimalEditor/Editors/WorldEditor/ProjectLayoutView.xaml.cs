using System.Windows.Controls;
using PrimalEditor.Components;
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

        private void OnAddGameEntity_Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Button btn = sender as Button;
            Scene vm = btn.DataContext as Scene;
            vm.AddGameEntityCommand.Execute(new GameEntity(vm) { Name = "Empty Game Entity" });
        }
    }
}
