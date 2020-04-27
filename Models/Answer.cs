using System.ComponentModel.DataAnnotations;

namespace coolproject.Models
{
    public class Answer
    {
        [Key]
        public int AnswerId {get; set; }
        public int UserId {get; set; }
        public int newActivityId {get; set; }
    }
}