using System;
using System.Globalization;
using MongoDB.Driver.GeoJsonObjectModel;

namespace Api.Data.Collections 
{
  public abstract class Paciente 
  {
    public string CodigoPaciente { get; set; }

    public String DataNascimento { get; set; }

    public string Sexo { get; set; }

    public GeoJson2DGeographicCoordinates Localizacao { get; set; }

    public string GerarId(string id)
    {
      id = Guid.NewGuid().ToString("N").Substring(0, 5);

      return id;
    }

    public string FormatarDataNascimento(DateTime datetime)
    {
      string data = datetime.ToString("dd/M/yyyy", CultureInfo.InvariantCulture);

      return data;
    }
  }
}
