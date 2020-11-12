using System;

namespace Api.Models
{
  public class InfectadoDto
  {
    public string CodigoPaciente { get; set; }
    public DateTime DataNascimento { get; set; }
    public string Sexo { get; set; }
    public bool Covid19 { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }
  }
}