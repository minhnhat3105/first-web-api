using System.Text.Json.Serialization;

namespace FirstWebAPI.API.Models
{
    public class ToDoItem
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        [JsonPropertyName("is_complete")]
        public bool IsComplete { get; set; }
    }
}
