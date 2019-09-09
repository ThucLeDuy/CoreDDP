using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDD.Models
{
    interface IServiceManager
    {
        bool AddServiceWithIdInvoice(int idInvoice, Service service);
        bool DeleteServiceWithIdInvoice(int idInvoice, int idService);
    }
}
