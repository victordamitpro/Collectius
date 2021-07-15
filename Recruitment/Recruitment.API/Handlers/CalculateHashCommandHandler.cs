using CommandQuery;
using Recruitment.API.Helpers;
using Recruitment.Contracts.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recruitment.API.Handlers
{
    public class CalculateHashCommandHandler : ICommandHandler<CalculateHashCommand, CalculateHash>
    {
        public CalculateHashCommandHandler()
        {
        }

        public async Task<CalculateHash> HandleAsync(CalculateHashCommand command)
        {

            var result = new CalculateHash { Data = Md5Helper.MD5Hash(string.Format("{0}{1}", command.Login, command.PassWord)) };

            return await Task.FromResult(result);
        }
    }
}
