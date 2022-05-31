# IO.Swagger.Model.SummarySegment
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long?** | The unique identifier of this segment | [optional] 
**Name** | **string** | The name of this segment | [optional] 
**ActivityType** | **string** |  | [optional] 
**Distance** | **float?** | The segment&#x27;s distance, in meters | [optional] 
**AverageGrade** | **float?** | The segment&#x27;s average grade, in percents | [optional] 
**MaximumGrade** | **float?** | The segments&#x27;s maximum grade, in percents | [optional] 
**ElevationHigh** | **float?** | The segments&#x27;s highest elevation, in meters | [optional] 
**ElevationLow** | **float?** | The segments&#x27;s lowest elevation, in meters | [optional] 
**StartLatlng** | [**LatLng**](LatLng.md) |  | [optional] 
**EndLatlng** | [**LatLng**](LatLng.md) |  | [optional] 
**ClimbCategory** | **int?** | The category of the climb [0, 5]. Higher is harder ie. 5 is Hors catégorie, 0 is uncategorized in climb_category. | [optional] 
**City** | **string** | The segments&#x27;s city. | [optional] 
**State** | **string** | The segments&#x27;s state or geographical region. | [optional] 
**Country** | **string** | The segment&#x27;s country. | [optional] 
**_Private** | **bool?** | Whether this segment is private. | [optional] 
**AthletePrEffort** | [**SummarySegmentEffort**](SummarySegmentEffort.md) |  | [optional] 
**AthleteSegmentStats** | [**SummaryPRSegmentEffort**](SummaryPRSegmentEffort.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

