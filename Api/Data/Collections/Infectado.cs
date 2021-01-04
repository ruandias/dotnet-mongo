using System;
using MongoDB.Driver.GeoJsonObjectModel;

namespace Api.Data.Collections
{
  public class Infectado : Paciente
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
      this.DataNascimento = FormatarDataNascimento(dataNascimento);
      this.Sexo = sexo;
      this.Covid19 = covid19;
      this.Localizacao = new GeoJson2DGeographicCoordinates(longitude, latitude);
    }

    public bool Covid19 { get; set; }

  }
}