using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIHudUGCTeamBattleMatchResultItemController : UIHudMatchResultItemBaseController
{
	private sealed class _003CShowSelfBadgeVFXCoroutine_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudUGCTeamBattleMatchResultItemController _003C_003E4__this;

		private float _003Cdelay_003E5__2;

		private int _003Ci_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CShowSelfBadgeVFXCoroutine_003Ed__25(int _003C_003E1__state)
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

	protected UIHudUGCTeamBattleMatchResultItemView m_View;

	private Color Bar2Color;

	private Color Bar3Color;

	private Color BarlColor;

	private uint m_SreakScrollCallId;

	private int m_scrollIndex;

	private int BadgeMaskCount;

	private int BadgeMaxCount;

	private TeammateStats m_Player;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public void HandleGradeAndStreakPos(bool isConfigShowStreak = true)
	{
	}

	public void SetLocalTeam(bool localTeam)
	{
	}

	public void InitGradePanelDepth(int depth)
	{
	}

	private void StreakScroll()
	{
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnSetPlayerData(TeammateStats data, bool single)
	{
	}

	protected override void OnClickVisitorBtn()
	{
	}

	private void UpdateBadgeInfo(TeammateStats data)
	{
	}

	public override void OnChangePageType(EMatchResultPageType pageType)
	{
	}

	protected override void OnDestroy()
	{
	}

	private void UpdatePlayerData(TeammateStats player)
	{
	}

	private void UpdateTeamIndex(int index)
	{
	}

	private void UpdateWinStreakIcon(uint playerStreakWins)
	{
	}

	private void OnPlatformHeadpicGetted()
	{
	}

	public void ShowSelfBadgeVFX()
	{
	}

	private IEnumerator ShowSelfBadgeVFXCoroutine()
	{
		return null;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnSetPlayerData(TeammateStats P0, bool P1)
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
}
