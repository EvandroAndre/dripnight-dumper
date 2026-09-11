using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIHudNormalMatchResultItemController : UIHudMatchResultItemBaseController
{
	private sealed class _003CShowSelfBadgeVFXCoroutine_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudNormalMatchResultItemController _003C_003E4__this;

		private float _003Cdelay_003E5__2;

		private int _003Ci_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CShowSelfBadgeVFXCoroutine_003Ed__40(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	protected UIHudNormalMatchResultItemView m_View;

	private UIPrivilegeIconController m_PrivilegeIconController;

	private GameObject m_PrimeAvatarFrame;

	private ResourceID m_AvatarFrameRes;

	private float m_RatingNum;

	private Color BarlColor;

	private Color Bar2Color;

	private Color Bar3Color;

	private Color Bar4Color;

	private Color Bar5Color;

	private uint m_SreakScrollCallId;

	private int m_scrollIndex;

	private TeammateStats m_Player;

	private new MatchStats m_MatchStats;

	private int SelfBadgeMaxCount;

	private int NotSelfBadgeMaxCount;

	private int BadgeMaskCountSelf;

	private int BadgeMaskCountNotSelf;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public void SetLocalTeam(bool localTeam)
	{
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnSetPlayerData(TeammateStats data, bool single)
	{
	}

	public override void OnSetMatchData(MatchStats stats)
	{
	}

	protected override void OnClickVisitorBtn()
	{
	}

	public void InitGradePanelDepth(int depth)
	{
	}

	public override void OnChangePageType(EMatchResultPageType pageType)
	{
	}

	public void ShowRatingUIFX()
	{
	}

	protected override void OnDestroy()
	{
	}

	private void UpdatePlayerData(TeammateStats player)
	{
	}

	public override void SetGradeInfo(bool isMVP, bool win, string gradeTxt = "", bool hideScroe = false, bool isToxic = false)
	{
	}

	private void UpdateWinStreakIconAndRating(uint playerStreakWins, float br_ranking_rating_point, bool isMvp)
	{
	}

	private void UpdateWinStreakIconLabel(GameObject steakContainer, UILabel streakTxt, UISprite icon, uint playerStreakWins)
	{
	}

	private void UpdateTeamIndex(int index)
	{
	}

	public void HandleGradeAndStreakPos()
	{
	}

	private void StreakScroll()
	{
	}

	private void OnPlatformHeadpicGetted()
	{
	}

	private void UpdateBadgeInfo(TeammateStats data)
	{
	}

	public void SetInfoTxTPos(float[] posX)
	{
	}

	public void SetDataTxTPos(float[] posX)
	{
	}

	public void ShowSelfBadgeVFX()
	{
	}

	private IEnumerator ShowSelfBadgeVFXCoroutine()
	{
		return null;
	}

	private void SetPrivilegeIcon(uint mainType, uint subType)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnSetPlayerData(TeammateStats P0, bool P1)
	{
	}

	public void _003C_003EiFixBaseProxy_OnSetMatchData(MatchStats P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnClickVisitorBtn()
	{
	}

	public void _003C_003EiFixBaseProxy_OnChangePageType(EMatchResultPageType P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_SetGradeInfo(bool P0, bool P1, string P2, bool P3, bool P4)
	{
	}
}
