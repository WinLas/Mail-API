

namespace Mail_API.Models.Db
{
    public class AttachmentFiles
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Data { get; set; }
        public int MailId { get; set; }
    }
}
