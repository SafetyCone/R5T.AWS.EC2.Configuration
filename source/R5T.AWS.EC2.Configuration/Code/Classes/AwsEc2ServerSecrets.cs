using System;

using R5T.NetStandard.Configuration;


namespace R5T.AWS.EC2.Configuration
{
    /// <summary>
    /// Secrets for logging into an AWS EC2 instance (for example, for SFTP).
    /// </summary>
    public class AwsEc2ServerSecrets : BasicAuthentication
    {
        public string Host { get; set; }
        public string PrivateKeyFilePath { get; set; }
    }
}
