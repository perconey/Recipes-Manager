using System;
using System.Globalization;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using WpfApp2.Logic;


namespace WpfApp2
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoadRecipes_Click(object sender, RoutedEventArgs e)
        {
            //Makes it visible
            var path = "C:\\Users\\Roman\\Desktop\\C#\\WpfApp2\\WpfApp2\\Recipes\\recipesRepoFile.txt";
            listView.Visibility = 0;
            var repo = new RecipesRepository();
            var list = repo.Retrieve();
            var valid = repo.CheckIfRecipeRepositoryIsOk(list);

            if (valid)
            {
                //populates the listview
                listView.DataContext = list;
                MessageBox.Show("Succesfully exported recipes from repository into listview");
            }
            else if(new FileInfo(path).Length != 0)
            {
                MessageBox.Show("Can't import repository into listview because one of the field is invalid");
            }

        }

        private void AddRecipe_Click(object sender, RoutedEventArgs e)
        {
            var addRecipeWindow = new AddRecipeWindow();
            addRecipeWindow.Show();
            addRecipeWindow.Activate();
        }

        //Klikniecie w jeden z elementow listy
        private void ListViewItemClicked(object sender, SelectionChangedEventArgs e)
        {
            //listView.SelectedIndex return selected index number FIRST IS 0. None is -1
            var recipeWindow = new RecipeWindow();

            //Imports data from repository for future use
            var repositoryInstance = new RecipesRepository();
            var repo = repositoryInstance.Retrieve();

            try
            {
            recipeWindow.Title = repo[listView.SelectedIndex].Nazwa;

            //Populates the new window fields
            recipeWindow.recipeNameTextBlock.Text = repo[listView.SelectedIndex].Nazwa;
            recipeWindow.recipeDescriptionTextBlock.Text = repo[listView.SelectedIndex].Przepis;
            recipeWindow.recipeDateTextBlock.Text = repo[listView.SelectedIndex].Data.ToString(CultureInfo.InvariantCulture);

            recipeWindow.ingredientsListView.DataContext = repo[listView.SelectedIndex].Ings;



            recipeWindow.Show();
            recipeWindow.Activate();
            }
            catch (ArgumentException)
            {

            }

        }

    }
}
