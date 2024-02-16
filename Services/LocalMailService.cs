namespace WebApiCourse6_7.Services
{
    public class LocalMailService
    {
        private string _mailTo = "mstr.m.zx@gmail.com";
        private string _mailFrom = "someonesdfsdfg@gmail.com";

        public void Send(string subject, string message)
        {
            // only console output sending
            Console.Write($"Mail from {_mailFrom} to {_mailTo}" +
                $"with {nameof(LocalMailService)}.");
            Console.WriteLine($"Subject: {subject}");
            Console.WriteLine($"Message: {message}");
        }
    }
}
