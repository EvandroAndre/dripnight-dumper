using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

internal class UIElitePassChallengeItemController : UIBaseController, UITable2.IUITable2Item
{
	private enum EPBtnState
	{
		OnGoing,
		Lock,
		Claimed,
		Reached,
		ReachedButIsNotEP
	}

	private sealed class _003C_003Ec__DisplayClass15_0
	{
		public UIElitePassChallengeItemController _003C_003E4__this;

		public object data;

		public int data_index;

		internal void _003CSetViewData_003Eb__0()
		{
		}
	}

	private UIElitePassChallengeItemView m_View;

	private UIModelBooyahPass m_BPModel;

	private EPChallengeInfo m_ChallengeInfo;

	private EPBtnState m_BtnState;

	private List<UIStandardItemMiniController> m_Rewards;

	private string PREFIX_TEAM_WORK;

	private string RANK_TASK;

	private uint DelayCallID;

	private string GoPosString;

	private int m_Index;

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	private void InitLabel()
	{
	}

	public void SetViewData(object data, int data_index)
	{
	}

	private void InitView(object data, int data_index)
	{
	}

	public void SetRefreshBtn()
	{
	}

	private void OnClaimBtnClick()
	{
	}

	private void OnRefreshBtnClick()
	{
	}

	private void OnGoTaskBtnClick()
	{
	}

	private void SetButtonState(EPTarget_Status taskState, bool isEPPlayer, bool isLock, bool isEPOnlyTask)
	{
	}

	private void SetReward(BaseItemInfo[] lst)
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

	private void _003COnRefreshBtnClick_003Eb__19_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
