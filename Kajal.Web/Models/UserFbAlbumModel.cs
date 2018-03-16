using FbManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Kajal.Web.App_Manager;

namespace Kajal.Web.Models
{
    public class UserFbAlbumModel : FacebookUserAlbum
    { 
        public string CoverPhotoUrl
        {
            get
            {
                return FbManager.Helpers.UrlHelper.GetAlbumPhotoCoverUrl(this.CoverPhoto, SessionManager.GetInstance().FbAccessToken);
            }
        }

    }
}