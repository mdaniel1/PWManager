using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PWManager.classes
{
    public class Domain : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public BindingList<string> ListAccount { get; set; }
        private string _name;

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
            }
        }

        public Domain(string name)
        {
            Name = name;
            ListAccount = new BindingList<string>();
        }

        
        public override string ToString()
        {
            return Name;
        }
    }
}
