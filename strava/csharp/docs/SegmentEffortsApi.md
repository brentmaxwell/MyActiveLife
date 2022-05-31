# IO.Swagger.Api.SegmentEffortsApi

All URIs are relative to *https://www.strava.com/api/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetEffortsBySegmentId**](SegmentEffortsApi.md#geteffortsbysegmentid) | **GET** /segment_efforts | List Segment Efforts
[**GetSegmentEffortById**](SegmentEffortsApi.md#getsegmenteffortbyid) | **GET** /segment_efforts/{id} | Get Segment Effort

<a name="geteffortsbysegmentid"></a>
# **GetEffortsBySegmentId**
> List<DetailedSegmentEffort> GetEffortsBySegmentId (int? segmentId, DateTime? startDateLocal = null, DateTime? endDateLocal = null, int? perPage = null)

List Segment Efforts

Returns a set of the authenticated athlete's segment efforts for a given segment.  Requires subscription.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetEffortsBySegmentIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: strava_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SegmentEffortsApi();
            var segmentId = 56;  // int? | The identifier of the segment.
            var startDateLocal = 2013-10-20T19:20:30+01:00;  // DateTime? | ISO 8601 formatted date time. (optional) 
            var endDateLocal = 2013-10-20T19:20:30+01:00;  // DateTime? | ISO 8601 formatted date time. (optional) 
            var perPage = 56;  // int? | Number of items per page. Defaults to 30. (optional)  (default to 30)

            try
            {
                // List Segment Efforts
                List&lt;DetailedSegmentEffort&gt; result = apiInstance.GetEffortsBySegmentId(segmentId, startDateLocal, endDateLocal, perPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SegmentEffortsApi.GetEffortsBySegmentId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **segmentId** | **int?**| The identifier of the segment. | 
 **startDateLocal** | **DateTime?**| ISO 8601 formatted date time. | [optional] 
 **endDateLocal** | **DateTime?**| ISO 8601 formatted date time. | [optional] 
 **perPage** | **int?**| Number of items per page. Defaults to 30. | [optional] [default to 30]

### Return type

[**List<DetailedSegmentEffort>**](DetailedSegmentEffort.md)

### Authorization

[strava_oauth](../README.md#strava_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getsegmenteffortbyid"></a>
# **GetSegmentEffortById**
> DetailedSegmentEffort GetSegmentEffortById (long? id)

Get Segment Effort

Returns a segment effort from an activity that is owned by the authenticated athlete. Requires subscription.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSegmentEffortByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: strava_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SegmentEffortsApi();
            var id = 789;  // long? | The identifier of the segment effort.

            try
            {
                // Get Segment Effort
                DetailedSegmentEffort result = apiInstance.GetSegmentEffortById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SegmentEffortsApi.GetSegmentEffortById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The identifier of the segment effort. | 

### Return type

[**DetailedSegmentEffort**](DetailedSegmentEffort.md)

### Authorization

[strava_oauth](../README.md#strava_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
