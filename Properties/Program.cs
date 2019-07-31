using System;

namespace Properties
{
    public class Person
    {
        // type "prop" + 2 tabs
        public string LastName { get; set; }

        private string _firstName;

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }
        

        public string FullName
        {
            get
            {
                return string.Format("{0} (1}", FirstName, LastName);
            }
        }
    }
}
