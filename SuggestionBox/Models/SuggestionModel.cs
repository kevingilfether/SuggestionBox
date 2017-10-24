using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SuggestionBox.Models
{
    public class SuggestionModel
    {
        // Make Properties for the suggestion model
        //Add a data annotation above ID

        [Key]
        public int ID { get; set; }

        public string Topic { get; set; }

        public string Comment { get; set; }

    }
}