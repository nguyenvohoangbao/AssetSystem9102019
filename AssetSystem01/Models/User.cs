using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AssetSystem01.Models
{
    public class User
    {
        [Key]
        public int ID_User { set; get; }
        public string Name { get; set; }
        public string UserName { set; get; }
        public string PassWord { set; get; }
        

    }
}
