using System;
using System.Collections.Generic;
using System.Linq;
namespace c_
{
       class Program
    {

        static void Main(string[] args)
        {
            Person p = new Person();
            Member m = new Member();
            List<Member> mb = new List<Member>();
            var m1 = new Member("Le", "Huy","Male",new DateTime(1997,4,5).Date,"132515","Hanoi",true,new DateTime(2021,2,1).Date,null);
            var m2 = new Member("Nguyen", "Hoang","Male",new DateTime(1996,4,6).Date,"562515","Hanoi",true,new DateTime(2021,3,25).Date,null);
            var m3 = new Member("Tran", "Hai","Female",new DateTime(1994,7,2).Date,"564115","Hanoi",true,new DateTime(2021,2,28).Date,null);
            var m4 = new Member("Tran", "Hoa","Female",new DateTime(2000,5,8).Date,"562135","TPHCM",false,new DateTime(2021,3,29).Date,null);
            var m5  = new Member("Le", "Loc","Male",new DateTime(1999,7,9).Date,"562135","TPHCM",false,new DateTime(2020,1,29),new DateTime(2021,1,15).Date);
            mb.Add(m1);
            mb.Add(m2);
            mb.Add(m3);
            mb.Add(m4);
            mb.Add(m5);

            List<Person> person = new List<Person>();
            var l1 = new Person("Nguyen", "Van","Male",new DateTime(1998,4,5).Date,"132515","Hanoi",true);
            var l2 = new Person("Nguyen", "Tu","Male",new DateTime(1998,4,6).Date,"562515","Hanoi",true);
            var l3 = new Person("Tran", "Trang","Female",new DateTime(1989,1,2).Date,"564115","Hanoi",true);
            var l4 = new Person("Tran", "Ha","Female",new DateTime(2000,5,8).Date,"562135","TPHCM",false);
            var l5  = new Person("Le", "Dat","Male",new DateTime(1999,7,9).Date,"562135","TPHCM",false);
            person.Add(l1);
            person.Add(l2);
            person.Add(l3);
            person.Add(l4);
            person.Add(l5);

            
          
            p.getMalePerson(person);
            p.findOldestPerson(person);  
            p.getLastNameAndFirstName(person);       
            p.get3ListWithSwitchCase("=1998",person);
            p.get3ListWithSwitchCase("<1998",person);
            p.get3ListWithSwitchCase(">1998",person);
            p.getPersonHanoi(person);
            m.getDateJoinMember(mb);
            m.getMaleMember(mb);
           
        }
    }
}
