using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp.Authenticators;

namespace MyFramework.rest {
    public class JWTAuthentication : JwtAuthenticator {
        public JWTAuthentication(string accessToken) : base(accessToken){ }

        
    }
}
