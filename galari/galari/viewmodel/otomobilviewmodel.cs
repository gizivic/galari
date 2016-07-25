using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace galari.viewmodel
{
    public class otomobilviewmodel
    {

        [Required(ErrorMessage = "bu alan bos bırakılamaz")]
        public string otomobilmarkasi { get; set; }


        [Required(ErrorMessage = "bu alan bos bırakılamaz")]
        public int müsteriID { get; set; }


        [Required(ErrorMessage = "bu alan bos bırakılamaz")]
        public int OtoID { get; set; }

        [Required(ErrorMessage = "bu alan bos bırakılamaz")]
        public bool satis { get; set; }
    }
}