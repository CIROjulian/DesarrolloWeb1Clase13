using DesarrolloWeb1Clase13.Dto;
using DesarrolloWeb1Clase13.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesarrolloWeb1Clase13.Service
{
    public class EstudianteService
    {
        desarrolloEntities db = new desarrolloEntities();
        public HobiesByStudentId GetHobbiesByStudentId(string StudentId)
        {
            HobiesByStudentId hobbiesByStudentId = new HobiesByStudentId();
            var datosEstudiante = db.estudiente.Where(est => est.identificacion.Equals(StudentId)).FirstOrDefault();
            var datosHobbiess = db.Hobbie
            .Join(db.EstudianteHobbie, h => h.codigo, eh => eh.codigoHobbie, (h, eh) => new { h, eh })
            .Where(joined => joined.eh.identificacion == StudentId)
            .Select(joined => joined.h)
            .ToList();

            hobbiesByStudentId.nombre = datosEstudiante.nombre;
            hobbiesByStudentId.apellido = datosEstudiante.apellido;
            hobbiesByStudentId.celular = "NA";
            hobbiesByStudentId.gmail = datosEstudiante.gamil;
            hobbiesByStudentId.hobbies = (from h in datosHobbiess
                                          select new HobbiesDto
                                          {
                                              codigo = h.codigo,
                                              nombre = h.nombre,
                                          }).ToList();

            return hobbiesByStudentId;
        }
    }
}