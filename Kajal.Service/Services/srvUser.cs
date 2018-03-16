using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kajal.DB;
using FbManager.Models;

namespace Kajal.Service
{
    public class srvUser : BaseService<User>, IBaseService<User>
    {
        public User GetUserByFbId(string FbId)
        {
            using (Context c = new Context())
            {
                return c.Users.Where(m => m.FbId == FbId && m.IsActive == true && m.IsDeleted == false).FirstOrDefault();
            }
        }

        public User FbDataSave(FacebookUser FbData)
        {
            DB.User userDB = null;
            userDB = GetUserByFbId(FbData.FbId);

            if (userDB == null)
            {
                userDB = new DB.User();
                userDB.FbId = FbData.FbId;
                userDB.CreateDate = DateTime.Now;
            }
            userDB.Name = FbData.Name;
            userDB.FirstName = FbData.FirstName;
            userDB.LastName = FbData.LastName;
            userDB.Gender = FbData.Gender;
            userDB.Email = FbData.Email;
            userDB.Locale = FbData.Locale;
            userDB.PictureUrl = FbData.PictureUrl;
            userDB.UserName = "";// FbData.Username;
            userDB.Birthday = null;// FbData.Birthday;
            userDB.Link = FbData.Link;


            Save(userDB);

            return userDB;

        }

    }
}
