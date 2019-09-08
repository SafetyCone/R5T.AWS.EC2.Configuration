using System;

using Microsoft.Extensions.Configuration;

using R5T.Rivet.Configuration;


namespace R5T.AWS.EC2.Configuration
{
    public static class IConfigurationBuilderExtensions
    {
        /// <summary>
        /// Uses the default AWS EC2 server secrets JSON file name (<see cref="Constants.AwsEc2ServerSecretsJsonFileNameValue"/>).
        /// </summary>
        public static IConfigurationBuilder AddAwsEc2ServerSecretsJsonFile(this IConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.AddAwsEc2ServerSecretsJsonFile(Constants.AwsEc2ServerSecretsJsonFileNameValue);

            return configurationBuilder;
        }

        /// <summary>
        /// Allows specifying the AWS EC2 server secrets JSON file name to use.
        /// </summary>
        public static IConfigurationBuilder AddAwsEc2ServerSecretsJsonFile(this IConfigurationBuilder configurationBuilder, string fileName)
        {
            configurationBuilder.AddSecretJsonFile(fileName);

            return configurationBuilder;
        }
    }
}
