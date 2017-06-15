using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __TheLibrary.Entity
{
    public class EShelf
    {
        public int ID { get; set; }
        public string ShelfNo { get; set; }
        public ECategories Category { get; set; }
    }
}
