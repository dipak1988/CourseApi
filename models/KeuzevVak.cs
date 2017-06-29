using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{


    public class KeuzevVak
    {

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        public string code { get; set; }
        public string title { get; set; }
        public int credits { get; set; }

    }
}
