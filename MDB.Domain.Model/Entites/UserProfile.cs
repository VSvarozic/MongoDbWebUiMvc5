using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDB.Domain.Model.Entites
{
    [Table("UserProfile")]
    public class UserProfile : Entity
    {
        public string UserName { get; set; }
    }
}
