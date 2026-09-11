using System;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

internal class UIHudUGCMultiTeamMatchResultController : UIHudMatchResultBaseController, IEasyList
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__12_0;

		public static Action _003C_003E9__12_1;

		internal void _003COnShowDetailUI_003Eb__12_0()
		{
		}

		internal void _003COnShowDetailUI_003Eb__12_1()
		{
		}
	}

	private UIHudUGCMultiTeamMatchResultView m_View;

	private uint m_DelayID;

	private int[] m_RankToScoreRule;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public bool IsSelfTeam(ulong teamIndex)
	{
		return false;
	}

	protected override void OnUIInit()
	{
	}

	public override void AfterScreenshot()
	{
	}

	protected override bool NeedCountDown()
	{
		return false;
	}

	protected override void AdjustCountDownLabelPos()
	{
	}

	protected override void OnShowAvatarInfoUI()
	{
	}

	protected override void RefreshDetailUI(MatchStats stats)
	{
	}

	protected override void OnShowDetailUI(bool show)
	{
	}

	private void SetMatch(UGCMatchStats matchStats)
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	private bool _003CRefreshDetailUI_003Eb__11_0(UGCTeamStats item)
	{
		return false;
	}

	private bool _003CSetMatch_003Eb__13_0(UGCTeamStats item)
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}

	public bool _003C_003EiFixBaseProxy_NeedCountDown()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_AdjustCountDownLabelPos()
	{
	}

	public void _003C_003EiFixBaseProxy_OnShowAvatarInfoUI()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshDetailUI(MatchStats P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnShowDetailUI(bool P0)
	{
	}
}
