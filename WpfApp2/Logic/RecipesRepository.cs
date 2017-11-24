using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows;

namespace WpfApp2.Logic
{
    public class RecipesRepository
    {
        
        public List<Recipe> Retrieve()
        {
            var path = "C:\\Users\\Roman\\Desktop\\C#\\WpfApp2\\WpfApp2\\Recipes\\recipesRepoFile.txt";
            
            //Old version below XD
            {//using (MemoryStream ms = new MemoryStream())
             //using (FileStream file = new FileStream("C:\\Users\\Roman\\Desktop\\C#\\WpfApp2\\WpfApp2\\Recipes\\recipesRepoFile.txt", FileMode.Open, FileAccess.Read))
             //{
             //    if(new FileInfo("C:\\Users\\Roman\\Desktop\\C#\\WpfApp2\\WpfApp2\\Recipes\\recipesRepoFile.txt").Length == 0)
             //    {
             //        MessageBox.Show("Repo is empty");
             //        var emptylist = new List<Recipe>();
             //        return emptylist;
             //    }
             //    else
             //    {
             //        byte[] bytes = new byte[file.Length];
             //        file.Read(bytes, 0, (int)file.Length);
             //        ms.Write(bytes, 0, (int)file.Length);

                //        IFormatter formatter = new BinaryFormatter();
                //        ms.Seek(0, SeekOrigin.Begin);
                //        List<Recipe> r = (List<Recipe>)formatter.Deserialize(ms);
                //        return r;
                //    }
                // -zobacz co sie zretrievewowało xd- MessageBox.Show(r[0].Nazwa);
                //}
            }

            if (new FileInfo(path).Length == 0)
            {
                MessageBox.Show("Cant import from empty repository");
                var empty = new List<Recipe>();
                return empty;
            }

            var ms = new MemoryStream();
            var file = new FileStream(path, FileMode.Open, FileAccess.Read);

            var bytes = new byte[file.Length];
            file.Read(bytes, 0, (int)file.Length);
            ms.Write(bytes, 0, (int)file.Length);

            IFormatter formatter = new BinaryFormatter();
            ms.Seek(0, SeekOrigin.Begin);
            var r = (List<Recipe>)formatter.Deserialize(ms);
            file.Close();
            ms.Close();
            return r;
        }

        public List<Recipe> RetrieveForProcessing()
        {
            var path = "C:\\Users\\Roman\\Desktop\\C#\\WpfApp2\\WpfApp2\\Recipes\\recipesRepoFile.txt";

            if (new FileInfo(path).Length == 0)
            {
                var empty = new List<Recipe>();
                return empty;
            }

            var ms = new MemoryStream();
            var file = new FileStream(path, FileMode.Open, FileAccess.Read);

            var bytes = new byte[file.Length];
            file.Read(bytes, 0, (int)file.Length);
            ms.Write(bytes, 0, (int)file.Length);

            IFormatter formatter = new BinaryFormatter();
            ms.Seek(0, SeekOrigin.Begin);
            var r = (List<Recipe>)formatter.Deserialize(ms);
            file.Close();
            ms.Close();
            return r;
        }


        private Object ByteArrayToObject(byte[] arrBytes)
        {
            var memStream = new MemoryStream();
            var binForm = new BinaryFormatter();
            memStream.Write(arrBytes, 0, arrBytes.Length);
            memStream.Seek(0, SeekOrigin.Begin);
            var obj = (Object)binForm.Deserialize(memStream);

            return obj;
        }

        public T FromByteArray<T>(byte[] data)
        {
            if (data == null)
                return default(T);
            var bf = new BinaryFormatter();
            using (var ms = new MemoryStream(data))
            {
                var obj = bf.Deserialize(ms);
                return (T)obj;
            }
        }

        public List<Recipe> RetrieveBadValueRepo()
        {
            var repo = new List<Recipe>
            {
                new Recipe() {Nazwa = "", Przepis = "TEKSTPRZEPISUTESKTPRZEPISY", Data = DateTime.Now },
                new Recipe() {Nazwa = "Babeczka", Przepis = "TESTETSETSETSETES", Data = DateTime.Now },
                new Recipe() {Nazwa = "Cukinia z nadzieniem", Przepis = "TESTESTETSETESTET", Data = DateTime.Now },
                new Recipe() {Nazwa = "Ciasto bakaliowe", Przepis = " ", Data = DateTime.Now },
                new Recipe() {Nazwa = "Indyk w zalewie", Przepis = "BlabLBAlbalbal", Data = DateTime.Now }
            };
            return repo;
        }

        public bool CheckIfRecipeRepositoryIsOk(List<Recipe> repo)
        {
            if(new FileInfo("C:\\Users\\Roman\\Desktop\\C#\\WpfApp2\\WpfApp2\\Recipes\\recipesRepoFile.txt").Length != 0)
            {
                foreach (var item in repo)
                {
                    if (String.IsNullOrWhiteSpace(item.Nazwa))
                    {
                        return false;
                    }
                    if (String.IsNullOrWhiteSpace(item.Przepis))
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }

    //public bool CheckIfRecipeRepositoryIsOk(List<Recipe> repo)
    //{
    //    if (repo.Any())
    //    {
    //        foreach (var item in repo)
    //        {
    //            if (String.IsNullOrWhiteSpace(item.Nazwa))
    //            {
    //                return false;
    //            }
    //            if (String.IsNullOrWhiteSpace(item.Przepis))
    //            {
    //                return false;
    //            }
    //        }
    //        return true;
    //    }
    //    else
    //    {
    //        return false;
    //    }
    //}

    }

}
