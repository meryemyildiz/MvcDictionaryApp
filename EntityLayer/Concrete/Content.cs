using System;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Content
    {
        [Key]
        public int ContentId { get; set; }
        [StringLength(1000)]
        public string ContentValue { get; set; }

        public DateTime ContentDate { get; set; }
        //başlık
        //yazar  ilişkili old.için sonra ele alacağız..

        public bool ContentStatus { get; set; }
        public int HeadingId { get; set; }
        public virtual Heading Heading { get; set; }

       public int? WriterId { get; set; }  //ıd null olabilir demektir
       public virtual Writer Writer { get; set; }
    }
}
