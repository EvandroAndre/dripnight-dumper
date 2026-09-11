using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using message;

namespace COW;

public class UIHudLWSOLeaderBoardController : UIBaseController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<MFNHNEDOGKH> _003C_003E9__14_0;

		public static Comparison<MFNHNEDOGKH> _003C_003E9__14_1;

		public static Comparison<MFNHNEDOGKH> _003C_003E9__15_0;

		internal int _003CRefreshItem_003Eb__14_0(MFNHNEDOGKH a, MFNHNEDOGKH b)
		{
			return 0;
		}

		internal int _003CRefreshItem_003Eb__14_1(MFNHNEDOGKH a, MFNHNEDOGKH b)
		{
			return 0;
		}

		internal int _003CChangeItemData_003Eb__15_0(MFNHNEDOGKH a, MFNHNEDOGKH b)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass13_0
	{
		public UIHudLWSOLeaderBoardController _003C_003E4__this;

		public bool canWaitMatchEnd;

		public int delayTime;

		public int phaseEndTime;

		internal void _003CShowLeaderBoard_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass16_0
	{
		public MFNHNEDOGKH m_Data;

		public UIHudLWSOLeaderBoardController _003C_003E4__this;

		public int randomCount;

		internal void _003CRefreshSelfInfo_003Eb__0()
		{
		}
	}

	private UIHudLWSOLeaderBoardView m_View;

	private UIModelMatch m_ModelMatch;

	private CIBDABGDGOM m_Game;

	private uint m_CloseUIDelayCallID;

	private uint m_RandomIconDelayCallID;

	private int m_CurrRound;

	private UIHudLWSOLeaderBoardItemController m_SelfItemCtrl;

	private List<UIHudLWSOLeaderBoardItemController> m_ItemCtrlList;

	private UIHudLWSOLeaderBoardItemController m_TempCtrl;

	private List<MFNHNEDOGKH> m_LWSOTeamInfoList;

	private List<UISprite> m_SelfInfoHPList;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void ShowLeaderBoard(bool matchMaking, bool canWaitMatchEnd)
	{
	}

	private void RefreshItem(bool matchMaking)
	{
	}

	private void ChangeItemData()
	{
	}

	private void RefreshSelfInfo(MFNHNEDOGKH m_Data, bool matchMaking, bool changeData)
	{
	}

	private void ShowZoneIconInfo(int zone, int Identity)
	{
	}

	private void ScrollViewOnDarg()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
