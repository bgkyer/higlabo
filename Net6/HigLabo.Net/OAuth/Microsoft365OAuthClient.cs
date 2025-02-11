﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HigLabo.Net.OAuth
{
    public class Microsoft365OAuthClient : OAuthClient
    {
        public Microsoft365OAuthClient(String clientID, String clientSecret)
            : base("https://login.microsoftonline.com/common/oauth2/v2.0/token", clientID, clientSecret)
        {

        }

        public override String CreateAuthorizeUrl(OAuthServiceProvider provider, String redirectUrl, String[] scopes)
        {
            return String.Format("https://login.microsoftonline.com/common/oauth2/v2.0/authorize?response_type=code"
                + "&client_id={0}&redirect_uri={1}&scope={2}&state={3}"
                , this.ClientID, redirectUrl, WebUtility.UrlEncode(String.Join(" ", scopes))
                , new Random().Next(0, 100000));
        }
        public override async Task<OAuthTokenGetRequestResult> PostCodeAsync(string code, string redirectUrl)
        {
            return await PostCodeAsync_Common(code, redirectUrl);
        }
        public async Task<OAuthTokenGetRequestResult> RefreshTokenAsync(String refreshToken, String redirectUrl, String[] scopes)
        {
            var cl = new HttpClient();
            var d = new Dictionary<String, String>();
            d["client_id"] = this.ClientID;
            d["client_secret"] = this.ClientSecret;
            d["grant_type"] = "refresh_token";
            d["refresh_token"] = refreshToken;
            d["scope"] = String.Join(" ", scopes);
            d["redirect_uri"] = redirectUrl;
            var res = await cl.PostAsync("https://login.microsoftonline.com/common/oauth2/v2.0/token", new FormUrlEncodedContent(d));
            var bodyText = await res.Content.ReadAsStringAsync();
            if (res.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<OAuthTokenGetRequestResult>(bodyText);
            }
            else
            {
                var ex = JsonConvert.DeserializeObject<RefreshTokenException>(bodyText);
                throw ex;
            }
        }
    }
}
