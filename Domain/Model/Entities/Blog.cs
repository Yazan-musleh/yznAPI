using System.ComponentModel.DataAnnotations;

namespace yzn_web.Domain.Model.Entities
{
    public class Blog
    {
        public int Id { get; set; }

        public string Topic { get; set; } = string.Empty;

        public string Summary { get; set; } = string.Empty;

        public string Text { get; set; } = string.Empty;
    }
}