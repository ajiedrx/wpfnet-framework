using System;
using System.Net.Http;

namespace Velacro.Api {
    public class AuthToken{
        private string token;

        internal AuthToken(string _token){
            token = _token;
        }
        
        internal void setToken(string _token){
            token = _token;
        }

        internal string getToken(){
            return token;
        }

        internal void addAuthToken(HttpRequestMessage _apiRequestBundle){
            if (token == null || token.Trim().Equals("")) {
                throw new NullReferenceException("Auth token can't be null or empty.");
            }

            _apiRequestBundle.Headers.Add("Authorization", "Bearer " + token);
        }

        internal bool isAuthenticated(){
            if (token == null || token.Trim().Equals("")){
                return false;
            }
            else{
                return true;
            }
        }
    }
}
