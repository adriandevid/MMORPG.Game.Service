namespace MMORPG.Game.Service.Application.UseCases.Base.Responses.Base
{
    public class ApiResponse
    {
        public object Data { get; set; }
        private string[] Messages { get; set; }
        public bool IsValid => Messages == null;

        public void AppendMessage(string message)
        {
            Messages.Append(message);
        }
    }
}
