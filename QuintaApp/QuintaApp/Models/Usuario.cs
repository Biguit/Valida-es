using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuintaApp.Models
{
    public class Usuario
    {
        public int UsuId { get; set; }
        [Required (ErrorMessage = "O nome é obrigatório")] //Professor, tentei de todas as maneiras colocar validação, porám nenhuma delas deu certo, e eu n vi motivo para nenhuma delas falharem, por isso, deixarei assim mesmo
        public string UsuNome { get; set; }
        [Required(ErrorMessage = "O nome é obrigatório")]
        public string UsuObs { get; set; }
        public DateTime UsuNasc { get; set; }
        public string UsuEmail { get; set; }
        public string UsuLogin { get; set; }
        public string UsuSenha { get; set; }
        public string UsuConfirmarSenha { get; set; }

    }
}