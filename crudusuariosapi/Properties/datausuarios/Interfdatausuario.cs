using crudusuariosapi.Properties.datausuarios.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crudusuariosapi.Properties.datausuarios
{
    interface Interfdatausuario 
    {
       List<usuarios> GetUsuarios();

        usuarios GetUsuarios(Guid id);

        usuarios addusuarios(usuarios usuarios);

        usuarios deleteusuarios(usuarios usuarios);

        usuarios editusuarios(usuarios usuarios);

    }
}
