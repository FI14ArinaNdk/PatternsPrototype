using System;
using System.Runtime;
using PatternsPrototype;

namespace PatternsPrototype.Tests
{
    public class Tests
    {
        [Test]
        public void IncompleteCopy_ShouldCreateNewObjectWithIncompleteValues()
        {
            Milk milk = new Milk();
            milk.Price = 42;
            milk.ExpirationDate = 34;
            milk.Name = "Galychina";
            milk.IdInfo = new IdInfo(938716483);

            Milk milk1 = milk.IncompleteCopy();

            Assert.AreNotSame(milk, milk1);
            Assert.AreEqual(milk.Price, milk1.Price);
            Assert.AreEqual(milk.ExpirationDate, milk1.ExpirationDate);
            Assert.AreEqual(milk.Name, milk1.Name);
            Assert.AreSame(milk.IdInfo, milk1.IdInfo);
        }

        [Test]
        public void IncompleteCopy_ShouldNotCopyNameIfNameIsNull()
        {
            Milk milk = new Milk();
            milk.Price = 42;
            milk.ExpirationDate = 34;
            milk.Name = null;
            milk.IdInfo = new IdInfo(938716483);

            Milk milk1 = milk.IncompleteCopy();

            Assert.AreNotSame(milk, milk1);
            Assert.AreEqual(milk.Price, milk1.Price);
            Assert.AreEqual(milk.ExpirationDate, milk1.ExpirationDate);
            Assert.IsNull(milk1.Name);
            Assert.AreSame(milk.IdInfo, milk1.IdInfo);
        }

        [Test]
        public void CompleteCopy_ShouldCreateNewObjectWithCopiedValues()
        {
            Milk milk = new Milk();
            milk.Price = 32;
            milk.ExpirationDate = 7;
            milk.Name = "Ferma";
            milk.IdInfo = new IdInfo(83684920);

            Milk milk2 = milk.CompleteCopy();

            Assert.AreNotSame(milk, milk2);
            Assert.AreEqual(milk.Price, milk2.Price);
            Assert.AreEqual(milk.ExpirationDate, milk2.ExpirationDate);
            Assert.AreEqual(milk.Name, milk2.Name);
            Assert.AreEqual(milk.IdInfo.IdNumber, milk2.IdInfo.IdNumber);
        }

        [Test]
        public void CompleteCopy_ShouldCreateNewObjectWithEmptyName_WhenNameIsEmpty()
        {
            Milk milk = new Milk();
            milk.Price = 32;
            milk.ExpirationDate = 7;
            milk.Name = "";
            milk.IdInfo = new IdInfo(83684920);

            Milk milk2 = milk.CompleteCopy();

            Assert.AreNotSame(milk, milk2);
            Assert.AreEqual(milk.Price, milk2.Price);
            Assert.AreEqual(milk.ExpirationDate, milk2.ExpirationDate);
            Assert.AreEqual("", milk2.Name);
            Assert.AreEqual(milk.IdInfo.IdNumber, milk2.IdInfo.IdNumber);
        }

        [Test]
        public void CompleteCopy_ShouldCreateNewObjectWithDifferentPrice()
        {
            Milk milk = new Milk();
            milk.Price = 32;
            milk.ExpirationDate = 7;
            milk.Name = "Ferma";
            milk.IdInfo = new IdInfo(83684920);

            Milk milk2 = milk.CompleteCopy();
            milk2.Price = 50; 

            Assert.AreNotSame(milk, milk2);
            Assert.AreNotEqual(milk.Price, milk2.Price); 
            Assert.AreEqual(milk.ExpirationDate, milk2.ExpirationDate);
            Assert.AreEqual(milk.Name, milk2.Name);
            Assert.AreEqual(milk.IdInfo.IdNumber, milk2.IdInfo.IdNumber);
        }
    }
}



