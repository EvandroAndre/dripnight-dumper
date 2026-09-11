using GCommon;
using UnityEngine;
using message;
using proto;

namespace COW;

public class UISeasonYearHeroicPointController : UIBaseController
{
	protected UISeasonYearHeroicPointView m_View;

	protected SeasonState m_SeasonState;

	private UIModelLadderMatch m_ModelBRLadderMatch;

	private UIModelCSLadderMatch m_ModelCSLadderMatch;

	private UIModelSeasonYear m_ModelSeasonYear;

	private UIModelCSPeakTournamentLadderMatch m_ModelCSPeakTournamentLadderMatch;

	private uint m_CurBRRankId;

	private uint m_CurCSRankId;

	private ResourceID m_LightUpIconRes;

	private ResourceID m_UnLightUpIconRes;

	private ResourceID m_BeforeRankLightUpIconRes;

	protected ResourceID m_LightUpIconSoundRes;

	private bool m_IsReachMaster;

	private bool m_IsCurSeasonId;

	private string m_TipsTitle;

	private string m_TipsTime;

	private string m_TipsKey;

	private Animation m_LightUpAnim;

	private float m_LightUpRankScale;

	private float m_BeforeRankLightUpRankScale;

	private Vector3 m_DefaultLightUpRankScale;

	private Vector3 m_DefaultBeforeRankLightUpRankScale;

	protected string m_UnLightUpBRIconName;

	protected string m_UnLightUpCSIconName;

	protected string m_InProgressBRIconName;

	protected string m_InProgressCSIconName;

	protected string m_UnOpenBRIconName;

	protected string m_UnOpenCSIconName;

	private uint m_LightUpAnimDelayCall;

	public bool IsReachHeroic;

	private UICSPeakTournamentRankIconController m_CSPeakTRankIconController;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected virtual uint GetSeasonYearId()
	{
		return 0u;
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected virtual void InitSeasonYearIconNames()
	{
	}

	protected virtual PeakRankData GetHistoryPeakRankData(DLBMPCCFKKM rankType = DLBMPCCFKKM.EMATCHMODE_RANKING, PlayerHistorySeasonRankInfo rankInfo = null)
	{
		return null;
	}

	protected virtual void SetSeasonYearLabelStyle(uint seasonId)
	{
	}

	public void SetPointView(SeasonYearRankType rankType, uint seasonId, uint index)
	{
	}

	protected virtual void SetSeasonStateBySeasonId(SeasonYearRankType rankType, uint seasonId, uint index)
	{
	}

	private void SetBeforeRankRes(SeasonYearRankType rankType, bool isReachMaster)
	{
	}

	private void SetLightUpView()
	{
	}

	private void SetUnLightUpView(SeasonYearRankType rankType)
	{
	}

	private void SetInProgressView(SeasonYearRankType rankType)
	{
	}

	private void SetLightUpIcon()
	{
	}

	private void SetUnOpenView(SeasonYearRankType rankType)
	{
	}

	private void OnShowMoreBtnClick()
	{
	}

	private void DelayShowPointUIFX()
	{
	}

	private void SetCSPeakView()
	{
	}

	private void _003CDelayShowPointUIFX_003Eb__47_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
