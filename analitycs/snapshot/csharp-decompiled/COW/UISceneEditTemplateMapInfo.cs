using System;
using proto;

namespace COW;

public class UISceneEditTemplateMapInfo
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<uint> _003C_003E9__12_0;

		internal bool _003Cop_Implicit_003Eb__12_0(uint x)
		{
			return false;
		}
	}

	public SceneEditSlotInfo SlotInfo;

	public string text;

	public string cdn;

	public EUGCScene scene;

	public uint pageId;

	public EMAP_Type type;

	public UISceneEditUGCCenterController.ETabIndex ETabIndex;

	public bool IsShowCrown;

	private bool _003CIsUGCVipMap_003Ek__BackingField;

	public bool IsUGCVipMap
	{
		get
		{
			return _003CIsUGCVipMap_003Ek__BackingField;
		}
		private set
		{
			_003CIsUGCVipMap_003Ek__BackingField = value;
		}
	}

	public static implicit operator UISceneEditTemplateMapInfo(WorkshopHotInfo data)
	{
		return null;
	}

	public static implicit operator UISceneEditTemplateMapInfo(WorkshopAuthorSlotInfo data)
	{
		return null;
	}

	public static implicit operator UISceneEditTemplateMapInfo(WorkshopHistoryInfo data)
	{
		return null;
	}

	public static implicit operator UISceneEditTemplateMapInfo(WorkshopLatestInfo data)
	{
		return null;
	}

	public static implicit operator UISceneEditTemplateMapInfo(SceneEditSlotInfo data)
	{
		return null;
	}

	public static implicit operator UISceneEditTemplateMapInfo(WorkshopBasicInfo data)
	{
		return null;
	}
}
