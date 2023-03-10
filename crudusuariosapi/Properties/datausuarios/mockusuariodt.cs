using crudusuariosapi.Properties.datausuarios.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crudusuariosapi.Properties.datausuarios
{
    public class mockusuariodt : Interfdatausuario
    {
        public usuarios addusuarios(usuarios usuarios)
        {
            throw new NotImplementedException();
        }

        public usuarios deleteusuarios(usuarios usuarios)
        {
            throw new NotImplementedException();
        }

        public usuarios editusuarios(usuarios usuarios)
        {
            throw new NotImplementedException();
        }

        public List<usuarios> GetUsuarios()
        {
            throw new NotImplementedException();
        }

        public usuarios GetUsuarios(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
