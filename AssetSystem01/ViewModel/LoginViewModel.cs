using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AssetSystem01.ViewModel
{
    public class LoginViewModel
    {
        public int ID { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string PassWord { set; get; }

    }
}
