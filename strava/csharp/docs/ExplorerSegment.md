# IO.Swagger.Model.ExplorerSegment
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long?** | The unique identifier of this segment | [optional] 
**Name** | **string** | The name of this segment | [optional] 
**ClimbCategory** | **int?** | The category of the climb [0, 5]. Higher is harder ie. 5 is Hors catégorie, 0 is uncategorized in climb_category. If climb_category &#x3D; 5, climb_category_desc &#x3D; HC. If climb_category &#x3D; 2, climb_category_desc &#x3D; 3. | [optional] 
**ClimbCategoryDesc** | **string** | The description for the category of the climb | [optional] 
**AvgGrade** | **float?** | The segment&#x27;s average grade, in percents | [optional] 
**StartLatlng** | [**LatLng**](LatLng.md) |  | [optional] 
**EndLatlng** | [**LatLng**](LatLng.md) |  | [optional] 
**ElevDifference** | **float?** | The segments&#x27;s evelation difference, in meters | [optional] 
**Distance** | **float?** | The segment&#x27;s distance, in meters | [optional] 
**Points** | **string** | The polyline of the segment | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

