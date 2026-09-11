using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using message;
using proto;

namespace COW;

public class UIHudMatchResultMVPShowController : UIBaseController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<IngameFeedbackData> _003C_003E9__39_0;

		internal int _003CShowGroupMedals_003Eb__39_0(IngameFeedbackData a, IngameFeedbackData b)
		{
			return 0;
		}
	}

	private UIHudMatchResultMVPShowView m_View;

	private NIKKALKPIBO m_GameMode;

	private bool m_HasWaitContinue;

	private uint m_UIEnterDelayCallID;

	private float MVPUIEnterDelayTime;

	private bool m_NeedLogContinueBtn;

	private uint m_LikedCount;

	private bool m_IsMVPSelf;

	private ulong m_MVPAccountID;

	private bool m_HasLike;

	private int m_PanelDepth;

	private List<AvatarSkillData> m_ListSkill;

	private List<Transform> m_ListSkillTransform;

	private uint[] m_ListSkillIds;

	private Color m_ColorAfterLike;

	private UILeaderBoardTitleCommonController m_LeaderBoardTitleCommonCtrl;

	private UIPrivilegeIconController m_PrivilegeIconController;

	private NIKKALKPIBO GameMode => NIKKALKPIBO.EGAMEMODE_NONE;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIClose()
	{
	}

	public override void BeforeScreenshot()
	{
	}

	public override void AfterScreenshot()
	{
	}

	public void SetData(NIKKALKPIBO gameMode, TeammateStats mvpData, bool isWin)
	{
	}

	public void SetDelayData(float delay)
	{
	}

	public void SetDownloadState(bool flag)
	{
	}

	private void ShowLeaderBoardTitleInfo(LeaderBoardTitleShowingParams showParams)
	{
	}

	private void RefreshTableLater()
	{
	}

	private void OnClickShareBtn()
	{
	}

	private void OnClickContinueBtn()
	{
	}

	private void MVPUIEnter()
	{
	}

	private void SetPlayerLikedCountByEvent(object[] data)
	{
	}

	private void SetPlayerLikedCount(uint count, bool clickBySelf = false)
	{
	}

	private void SetLikeBubbleState(bool afterLike, uint count)
	{
	}

	private void OnClickLikeBtn()
	{
	}

	private void SetSkillList()
	{
	}

	private void GenerateMVPSkillItem()
	{
	}

	private void ShowGroupMedals(uint[] groupMedals)
	{
	}

	private UIHUDFeedbackGroupEndItemController GetFeedBackItem()
	{
		return null;
	}

	private void SetMVPGradeAndRating(bool isWin, float ratingPoint, float player_percentile, TeammateStats mvpData)
	{
	}

	private void SetPrivilegeIcon(uint mainType, uint subType)
	{
	}

	private void _003CRefreshTableLater_003Eb__29_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	public void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}
}
