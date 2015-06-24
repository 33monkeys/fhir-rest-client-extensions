using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Hl7.Fhir.Rest;

namespace FhirNetApiExtension
{
    /// <summary>
    /// Netrika Fhir Client
    /// </summary>
    public class N3FhirClient : FhirClient
    {
        public N3Credentials N3Credentials { get; set; }

        public N3FhirClient(string endpoint, N3Credentials credentials) : base(endpoint)
        {
            N3Credentials = credentials;
        }

        /// <summary>
        /// Inspect or modify the HttpWebRequest just before the FhirClient issues a call to the server
        /// </summary>
        /// <param name="rawRequest">The request as it is about to be sent to the server</param>
        protected override void BeforeRequest(HttpWebRequest rawRequest)
        {
            rawRequest.Headers.Add(HttpRequestHeader.Authorization, N3Credentials.ToString());
            base.BeforeRequest(rawRequest);
        }
    }
}
