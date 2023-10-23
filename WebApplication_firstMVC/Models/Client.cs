using System.ComponentModel.DataAnnotations;

namespace WebApplication_firstMVC.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string WebSite { get; set; }
        public string URL{ get; set; }
        public string ServiceCenter { get; set; }
    }
}
