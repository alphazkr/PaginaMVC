using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Practica2.Models.Entity;

namespace Practica2
{
    public class UsuarioServices
    {
        public List<usuario> mostrarUsuarios()
        {
            var lst = new List<usuario>();
            using (Model1 db = new Model1())
            {
                lst = db.usuario
                    .OrderBy(x=> x.cNombre)
                    .ToList();

                //lst = (
                //    //from d in db.usuario
                //    //   select new usuario{cnombre= d.cnombre}
                //       ).tolist();
            }
            return lst;
        }

    

    }
}