using IdentityModel;
using IdentityModel.Client;
using Microsoft.IdentityModel.Tokens;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.OpenSsl;
using Org.BouncyCastle.Security;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;

namespace GerarAssertion
{
    public class GerarTokenAssertion
    {
        public static string GetAssertionToken(string clientId, string urlSso, string pathArquivo)
        {
            return CreateAssertionToken(clientId, urlSso, pathArquivo);
        }

        private static string CreateAssertionToken(string clientId, string urlSso, string pathArquivo)
        {
            var privatePem = File.ReadAllText(pathArquivo);
            var provider = ImportPrivateKey(privatePem);
            var dateNow = DateTime.UtcNow;

            var token = new JwtSecurityToken(
                    clientId,
                    TreatUrl(urlSso),
                    new List<Claim>()
                    {
                        new Claim("jti", Guid.NewGuid().ToString()),
                        new Claim(JwtClaimTypes.Subject, clientId),
                        new Claim(JwtClaimTypes.IssuedAt, dateNow.ToEpochTime().ToString(), ClaimValueTypes.Integer64)
                    },
                    dateNow,
                    dateNow.AddHours(2),
                    new SigningCredentials(new RsaSecurityKey(provider.ExportParameters(true)),
                        SecurityAlgorithms.RsaSha256
                    )
                );

            var tokenHandler = new JwtSecurityTokenHandler();
            return tokenHandler.WriteToken(token);
        }

        private static RSACryptoServiceProvider ImportPrivateKey(string pem)
        {
            PemReader pr = new PemReader(new StringReader(pem));
            AsymmetricCipherKeyPair KeyPair = (AsymmetricCipherKeyPair)pr.ReadObject();
            RSAParameters rsaParams = DotNetUtilities.ToRSAParameters((RsaPrivateCrtKeyParameters)KeyPair.Private);

            RSACryptoServiceProvider csp = new RSACryptoServiceProvider();
            csp.ImportParameters(rsaParams);
            return csp;
        }

        private static string TreatUrl(string url)
        {
            var uri = new Uri(url);
            var urlSso = uri.GetLeftPart(UriPartial.Authority);
            return $"{urlSso}/connect/token";
        }
    }
}
