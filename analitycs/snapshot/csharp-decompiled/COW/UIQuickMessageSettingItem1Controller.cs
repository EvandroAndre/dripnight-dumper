using GCommon;
using UnityEngine;

namespace COW;

public class UIQuickMessageSettingItem1Controller : UIBaseController, UITable2.IUITable2Item, IQuickMsgItemData, IUIModelDataChangeObserver
{
	private UIQuickMessageSettingItem1View m_View;

	private UIModelQuickMessage m_ModelQuickMessage;

	private UIQuickMessageSettingController m_Parent;

	private bool m_NeedDownload;

	private UINewDownloadInfoController m_DownloadCtrl;

	private uint m_MsgId;

	private GameObject m_GlowVoice;

	private GameObject m_Icon;

	private const uint m_QuickMessageTxtColor = uint.MaxValue;

	private const uint m_QuickMessageTxtLockColor = 1886417151u;

	private const uint m_QuickMessageTxtPlayColor = 4239917311u;

	private GameObject m_NewItemVFX;

	private UIModelInventory m_ModelInventory;

	private CSVBaseData m_Data;

	public uint MsgId => 0u;

	public uint Type => 0u;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void RefreshAfterCreate()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void OnBtnClick()
	{
	}

	private void OnGoPosBtnClick()
	{
	}

	public object SetTable2ItemData(int index, object data, object viewState)
	{
		return null;
	}

	public void SetPosition(Vector2 position)
	{
	}

	public void SetTable2Visible(bool visible)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void RefreshUI(object data)
	{
	}

	private void RefreshUI(CSVBaseData data)
	{
	}

	private void RefreshGoPos(IngameQuickChatItemData chatItemData)
	{
	}

	private void ShowVoicePlayingVfx(bool value)
	{
	}

	private void RefreshDownloadView()
	{
	}

	private void DownloadSecondConfirmWnd()
	{
	}

	private void DownloadRes()
	{
	}

	private void ClearDownloadView()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
