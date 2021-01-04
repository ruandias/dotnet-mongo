using Api.Data.Collections;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace Api.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class CuradoController : ControllerBase
  {
    Data.MongoDB _mongoDB;
    IMongoCollection<Infectado> _curadosCollection;

    public CuradoController(Data.MongoDB mongoDB)
    {
      _mongoDB = mongoDB;
      _curadosCollection = _mongoDB.DB.GetCollection<Infectado>(typeof(Infectado).Name.ToLower());
    }

    [HttpGet]
    public ActionResult ObterCurados()
    {
      var curados = _curadosCollection.Aggregate()
    .Match(infectado => infectado.Covid19 == false)
    .ToList();

      return Ok(curados);

    }

  }
}
