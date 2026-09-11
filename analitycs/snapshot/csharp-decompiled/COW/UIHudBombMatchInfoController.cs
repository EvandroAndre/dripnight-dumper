using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudBombMatchInfoController : UIBaseController
{
	private sealed class _003C_003Ec__DisplayClass34_0
	{
		public UIHudBombMatchInfoController _003C_003E4__this;

		public int odFaction;

		internal void _003COnODFactionSwitchDone_003Eb__0()
		{
		}
	}

	public static float AnimationTime;

	private UIHudBombMatchInfoView m_View;

	private List<UIHudCSPlayerStateInfoView> m_MyTeamViews;

	private List<UIHudCSPlayerStateInfoView> m_OppoTeamViews;

	private IIBMILKCJMH mGame;

	private UIModelMatch m_ModelMatch;

	private uint m_BaseTeamCount;

	private uint m_BaseItemSize;

	private uint m_BombExplodeTime;

	private MutableString m_Timer;

	private Color m_BombCountDownDangerousColor;

	private Color m_BombCountDownDangerousColor1;

	private int min;

	private int sec;

	private byte m_MyScore;

	private byte m_OtherScore;

	private bool m_IsMatchPointSoundPlayed;

	private List<int> m_states;

	private int m_CachedSeconds;

	private int m_CachedMilliSeconds;

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

	protected override void OnVisibilityChanged()
	{
	}

	private void OnBtnLeaderboardClick()
	{
	}

	private void SetUIData()
	{
	}

	private void RefreshTeamStatesUI(BHGGAEEHJCO pId)
	{
	}

	private void SetTeamStatesUI(List<BHGGAEEHJCO> pids, List<UIHudCSPlayerStateInfoView> views, bool ascending = true)
	{
	}

	private void OnPlayerHPChanged(GEvent data)
	{
	}

	private void OnPlayerStateChanged(object[] data)
	{
	}

	private void OnPlayerQuit(object[] data)
	{
	}

	private void OnScoreChanged(object[] data)
	{
	}

	private void PlayMatchPointSound(byte myScore, byte otherScore)
	{
	}

	public UIButton GetTutorialBtn()
	{
		return null;
	}

	public UIWidget GetTutorialWidget()
	{
		return null;
	}

	private void SetRoundInfoUI()
	{
	}

	private void OnODFactionSwitchDone(object[] data)
	{
	}

	private void OnODFactionChanged(object[] data)
	{
	}

	private void ResetSwitchAnimation()
	{
	}

	private void ShowSwitchFactionSprites(bool v)
	{
	}

	private void ShowFixedFactionSprites(bool v)
	{
	}

	private void SetODFaction(int ODFactionId)
	{
	}

	private void OnBombPlantTimeSync(object[] data)
	{
	}

	private void Update()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
