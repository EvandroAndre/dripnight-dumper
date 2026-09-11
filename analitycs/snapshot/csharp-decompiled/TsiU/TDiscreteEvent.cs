namespace TsiU;

internal class TDiscreteEvent
{
	internal delegate int DiscreteEventAction(TAny workingData);

	private TTimeAbs _003CTriggeredTime_003Ek__BackingField;

	private int _003CPriority_003Ek__BackingField;

	private DiscreteEventAction _003CEventAction_003Ek__BackingField;

	internal TTimeAbs TriggeredTime
	{
		get
		{
			return _003CTriggeredTime_003Ek__BackingField;
		}
		set
		{
			_003CTriggeredTime_003Ek__BackingField = value;
		}
	}

	internal int Priority
	{
		get
		{
			return _003CPriority_003Ek__BackingField;
		}
		set
		{
			_003CPriority_003Ek__BackingField = value;
		}
	}

	internal DiscreteEventAction EventAction
	{
		get
		{
			return _003CEventAction_003Ek__BackingField;
		}
		set
		{
			_003CEventAction_003Ek__BackingField = value;
		}
	}
}
