using System.Windows;
using System.Windows.Controls;

namespace PrimalEditor.GameProject
{
    /// <summary>
    /// Interaction logic for NewProjectView.xaml
    /// </summary>
    public partial class NewProjectView : UserControl
    {
        public NewProjectView()
        {
            InitializeComponent();
        }

        private void OnCreate_Button_Click(object sender, RoutedEventArgs e)
        {
            var data = DataContext as NewProject;
            var projectPath = data.CreateProject(templateListBox.SelectedItem as ProjectTemplate);
            bool dialogResult = false;
            var win = Window.GetWindow(this);

            if (!string.IsNullOrEmpty(projectPath))
            {
                dialogResult = true;
            }
            win.DialogResult = dialogResult;
            win.Close();
        }
    }
}
