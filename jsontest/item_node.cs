using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jsontest
{
    class item_node
    {
        private string type, name, location, time;
        private int slot, star;

        public item_node()
        {

        }

        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Location
        {
            get
            {
                return location;
            }
            set
            {
                location = value;
            }
        }

        public int Slot
        {
            get
            {
                return slot;
            }
            set
            {
                slot = value;
            }
        }

        public string Time
        {
            get
            {
                return time;
            }
            set
            {
                time = value;
            }
        }

        public int Star
        {
            get
            {
                return star;
            }
            set
            {
                star = value;
            }
        }
    }
}
