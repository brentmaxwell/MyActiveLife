# IO.Swagger.Api.AthletesApi

All URIs are relative to *https://www.strava.com/api/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetLoggedInAthlete**](AthletesApi.md#getloggedinathlete) | **GET** /athlete | Get Authenticated Athlete
[**GetLoggedInAthleteZones**](AthletesApi.md#getloggedinathletezones) | **GET** /athlete/zones | Get Zones
[**GetStats**](AthletesApi.md#getstats) | **GET** /athletes/{id}/stats | Get Athlete Stats
[**UpdateLoggedInAthlete**](AthletesApi.md#updateloggedinathlete) | **PUT** /athlete | Update Athlete

<a name="getloggedinathlete"></a>
# **GetLoggedInAthlete**
> DetailedAthlete GetLoggedInAthlete ()

Get Authenticated Athlete

Returns the currently authenticated athlete. Tokens with profile:read_all scope will receive a detailed athlete representation; all others will receive a summary representation.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetLoggedInAthleteExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: strava_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AthletesApi();

            try
            {
                // Get Authenticated Athlete
                DetailedAthlete result = apiInstance.GetLoggedInAthlete();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AthletesApi.GetLoggedInAthlete: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**DetailedAthlete**](DetailedAthlete.md)

### Authorization

[strava_oauth](../README.md#strava_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getloggedinathletezones"></a>
# **GetLoggedInAthleteZones**
> Zones GetLoggedInAthleteZones ()

Get Zones

Returns the the authenticated athlete's heart rate and power zones. Requires profile:read_all.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetLoggedInAthleteZonesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: strava_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AthletesApi();

            try
            {
                // Get Zones
                Zones result = apiInstance.GetLoggedInAthleteZones();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AthletesApi.GetLoggedInAthleteZones: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Zones**](Zones.md)

### Authorization

[strava_oauth](../README.md#strava_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getstats"></a>
# **GetStats**
> ActivityStats GetStats (long? id)

Get Athlete Stats

Returns the activity stats of an athlete. Only includes data from activities set to Everyone visibilty.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetStatsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: strava_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AthletesApi();
            var id = 789;  // long? | The identifier of the athlete. Must match the authenticated athlete.

            try
            {
                // Get Athlete Stats
                ActivityStats result = apiInstance.GetStats(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AthletesApi.GetStats: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The identifier of the athlete. Must match the authenticated athlete. | 

### Return type

[**ActivityStats**](ActivityStats.md)

### Authorization

[strava_oauth](../README.md#strava_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateloggedinathlete"></a>
# **UpdateLoggedInAthlete**
> DetailedAthlete UpdateLoggedInAthlete (float? weight)

Update Athlete

Update the currently authenticated athlete. Requires profile:write scope.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateLoggedInAthleteExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: strava_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AthletesApi();
            var weight = 3.4;  // float? | The weight of the athlete in kilograms.

            try
            {
                // Update Athlete
                DetailedAthlete result = apiInstance.UpdateLoggedInAthlete(weight);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AthletesApi.UpdateLoggedInAthlete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **weight** | **float?**| The weight of the athlete in kilograms. | 

### Return type

[**DetailedAthlete**](DetailedAthlete.md)

### Authorization

[strava_oauth](../README.md#strava_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
