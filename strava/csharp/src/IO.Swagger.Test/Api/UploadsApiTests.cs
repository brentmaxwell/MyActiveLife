/* 
 * Strava API v3
 *
 * The [Swagger Playground](https://developers.strava.com/playground) is the easiest way to familiarize yourself with the Strava API by submitting HTTP requests and observing the responses before you write any client code. It will show what a response will look like with different endpoints depending on the authorization scope you receive from your athletes. To use the Playground, go to https://www.strava.com/settings/api and change your “Authorization Callback Domain” to developers.strava.com. Please note, we only support Swagger 2.0. There is a known issue where you can only select one scope at a time. For more information, please check the section “client code” at https://developers.strava.com/docs.
 *
 * OpenAPI spec version: 3.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing UploadsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class UploadsApiTests
    {
        private UploadsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new UploadsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of UploadsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' UploadsApi
            //Assert.IsInstanceOfType(typeof(UploadsApi), instance, "instance is a UploadsApi");
        }

        /// <summary>
        /// Test CreateUpload
        /// </summary>
        [Test]
        public void CreateUploadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //byte[] file = null;
            //string name = null;
            //string description = null;
            //string trainer = null;
            //string commute = null;
            //string dataType = null;
            //string externalId = null;
            //var response = instance.CreateUpload(file, name, description, trainer, commute, dataType, externalId);
            //Assert.IsInstanceOf<Upload> (response, "response is Upload");
        }
        /// <summary>
        /// Test GetUploadById
        /// </summary>
        [Test]
        public void GetUploadByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? uploadId = null;
            //var response = instance.GetUploadById(uploadId);
            //Assert.IsInstanceOf<Upload> (response, "response is Upload");
        }
    }

}
