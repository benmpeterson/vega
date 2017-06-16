using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace vega.Models
{
    public class ModelResource
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}