using System;
using GCommon;

namespace COW;

public class UILobbyV2PreVeteranController : UIBaseController, ITipsDelegate
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static OnFinished _003C_003E9__8_0;

		internal void _003CRefreshPreVeteranBtnState_003Eb__8_0()
		{
		}
	}

	private UILobbyNewEventPreVeteranView m_View;

	private UICountDownController m_PreVeteranCountDownCtrl;

	private UITipsNormalController m_GiftTipsCtrl;

	private UIModelPreVeteran m_ModelPreVeteran;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void OnBtnPreVeteranClick()
	{
	}

	public void RefreshPreVeteranBtnState(object[] data)
	{
	}

	public void ResetCountdownBubbleContainer(bool isShow)
	{
	}

	public void SetBubbleLabel()
	{
	}

	private string GetCurrentDate()
	{
		return null;
	}

	public bool ShowPreVeteranBubble()
	{
		return false;
	}

	public void ResetPreVeteranBubble()
	{
	}

	public bool IsPreVeteranBubbleCanShow()
	{
		return false;
	}

	public void OnTipsDataChange(ETipsType type, int num)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
