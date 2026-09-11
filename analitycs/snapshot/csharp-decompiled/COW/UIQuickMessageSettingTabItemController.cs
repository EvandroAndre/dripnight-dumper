using GCommon;
using UnityEngine;

namespace COW;

public class UIQuickMessageSettingTabItemController : UIEasyListItemController, IUIModelDataChangeObserver
{
	private UIQuickMessageSettingTabItemView m_View;

	private UIQuickMessageSettingController m_Parent;

	private uint m_GroupId;

	private bool m_NeedDownload;

	private UIModelQuickMessage m_ModelQuickMessage;

	private ResourceID m_SpecialUIFXResourceID;

	private GameObject m_SpecialUIFXObj;

	private const string m_TacticIconName = "UI_Priview_icon_weapon";

	private const int m_TacticIconSize = 48;

	private const string m_DirectionIconName = "FF_Icon_Footprint";

	private const int m_DirectionIconSize = 40;

	private const string m_DiscussionIconName = "Icon_Chat_FastMessage";

	private const int m_DiscussionIconSize = 48;

	private EQuickChatMainTab m_MainTab;

	public EQuickChatMainTab MainTab
	{
		get
		{
			return EQuickChatMainTab.None;
		}
		set
		{
		}
	}

	public uint GroupId => 0u;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpenAsChild()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	private void RefreshSpecialUIFX(ResourceID resId)
	{
	}

	private void RefreshDownloadView()
	{
	}

	public void SetItemSelectedView(bool isShow)
	{
	}

	private void OnCustomizationItemClick(uint groupId)
	{
	}

	public override void OnItemBtnClick()
	{
	}

	public override void OnItemBtnUnSelect()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpenAsChild()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
