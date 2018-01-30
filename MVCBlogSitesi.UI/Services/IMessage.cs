namespace MVCBlogSitesi.UI.Services
{
    public interface IMessage
    {
        bool SendMessage(string subject, string message);
    }
}
