using System;
using System.Collections.Generic;
using System.Linq;

namespace c_
{
    class Person
    {
        public string FirstName;
        public string LastName;
        public string Gender;
        public DateTime DateOfBirth;
        public string PhoneNumber;
        public string BirthPlace;
        public bool isGraduate;
        List<Person> ps = new List<Person>();
        public Person()
        {

        }
        public Person(string fn, string ln, string gd, DateTime dob, string pn, string bp, bool ig)
        {
            FirstName = fn;
            LastName = ln;
            Gender = gd;
            DateOfBirth = dob;
            PhoneNumber = pn;
            BirthPlace = bp;
            isGraduate = ig;
        }

    
        public void findOldestPerson(List<Person> p)
        {
            var result = p.OrderBy(x => x.DateOfBirth).First(); 
            Console.WriteLine("The Oldest Person is "+ result.LastName+"  " + result.DateOfBirth);
            
        }
        public void getLastNameAndFirstName(List<Person> p)
        {
        
          

            foreach (var i in p)
            {
                Console.WriteLine("Full name :" + i.LastName + " " + i.FirstName);
            }

        }
        // public void getPersonBornIn1998(List<Person> p)
        // {
        //     var result = p.Where(x => x.DateOfBirth.Year == 1998).ToList();

        //     foreach (var i in result)
        //     {
        //         Console.WriteLine("Person was born in 1998 :" + i.LastName + " " + i.FirstName + " " +i.DateOfBirth);
        //     }

        // }
        // public void getPersonAfter1998(List<Person> p)
        // {
           

        //     var result = p.Where(x => x.DateOfBirth.Year > 1998).ToList();

        //     foreach (var i in result)
        //     {
        //         Console.WriteLine("Person was born after 1998 :" + i.LastName + " " + i.FirstName + " " +i.DateOfBirth);
        //     }

        // }
        // public void getPersonBefore1998(List<Person> p)
        // {
       

        //     var result = p.Where(x => x.DateOfBirth.Year < 1998).ToList();

        //     foreach (var i in result)
        //     {
        //         Console.WriteLine("Person was born before 1998 :" + i.LastName + " " + i.FirstName + " " +i.DateOfBirth);
        //     }

        // }
          public void get3ListWithSwitchCase(string year ,List<Person> person)
        {
            switch(year)
            {
                case "=1998":
                var result1 = person.Where(x=>x.DateOfBirth.Year == 1998).ToList();
                foreach(var i in result1)
                {
                    Console.WriteLine("Member was born in 1998 : "+ i.LastName +" "+i.FirstName + " "+i.Gender+" "+i.PhoneNumber+" "+i.DateOfBirth+" "+i.BirthPlace+" "+i.isGraduate );
                }
                break;
                
                case "<1998":
                var result2 = person.Where(x=>x.DateOfBirth.Year < 1998).ToList();
                foreach(var i in result2)
                {
                    Console.WriteLine("Member was born before 1998 : "+ i.LastName +" "+i.FirstName + " "+i.Gender+" "+i.PhoneNumber+" "+i.DateOfBirth+" "+i.BirthPlace+" "+i.isGraduate );
                }
                break;

                case ">1998":
                var result3 = person.Where(x=>x.DateOfBirth.Year > 1998).ToList();
                foreach(var i in result3)
                {
                    Console.WriteLine("Member was born after 1998 : "+ i.LastName +" "+i.FirstName + " "+i.Gender+" "+i.PhoneNumber+" "+i.DateOfBirth+" "+i.BirthPlace+" "+i.isGraduate );
                }
                break;
            }
        }
        public void getPersonHanoi(List<Person> p)
        {
          

            var result = p.Where(x => x.BirthPlace == "Hanoi").ToList();

            foreach (var i in result)
            {
                Console.WriteLine("Person was born in Hanoi :" + i.LastName + " " + i.FirstName + " " +i.BirthPlace);
            }

        }
        public void getMalePerson(List<Person> p)
        {
           

            var result = p.Where(x => x.Gender == "Male").ToList();

            foreach (var i in result)
            {
                Console.WriteLine("Male Person is  :" + i.LastName + " " + i.FirstName + " " +i.Gender);
            }

        }

    }
}