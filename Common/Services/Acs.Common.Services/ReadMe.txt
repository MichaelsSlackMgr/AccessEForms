

Regions in XAML:
    <!--#region  Some block of UI-->
    ... heaps of markup
    <!--#endregion  Some block of UI-->



API Documentation for E-Signature:
    https://accessefm.sharepoint.com/sites/CraftLogicProjects/_layouts/15/WopiFrame2.aspx?sourcedoc=%7B2284C60E-0C76-4164-BAAA-0406AFEC2788%7D&file=Passport%20Web%20API%20-%20E-Signature%20Mobile.docx&action=default

The API endpoints are version 2.0 of the Passport Mobile Web API. 

All endpoints will follow the construct /api/v2.0/mobile/{endpointName} 

(e.g. https://passport-api.accessefm.com/api/v2.0/mobile/{endpointName}/{endpointParams})



Calls:

AuthenticationRequest
    Post
    /mobile/account

Authentication Request Status

    Enum Name: AuthenticationStatus

    Description: Base class inherited by all Rest Result Entities

    Namespace Acs.Mobile.API.Enumerations

    Values

    Name Value Description

    Success 0 The authentication attempt was successful.

    InvalidUnOrPwd 1 Device ID and Device Authorization Token are valid, but the domain, username and/or password is not.

    InvalidDeviceID 2 The device identifier sent in the request is invalid or the device is not registered.

    InvalidAuthorizationToken 3 The Device’s Authorization token has expired or is invalid.


Patient
    GET
    /mobile/esig/patient/{patientID}


    Class Name: GetPatientResult

    Description: The GetPatientResult class is returned from the Get Patient API method

    Namespace Acs.Mobile.API.Entities

    Properties

    Name Type Required Default Value Description

    Success bool yes False Determines if the API call was successful.

    Error String No n/a If the call was not successful, this will contain the reason.

    FirstName String Yes n/a Patient’s First Name

    LastName String Yes n/a Patient’s Middle Name

    DOB String Yes n/a Patient’s DOB

    AccountNumber String Yes n/a Patient’s Account Number

