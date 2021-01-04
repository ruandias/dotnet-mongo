using System;
using Api.Data.Enums;
using MongoDB.Driver.GeoJsonObjectModel;

namespace Api.Data.Collections 
{
  public class Curado : Paciente
  {
    public Curado(
    string codigoPaciente,
    DateTime dataNascimento,
    ESexo sexo,
    bool covid19,
    double latitude,
    double longitude
    )
    {
      this.CodigoPaciente = GerarId(codigoPaciente);
      this.DataNascimento = FormatarDataNascimento(dataNascimento);
      this.Covid19 = covid19;
      this.Localizacao = new GeoJson2DGeographicCoordinates(longitude, latitude);
    }
    public bool Covid19 { get; set; }
  }
}