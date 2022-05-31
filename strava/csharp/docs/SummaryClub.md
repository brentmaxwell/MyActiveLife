# IO.Swagger.Model.SummaryClub
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long?** | The club&#x27;s unique identifier. | [optional] 
**ResourceState** | **int?** | Resource state, indicates level of detail. Possible values: 1 -&gt; \&quot;meta\&quot;, 2 -&gt; \&quot;summary\&quot;, 3 -&gt; \&quot;detail\&quot; | [optional] 
**Name** | **string** | The club&#x27;s name. | [optional] 
**ProfileMedium** | **string** | URL to a 60x60 pixel profile picture. | [optional] 
**CoverPhoto** | **string** | URL to a ~1185x580 pixel cover photo. | [optional] 
**CoverPhotoSmall** | **string** | URL to a ~360x176  pixel cover photo. | [optional] 
**SportType** | **string** | Deprecated. Prefer to use activity_types. | [optional] 
**ActivityTypes** | [**List&lt;ActivityType&gt;**](ActivityType.md) | The activity types that count for a club. This takes precedence over sport_type. | [optional] 
**City** | **string** | The club&#x27;s city. | [optional] 
**State** | **string** | The club&#x27;s state or geographical region. | [optional] 
**Country** | **string** | The club&#x27;s country. | [optional] 
**_Private** | **bool?** | Whether the club is private. | [optional] 
**MemberCount** | **int?** | The club&#x27;s member count. | [optional] 
**Featured** | **bool?** | Whether the club is featured or not. | [optional] 
**Verified** | **bool?** | Whether the club is verified or not. | [optional] 
**Url** | **string** | The club&#x27;s vanity URL. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

