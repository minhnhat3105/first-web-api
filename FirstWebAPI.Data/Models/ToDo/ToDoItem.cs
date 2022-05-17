using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FirstWebAPI.Data.Models.ToDo
{
    public class ToDoItem
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        [JsonPropertyName("is_complete")]
        public bool IsComplete { get; set; }
    }
}
