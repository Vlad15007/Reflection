using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group
{
    interface IGroup
    {

    }

    public class Lada : IGroup
    {
        private string name;
        public string Name { get; set; }

        public event EventHandler Gladit;

        public void SeeKitten()
        {
            Gladit.Invoke(this, EventArgs.Empty);
        }
        public void Shut()
        {

        }
    }
}
