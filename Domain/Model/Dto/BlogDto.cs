using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace yzn_web.Domain.Model.Dto
{
    public class BlogDto
    {
        public string Topic { get; set; } = string.Empty;

        public string Summary { get; set; } = string.Empty;

        public string Text { get; set; } = string.Empty;
    }
}