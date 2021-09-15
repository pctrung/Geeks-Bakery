using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksBakery.Utilities.SystemConstants
{
    public class SystemConstants
    {
        public const string MAIN_CONNECTION_STRING = "GeeksBakeryDb";
        public const string DEFAULT_AVATAR_URL = "/user-content/default-avatar.png";
        public const string DEFAULT_CAKE_IMAGE_URL = "/user-content/default-cake.png";
        public const string DEFAULT_CAKE_IMAGE_CAPTION = "Cake Image";
        public const string DEFAULT_AVATAR_CAPTION = "Avatar image";

        public class AppSettings
        {
            public const string Token = "Token";
            public const string ApiAddress = "ApiAddress";
            public const string ImageUrl = "https://localhost:5001/user-content";
        }
    }
}