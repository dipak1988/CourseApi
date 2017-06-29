using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class PropedeuseCourse
    {

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        public string code { get; set;}
        public string title { get; set; }
        public int credits { get; set; }

    }
}