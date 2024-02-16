namespace WebApiCourse6_7.Services
{
    public class CloudMailService : IlMailService
    {
        private readonly string _mailTo;
        private readonly string _mailFrom;

        public CloudMailService(IConfiguration config)
        {
            _mailTo = config["mailSettings:mailToAdress"];
            _mailFrom = config["mailSettings:mailFromAdress"];
        }

        public void Send(string subject, string message)
        {
            // only console output sending
            Console.Write($"Mail from {_mailFrom} to {_mailTo}" +
                $"with {nameof(CloudMailService)}.");
            Console.WriteLine($"Subject: {subject}");
            Console.WriteLine($"Message: {message}");
        }
    }
}
