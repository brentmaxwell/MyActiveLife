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
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using IO.Swagger.Attributes;
using IO.Swagger.Security;
using Microsoft.AspNetCore.Authorization;
using IO.Swagger.Models;

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class GearsApiController : ControllerBase
    { 
        /// <summary>
        /// Get Equipment
        /// </summary>
        /// <remarks>Returns an equipment using its identifier.</remarks>
        /// <param name="id">The identifier of the gear.</param>
        /// <response code="200">A representation of the gear.</response>
        /// <response code="0">Unexpected error.</response>
        [HttpGet]
        [Route("/api/v3/gear/{id}")]
        [ValidateModelState]
        [SwaggerOperation("GetGearById")]
        [SwaggerResponse(statusCode: 200, type: typeof(DetailedGear), description: "A representation of the gear.")]
        [SwaggerResponse(statusCode: 0, type: typeof(Fault), description: "Unexpected error.")]
        public virtual IActionResult GetGearById([FromRoute][Required]string id)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(DetailedGear));

            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(Fault));
            string exampleJson = null;
            exampleJson = "\"\"";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<DetailedGear>(exampleJson)
                        : default(DetailedGear);            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
