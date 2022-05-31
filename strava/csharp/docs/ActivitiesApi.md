# IO.Swagger.Api.ActivitiesApi

All URIs are relative to *https://www.strava.com/api/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateActivity**](ActivitiesApi.md#createactivity) | **POST** /activities | Create an Activity
[**GetActivityById**](ActivitiesApi.md#getactivitybyid) | **GET** /activities/{id} | Get Activity
[**GetCommentsByActivityId**](ActivitiesApi.md#getcommentsbyactivityid) | **GET** /activities/{id}/comments | List Activity Comments
[**GetKudoersByActivityId**](ActivitiesApi.md#getkudoersbyactivityid) | **GET** /activities/{id}/kudos | List Activity Kudoers
[**GetLapsByActivityId**](ActivitiesApi.md#getlapsbyactivityid) | **GET** /activities/{id}/laps | List Activity Laps
[**GetLoggedInAthleteActivities**](ActivitiesApi.md#getloggedinathleteactivities) | **GET** /athlete/activities | List Athlete Activities
[**GetZonesByActivityId**](ActivitiesApi.md#getzonesbyactivityid) | **GET** /activities/{id}/zones | Get Activity Zones
[**UpdateActivityById**](ActivitiesApi.md#updateactivitybyid) | **PUT** /activities/{id} | Update Activity

<a name="createactivity"></a>
# **CreateActivity**
> DetailedActivity CreateActivity (string name, string type, DateTime? startDateLocal, int? elapsedTime, string description, float? distance, int? trainer, int? commute, bool? hideFromHome)

Create an Activity

Creates a manual activity for an athlete, requires activity:write scope.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateActivityExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: strava_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ActivitiesApi();
            var name = name_example;  // string | 
            var type = type_example;  // string | 
            var startDateLocal = 2013-10-20T19:20:30+01:00;  // DateTime? | 
            var elapsedTime = 56;  // int? | 
            var description = description_example;  // string | 
            var distance = 3.4;  // float? | 
            var trainer = 56;  // int? | 
            var commute = 56;  // int? | 
            var hideFromHome = true;  // bool? | 

            try
            {
                // Create an Activity
                DetailedActivity result = apiInstance.CreateActivity(name, type, startDateLocal, elapsedTime, description, distance, trainer, commute, hideFromHome);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivitiesApi.CreateActivity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**|  | 
 **type** | **string**|  | 
 **startDateLocal** | **DateTime?**|  | 
 **elapsedTime** | **int?**|  | 
 **description** | **string**|  | 
 **distance** | **float?**|  | 
 **trainer** | **int?**|  | 
 **commute** | **int?**|  | 
 **hideFromHome** | **bool?**|  | 

### Return type

[**DetailedActivity**](DetailedActivity.md)

### Authorization

[strava_oauth](../README.md#strava_oauth)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getactivitybyid"></a>
# **GetActivityById**
> DetailedActivity GetActivityById (long? id, bool? includeAllEfforts = null)

Get Activity

Returns the given activity that is owned by the authenticated athlete. Requires activity:read for Everyone and Followers activities. Requires activity:read_all for Only Me activities.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetActivityByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: strava_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ActivitiesApi();
            var id = 789;  // long? | The identifier of the activity.
            var includeAllEfforts = true;  // bool? | To include all segments efforts. (optional) 

            try
            {
                // Get Activity
                DetailedActivity result = apiInstance.GetActivityById(id, includeAllEfforts);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivitiesApi.GetActivityById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The identifier of the activity. | 
 **includeAllEfforts** | **bool?**| To include all segments efforts. | [optional] 

### Return type

[**DetailedActivity**](DetailedActivity.md)

### Authorization

[strava_oauth](../README.md#strava_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getcommentsbyactivityid"></a>
# **GetCommentsByActivityId**
> List<Comment> GetCommentsByActivityId (long? id, int? page = null, int? perPage = null)

List Activity Comments

Returns the comments on the given activity. Requires activity:read for Everyone and Followers activities. Requires activity:read_all for Only Me activities.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCommentsByActivityIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: strava_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ActivitiesApi();
            var id = 789;  // long? | The identifier of the activity.
            var page = 56;  // int? | Page number. Defaults to 1. (optional) 
            var perPage = 56;  // int? | Number of items per page. Defaults to 30. (optional)  (default to 30)

            try
            {
                // List Activity Comments
                List&lt;Comment&gt; result = apiInstance.GetCommentsByActivityId(id, page, perPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivitiesApi.GetCommentsByActivityId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The identifier of the activity. | 
 **page** | **int?**| Page number. Defaults to 1. | [optional] 
 **perPage** | **int?**| Number of items per page. Defaults to 30. | [optional] [default to 30]

### Return type

[**List<Comment>**](Comment.md)

### Authorization

[strava_oauth](../README.md#strava_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getkudoersbyactivityid"></a>
# **GetKudoersByActivityId**
> List<SummaryAthlete> GetKudoersByActivityId (long? id, int? page = null, int? perPage = null)

List Activity Kudoers

Returns the athletes who kudoed an activity identified by an identifier. Requires activity:read for Everyone and Followers activities. Requires activity:read_all for Only Me activities.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetKudoersByActivityIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: strava_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ActivitiesApi();
            var id = 789;  // long? | The identifier of the activity.
            var page = 56;  // int? | Page number. Defaults to 1. (optional) 
            var perPage = 56;  // int? | Number of items per page. Defaults to 30. (optional)  (default to 30)

            try
            {
                // List Activity Kudoers
                List&lt;SummaryAthlete&gt; result = apiInstance.GetKudoersByActivityId(id, page, perPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivitiesApi.GetKudoersByActivityId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The identifier of the activity. | 
 **page** | **int?**| Page number. Defaults to 1. | [optional] 
 **perPage** | **int?**| Number of items per page. Defaults to 30. | [optional] [default to 30]

### Return type

[**List<SummaryAthlete>**](SummaryAthlete.md)

### Authorization

[strava_oauth](../README.md#strava_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getlapsbyactivityid"></a>
# **GetLapsByActivityId**
> List<Lap> GetLapsByActivityId (long? id)

List Activity Laps

Returns the laps of an activity identified by an identifier. Requires activity:read for Everyone and Followers activities. Requires activity:read_all for Only Me activities.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetLapsByActivityIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: strava_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ActivitiesApi();
            var id = 789;  // long? | The identifier of the activity.

            try
            {
                // List Activity Laps
                List&lt;Lap&gt; result = apiInstance.GetLapsByActivityId(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivitiesApi.GetLapsByActivityId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The identifier of the activity. | 

### Return type

[**List<Lap>**](Lap.md)

### Authorization

[strava_oauth](../README.md#strava_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getloggedinathleteactivities"></a>
# **GetLoggedInAthleteActivities**
> List<SummaryActivity> GetLoggedInAthleteActivities (int? before = null, int? after = null, int? page = null, int? perPage = null)

List Athlete Activities

Returns the activities of an athlete for a specific identifier. Requires activity:read. Only Me activities will be filtered out unless requested by a token with activity:read_all.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetLoggedInAthleteActivitiesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: strava_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ActivitiesApi();
            var before = 56;  // int? | An epoch timestamp to use for filtering activities that have taken place before a certain time. (optional) 
            var after = 56;  // int? | An epoch timestamp to use for filtering activities that have taken place after a certain time. (optional) 
            var page = 56;  // int? | Page number. Defaults to 1. (optional) 
            var perPage = 56;  // int? | Number of items per page. Defaults to 30. (optional)  (default to 30)

            try
            {
                // List Athlete Activities
                List&lt;SummaryActivity&gt; result = apiInstance.GetLoggedInAthleteActivities(before, after, page, perPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivitiesApi.GetLoggedInAthleteActivities: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **before** | **int?**| An epoch timestamp to use for filtering activities that have taken place before a certain time. | [optional] 
 **after** | **int?**| An epoch timestamp to use for filtering activities that have taken place after a certain time. | [optional] 
 **page** | **int?**| Page number. Defaults to 1. | [optional] 
 **perPage** | **int?**| Number of items per page. Defaults to 30. | [optional] [default to 30]

### Return type

[**List<SummaryActivity>**](SummaryActivity.md)

### Authorization

[strava_oauth](../README.md#strava_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getzonesbyactivityid"></a>
# **GetZonesByActivityId**
> List<ActivityZone> GetZonesByActivityId (long? id)

Get Activity Zones

Summit Feature. Returns the zones of a given activity. Requires activity:read for Everyone and Followers activities. Requires activity:read_all for Only Me activities.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetZonesByActivityIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: strava_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ActivitiesApi();
            var id = 789;  // long? | The identifier of the activity.

            try
            {
                // Get Activity Zones
                List&lt;ActivityZone&gt; result = apiInstance.GetZonesByActivityId(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivitiesApi.GetZonesByActivityId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The identifier of the activity. | 

### Return type

[**List<ActivityZone>**](ActivityZone.md)

### Authorization

[strava_oauth](../README.md#strava_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateactivitybyid"></a>
# **UpdateActivityById**
> DetailedActivity UpdateActivityById (long? id, UpdatableActivity body = null)

Update Activity

Updates the given activity that is owned by the authenticated athlete. Requires activity:write. Also requires activity:read_all in order to update Only Me activities

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateActivityByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: strava_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ActivitiesApi();
            var id = 789;  // long? | The identifier of the activity.
            var body = new UpdatableActivity(); // UpdatableActivity |  (optional) 

            try
            {
                // Update Activity
                DetailedActivity result = apiInstance.UpdateActivityById(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivitiesApi.UpdateActivityById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The identifier of the activity. | 
 **body** | [**UpdatableActivity**](UpdatableActivity.md)|  | [optional] 

### Return type

[**DetailedActivity**](DetailedActivity.md)

### Authorization

[strava_oauth](../README.md#strava_oauth)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
