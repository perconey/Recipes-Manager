using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows;
using WpfApp2.Logic;

namespace WpfApp2
{
    /// <summary>
    /// Logika interakcji dla klasy Window1.xaml
    /// </summary>
    public partial class AddRecipeWindow
    {
        List<Ingredient> listOfIngredients = new List<Ingredient>();

        public AddRecipeWindow()
        {
            InitializeComponent();
        }

        //Klikniecie dodaj w okienku dodawnia przepisu
        private void button_Click(object sender, RoutedEventArgs e)
        {
            var currentRecipe = new Recipe()
            {
                Nazwa = recipeNameTextField.Text,
                Przepis = recipeDescTextField.Text,
                Data = DateTime.Now,
                Ings = listOfIngredients
            };

            var repo = new RecipesRepository();
            var retr = repo.RetrieveForProcessing();
            var repoIsGood = repo.CheckIfRecipeRepositoryIsOk(retr);
            MessageBox.Show(repoIsGood.ToString());

            if (repoIsGood)
            {
                MessageBox.Show("Gora");
                var bytes = new byte[Serialize(retr, currentRecipe).Length];
                Serialize(retr, currentRecipe).Read(bytes, 0, (int)Serialize(retr, currentRecipe).Length);
                var fileStream = new FileStream("C:\\Users\\Roman\\Desktop\\C#\\WpfApp2\\WpfApp2\\Recipes\\recipesRepoFile.txt", FileMode.Create, FileAccess.Write);
                fileStream.Write(bytes, 0, bytes.Length);
                Serialize(retr, currentRecipe).Close();
                fileStream.Close();
                Close();
            }
            else
            {
                MessageBox.Show("Dol");
                var bytes = new byte[Serialize(currentRecipe).Length];
                Serialize(currentRecipe).Read(bytes, 0, (int)Serialize(currentRecipe).Length);
                var fileStream = new FileStream("C:\\Users\\Roman\\Desktop\\C#\\WpfApp2\\WpfApp2\\Recipes\\recipesRepoFile.txt", FileMode.Create, FileAccess.Write);
                fileStream.Write(bytes, 0, bytes.Length);
                Serialize(currentRecipe).Close();
                fileStream.Close();
                Close();
            }
        }
        //using (FileStream fileStream = new FileStream("C:\\Users\\Roman\\Desktop\\C#\\WpfApp2\\WpfApp2\\Recipes\\recipesRepoFile.txt", FileMode.Create, FileAccess.Write))
        //{
        //    if (repo.CheckIfRecipeRepositoryIsOk(retr) == true)
        //    {
        //        MessageBox.Show("Gora");
        //        byte[] bytes = new byte[Serialize(retr, currentRecipe).Length];
        //        Serialize(retr, currentRecipe).Read(bytes, 0, (int)Serialize(retr, currentRecipe).Length);
        //        fileStream.Write(bytes, 0, bytes.Length);
        //        Serialize(retr, currentRecipe).Close();
        //        this.Close();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Dol");
        //        byte[] bytes = new byte[Serialize(currentRecipe).Length];
        //        Serialize(currentRecipe).Read(bytes, 0, (int)Serialize(currentRecipe).Length);
        //        fileStream.Write(bytes, 0, bytes.Length);
        //        Serialize(currentRecipe).Close();
        //        this.Close();
        //    }
        // //nawias klasy dont forget
        //}
        


        /// <summary>
        /// 2 Methods below are unstable and copied from Stackoverflow
        /// </summary>

        // 1 arg - dotychczasowa lista
        public static Stream Serialize(List<Recipe> backList, Recipe recipe)
        {
            var rec = new Recipe { Nazwa = recipe.Nazwa, Przepis = recipe.Przepis, Data = recipe.Data, Ings = recipe.Ings };
            var list = new List<Recipe>(backList);
            list.Add(rec);

            var stream = new MemoryStream();

            var formatter = new BinaryFormatter();
            formatter.Serialize(stream, list);

            stream.Position = 0;

            return stream;
        }

        // Jezeli repo bylo puste
        public static Stream Serialize(Recipe recipe)
        {
            var list = new List<Recipe>();
            var rec = new Recipe { Nazwa = recipe.Nazwa, Przepis = recipe.Przepis, Data = recipe.Data, Ings = recipe.Ings };
            list.Add(rec);

            var stream = new MemoryStream();

            var formatter = new BinaryFormatter();
            formatter.Serialize(stream, list);

            stream.Position = 0;

            return stream;
        }

        //Default and bad value for amount is 666 xD
        private void addIngredientToRecipeButton_Click(object sender, RoutedEventArgs e)
        {

            var ing = new Ingredient()
            {
                Iname = ingredientNameTextField.Text,
                Iunit = ingredientUnitTextField.Text
            };

            try
            {
                ing.Iamount = Convert.ToDouble(ingredientAmountTextField.Text);  
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Amount is invalid, Exception: {ex.Message}");
                ing.Iamount = 666;
            }
            ClearIngredientFields();
            listOfIngredients.Add(ing);
        }

        public void ClearIngredientFields()
        {
            ingredientNameTextField.Text = "";
            ingredientUnitTextField.Text = "";
            ingredientAmountTextField.Text = "";
        }
    }
}
