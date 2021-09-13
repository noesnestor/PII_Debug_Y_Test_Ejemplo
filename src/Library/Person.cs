using System;
using System.Collections.Generic;
using System.Runtime;

namespace UnitTestAndDebug
{
    public class Person
    {
        public Person(string name, string id, string dateOfBirth)
        {
            this.Name = name;
            this.ID = id;
            this.DateOfBirth = dateOfBirth;
        }

        private string name;

        private string id;

        private string dateOfBirth;

        public string DateOfBirth

        {
            get
            {
                return this.dateOfBirth;
            }
            
            set
            {
               if(BirthCheck.DateOfBirthIsValid(value))
               {
                this.dateOfBirth = value; 
               }
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.name = value;
                }
            }
        }
        public string ID
        {
            get
            {
                return this.id;
            }

            set
            {
                if (IdUtils.IdIsValid(value))
                {
                    this.id = value;
                }
            }
        }

        public void IntroduceYourself()
        {
            Console.WriteLine($"Soy {this.Name}, naci el {this.DateOfBirth} y mi cédula es {this.ID}");
        }
    }
}
