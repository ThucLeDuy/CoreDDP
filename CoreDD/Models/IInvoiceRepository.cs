using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDD.Models
{
    public interface IInvoiceRepository
    {
        IEnumerable<Invoice> GetAllInvoices();

        Invoice GetInvoiceByID(int id);

        bool CheckExistInvoice(int id);

        bool DeleteInvoiceByID(int id);

        // will delete all invoice if have same date time
        bool DeleteInvoicesByDatetime(DateTime invoiceDate);

        bool DeleteInvoicesByEmployee(DateTime invoiceDate);

        bool AddInvoice(Invoice invoice);

        bool UpdateInvoice(Invoice invoice);
        
    }
}
