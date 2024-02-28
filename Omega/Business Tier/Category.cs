using Omega.Data_Tier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omega.Objects
{
    public class Category : IBaseClass<Category>
    {
        private int id;
        private string nazev;
        private int dph;
        public int Id { get => id; set => id = value; }
        public string Nazev { get => nazev; set => nazev = value; }
        public int DPH { get => dph; set => dph = value; }

        public Category() { }

        public Category(string nazev, int dph)
        {
            Nazev = nazev;
            DPH = dph;
        }

        // -------------------WORK WITH DATABASE=================

        public void AddToDB()
        {
            try
            {
                CategoryDAO c = new CategoryDAO();
                c.Insert(this);
            }
            catch
            {

            }
        }

    }
}
