using System.ComponentModel.DataAnnotations;

namespace SNTApiV.Model
{
    public class Роль
    {
        [Key]
        public int IDРоль {  get; set; }
        public string Название_роли {  get; set; }
    }
}
