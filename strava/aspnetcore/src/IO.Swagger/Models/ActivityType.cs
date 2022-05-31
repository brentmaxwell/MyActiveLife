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
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{ 
        /// <summary>
        /// An enumeration of the types an activity may have.
        /// </summary>
        /// <value>An enumeration of the types an activity may have.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ActivityType
        {
            /// <summary>
            /// Enum AlpineSkiEnum for AlpineSki
            /// </summary>
            [EnumMember(Value = "AlpineSki")]
            AlpineSkiEnum = 0,
            /// <summary>
            /// Enum BackcountrySkiEnum for BackcountrySki
            /// </summary>
            [EnumMember(Value = "BackcountrySki")]
            BackcountrySkiEnum = 1,
            /// <summary>
            /// Enum CanoeingEnum for Canoeing
            /// </summary>
            [EnumMember(Value = "Canoeing")]
            CanoeingEnum = 2,
            /// <summary>
            /// Enum CrossfitEnum for Crossfit
            /// </summary>
            [EnumMember(Value = "Crossfit")]
            CrossfitEnum = 3,
            /// <summary>
            /// Enum EBikeRideEnum for EBikeRide
            /// </summary>
            [EnumMember(Value = "EBikeRide")]
            EBikeRideEnum = 4,
            /// <summary>
            /// Enum EllipticalEnum for Elliptical
            /// </summary>
            [EnumMember(Value = "Elliptical")]
            EllipticalEnum = 5,
            /// <summary>
            /// Enum GolfEnum for Golf
            /// </summary>
            [EnumMember(Value = "Golf")]
            GolfEnum = 6,
            /// <summary>
            /// Enum HandcycleEnum for Handcycle
            /// </summary>
            [EnumMember(Value = "Handcycle")]
            HandcycleEnum = 7,
            /// <summary>
            /// Enum HikeEnum for Hike
            /// </summary>
            [EnumMember(Value = "Hike")]
            HikeEnum = 8,
            /// <summary>
            /// Enum IceSkateEnum for IceSkate
            /// </summary>
            [EnumMember(Value = "IceSkate")]
            IceSkateEnum = 9,
            /// <summary>
            /// Enum InlineSkateEnum for InlineSkate
            /// </summary>
            [EnumMember(Value = "InlineSkate")]
            InlineSkateEnum = 10,
            /// <summary>
            /// Enum KayakingEnum for Kayaking
            /// </summary>
            [EnumMember(Value = "Kayaking")]
            KayakingEnum = 11,
            /// <summary>
            /// Enum KitesurfEnum for Kitesurf
            /// </summary>
            [EnumMember(Value = "Kitesurf")]
            KitesurfEnum = 12,
            /// <summary>
            /// Enum NordicSkiEnum for NordicSki
            /// </summary>
            [EnumMember(Value = "NordicSki")]
            NordicSkiEnum = 13,
            /// <summary>
            /// Enum RideEnum for Ride
            /// </summary>
            [EnumMember(Value = "Ride")]
            RideEnum = 14,
            /// <summary>
            /// Enum RockClimbingEnum for RockClimbing
            /// </summary>
            [EnumMember(Value = "RockClimbing")]
            RockClimbingEnum = 15,
            /// <summary>
            /// Enum RollerSkiEnum for RollerSki
            /// </summary>
            [EnumMember(Value = "RollerSki")]
            RollerSkiEnum = 16,
            /// <summary>
            /// Enum RowingEnum for Rowing
            /// </summary>
            [EnumMember(Value = "Rowing")]
            RowingEnum = 17,
            /// <summary>
            /// Enum RunEnum for Run
            /// </summary>
            [EnumMember(Value = "Run")]
            RunEnum = 18,
            /// <summary>
            /// Enum SailEnum for Sail
            /// </summary>
            [EnumMember(Value = "Sail")]
            SailEnum = 19,
            /// <summary>
            /// Enum SkateboardEnum for Skateboard
            /// </summary>
            [EnumMember(Value = "Skateboard")]
            SkateboardEnum = 20,
            /// <summary>
            /// Enum SnowboardEnum for Snowboard
            /// </summary>
            [EnumMember(Value = "Snowboard")]
            SnowboardEnum = 21,
            /// <summary>
            /// Enum SnowshoeEnum for Snowshoe
            /// </summary>
            [EnumMember(Value = "Snowshoe")]
            SnowshoeEnum = 22,
            /// <summary>
            /// Enum SoccerEnum for Soccer
            /// </summary>
            [EnumMember(Value = "Soccer")]
            SoccerEnum = 23,
            /// <summary>
            /// Enum StairStepperEnum for StairStepper
            /// </summary>
            [EnumMember(Value = "StairStepper")]
            StairStepperEnum = 24,
            /// <summary>
            /// Enum StandUpPaddlingEnum for StandUpPaddling
            /// </summary>
            [EnumMember(Value = "StandUpPaddling")]
            StandUpPaddlingEnum = 25,
            /// <summary>
            /// Enum SurfingEnum for Surfing
            /// </summary>
            [EnumMember(Value = "Surfing")]
            SurfingEnum = 26,
            /// <summary>
            /// Enum SwimEnum for Swim
            /// </summary>
            [EnumMember(Value = "Swim")]
            SwimEnum = 27,
            /// <summary>
            /// Enum VelomobileEnum for Velomobile
            /// </summary>
            [EnumMember(Value = "Velomobile")]
            VelomobileEnum = 28,
            /// <summary>
            /// Enum VirtualRideEnum for VirtualRide
            /// </summary>
            [EnumMember(Value = "VirtualRide")]
            VirtualRideEnum = 29,
            /// <summary>
            /// Enum VirtualRunEnum for VirtualRun
            /// </summary>
            [EnumMember(Value = "VirtualRun")]
            VirtualRunEnum = 30,
            /// <summary>
            /// Enum WalkEnum for Walk
            /// </summary>
            [EnumMember(Value = "Walk")]
            WalkEnum = 31,
            /// <summary>
            /// Enum WeightTrainingEnum for WeightTraining
            /// </summary>
            [EnumMember(Value = "WeightTraining")]
            WeightTrainingEnum = 32,
            /// <summary>
            /// Enum WheelchairEnum for Wheelchair
            /// </summary>
            [EnumMember(Value = "Wheelchair")]
            WheelchairEnum = 33,
            /// <summary>
            /// Enum WindsurfEnum for Windsurf
            /// </summary>
            [EnumMember(Value = "Windsurf")]
            WindsurfEnum = 34,
            /// <summary>
            /// Enum WorkoutEnum for Workout
            /// </summary>
            [EnumMember(Value = "Workout")]
            WorkoutEnum = 35,
            /// <summary>
            /// Enum YogaEnum for Yoga
            /// </summary>
            [EnumMember(Value = "Yoga")]
            YogaEnum = 36        }
}
