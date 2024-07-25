using TodoListAPI.Domain.Entities;

namespace TodoListAPI.Application.DTOs
{
    public class CreateTodoDTO
    {
        public string Title { get; set; }
        public bool Completed { get; set; }

        public Todo MapToEntity()
        {
            return new Todo()
            {
                Title = this.Title,
                Completed = this.Completed,
                CreatedAt = DateTime.UtcNow
            };
        }
    }
}
