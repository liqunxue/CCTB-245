using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEssentials
{
    public class Store
    {
        #region Properties and Fields
        public int Id { get; set; }
        public string Name { get; set; }
        #endregion

        #region Constructors
        public Store(int id, string name)
        {
            Id = id;
            Name = name;
        }
        #endregion

        #region Methods
        public Product GetProducts(int id)
        {
            // find product in database and return
            // (for now, we just "pretend")
            Product result = new Product(id, "Visual Studio 2013 Ultimate");
            return result;
        }
        #endregion

    }
}
