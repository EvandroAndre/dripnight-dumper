using GCommon;
using UnityEngine;
using tcp;

namespace COW;

public class UIHudMessageInviteChooseBoxController : UIEasyListItemController, UITable2.IUITable2Item
{
	private sealed class _003C_003Ec__DisplayClass10_0
	{
		public UIHudMessageInviteChooseBoxController _003C_003E4__this;

		public GroupInviteNtf inviteNtfData;

		internal void _003COnAcceptBtnClicked_003Eb__0()
		{
		}
	}

	private UIHudMessageInviteChooseBoxView m_View;

	private MessageInviteChooseBoxData m_Data;

	private bool m_IsCountDown;

	private string m_DescLabel;

	private float m_TimeStart;

	private float m_CountDownDuration;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void Update()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	private void OnAcceptBtnClicked()
	{
	}

	private void OnRejectBtnClicked()
	{
	}

	private void RefreshBtnState()
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

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
