using GCommon;
using UnityEngine;

namespace COW;

public class CommonRewardWndStyleCSPeakTournamentController : CommonRewardWindowStyleBaseController
{
	public uint m_RankPoints;

	private UICSPeakTournamentRankIconController m_RankIconCtrl;

	private CommonRewardWnd_BGStyle_CSPeakTournamentViewExt m_ViewExt;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void SetUserData(object userData)
	{
	}

	private void SetUIData()
	{
	}

	protected override string GetNormalBtnSpriteName()
	{
		return null;
	}

	protected override string GetGuideBtnSpriteName()
	{
		return null;
	}

	public override void GetRewardGridPosAndPivot(out Vector3 pos, out UIWidget.Pivot? pivot)
	{
		pos = default(Vector3);
		pivot = null;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_SetUserData(object P0)
	{
	}

	public string _003C_003EiFixBaseProxy_GetNormalBtnSpriteName()
	{
		return null;
	}

	public string _003C_003EiFixBaseProxy_GetGuideBtnSpriteName()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_GetRewardGridPosAndPivot(out Vector3 P0, out UIWidget.Pivot? P1)
	{
		P0 = default(Vector3);
		P1 = null;
	}
}
