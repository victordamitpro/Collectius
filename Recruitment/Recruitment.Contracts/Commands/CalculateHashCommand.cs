using CommandQuery;

namespace Recruitment.Contracts.Commands
{
    public class CalculateHashCommand : ICommand<CalculateHash>
    {
        public string Login { get; set; }
        public string PassWord { get; set; }
    }

    public class CalculateHash
    {
        public string Data { get; set; }
    }
}
