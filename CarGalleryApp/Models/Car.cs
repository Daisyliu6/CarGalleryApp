using CarGalleryApp.CustomAttributes;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;


namespace CarGalleryApp.Models
{
    public class Car
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Brand")]
        [Required]
        public string Brand { get; set; }

        [BsonElement("Model")]
        [Required]
        public string Model { get; set; }

        [BsonElement("Year")]
        [Required]
        [YearRange] // YearRange is a custome attribute that allows only a valid range for the Year property
        public int Year { get; set; }

        [BsonElement("Price")]
        [Display(Name = "Price($)")]
        [DisplayFormat(DataFormatString = "{0:#,0}")]
        public decimal Price { get; set; }

        [BsonElement("ImageUrl")]
        [Display(Name = "Photo")]
        [DataType(DataType.ImageUrl)]
        [Required]
        public string ImageUrl { get; set; }
    }
}
