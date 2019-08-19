using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDD.Models
{
    public class InvoiceRepository : IInvoiceRepository
    {
        private readonly DBFoodContext _context;

        public bool AddInvoice(Invoice invoice)
        {
            try
            {
                _context.Invoices.Add(invoice);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool CheckExistInvoice(int id)
        {
            throw new NotImplementedException();
        }

        public bool DeleteInvoiceByID(int id)
        {
            try
            {
                var inv = _context.Invoices.Find(id);
                _context.Invoices.Remove(inv);

                _context.SaveChanges();
            }
            catch (Exception)
            {
                return false;

            }
            return true;
        }

        public bool DeleteInvoicesByDatetime(DateTime invoiceDate)
        {
            try
            {
                IEnumerable<Invoice> invoiceToDelete = _context.Invoices.Where(i => i.InvoiceDate == invoiceDate);
                _context.Invoices.RemoveRange(invoiceToDelete);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool DeleteInvoicesByEmployee(DateTime invoiceDate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Invoice> GetAllInvoices()
        {
            return _context.Invoices.ToList();
        }

        public Invoice GetInvoiceByID(int id)
        {
            return _context.Invoices.FirstOrDefault(i => i.Id == id);
        }

        public bool UpdateInvoice(Invoice invoice)
        {
            try
            {             
                _context.Invoices.Update(invoice);
                _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
    }
}
