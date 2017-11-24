using System;

namespace WpfApp2
{
    public static class ListBoxExtensions
    {
        /// <summary>
        /// Something went wrong with references
        /// </summary>

        //public static void PopulateListBoxWithListOfRecipies(this ListBox lista, List<Recipe> recipes)
        //{
        //    foreach(var item in recipes)
        //    {
        //        lista.Items.Add($"{item.Nazwa}  {item.Przepis}  {item.Data}");
        //    }
        //}

        public static String Cepik(this String napis)
        {
            return napis.ToLower();
        }
    }
}