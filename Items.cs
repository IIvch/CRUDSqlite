using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUDSqlite
{
    [Table("Items")]
    public class Items
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
