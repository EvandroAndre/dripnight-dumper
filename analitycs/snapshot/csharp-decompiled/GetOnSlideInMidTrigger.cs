using GCommon;

public class GetOnSlideInMidTrigger : Entity
{
	private int _003CSlideGroupID_003Ek__BackingField;

	private int _003CSlideNumber_003Ek__BackingField;

	public int SlideGroupID
	{
		get
		{
			return _003CSlideGroupID_003Ek__BackingField;
		}
		set
		{
			_003CSlideGroupID_003Ek__BackingField = value;
		}
	}

	public int SlideNumber
	{
		get
		{
			return _003CSlideNumber_003Ek__BackingField;
		}
		set
		{
			_003CSlideNumber_003Ek__BackingField = value;
		}
	}

	protected override void OnAwake()
	{
	}
}
