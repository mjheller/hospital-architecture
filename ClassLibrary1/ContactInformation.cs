using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public struct ContactInformation
    {
        private string _firstName;
        private string _lastName;
        private string _name;
        private int _age;
        private string _email;
        private string _phoneNumber;
        private string _gender;
        private string _address;
        private string _city;
        private string _state;
        private string _zipCode;

        public string FirstName { get { return _firstName; } set { _firstName = value; } }
        public string LastName { get { return _lastName; } set { _lastName = value; } }
        public string Name { get { return _firstName + " " + _lastName; } set { _name = value; } }
        public int Age { get { return _age; } set { _age = value; } }
        public string Email { get { return _email; } set { _email = value; } }
        public string PhoneNumber { get { return _phoneNumber; } set { _phoneNumber = value; } }
        public string Gender { get { return _gender; } set { _gender = value; } }
        public string Address { get { return _address; } set { _address = value; } }
        public string City { get { return _city; } set { _city = value; } }
        public string State { get { return _state; } set { _state = value; } }
        public string ZipCode { get { return _zipCode; } set { _zipCode = value; } }
    }
}