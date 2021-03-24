using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Saved to db : " + customer.FirstName);
        }
    }
}
//Virtual, metodlara uygulanan anahtar bir sözcüktür.
//Ve Virtual olarak tanımladığımız metodlarımızı,
//diğer class larda override edebiliriz.
//Yani, kalıtıldığı(miras alındığı) sınıfta metodun gövdesini
//( süslü parantezlerin içi) değiştirebileceğimiz anlamına gelir.
