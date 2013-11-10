using System.Collections.Generic;
using Abp.Application.Services.Dto;

namespace Taskever.Application.Services.Dto.Tasks
{
    public class GetTasksByImportanceOutput : IOutputDto
    {
        public IList<TaskDto> Tasks { get; set; }
    }
}