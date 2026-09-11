namespace COW;

public class PlayerEditRecPlanItem
{
	public enum EPublishStatus
	{
		NoContent,
		Unpublished,
		Published
	}

	private RecommendPlanItem _003CRecommendPlan_003Ek__BackingField;

	public EPublishStatus PublishState;

	public bool IsPublishedEditMode;

	public RecommendPlanItem RecommendPlan
	{
		get
		{
			return _003CRecommendPlan_003Ek__BackingField;
		}
		set
		{
			_003CRecommendPlan_003Ek__BackingField = value;
		}
	}
}
