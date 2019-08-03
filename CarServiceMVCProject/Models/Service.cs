using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarServiceMVCProject.Models
{
    public class Service
    {
       
            public int Id { get; set; }
        [Required(ErrorMessage = "Please Enter Miles")]
        public int Miles { get; set; }
        [Required(ErrorMessage = "Please Enter Price")]
        public int Price { get; set; }
        [Required(ErrorMessage = "Please Enter Details")]
        public string Details { get; set; }
        [Required(ErrorMessage = "Please Enter Date")]
        public DateTime DateAdded { get; set; }
        [Required(ErrorMessage = "Please Enter ServiceType")]
        public ServiceType ServiceType { get; set; }
        [Required(ErrorMessage = "Please Enter ServiceTypeId")]
        public int ServiceTypeId { get; set; }

            public Car Car { get; set; }
            public int CarId { get; set; }
        
    }
}