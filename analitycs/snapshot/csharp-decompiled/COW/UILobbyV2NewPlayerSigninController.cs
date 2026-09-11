using GCommon;

namespace COW;

public class UILobbyV2NewPlayerSigninController : UIBaseController, ITipsDelegate
{
	private sealed class _003C_003Ec__DisplayClass10_0
	{
		public UIModelNewPlayerV3 modelNewPlayer;

		internal void _003CRefreshNewPlayerSigninState_003Eb__0()
		{
		}
	}

	private UILobbyNewEventNewPlayerSigninView m_View;

	private UICountDownController m_NewPlayerCountDownCtrl;

	private UIModelLobbyEventBubble m_ModelLobbyEventBubble;

	private UITipsNormalController m_GiftTipsCtrl;

	private float m_BubbleHideTime;

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

	private void Update()
	{
	}

	private void OnNewPlayerSigninClick()
	{
	}

	public void RefreshNewPlayerSigninState()
	{
	}

	public void ResetCountdownBubbleContainer(bool isShow)
	{
	}

	public bool ShowNewPlayerSigninIntroIfNeed()
	{
		return false;
	}

	public bool IsNewPlayerBubbleCanShow()
	{
		return false;
	}

	public void ResetNewPlayerBubble()
	{
	}

	public void OnTipsDataChange(ETipsType type, int num)
	{
	}

	private void HideBubble()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
