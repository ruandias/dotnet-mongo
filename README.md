<h2 align="center">API Coronavirus</h2>

___




<h3 align="center">
  <a href="#about">Sobre</a>&nbsp;|&nbsp;
  <a href="#reason">Motivo</a>&nbsp;|&nbsp;
  <a href="#requirements">Requisitos</a>&nbsp;|&nbsp;
  <a href="#technologies">Tecnologias</a>&nbsp;|&nbsp;
	<a href="#references">Referências</a>&nbsp;|&nbsp;
</h3>

___


<h2 id="about">🔎 Sobre</h2>

É uma API desenvolvida em .NET Core.

Para teste:

Método POST

https://localhost:5001/infectado

Exemplo para inserir um infectado:

```json
{
   "dataNascimento":"1994-03-24",
   "sexo":"M",
   "COVID19":true,
   "latitude":-23.5630994,
   "longitude":-46.6565712
}
```
Método GET Curados

https://localhost:5001/Curado

Exemplo de retorno:
```
[
   {
      "covid19":false,
      "codigoPaciente":"bd07a",
      "dataNascimento":"15/7/1994",
      "sexo":"F",
      "localizacao":{
         "values":[
            -46.6565712,
            -23.5630994
         ],
         "longitude":-46.6565712,
         "latitude":-23.5630994
      }
   }
]
```

OBS: é preciso ter que configurar o acesso ao banco no appsettings. 

**Passo a Passo:** Ir até o seu cluster criado, pegar a connectionString e colocar dentro do appsettings.json;

<h2 id="reason">🎯 Motivo</h2>

O objetivo aqui é desenvolver uma API, utilizando .NET Core integrada a um cluster MongoDB, usando o service cloud Mongo Atlas. Assim, praticar e comprovar minhas habilidades desenvoldidas durante o Bootcamp FullStack da Avanade, que foi proposta através da DigitalinnovationOne.

<h2 id="requirements">⚙ Requisitos</h2>

git clone ou baixar esse repositório, depois disso:

```bash
dotnet clean
dotnet build
dotnet run
```
E utilizar uma ferramenta, como o Postman, para realizar requisições HTTP. 😊

<h2 id="technologies">🚀 Tecnologias</h2>

O projeto foi desenvolvido em:

- .NET Core 3.1
- MongoDB Atlas


<h2 id="references">📚 Referências</h2>

https://docs.mongodb.com/

https://docs.mongodb.com/manual/

https://docs.mongodb.com/ecosystem/drivers/csharp/

https://docs.atlas.mongodb.com/

-----------------------------------------------
Links Uteis:

- .net core - https://dotnet.microsoft.com/download

- visual code - https://code.visualstudio.com/download

- postman - https://www.postman.com/downloads/

- mongo atlas - https://www.mongodb.com/cloud/atlas/register
