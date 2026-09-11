using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using message;

namespace COW;

public class UIHudCSTeamGoalBtnController : UIBaseController
{
	private UIHudCSTeamGoalBtnView m_View;

	private CIJPLNEAIIH m_LastPhase;

	private uint m_PointId;

	private DFMAGBNLCHD m_Type;

	private uint m_SubType;

	private uint m_DelayCallHidePathID;

	private uint m_DelayCallClearTeamGoalSelectItemID;

	private bool m_CanClickItem;

	private bool m_GoContianerCanShow;

	private const string m_GoContainerOpenAnimation = "UIFX_UIHudCSTeamGoalBtn_Open";

	private const string m_GoContainerCloseAnimation = "UIFX_UIHudCSTeamGoalBtn_Close";

	private float m_GoContainerCloseAnimationLength;

	private uint m_DelayCallGoContainerHideID;

	private Dictionary<int, UIHudCSTeamGoalBtnItem> m_CSTeamGoalBtnItemDict;

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

	private void OnTeamGoalBtnClick()
	{
	}

	private void OnNewPhaseStarted(object[] param)
	{
	}

	private void OnRefreshTeamGoalGoContainer(bool isShow)
	{
	}

	public void BindTeamGoalTarget(uint id, string hintTxt, DFMAGBNLCHD type, uint subType)
	{
	}

	public void ResetTeamGoalBtnCtrl()
	{
	}

	public void TryShowTeamGoalSelectItem(uint id, int playerIndex, bool showSelectUIFX = false)
	{
	}

	public void TryHideTeamGoalSelectItem(uint id, int playerIndex)
	{
	}

	private void ClearTeamGoalSelectItem()
	{
	}

	private void RecyclePath()
	{
	}

	private void CancelDelay()
	{
	}

	private void _003COnRefreshTeamGoalGoContainer_003Eb__19_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
