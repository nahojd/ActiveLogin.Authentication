using ActiveLogin.Identity.Swedish;

namespace ActiveLogin.Authentication.BankId.Core.Models;

public class BankIdFlowOptions
{
    public BankIdFlowOptions(
        List<string> certificatePolicies,
        bool sameDevice,
        bool requirePinCode,
        bool requireMrtd,
        PersonalIdentityNumber? requirePersonalNumber = null)
    {
        CertificatePolicies = certificatePolicies;
        SameDevice = sameDevice;
        RequirePinCode = requirePinCode;
        RequireMrtd = requireMrtd;
        RequirePersonalNumber = requirePersonalNumber;
    }

    public List<string> CertificatePolicies { get; }

    public bool SameDevice { get; }

    public bool RequirePinCode { get; }

    public bool RequireMrtd { get; }

    public PersonalIdentityNumber? RequirePersonalNumber { get; }

}
