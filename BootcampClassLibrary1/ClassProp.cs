using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BootcampClassLibrary1
{
    public class ClassProp
    {
        private int _id;
        private string _name;
        private string _name2;
        private DateTime _creationDate;

        public int ID { get => _id; }
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
            }
        }

        public string Name2
        {
            get => _name2;

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new System.Exception("Blank Names Are not allowed");

                }
                _name2 = value;
            }
        }

        public string NameUpperCase
        {
            get
            {
                return _name.ToUpper();

            }
        }
        public decimal Rating { get; set; }

        public ClassProp()      // empty constructor 
        {
            _creationDate = DateTime.Now;

        }
        public ClassProp(int id, string name)   // parameterised constructor

        {
            _creationDate = DateTime.Now;
            _id = id;
            _name = name;
        }


    }
}
