# IO.Swagger.Model.DetailedSegment
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
**CreatedAt** | **DateTime?** | The time at which the segment was created. | [optional] 
**UpdatedAt** | **DateTime?** | The time at which the segment was last updated. | [optional] 
**TotalElevationGain** | **float?** | The segment&#x27;s total elevation gain. | [optional] 
**Map** | [**PolylineMap**](PolylineMap.md) |  | [optional] 
**EffortCount** | **int?** | The total number of efforts for this segment | [optional] 
**AthleteCount** | **int?** | The number of unique athletes who have an effort for this segment | [optional] 
**Hazardous** | **bool?** | Whether this segment is considered hazardous | [optional] 
**StarCount** | **int?** | The number of stars for this segment | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

