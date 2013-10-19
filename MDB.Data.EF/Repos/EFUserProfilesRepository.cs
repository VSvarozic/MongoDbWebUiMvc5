using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MDB.Domain.Model.Abstract;

namespace MDB.Data.EF.Repos
{
    public class EFUserProfilesRepository : IUserProfilesRepository
    {
        public int Id { get; set; }

        public EFUserProfilesRepository()
        {
            Id = 200;
        }
    }
}
