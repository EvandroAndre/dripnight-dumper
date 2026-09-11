using System.Collections.Generic;
using COW.GamePlay;
using GCommon;

namespace COW;

public class UIHudWereWolvesVoteItemController : UIEasyListItemController
{
	private UIHudWereWolvesVoteItemView m_View;

	private BEIPMEAHGNP m_info;

	private List<UIHudWereWolvesVoteIndexController> m_IdxChildList;

	private ulong m_userId;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnDestroy()
	{
	}

	public override void OnItemBtnSelect()
	{
	}

	public override void OnItemBtnUnSelect()
	{
	}

	private void QuickChatBtnClick()
	{
	}

	private void OnVoteSelectChanged(object[] data)
	{
	}

	private void OnPlayerRoleChange(object[] data)
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	private void OnMuteStateChange(object[] data)
	{
	}

	private void OnPlayerVoiceStateChange(object[] data)
	{
	}

	private void OnLocalPlayerVoiceStateChange(object[] data)
	{
	}

	public void RefreshSelectHighlight()
	{
	}

	public UIWidget GetEnabelQuickChatBtnTutWidget()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
