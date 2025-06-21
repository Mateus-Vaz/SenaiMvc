using System.ComponentModel.DataAnnotations;

namespace SenaiMvc.Models.Escola
{
    public class EnderecoModel
    {
        public long? Id { get; set; }

     [Required(ErrorMessage = "O campo Estado é obrigatório."),MaxLength(2)]
        public string Estado { get; set; }

        [Required(ErrorMessage = "O campo Rua é obrigatório.")]
        public string Rua { get; set; }

        [Required(ErrorMessage = "O campo Bairro é obrigatório.")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "O campo Cidade é obrigatório.")]

        public string Cidade { get; set; }

        [Required (ErrorMessage = "O campo Numero é obrigatório.")]
      
        public int? Numero { get; set; }

    }
}
