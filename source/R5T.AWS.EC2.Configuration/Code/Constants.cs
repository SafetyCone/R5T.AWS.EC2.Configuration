using System;

using R5T.NetStandard.IO.Paths;
using R5T.NetStandard.IO.Paths.Extensions;


namespace R5T.AWS.EC2.Configuration
{
    public static class Constants
    {
        public const string AwsEc2ServerSecretsJsonFileNameValue = "AwsEc2ServerSecrets.json";
        public static readonly FileName AwsEc2ServerSecretsJsonFileName = Constants.AwsEc2ServerSecretsJsonFileNameValue.AsFileName();
    }
}
