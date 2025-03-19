using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesarrolloWeb1Clase13.Dto
{
    public class HobiesByStudentId
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string gmail { get; set; }
        public string celular { get; set; }
        public virtual List<HobbiesDto> hobbies { get; set; }
    }
}