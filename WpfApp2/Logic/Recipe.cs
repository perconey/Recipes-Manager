using System;
using System.Collections.Generic;

namespace WpfApp2.Logic
{
    [Serializable]
    public class Recipe : Object
    {
        private string _nazwa;
        private DateTime _data;
        private string _przepis;
        private List<Ingredient> _ings;

        public List<Ingredient> Ings
        {
            set => _ings = value;
            get => _ings;
        }

        public string Nazwa
        {
            set => _nazwa = value;
            get => _nazwa;
        }
        public string Przepis
        {
            set => _przepis = value;
            get => _przepis;
        }

        public DateTime Data
        {
            set => _data= value;
            get => _data;
        }

    }
}
