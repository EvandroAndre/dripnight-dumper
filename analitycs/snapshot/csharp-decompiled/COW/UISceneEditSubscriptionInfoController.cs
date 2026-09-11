using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class UISceneEditSubscriptionInfoController : UIBaseController, IUIModelDataChangeObserver
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<SceneEditSlotInfo> _003C_003E9__8_0;

		public static Converter<SceneEditSlotInfo, UISceneEditTemplateMapInfo> _003C_003E9__8_1;

		internal bool _003CRefreshUI_003Eb__8_0(SceneEditSlotInfo e)
		{
			return false;
		}

		internal UISceneEditTemplateMapInfo _003CRefreshUI_003Eb__8_1(SceneEditSlotInfo temp)
		{
			return null;
		}
	}

	private UISceneEditSubscriptionInfoView m_View;

	private UIModelSceneEdit m_ModelSceneEdit;

	private List<UISceneEditTemplateMapItemController> m_CachedSubscriptionList;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void OnEmptyButtonClick()
	{
	}

	public static int CompareSubscriptionInfo(SceneEditSlotInfo infoA, SceneEditSlotInfo infoB)
	{
		return 0;
	}

	private void RefreshUI()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void _003CRefreshUI_003Eb__8_2(SceneEditSlotInfo slotInfo)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
