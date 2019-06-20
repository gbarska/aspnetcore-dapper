using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIIndicadores
{
     
    public class IndicadoresController : Controller
    {

    [Route("v1/[controller]/{id}")]
    [HttpGet]
   public Indicador Get(
            [FromServices]IndicadoresDAO indicadoresDAO,
            string id)
    {
        return indicadoresDAO.Obter(id);
    }

    }
}