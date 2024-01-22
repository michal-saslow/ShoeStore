using calendar;
using calendar.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace UnitTest
{
    public class EventControllerTest
    {
        private EventsController _eventsController;
        public EventControllerTest()
        {
            var context = new FakeDataContext();
            _eventsController = new EventsController(context);
        }
        [Fact]
        public void Testget_NutNull()
        {
            var result = _eventsController.Get();
            Assert.NotNull(result);
        }
        [Fact]
        public void TestPost()
        { 
            var testItem = new Event{ Id = 1, Title = "event 4", Start = new DateTime(2023, 12, 09), End = new DateTime(2023, 12, 09) };
            // Act
            var createdResponse = _eventsController.Post(testItem) as OkObjectResult;
            
            // Assert
            var item=Assert.IsType<Event>(createdResponse.Value);
            Assert.Equal("event 4", item.Title);
        }



    }
}