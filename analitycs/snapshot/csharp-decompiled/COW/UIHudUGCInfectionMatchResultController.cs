using System;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

internal class UIHudUGCInfectionMatchResultController : UIHudSingleFightMatchResultController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__8_0;

		public static Action _003C_003E9__8_1;

		internal void _003COnShowDetailUI_003Eb__8_0()
		{
		}

		internal void _003COnShowDetailUI_003Eb__8_1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass10_0
	{
		public UGCMatchStats matchStats;

		internal bool _003CSetMatch_003Eb__0(UGCPlayerStats x)
		{
			return false;
		}
	}

	private uint m_DelayID;

	private UIHudUGCInfectionMatchResultItemController m_SelfUIItem;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override bool IsNeedShowAvatar()
	{
		return false;
	}

	protected override void OnUIOpen()
	{
	}

	protected override bool NeedCountDown()
	{
		return false;
	}

	protected override bool IsShowDetailBtn()
	{
		return false;
	}

	protected void OnScrollViewMoving()
	{
	}

	protected override void OnShowDetailUI(bool show)
	{
	}

	protected override void RefreshDetailUI(MatchStats stats)
	{
	}

	private void SetMatch(UGCMatchStats matchStats)
	{
	}

	public override UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public bool _003C_003EiFixBaseProxy_IsNeedShowAvatar()
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public new bool _003C_003EiFixBaseProxy_NeedCountDown()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_IsShowDetailBtn()
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnShowDetailUI(bool P0)
	{
	}

	public new void _003C_003EiFixBaseProxy_RefreshDetailUI(MatchStats P0)
	{
	}

	public UIEasyListItemController _003C_003EiFixBaseProxy_OpenItemController(Transform P0)
	{
		return null;
	}
}
