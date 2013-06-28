using System.Collections.Generic;

namespace PayPal.OpenIDConnect
{
    public class CreateFromRefreshTokenParameters
    {
        /// <summary>
        /// Scope used in query parameters
        /// </summary>
        private const string Scope = "scope";

        /// <summary>
        /// Grant Type used in query parameters
        /// </summary>
        private const string GrantType = "grant_type";

        /// <summary>
        /// Refresh Token used in query parameters
        /// </summary>
        private const string RefreshToken = "refresh_token";

        public CreateFromRefreshTokenParameters()
        {
            ContainerMap = new Dictionary<string, string>();
            ContainerMap.Add(GrantType, "refresh_token");
        }

#if NET_2_0
        /// <summary>
        /// Backing map
        /// </summary>
        private Dictionary<string, string> MapContainer;

        /// <summary>
        /// Backing map
        /// </summary>
        public Dictionary<string, string> ContainerMap
        {
            get
            {
                return this.MapContainer;
            }
            set
            {
                this.MapContainer = value;
            }
        }
#else
        /// <summary>
        /// Backing map
        /// </summary>
        public Dictionary<string, string> ContainerMap
        {
            get;
            set;
        }
#endif
        /// <summary>
        /// Set the scope
        /// </summary>
        /// <param name="scope"></param>
        public void SetScope(string scope)
        {

#if NET_2_0
            MapContainer.Add(Scope, scope);
#else
            ContainerMap.Add(Scope, scope);
#endif
        }

        /// <summary>
        /// Set the Grant Type
        /// </summary>
        /// <param name="grantType"></param>
        public void SetGrantType(string grantType)
        {
            ContainerMap.Add(GrantType, grantType);
        }

        /// <summary>
        /// Set the Refresh Token
        /// </summary>
        /// <param name="refreshToken"></param>
        public void SetRefreshToken(string refreshToken)
        {
            ContainerMap.Add(RefreshToken, refreshToken);
        }
    }

}