﻿namespace Azure.Data.Wrappers.Test.Unit
{
    using System;
    using Azure.Data.Wrappers;
    using Microsoft.WindowsAzure.Storage;
    using NUnit.Framework;

    [TestFixture]
    public class AzureStorageTests
    {
        const string ConnectionString = "UseDevelopmentStorage=true";

        [Test]
        public void Constructor()
        {
            new AzureStorage(ConnectionString);
        }

        [Test]
        public void IsIStorageAccount()
        {
            Assert.IsNotNull(new AzureStorage(ConnectionString) as IStorageAccount);
        }

        [Test]
        public void ConstructorConnectionStringNull()
        {
            Assert.That(() => new AzureStorage((string)null), Throws.TypeOf<ArgumentNullException>());
        }

        [Test]
        public void ConstructorAccountNull()
        {
            Assert.That(() => new AzureStorage((CloudStorageAccount)null), Throws.TypeOf<ArgumentNullException>());
        }
    }
}