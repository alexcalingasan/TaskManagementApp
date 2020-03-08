using MediatR;
using TaskManagementApp.Application.Tasks.Dto;

namespace TaskManagementApp.Application.Tasks.Queries
{
    public class GetTaskByIdQuery: IRequest<TaskDto>
    {
        public int Id { get; set; }
    }
}
