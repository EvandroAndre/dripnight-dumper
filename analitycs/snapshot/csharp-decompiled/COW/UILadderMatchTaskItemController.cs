using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using message;
using proto;

namespace COW;

public class UILadderMatchTaskItemController : UIBaseController, UITable2.IUITable2Item
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<uint> _003C_003E9__11_0;

		public static Converter<uint, object> _003C_003E9__11_1;

		public static Predicate<uint> _003C_003E9__13_0;

		public static Converter<uint, object> _003C_003E9__13_1;

		internal bool _003CInitViewData_003Eb__11_0(uint i)
		{
			return false;
		}

		internal object _003CInitViewData_003Eb__11_1(uint s)
		{
			return null;
		}

		internal bool _003CInitViewData_003Eb__13_0(uint i)
		{
			return false;
		}

		internal object _003CInitViewData_003Eb__13_1(uint s)
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass9_0
	{
		public UILadderMatchTaskItemController _003C_003E4__this;

		public int index;

		public object data;

		internal void _003CSetViewData_003Eb__0()
		{
		}
	}

	private UIElitePassChallengeItemView m_View;

	private UICountDownController m_CDController;

	private DLBMPCCFKKM m_CurMatchMode;

	private List<UIStandardItemMiniController> m_RewardItemCtrlList;

	public ERankingTask.State TaskState;

	private uint DelayCallID;

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

	private void SetViewData(int index, object data)
	{
	}

	private void InitViewAllKindData(int index, object data)
	{
	}

	private void InitViewData(int index, RankingTaskInfo taskInfo)
	{
	}

	public UIWidget GetItemWidget()
	{
		return null;
	}

	private void InitViewData(int index, CSRankingTaskInfo taskInfo)
	{
	}

	private void SetCountDownView(ulong endTime)
	{
	}

	private void SetReward(List<BaseItemInfo> lst)
	{
	}

	private void SetBtnView(ERankingTask.State state, ERankingTask.Type tasktype)
	{
	}

	private void OnGoTaskClick()
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

	private void _003CSetCountDownView_003Eb__14_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
