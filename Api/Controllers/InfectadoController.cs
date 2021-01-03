using Api.Data.Collections;
using Api.Models;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace Api.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class InfectadoController : ControllerBase
  {
    Data.MongoDB _mongoDB;
    IMongoCollection<Infectado> _infectadosCollection;

    public InfectadoController(Data.MongoDB mongoDB)
    {
      _mongoDB = mongoDB;
      _infectadosCollection = _mongoDB.DB.GetCollection<Infectado>(typeof(Infectado).Name.ToLower());
    }

    [HttpPost]
    public ActionResult SalvarInfectado([FromBody] InfectadoDto dto)
    {
      var infectado = new Infectado(dto.CodigoPaciente, dto.DataNascimento, dto.Sexo, dto.Covid19, dto.Latitude, dto.Longitude);

      _infectadosCollection.InsertOne(infectado);

      return StatusCode(201, $"Infectado adicionado com sucesso {infectado.CodigoPaciente}");
    }

    [HttpGet]
    public ActionResult ObterInfectados()
    {
      var infectados = _infectadosCollection.Find(Builders<Infectado>.Filter.Empty).ToList();

      return Ok(infectados);
    }

    [HttpPatch("{id}")]
    public ActionResult AtualizarInfectado(string id, [FromBody] InfectadoDto dto)
    {
      var filter = Builders<Infectado>.Filter.Eq("codigoPaciente", id);

      var update = Builders<Infectado>.Update.Set("covid19", dto.Covid19);

      _infectadosCollection.UpdateOne(filter, update);

      return Ok("Atualizado com sucesso!");
    }

    [HttpDelete("{id}")]
    public ActionResult DeletarInfectado(string id)
    {
      var deleteFilter = Builders<Infectado>.Filter.Eq("codigoPaciente", id);

      _infectadosCollection.DeleteOne(deleteFilter);

      return Ok("Deletado com sucesso!");
    }
  }
}
