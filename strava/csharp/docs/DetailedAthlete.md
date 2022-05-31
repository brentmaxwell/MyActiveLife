# IO.Swagger.Model.DetailedAthlete
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ResourceState** | **int?** | Resource state, indicates level of detail. Possible values: 1 -&gt; \&quot;meta\&quot;, 2 -&gt; \&quot;summary\&quot;, 3 -&gt; \&quot;detail\&quot; | [optional] 
**Firstname** | **string** | The athlete&#x27;s first name. | [optional] 
**Lastname** | **string** | The athlete&#x27;s last name. | [optional] 
**ProfileMedium** | **string** | URL to a 62x62 pixel profile picture. | [optional] 
**Profile** | **string** | URL to a 124x124 pixel profile picture. | [optional] 
**City** | **string** | The athlete&#x27;s city. | [optional] 
**State** | **string** | The athlete&#x27;s state or geographical region. | [optional] 
**Country** | **string** | The athlete&#x27;s country. | [optional] 
**Sex** | **string** | The athlete&#x27;s sex. | [optional] 
**Premium** | **bool?** | Deprecated.  Use summit field instead. Whether the athlete has any Summit subscription. | [optional] 
**Summit** | **bool?** | Whether the athlete has any Summit subscription. | [optional] 
**CreatedAt** | **DateTime?** | The time at which the athlete was created. | [optional] 
**UpdatedAt** | **DateTime?** | The time at which the athlete was last updated. | [optional] 
**FollowerCount** | **int?** | The athlete&#x27;s follower count. | [optional] 
**FriendCount** | **int?** | The athlete&#x27;s friend count. | [optional] 
**MeasurementPreference** | **string** | The athlete&#x27;s preferred unit system. | [optional] 
**Ftp** | **int?** | The athlete&#x27;s FTP (Functional Threshold Power). | [optional] 
**Weight** | **float?** | The athlete&#x27;s weight. | [optional] 
**Clubs** | [**List&lt;SummaryClub&gt;**](SummaryClub.md) | The athlete&#x27;s clubs. | [optional] 
**Bikes** | [**List&lt;SummaryGear&gt;**](SummaryGear.md) | The athlete&#x27;s bikes. | [optional] 
**Shoes** | [**List&lt;SummaryGear&gt;**](SummaryGear.md) | The athlete&#x27;s shoes. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

