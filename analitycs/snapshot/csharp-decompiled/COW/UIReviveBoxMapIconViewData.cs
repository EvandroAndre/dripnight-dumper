using COW.GamePlay;
using GCommon;
using message;

namespace COW;

public class UIReviveBoxMapIconViewData : UIManagedLevelObjectMapIconViewData
{
	private LevelReviveBox _003CReviveBox_003Ek__BackingField;

	private UIMapUtil.MapOffsetContext _003CMapOffsetContext_003Ek__BackingField;

	private UIPanel _003CParentPanel_003Ek__BackingField;

	public LevelReviveBox ReviveBox
	{
		get
		{
			return _003CReviveBox_003Ek__BackingField;
		}
		private set
		{
			_003CReviveBox_003Ek__BackingField = value;
		}
	}

	public UIMapUtil.MapOffsetContext MapOffsetContext
	{
		get
		{
			return _003CMapOffsetContext_003Ek__BackingField;
		}
		private set
		{
			_003CMapOffsetContext_003Ek__BackingField = value;
		}
	}

	public UIPanel ParentPanel
	{
		get
		{
			return _003CParentPanel_003Ek__BackingField;
		}
		private set
		{
			_003CParentPanel_003Ek__BackingField = value;
		}
	}

	public UIReviveBoxMapIconViewData(LevelReviveBox reviveBox, UIMapUtil.MapOffsetContext mapOffsetContext, UIPanel parentPanel)
		: base(0u, OPICPDCLKAG.Invalid, default(ResourceID), keepRotationUp: false, keepVisuallyConstantWhenScale: false, EILKGGIDJEH.EItemMarkPointType_Location)
	{
	}
}
