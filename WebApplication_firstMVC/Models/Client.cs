using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplication_firstMVC.Models
{
    public class Client
    {
        public int Id { get; set; }
        [DisplayName("Client Name")]// amend column header display name
        public string Name { get; set; }
        public string WebSite { get; set; }
        [DisplayName("Company Logo")]// amend column header display name
        public string URL{ get; set; }
        public string ServiceCenter { get; set; }
    }
}
