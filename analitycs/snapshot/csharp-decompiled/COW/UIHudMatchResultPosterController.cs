using System;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIHudMatchResultPosterController : UIPreviewPopUpWindowController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<IngameFeedbackData> _003C_003E9__29_0;

		internal int _003CSetBadgeView_003Eb__29_0(IngameFeedbackData a, IngameFeedbackData b)
		{
			return 0;
		}
	}

	private UIHudMatchResultPosterView m_View;

	private Color m_BRtop3RankColor;

	private uint m_CurScreenShotType;

	private Action m_OnPosterSave;

	private EShareLadderIconType m_CurIconType;

	private bool m_IsBGLoadSuccess;

	private bool m_IsPreviewAvatarSuccess;

	private Vector3 m_WeaponAvatarPos;

	private uint m_ScreenShotDelayCall;

	private bool m_IsShowInFrontEndScene;

	private UIWaitingForRequestCircleController m_WaitingCircleController;

	private MatchStats m_CurMatchStats;

	private bool m_SetCloseSaveImageWnd;

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

	protected override bool UseCustomizedAnimation()
	{
		return false;
	}

	protected override FrontendPreviewType GetPreviewUIType()
	{
		return FrontendPreviewType.Lobby;
	}

	protected override UIWidget GetFrontEndPreviewBorder()
	{
		return null;
	}

	protected override void OnUIOpen()
	{
	}

	public void SetCloseSaveImageWnd(bool isClose)
	{
	}

	public void SharePoster(uint screenShotType, MatchStats matchStats, MatchIncome matchIncome, Action OnPosterSave, EShareLadderIconType iconType = EShareLadderIconType.None, bool isWin = true, bool isShowInFrontEndScene = false)
	{
	}

	public override void AfterScreenshot()
	{
	}

	public override void BeforeScreenshot()
	{
	}

	private void SetViewActive(bool active)
	{
	}

	public void ResetDefaultUIState()
	{
	}

	public void SetBRView(MatchStats matchStats, bool isWin)
	{
	}

	public void SetCSView(MatchStats matchStats, bool isWin)
	{
	}

	private void SetGameAnalysisView(MatchResultCommentsData commentData, bool isWinMVP, bool isLossMVP)
	{
	}

	public void SetBadgeView(MatchStats matchStats)
	{
	}

	public void SetGameInfoView(MatchStats matchStats)
	{
	}

	private void SetBGByType(MatchResultCommentsData data)
	{
	}

	private void SetGameName(MatchStats matchStats)
	{
	}

	private void TryScreenShot()
	{
	}

	private void showWeaponAvatar(uint weaponID, uint weaponSkinID)
	{
	}

	private void OnAvatarReady(UIStatedAvatar s)
	{
	}

	private BriefClanInfo GetMyTeamBriefClanInfo(MatchStats stats)
	{
		return null;
	}

	private void _003CSetBGByType_003Eb__31_0()
	{
	}

	private void _003CTryScreenShot_003Eb__33_0()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}

	public void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}
}
