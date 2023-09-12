using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders19Solid
{
    public class UserRepository
    {
        IdbContext db;
        public UserRepository(IdbContext dbContext)
        {
            db = dbContext;
        }
        public List<string> List()
        {
            return db.Listele();
        }
    }
}
