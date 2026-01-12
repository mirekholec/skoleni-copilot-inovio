using System.ComponentModel.DataAnnotations;

namespace Demolice.Demo01_Completions;

/// <summary>
/// DTO pro produkty ze sytému XY
/// </summary>
public class ProductDto
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required]
    public string Title { get; set; }

    [Required]
    [Range(0.01, double.MaxValue, ErrorMessage = "AJAJAJ")]
    public decimal Price { get; set; }

    [Required]
    public string CategoryName { get; set; }


    // Vrátí ID a titulek v podobě bez háčku a čárek s pomlčkami mezi slovy
    public string GetBasicInfo()
    {
        return $"{Id}-{Title.Replace(" ", "-").Replace("č", "c").Replace("ř", "r").Replace("ž", "z").Replace("á", "a").Replace("é", "e").Replace("í", "i").Replace("ó", "o").Replace("ú", "u").Replace("ů", "u")}";
    }
}