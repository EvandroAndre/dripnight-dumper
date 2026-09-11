using COW.GamePlay;
using GCommon;
using message;

namespace COW;

public class UIManagedLevelObjectMapIconViewData : GEvent
{
	private uint _003CLevelObjectID_003Ek__BackingField;

	private bool _003CKeepRotationUp_003Ek__BackingField;

	private bool _003CKeepVisuallyConstantWhenScale_003Ek__BackingField;

	private OPICPDCLKAG _003CLevelObjectType_003Ek__BackingField;

	private ResourceID _003CContentResID_003Ek__BackingField;

	private EILKGGIDJEH _003CMarkPointType_003Ek__BackingField;

	public uint LevelObjectID
	{
		get
		{
			return _003CLevelObjectID_003Ek__BackingField;
		}
		private set
		{
			_003CLevelObjectID_003Ek__BackingField = value;
		}
	}

	public bool KeepRotationUp
	{
		get
		{
			return _003CKeepRotationUp_003Ek__BackingField;
		}
		private set
		{
			_003CKeepRotationUp_003Ek__BackingField = value;
		}
	}

	public bool KeepVisuallyConstantWhenScale
	{
		get
		{
			return _003CKeepVisuallyConstantWhenScale_003Ek__BackingField;
		}
		private set
		{
			_003CKeepVisuallyConstantWhenScale_003Ek__BackingField = value;
		}
	}

	public OPICPDCLKAG LevelObjectType
	{
		get
		{
			return _003CLevelObjectType_003Ek__BackingField;
		}
		private set
		{
			_003CLevelObjectType_003Ek__BackingField = value;
		}
	}

	public ResourceID ContentResID
	{
		get
		{
			return _003CContentResID_003Ek__BackingField;
		}
		private set
		{
			_003CContentResID_003Ek__BackingField = value;
		}
	}

	public EILKGGIDJEH MarkPointType
	{
		get
		{
			return _003CMarkPointType_003Ek__BackingField;
		}
		private set
		{
			_003CMarkPointType_003Ek__BackingField = value;
		}
	}

	public UIManagedLevelObjectMapIconViewData(uint levelObjectID, OPICPDCLKAG levelObjectType, ResourceID contentResID, bool keepRotationUp = true, bool keepVisuallyConstantWhenScale = true, EILKGGIDJEH markPointType = EILKGGIDJEH.EItemMarkPointType_MapLocation)
	{
	}
}
