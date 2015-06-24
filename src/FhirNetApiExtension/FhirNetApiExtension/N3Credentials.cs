using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FhirNetApiExtension
{
    public class N3Credentials
    {
        public N3Credentials(string token)
        {
            Token = token;
        }

        public string Token { get; set; }

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>
        /// A string that represents the current object.
        /// </returns>
        public override string ToString()
        {
            return string.Format("N3 {0}", Token);
        }
    }
}
