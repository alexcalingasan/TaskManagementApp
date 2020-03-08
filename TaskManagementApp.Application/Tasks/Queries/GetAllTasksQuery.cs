using MediatR;
using System.Collections.Generic;
using TaskManagementApp.Application.Tasks.Dto;

namespace TaskManagementApp.Application.Tasks.Queries
{
    public class GetAllTasksQuery: IRequest<List<TaskDto>>
    {
    }
}
