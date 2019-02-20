using Microsoft.AspNetCore.Mvc;
using MVCVirtualPets.Controllers;
using MVCVirtualPets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace MVCVirtualPets.Tests
{
    public class PetControllerTests
    {
        [Fact]
        public void Index_Returns_A_ViewResult()
        {
            var underTest = new PetController();

            var result = underTest.Index();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Index_Model_Has_3_Pets()
        {
            var underTest = new PetController();

            var result = underTest.Index();

            //Hard cast model into an IEnumerable<Pet>
            var model = (IEnumerable<Pet>)result.Model;

            Assert.Equal(3, model.Count());
        }
    }
}
