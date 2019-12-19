using FourAsset.Domain.Models;
using FourAsset.Service.Api;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FourAsset.IntegrationTest
{
    public class TarefaAPITest
    {
        private readonly HttpClient _httpClient;

        public TarefaAPITest()
        {
            var server = new TestServer(new WebHostBuilder()
                .UseEnvironment("Development")
                .UseStartup<Startup>());
            _httpClient = server.CreateClient();
        }

        [Theory]
        [InlineData("GET")]
        public async Task TarefaGetAllTest(string method)
        {
            //Arrange
            var request = new HttpRequestMessage(new HttpMethod(method), "/api/Tarefas/");

            //Act
            var response = await _httpClient.SendAsync(request);

            //Assert
            response.EnsureSuccessStatusCode();
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Theory]
        [InlineData("GET", 4)]
        public async Task TarefaGetByIdTest(string method, int id)
        {
            //Arrange
            var request = new HttpRequestMessage(new HttpMethod(method), $"/api/Tarefas/{id}");

            //Act
            var response = await _httpClient.SendAsync(request);
            // Assert

            //Assert
            response.EnsureSuccessStatusCode();
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }


        [Theory]
        [InlineData("POST")]
        public async Task TarefaPostTest(string method)
        {
            //Arrange
            var request = new HttpRequestMessage(new HttpMethod(method), "/api/Tarefas/");
            var Body = new
            {
                titulo = $"Tarefa {Guid.NewGuid()}",
                status = false,
                descricao = $"Tarefa de teste {Guid.NewGuid()}"
            };

            // Act
            var response = await _httpClient.PostAsync(request.RequestUri, ContentHelper.GetStringContent(Body));

            // Assert
            response.EnsureSuccessStatusCode();
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }


        [Theory]
        [InlineData("GET", "PUT")]
        public async Task TarefaPutTest(string method1, string method2)
        {
            //Arrange
            var request1 = new HttpRequestMessage(new HttpMethod(method1), "/api/Tarefas/2");
            var request2 = new HttpRequestMessage(new HttpMethod(method2), "/api/Tarefas/2");
            var response = await _httpClient.GetAsync(request1.RequestUri);
            var tarefa = JsonConvert.DeserializeObject<Tarefa>(await response.Content.ReadAsStringAsync());

            // Act
            tarefa.Titulo = $"Tarefa {Guid.NewGuid()}";
            tarefa.Descricao = $"Tarefa de teste {Guid.NewGuid()}";
            response = await _httpClient.PutAsync(request2.RequestUri, ContentHelper.GetStringContent(tarefa));

            // Assert
            response.EnsureSuccessStatusCode();
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Theory]
        [InlineData("POST", "DELETE")]
        public async Task TarefaDeleteTest(string method1, string method2)
        {
            //Arrange
            var request1 = new HttpRequestMessage(new HttpMethod(method1), "/api/Tarefas/");
            var Body = new
            {
                tarefaId = 1,
                titulo = $"Tarefa {Guid.NewGuid()}",
                status = false,
                descricao = $"Tarefa de teste {Guid.NewGuid()}"
            };
            var response = await _httpClient.PostAsync(request1.RequestUri, ContentHelper.GetStringContent(Body));
            var tarefa = JsonConvert.DeserializeObject<Tarefa>(await response.Content.ReadAsStringAsync());
            var request2 = new HttpRequestMessage(new HttpMethod(method2), $"/api/Tarefas/{tarefa.TarefaId}");

            // Act
            response = await _httpClient.DeleteAsync(request2.RequestUri);

            // Assert
            response.EnsureSuccessStatusCode();
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }

    public static class ContentHelper
    {
        public static StringContent GetStringContent(object obj)
            => new StringContent(JsonConvert.SerializeObject(obj), Encoding.Default, "application/json");
    }
}
