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
    ///  Class for testing ActivitiesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ActivitiesApiTests
    {
        private ActivitiesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ActivitiesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ActivitiesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ActivitiesApi
            //Assert.IsInstanceOfType(typeof(ActivitiesApi), instance, "instance is a ActivitiesApi");
        }

        /// <summary>
        /// Test CreateActivity
        /// </summary>
        [Test]
        public void CreateActivityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //string type = null;
            //DateTime? startDateLocal = null;
            //int? elapsedTime = null;
            //string description = null;
            //float? distance = null;
            //int? trainer = null;
            //int? commute = null;
            //bool? hideFromHome = null;
            //var response = instance.CreateActivity(name, type, startDateLocal, elapsedTime, description, distance, trainer, commute, hideFromHome);
            //Assert.IsInstanceOf<DetailedActivity> (response, "response is DetailedActivity");
        }
        /// <summary>
        /// Test GetActivityById
        /// </summary>
        [Test]
        public void GetActivityByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //bool? includeAllEfforts = null;
            //var response = instance.GetActivityById(id, includeAllEfforts);
            //Assert.IsInstanceOf<DetailedActivity> (response, "response is DetailedActivity");
        }
        /// <summary>
        /// Test GetCommentsByActivityId
        /// </summary>
        [Test]
        public void GetCommentsByActivityIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //int? page = null;
            //int? perPage = null;
            //var response = instance.GetCommentsByActivityId(id, page, perPage);
            //Assert.IsInstanceOf<List<Comment>> (response, "response is List<Comment>");
        }
        /// <summary>
        /// Test GetKudoersByActivityId
        /// </summary>
        [Test]
        public void GetKudoersByActivityIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //int? page = null;
            //int? perPage = null;
            //var response = instance.GetKudoersByActivityId(id, page, perPage);
            //Assert.IsInstanceOf<List<SummaryAthlete>> (response, "response is List<SummaryAthlete>");
        }
        /// <summary>
        /// Test GetLapsByActivityId
        /// </summary>
        [Test]
        public void GetLapsByActivityIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //var response = instance.GetLapsByActivityId(id);
            //Assert.IsInstanceOf<List<Lap>> (response, "response is List<Lap>");
        }
        /// <summary>
        /// Test GetLoggedInAthleteActivities
        /// </summary>
        [Test]
        public void GetLoggedInAthleteActivitiesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? before = null;
            //int? after = null;
            //int? page = null;
            //int? perPage = null;
            //var response = instance.GetLoggedInAthleteActivities(before, after, page, perPage);
            //Assert.IsInstanceOf<List<SummaryActivity>> (response, "response is List<SummaryActivity>");
        }
        /// <summary>
        /// Test GetZonesByActivityId
        /// </summary>
        [Test]
        public void GetZonesByActivityIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //var response = instance.GetZonesByActivityId(id);
            //Assert.IsInstanceOf<List<ActivityZone>> (response, "response is List<ActivityZone>");
        }
        /// <summary>
        /// Test UpdateActivityById
        /// </summary>
        [Test]
        public void UpdateActivityByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //UpdatableActivity body = null;
            //var response = instance.UpdateActivityById(id, body);
            //Assert.IsInstanceOf<DetailedActivity> (response, "response is DetailedActivity");
        }
    }

}
