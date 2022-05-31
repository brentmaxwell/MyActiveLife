# IO.Swagger.Api.SegmentsApi

All URIs are relative to *https://www.strava.com/api/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ExploreSegments**](SegmentsApi.md#exploresegments) | **GET** /segments/explore | Explore segments
[**GetLoggedInAthleteStarredSegments**](SegmentsApi.md#getloggedinathletestarredsegments) | **GET** /segments/starred | List Starred Segments
[**GetSegmentById**](SegmentsApi.md#getsegmentbyid) | **GET** /segments/{id} | Get Segment
[**StarSegment**](SegmentsApi.md#starsegment) | **PUT** /segments/{id}/starred | Star Segment

<a name="exploresegments"></a>
# **ExploreSegments**
> ExplorerResponse ExploreSegments (List<float?> bounds, string activityType = null, int? minCat = null, int? maxCat = null)

Explore segments

Returns the top 10 segments matching a specified query.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ExploreSegmentsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: strava_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SegmentsApi();
            var bounds = new List<float?>(); // List<float?> | The latitude and longitude for two points describing a rectangular boundary for the search: [southwest corner latitutde, southwest corner longitude, northeast corner latitude, northeast corner longitude]
            var activityType = activityType_example;  // string | Desired activity type. (optional) 
            var minCat = 56;  // int? | The minimum climbing category. (optional) 
            var maxCat = 56;  // int? | The maximum climbing category. (optional) 

            try
            {
                // Explore segments
                ExplorerResponse result = apiInstance.ExploreSegments(bounds, activityType, minCat, maxCat);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SegmentsApi.ExploreSegments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **bounds** | [**List&lt;float?&gt;**](float?.md)| The latitude and longitude for two points describing a rectangular boundary for the search: [southwest corner latitutde, southwest corner longitude, northeast corner latitude, northeast corner longitude] | 
 **activityType** | **string**| Desired activity type. | [optional] 
 **minCat** | **int?**| The minimum climbing category. | [optional] 
 **maxCat** | **int?**| The maximum climbing category. | [optional] 

### Return type

[**ExplorerResponse**](ExplorerResponse.md)

### Authorization

[strava_oauth](../README.md#strava_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getloggedinathletestarredsegments"></a>
# **GetLoggedInAthleteStarredSegments**
> List<SummarySegment> GetLoggedInAthleteStarredSegments (int? page = null, int? perPage = null)

List Starred Segments

List of the authenticated athlete's starred segments. Private segments are filtered out unless requested by a token with read_all scope.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetLoggedInAthleteStarredSegmentsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: strava_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SegmentsApi();
            var page = 56;  // int? | Page number. Defaults to 1. (optional) 
            var perPage = 56;  // int? | Number of items per page. Defaults to 30. (optional)  (default to 30)

            try
            {
                // List Starred Segments
                List&lt;SummarySegment&gt; result = apiInstance.GetLoggedInAthleteStarredSegments(page, perPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SegmentsApi.GetLoggedInAthleteStarredSegments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int?**| Page number. Defaults to 1. | [optional] 
 **perPage** | **int?**| Number of items per page. Defaults to 30. | [optional] [default to 30]

### Return type

[**List<SummarySegment>**](SummarySegment.md)

### Authorization

[strava_oauth](../README.md#strava_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getsegmentbyid"></a>
# **GetSegmentById**
> DetailedSegment GetSegmentById (long? id)

Get Segment

Returns the specified segment. read_all scope required in order to retrieve athlete-specific segment information, or to retrieve private segments.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSegmentByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: strava_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SegmentsApi();
            var id = 789;  // long? | The identifier of the segment.

            try
            {
                // Get Segment
                DetailedSegment result = apiInstance.GetSegmentById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SegmentsApi.GetSegmentById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The identifier of the segment. | 

### Return type

[**DetailedSegment**](DetailedSegment.md)

### Authorization

[strava_oauth](../README.md#strava_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="starsegment"></a>
# **StarSegment**
> DetailedSegment StarSegment (bool? starred, long? id)

Star Segment

Stars/Unstars the given segment for the authenticated athlete. Requires profile:write scope.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StarSegmentExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: strava_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SegmentsApi();
            var starred = true;  // bool? | 
            var id = 789;  // long? | The identifier of the segment to star.

            try
            {
                // Star Segment
                DetailedSegment result = apiInstance.StarSegment(starred, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SegmentsApi.StarSegment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **starred** | **bool?**|  | 
 **id** | **long?**| The identifier of the segment to star. | 

### Return type

[**DetailedSegment**](DetailedSegment.md)

### Authorization

[strava_oauth](../README.md#strava_oauth)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
