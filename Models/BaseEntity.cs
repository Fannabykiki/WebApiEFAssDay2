using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiEFAssDay1.Models
{
    public abstract class BaseEntity<T>
    {   
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public T? Id {get;set;}

    }
}