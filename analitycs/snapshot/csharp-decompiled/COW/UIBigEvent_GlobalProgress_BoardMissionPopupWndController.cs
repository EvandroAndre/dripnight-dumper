using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIBigEvent_GlobalProgress_BoardMissionPopupWndController : UIBaseController, IUIModelDataChangeObserver, IBigEventTemplateIdentifier
{
	private UIBigEvent_GlobalProgress_BoardMissionPopupWndView m_View;

	protected UIModelBigEventTemplate m_UIModelBigEventTemplate;

	protected UIModelActivity m_UIModelModelActivity;

	private List<UIBaseController> m_ListControllers;

	private List<UIBigEvent_GlobalProgress_Mission2Data> m_MissionDescList;

	private ResourceID m_GPBoardExchangeStoreVFXResID;

	private GameObject m_GPBoardExchangeStoreVFXGO;

	private EBigEventTemplateUseType _003CTemplateUseType_003Ek__BackingField;

	public EBigEventTemplateUseType TemplateUseType
	{
		get
		{
			return _003CTemplateUseType_003Ek__BackingField;
		}
		set
		{
			_003CTemplateUseType_003Ek__BackingField = value;
		}
	}

	protected UICommonRewardWndController.WndStyleEnum WndStyle => UICommonRewardWndController.WndStyleEnum.COMMON;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnClickBtnExchange()
	{
	}

	protected override void OnUIOpenAsChild()
	{
	}

	public void OnTemplateUIInit()
	{
	}

	private bool LoadGPBoardExchangeStoreVFX()
	{
		return false;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public EBigEventTemplateType GetTemplateType()
	{
		return EBigEventTemplateType.None;
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void RefreshExchangeStoreRedPoint()
	{
	}

	protected void ReloadMissionList()
	{
	}

	private int MissionCompareTo(UIBigEvent_GlobalProgress_Mission2Data x, UIBigEvent_GlobalProgress_Mission2Data y)
	{
		return 0;
	}

	protected void OnClickAllClaimedBtn()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpenAsChild()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
