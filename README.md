# N3FhirClient
Extension for fhir-net-api RestClient.
Supports sending authorization headers for N3(Netrika) fhir services.

Example:
```
var fhirClient = new N3FhirClient(FhirSettings.Adress, new N3Credentials(FhirSettings.FhirGuid));
var sd = fhirClient.Read<StructureDefinition>(reference);
```
