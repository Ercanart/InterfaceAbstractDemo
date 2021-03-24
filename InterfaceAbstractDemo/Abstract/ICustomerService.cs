using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;
//Bir Customer nesnesi var ise
//interface'si(ICustomerService) de olmak zorundadır.
namespace InterfaceAbstractDemo.Abstract
{
    public interface ICustomerService                        
    {
        void Save(Customer customer);

    }
}


