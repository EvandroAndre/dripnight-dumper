using System;
using GCommon;

namespace COW;

public class UILobbyV2VeteranSigninController : UIBaseController, ITipsDelegate
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static OnFinished _003C_003E9__9_0;

		internal void _003CRefreshVeteranBtnState_003Eb__9_0()
		{
		}
	}

	private UILobbyNewEventVeteranSigninView m_View;

	private UICountDownController m_VeteranCountDownCtrl;

	private UIModelVeteran m_ModelVeteran;

	private UITipsNormalController m_GiftTipsCtrl;

	private UITipsNormalController m_StoreTipsCtrl;

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

	private void OnVeteranSigninClick()
	{
	}

	public void RefreshVeteranBtnState()
	{
	}

	public void ResetCountdownBubbleContainer(bool isShow)
	{
	}

	public bool ShowVeteranBubble()
	{
		return false;
	}

	public void ResetVeteranBubble()
	{
	}

	public bool IsVeteranBubbleCanShow()
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
