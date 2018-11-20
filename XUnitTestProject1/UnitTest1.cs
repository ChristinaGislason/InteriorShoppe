using InteriorShoppe.Models;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {

        /// <summary>
        /// Tests Furniture Model Get
        /// </summary>
        [Fact]
        public void FurnitureGet()
        {
            Furniture furintureGet = new Furniture();
            furintureGet.Name = "Jeff's hair is pure gold";

            Assert.Equal("Jeff's hair is pure gold", furintureGet.Name);
        }

        /// <summary>
        /// Tests Furniture Model Set
        /// </summary>
        [Fact]
        public void FurnitureSet()
        {
            Furniture furnitureSet = new Furniture();
            furnitureSet.Name = "Christinia";

            furnitureSet.Name = "Is a badass lab partner!";

            Assert.Equal("Is a badass lab partner!", furnitureSet.Name);
        }

        /// <summary>
        /// Tests ApplicationUser Model Get
        /// </summary>
        [Fact]
        public void ApplicationUserGet()
        {
            ApplicationUser applicationGet = new ApplicationUser();
            applicationGet.FirstName = "This is tedious";

            Assert.Equal("This is tedious", applicationGet.FirstName);
        }


        /// <summary>
        /// Tests ApplicationUser Model Set
        /// </summary>
        [Fact]
        public void ApplicationUserSet()
        {
            ApplicationUser applicationGet = new ApplicationUser();
            applicationGet.FirstName = "I pwn";

            applicationGet.FirstName = "At basketball";

            Assert.Equal("At basketball", applicationGet.FirstName);
        }
    }
}
