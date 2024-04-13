using Omega.Data_Tier;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            catch (Exception ex2)
            {
                MessageBox.Show(ex2.Message);
            }
        }

        public void DeleteCategory(int id)
        {
            try
            {
                CategoryDAO categoryDAO = new CategoryDAO();
                categoryDAO.Delete(id);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void UpdateCategory(int id, Category category)
        {
            try
            {
                CategoryDAO categoryDAO = new CategoryDAO();
                categoryDAO.Update(id, category);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
