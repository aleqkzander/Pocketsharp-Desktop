namespace Pocketsharp_Desktop.Objects
{
    public class UserMessage
    {
        public string? Name { get; set; }
        public string? Message { get; set; }

        public UserMessage(string Name, string Message) 
        {
            this.Name = Name;
            this.Message = Message;
        }
    }
}
