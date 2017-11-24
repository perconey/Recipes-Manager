using System;

namespace WpfApp2.Logic
{   
    [Serializable]
    public class Ingredient
    {
        private String _iname;
        private double _iamount;
        private String _iunit;

        public String Iname
        {
            set => _iname = value;
            get => _iname;
        }

        public String Iunit
        {
            set => _iunit = value;
            get => _iunit;
        }

        public double Iamount
        {
            set => _iamount = value;
            get => _iamount;
        }

    }
}
