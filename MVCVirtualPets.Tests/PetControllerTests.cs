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
        PetController underTest;

        public PetControllerTests()
        {
            var underTest = new PetController();
        }

        [Fact]
        public void Index_Returns_A_ViewResult()
        {
            var result = underTest.Index();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Index_Model_Has_3_Pets()
        {
            var result = underTest.Index();

            //Hard cast model into an IEnumerable<Pet>
            var model = (IEnumerable<Pet>)result.Model;

            Assert.Equal(3, model.Count());
        }

        [Fact]
        public void Details_Model_Has_Correct_Id()
        {
            var expectedId = 2;
            var result = underTest.Details(expectedId);
            var model = (Pet)result.Model;
            Assert.Equal(expectedId, model.Id);
        }
    }
}
