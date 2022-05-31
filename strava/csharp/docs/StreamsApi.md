# IO.Swagger.Api.StreamsApi

All URIs are relative to *https://www.strava.com/api/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetActivityStreams**](StreamsApi.md#getactivitystreams) | **GET** /activities/{id}/streams | Get Activity Streams
[**GetRouteStreams**](StreamsApi.md#getroutestreams) | **GET** /routes/{id}/streams | Get Route Streams
[**GetSegmentEffortStreams**](StreamsApi.md#getsegmenteffortstreams) | **GET** /segment_efforts/{id}/streams | Get Segment Effort Streams
[**GetSegmentStreams**](StreamsApi.md#getsegmentstreams) | **GET** /segments/{id}/streams | Get Segment Streams

<a name="getactivitystreams"></a>
# **GetActivityStreams**
> StreamSet GetActivityStreams (long? id, List<string> keys, bool? keyByType)

Get Activity Streams

Returns the given activity's streams. Requires activity:read scope. Requires activity:read_all scope for Only Me activities.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetActivityStreamsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: strava_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StreamsApi();
            var id = 789;  // long? | The identifier of the activity.
            var keys = new List<string>(); // List<string> | Desired stream types.
            var keyByType = true;  // bool? | Must be true. (default to true)

            try
            {
                // Get Activity Streams
                StreamSet result = apiInstance.GetActivityStreams(id, keys, keyByType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StreamsApi.GetActivityStreams: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The identifier of the activity. | 
 **keys** | [**List&lt;string&gt;**](string.md)| Desired stream types. | 
 **keyByType** | **bool?**| Must be true. | [default to true]

### Return type

[**StreamSet**](StreamSet.md)

### Authorization

[strava_oauth](../README.md#strava_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getroutestreams"></a>
# **GetRouteStreams**
> StreamSet GetRouteStreams (long? id)

Get Route Streams

Returns the given route's streams. Requires read_all scope for private routes.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRouteStreamsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: strava_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StreamsApi();
            var id = 789;  // long? | The identifier of the route.

            try
            {
                // Get Route Streams
                StreamSet result = apiInstance.GetRouteStreams(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StreamsApi.GetRouteStreams: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The identifier of the route. | 

### Return type

[**StreamSet**](StreamSet.md)

### Authorization

[strava_oauth](../README.md#strava_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getsegmenteffortstreams"></a>
# **GetSegmentEffortStreams**
> StreamSet GetSegmentEffortStreams (long? id, List<string> keys, bool? keyByType)

Get Segment Effort Streams

Returns a set of streams for a segment effort completed by the authenticated athlete. Requires read_all scope.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSegmentEffortStreamsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: strava_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StreamsApi();
            var id = 789;  // long? | The identifier of the segment effort.
            var keys = new List<string>(); // List<string> | The types of streams to return.
            var keyByType = true;  // bool? | Must be true. (default to true)

            try
            {
                // Get Segment Effort Streams
                StreamSet result = apiInstance.GetSegmentEffortStreams(id, keys, keyByType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StreamsApi.GetSegmentEffortStreams: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The identifier of the segment effort. | 
 **keys** | [**List&lt;string&gt;**](string.md)| The types of streams to return. | 
 **keyByType** | **bool?**| Must be true. | [default to true]

### Return type

[**StreamSet**](StreamSet.md)

### Authorization

[strava_oauth](../README.md#strava_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getsegmentstreams"></a>
# **GetSegmentStreams**
> StreamSet GetSegmentStreams (long? id, List<string> keys, bool? keyByType)

Get Segment Streams

Returns the given segment's streams. Requires read_all scope for private segments.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSegmentStreamsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: strava_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StreamsApi();
            var id = 789;  // long? | The identifier of the segment.
            var keys = new List<string>(); // List<string> | The types of streams to return.
            var keyByType = true;  // bool? | Must be true. (default to true)

            try
            {
                // Get Segment Streams
                StreamSet result = apiInstance.GetSegmentStreams(id, keys, keyByType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StreamsApi.GetSegmentStreams: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The identifier of the segment. | 
 **keys** | [**List&lt;string&gt;**](string.md)| The types of streams to return. | 
 **keyByType** | **bool?**| Must be true. | [default to true]

### Return type

[**StreamSet**](StreamSet.md)

### Authorization

[strava_oauth](../README.md#strava_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
