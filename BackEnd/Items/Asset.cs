using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.Items
{
    public class Asset
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime RecivingDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public string InvoiceNubmer {  get; set; }
        public DateTime InvoiceDate {  get; set; }
        public double Value {  get; set; }

    }
}
