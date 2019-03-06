using System;
using System.Linq;
using System.Collections.Generic;
using MVCVirtualPets.Models;
using MVCVirtualPets.Controllers;
using MVCVirtualPets.Repositories;
using Xunit;
using NSubstitute;
using Microsoft.AspNetCore.Mvc;

namespace MVCVirtualPets.Tests
{
    public class PetControllerTests
    {
        PetController underTest;

        public PetControllerTests()
        {
            var context = new PetContext();
            var petRepo = new PetRepository(context);
            var underTest = new PetController(petRepo);
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
        public void Details_Model_Is_Expected_Model()
        {
            var expectedId = 2;
            var expectedModel = new Pet() { PetId = expectedId };
            var repo = Substitute.For<IPetRepository>();
            repo.GetById(expectedId).Returns(expectedModel);
            var underTest = new PetController(repo);
            
            var result = underTest.Details(expectedId);
            var model = (Pet)result.Model;

            Assert.Equal(expectedModel, model);
        }


    }
}
