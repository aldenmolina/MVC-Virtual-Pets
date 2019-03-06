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
        private IPetRepository repo;

        public PetControllerTests()
        {
            repo = Substitute.For<IPetRepository>();
            underTest = new PetController(repo);
        }

        [Fact]
        public void Index_Returns_A_ViewResult()
        {
            var result = underTest.Index();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Index_Model_Has_Expected_Model()
        {
            var expectedModel = new List<Pet>();
            repo.GetAll().Returns(expectedModel);

            var result = underTest.Index();
            //Hard cast model into an IEnumerable<Pet>
            var model = (IEnumerable<Pet>)result.Model;

            Assert.Equal(expectedModel, expectedModel);
        }

        [Fact]
        public void Details_Model_Is_Expected_Model()
        {
            var expectedId = 2;
            var expectedModel = new Pet();        
            repo.GetById(expectedId).Returns(expectedModel);  
            
            var result = underTest.Details(expectedId);
            var model = (Pet)result.Model;

            Assert.Equal(expectedModel, model);
        }


    }
}
