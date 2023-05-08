using MMORPG.Game.Service.Application.UseCases.Base.Responses.Base;
using MMORPG.Game.Service.Domain.Interfaces.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMORPG.Game.Service.Application.UseCases.Base.Commands
{
    public class CommandHandler
    {
        private ApiResponse ApiResponse = new ApiResponse();

        public async Task<ApiResponse> PersistDataAsync(IUnitOfWork unitOfWork, Action createEvents)
        {
            try
            {
                var resultSave = await unitOfWork.SaveChangesAsync(createEvents);
                if (resultSave)
                {
                    return ApiResponse;
                }
                else
                {
                    ApiResponse.AppendMessage("Error in persist data!");
                    return ApiResponse;
                }
            }
            catch (Exception ex)
            {
                ApiResponse.AppendMessage(ex.Message);
                return ApiResponse;
            }
        }
    }
}
