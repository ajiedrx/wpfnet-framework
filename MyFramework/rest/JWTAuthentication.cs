using RestSharp.Authenticators;

namespace Velacro.rest {
    public class JWTAuthentication : JwtAuthenticator {
        public JWTAuthentication(string accessToken) : base(accessToken){ }

        
    }
}
