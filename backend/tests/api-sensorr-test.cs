using NUnit.Framework;
using api.Controllers;
using Microsoft.AspNetCore.Mvc;
using domain.entities;
using Microsoft.Extensions.Logging;
using domain.interfaces;
using System.Threading.Tasks;
using Moq;

namespace tests
{
    public class Tests
    {
        private readonly ILogger<SensorController> _logger;
        private readonly ISensorRepository _sensorRepository;
        private SensorController sensorController;
        private Mock<SensorController> _mockSensorController;

        [SetUp]
        public void Setup() => sensorController = new SensorController(_logger, _sensorRepository);

        [Test]
        public async Task TestPostWithNullRequest()
        {
            var result = await sensorController.Post(null);
            Assert.IsInstanceOf<BadRequestObjectResult>(result);
        }

        [Test]
        public async Task TestPostWithoutTimestamp()
        {
            Sensor sensor = new Sensor(){
                timestamp = 0,
                tag = "brasil.sudeste.sensor01",
                valor = "valor_exemplo"
            };
            var result = await sensorController.Post(sensor);
            Assert.IsInstanceOf<BadRequestObjectResult>(result);
        }

        [Test]
        public async Task TestPostWithTagNull()
        {
            Sensor sensor = new Sensor(){
                timestamp = 1539112021301,
                tag = null,
                valor = "valor_exemplo"
            };
            var result = await sensorController.Post(sensor);
            Assert.IsInstanceOf<BadRequestObjectResult>(result);
        }

        [Test]
        public async Task TestPostWithTagEmpty()
        {
            Sensor sensor = new Sensor(){
                timestamp = 1539112021301,
                tag = "",
                valor = "valor_exemplo"
            };

            var result = await sensorController.Post(sensor);
            Assert.IsInstanceOf<BadRequestObjectResult>(result);
        }

        [Test]
        public async Task TestPostWithTagNonStandard_1()
        {
            Sensor sensor = new Sensor(){
                timestamp = 1539112021301,
                tag = "brasil.sudeste.",
                valor = "valor_exemplo"
            };

            var result = await sensorController.Post(sensor);
            Assert.IsInstanceOf<BadRequestObjectResult>(result);
        }

        [Test]
        public async Task TestPostWithTagNonStandard_2()
        {
            Sensor sensor = new Sensor(){
                timestamp = 1539112021301,
                tag = "brasilsudestesensor01",
                valor = "valor_exemplo"
            };

            var result = await sensorController.Post(sensor);
            Assert.IsInstanceOf<BadRequestObjectResult>(result);
        }

        [Test]
        public async Task TestPostWithTagNonStandard_3()
        {
            Sensor sensor = new Sensor(){
                timestamp = 1539112021301,
                tag = "brasil..sensor01",
                valor = "valor_exemplo"
            };
            var result = await sensorController.Post(sensor);

            Assert.IsInstanceOf<BadRequestObjectResult>(result);
        }

        // [Test]
        // public async Task TestPostWithCorretRequest()
        // {
        //     Sensor sensor = new Sensor(){
        //         timestamp = 1539112021301,
        //         tag = "brasil.sudeste.sensor01",
        //         valor = "valor_exemplo"
        //     };

        //     var result = await sensorController.PostAsync(sensor);
        //     Assert.IsInstanceOf<OkObjectResult>(result);
        // }
        
    }
}