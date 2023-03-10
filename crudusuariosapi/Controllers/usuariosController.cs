
using Microsoft.AspNetCore.Mvc;
using crudusuariosapi;

namespace crudusuariosapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class usuariosController : ControllerBase
    {

        private Interfdatausuarios _datausuarios;
        public usuariosController (Interfdatausuarios datausuarios )
        {
            _datausuarios = datausuarios;
        }

    }

}
