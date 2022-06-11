using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class About
    {
        [Key]
        public int AboutId { get; set; }
        [StringLength(1000)]
        public string AbotDetails1 { get; set; }
        [StringLength(1000)]
        public string AboutDetails2 { get; set; } //alacağımız temada iki farklı detay var. o yüzden iki farklı detail yazıyorum
        [StringLength(100)]
        public string AboutImage1 { get; set; }//Resimlerin dosya yolunu ekleyeceğim. direkt sunucuma atmayacagım 
        [StringLength(100)]
        public string AboutImage2 { get; set; }
    }
}
