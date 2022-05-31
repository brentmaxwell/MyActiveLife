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
    ///  Class for testing SegmentEffortsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class SegmentEffortsApiTests
    {
        private SegmentEffortsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new SegmentEffortsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SegmentEffortsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' SegmentEffortsApi
            //Assert.IsInstanceOfType(typeof(SegmentEffortsApi), instance, "instance is a SegmentEffortsApi");
        }

        /// <summary>
        /// Test GetEffortsBySegmentId
        /// </summary>
        [Test]
        public void GetEffortsBySegmentIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? segmentId = null;
            //DateTime? startDateLocal = null;
            //DateTime? endDateLocal = null;
            //int? perPage = null;
            //var response = instance.GetEffortsBySegmentId(segmentId, startDateLocal, endDateLocal, perPage);
            //Assert.IsInstanceOf<List<DetailedSegmentEffort>> (response, "response is List<DetailedSegmentEffort>");
        }
        /// <summary>
        /// Test GetSegmentEffortById
        /// </summary>
        [Test]
        public void GetSegmentEffortByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //var response = instance.GetSegmentEffortById(id);
            //Assert.IsInstanceOf<DetailedSegmentEffort> (response, "response is DetailedSegmentEffort");
        }
    }

}
