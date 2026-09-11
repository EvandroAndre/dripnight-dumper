using GCommon;
using UnityEngine;
using proto;

namespace COW;

internal class UIHudUGCOneTeamMatchResultController : UIHudUGCSingleFightMatchResultController
{
	private sealed class _003C_003Ec__DisplayClass9_0
	{
		public UGCMatchStats matchStats;

		internal bool _003CSetMatch_003Eb__0(UGCPlayerStats x)
		{
			return false;
		}
	}

	private ulong m_SelfAccountID;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override bool IsNeedShowAvatar()
	{
		return false;
	}

	protected override bool NeedCountDown()
	{
		return false;
	}

	protected override void OnUIOpen()
	{
	}

	protected override bool IsShowDetailBtn()
	{
		return false;
	}

	protected override void OnUIClose()
	{
	}

	protected void OnScrollViewMoved()
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

	protected override void AdjustCountDownLabelPos()
	{
	}

	public bool _003C_003EiFixBaseProxy_IsNeedShowAvatar()
	{
		return false;
	}

	public new bool _003C_003EiFixBaseProxy_NeedCountDown()
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public bool _003C_003EiFixBaseProxy_IsShowDetailBtn()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public new void _003C_003EiFixBaseProxy_RefreshDetailUI(MatchStats P0)
	{
	}

	public UIEasyListItemController _003C_003EiFixBaseProxy_OpenItemController(Transform P0)
	{
		return null;
	}

	public new void _003C_003EiFixBaseProxy_AdjustCountDownLabelPos()
	{
	}
}
