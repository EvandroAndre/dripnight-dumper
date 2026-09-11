using COW.GamePlay;
using GCommon;

namespace COW;

internal class UIHudCSSOLeaderboardController : UIBaseController
{
	private sealed class _003C_003Ec__DisplayClass13_0
	{
		public int delayTime;

		public UIHudCSSOLeaderboardController _003C_003E4__this;

		public int phaseEndTime;

		internal void _003CShowNewRoundStart_003Eb__0()
		{
		}
	}

	private UIHudCSSOLeaderboardView m_View;

	private GIOBEJEFOGC m_Game;

	private uint m_DelayCallID;

	private UIModelMatch m_ModelMatch;

	private const string DELAYTIMEKEY = "({0}s)";

	private int m_CurrRound;

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

	public void NewRoundStart()
	{
	}

	public void ShowLeaderBoard()
	{
	}

	private void CreateItemCtrl(bool newRoundStart)
	{
	}

	public void RefreshRoundInfo(bool newRoundStart)
	{
	}

	private void ShowNewRoundStart()
	{
	}

	private void ShowCurrRoundInfo()
	{
	}

	private void CancelDelayCall()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
