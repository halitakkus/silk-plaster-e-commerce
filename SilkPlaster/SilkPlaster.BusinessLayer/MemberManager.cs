using SilkPlaster.DataAccessLayer.EntityFramework;
using SilkPlaster.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilkPlaster.BusinessLayer
{
    public class MemberManager
    {
        DatabaseContext _context = new DatabaseContext();

        public List<Member> GetAllMember()
        {
            return _context.Members.ToList();
        }
    }
}
