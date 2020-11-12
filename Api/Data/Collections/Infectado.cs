using System;
using MongoDB.Driver.GeoJsonObjectModel;

namespace Api.Data.Collections
{
  public class Infectado
  {
    public Infectado(
    string codigoPaciente,
    DateTime dataNascimento,
    string sexo,
    bool covid19,
    double latitude,
    double longitude
    )
    {
      this.CodigoPaciente = GerarId(codigoPaciente);
      this.DataNascimento = dataNascimento;
      this.Sexo = sexo;
      this.Covid19 = covid19;
      this.Localizacao = new GeoJson2DGeographicCoordinates(longitude, latitude);
    }

    public string CodigoPaciente { get; set; }
    public DateTime DataNascimento { get; set; }
    public string Sexo { get; set; }
    public bool Covid19 { get; set; }
    public GeoJson2DGeographicCoordinates Localizacao { get; set; }

    private string GerarId(string id)
    {
      id = Guid.NewGuid().ToString("N").Substring(0, 5); ;
      return id;
    }
  }
}