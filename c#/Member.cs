using System;
using System.Collections.Generic;
using System.Linq;

namespace c_
{
    class Member : Person
    {
        public DateTime _StarDate;
        public Nullable<DateTime> _EndDate;
        public Member()
        {

        }
        public Member(string FirstName, string LastName, string Gender,DateTime DateOfBirth,string PhoneNumber, string BirthPlace, bool isGraduate, DateTime StartDate, Nullable<DateTime> EndDate) 
        : base(FirstName,LastName,Gender,DateOfBirth,PhoneNumber, BirthPlace,isGraduate )
        {
            _StarDate = StartDate;
            _EndDate = EndDate;
        }
      
        public void getDateJoinMember( List<Member> mb)
        {
            DateTime joinday = new DateTime(2021,3,22);

            var result = mb.Where(x=>x._StarDate < joinday ).ToList();
            foreach(var i in result)
            {
                Console.WriteLine("Member who join class before 22/03/2021 : "+ i.LastName +" "+i.FirstName + " "+i.Gender+" "+i.PhoneNumber+" "+i.DateOfBirth+" "+i.BirthPlace+" "+i.isGraduate +" "+i._StarDate+" "+i._EndDate);
            }

        }
        public void getMaleMember(List<Member> mb)
        {
           
            foreach(var i in mb)
            {
                if(i.Gender == "Male")
                Console.WriteLine("Male Member is  :" + i.LastName + " " + i.FirstName + " " +i.Gender);
            }
        }
      

    }
}