using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestingConnection.Models
{
    public class ErrorEntity
    {
        [Key]
        public string Title { get; set; }
        public string TimeDate { get; set; }
        public int ErrorCode { get; set; }
        public string ErrorMsg { get; set; }
        public string StackTrace { get; set; }
        public string ErrorLevel { get; set; }
        public string UserMsg { get; set; }
        public string UserEmail { get; set; }
    }
}
