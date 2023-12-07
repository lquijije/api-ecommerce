using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_ecommerce.Models;
public class tb_productos {
    public int it_id  {get;set;}
    public string? it_descripcion  {get;set;}
    public decimal it_precio { get; set; }
    public Boolean it_estado { get; set; }
    public string? it_detalle  {get;set;}
    public string? it_imagen  {get;set;}
}