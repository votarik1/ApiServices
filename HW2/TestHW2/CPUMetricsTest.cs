using System;
using Xunit;
using Manager.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace TestManager
{
    public class CPUMetricsTest
    {

        private CPUMetricsController controller;
        public CPUMetricsTest()
        {
            controller = new CPUMetricsController();
        }
        [Fact]
        public void GetMetricsFromAgent_ReturnsOK()
        {
            var agentID = 1;
            var fromTime = TimeSpan.FromSeconds(0);
            var toTime = TimeSpan.FromSeconds(100);
            var result = controller.GetMetricsFromAgent(agentID, fromTime, toTime);
            Assert.IsAssignableFrom<IActionResult>(result);
        }
    }
}
