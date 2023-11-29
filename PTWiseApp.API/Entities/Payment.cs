using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTWiseApp.API.Entities
{
    public class Payment
    {
        [Key]
        public int Id { get; set; }
        public Client Client { get; set; } = new Client();
        public int ClientId { get; set; }
        public int Amount { get; set; }
        public DateTime Date { get; set; }
    }
}
