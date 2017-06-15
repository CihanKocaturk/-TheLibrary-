using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __TheLibrary.Entity
{
    public class EPublisher
    {
        public EPublisher()
        {

        }

        public EPublisher(int _id,string _name)
        {
            ID = _id;
            Name = _name;
        }

        public int ID { get; set; }
        public string Name { get; set; }
    }
}
