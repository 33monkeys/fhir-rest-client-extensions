using FhirNetApiExtension;
using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
using NUnit.Framework;

namespace FhirNetApiExtensions.Test
{
    [TestFixture]
    public class TestHttpHeadersFhirClient
    {
        [Test]
        public void Test_With_Credentials()
        {
            var client = new N3FhirClient("http://localhost:50883/fhir/", new N3Credentials("a24f04ec-dbe0-4cdf-a87f-a6c1d98bfa49"));
            var patien = client.Read<Patient>("Patient/70a93a3d-81a5-4c71-aa39-c64db67ec714");

            Assert.That(patien, Is.Not.Null);
            Assert.That(patien.Id, Is.Not.Null.Or.Empty);
        }

        [Test]
        [ExpectedException]
        public void Test_Without_Credentials()
        {
            var client = new N3FhirClient("http://localhost:50883/fhir/", new N3Credentials(""));
            client.Read<Patient>("Patient/70a93a3d-81a5-4c71-aa39-c64db67ec714");
        }
    }
}
