using System;

using Microsoft.Extensions.Configuration;


namespace R5T.AWS.EC2.Configuration.Construction
{
    public static class Construction
    {
        public static void SubMain()
        {
            Construction.GetAwsEc2ServerSecretsFromConfiguration();
        }

        private static void GetAwsEc2ServerSecretsFromConfiguration()
        {
            var configuration = new ConfigurationBuilder()
                .AddAwsEc2ServerSecretsJsonFile()
                .Build()
                ;

            var awsEc2ServerSecrets = configuration.GetSection(nameof(AwsEc2ServerSecrets)).Get<AwsEc2ServerSecrets>();
        }
    }
}
