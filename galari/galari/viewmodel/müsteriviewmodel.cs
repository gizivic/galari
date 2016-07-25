using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace galari.viewmodel
{
    public class müsteriviewmodel
    {

        [Required(ErrorMessage = "bu alan bos bırakılamaz")]
        public string mAdi { get; set; }


        [Required(ErrorMessage = "bu alan bos bırakılamaz")]
         public string mSoyadi { get; set; }


        [Required(ErrorMessage = "bu alan bos bırakılamaz")]
         public int mOtoID { get; set; }

        [Required(ErrorMessage = "bu alan bos bırakılamaz")]
         public string mOtoadi { get; set; }
    }
}