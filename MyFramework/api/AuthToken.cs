using System;
using System.Net.Http;

namespace MyFramework.api {
    public class AuthToken{
        private string token;

        public AuthToken(string _token){
            token = _token;
        }

        public void setToken(string _token){
            token = _token;
        }

        public string getToken(){
            return token;
        }

        public void addAuthToken(HttpRequestMessage _apiRequestBundle){
            if (token == null || token.Trim().Equals("")) {
                throw new NullReferenceException("Auth token can't be null or empty.");
            }

            _apiRequestBundle.Headers.Add("Authorization", "Bearer " + token);
        }

        public bool isAuthenticated(){
            if (token == null || token.Trim().Equals("")){
                return false;
            }
            else{
                return true;
            }
        }
    }
}
