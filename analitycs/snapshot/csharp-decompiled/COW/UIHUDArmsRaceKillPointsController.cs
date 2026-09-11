using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHUDArmsRaceKillPointsController : UIBaseController
{
	private sealed class _003CIEPointsUpAnim_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHUDArmsRaceKillPointsController _003C_003E4__this;

		private int _003CrealPointLevel_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CIEPointsUpAnim_003Ed__21(int _003C_003E1__state)
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

	private const float m_PointLightUpAnimDuration = 1f;

	private const float m_LevelUpTransitionAnimDuration = 1.5f;

	private const float m_LevelUpTransitionDelay = 0.5f;

	private const string m_LevelUpTransitionAnimName = "UIFX_HUDArmsRaceKillPoints_Switch";

	private UIHUDArmsRaceKillPointsView m_View;

	private int m_KillPoints;

	private int m_CurShowArmLevel;

	private int m_CurShowAnimPoint;

	private Coroutine m_AnimHandle;

	private List<KCIPKBBMIOJ> m_CachArmsList;

	private List<UIHUDArmsRacePointItem> m_PointItems;

	private bool m_IsPlayingPointUpAnim;

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

	private void OnGameArmsListCome(object[] param)
	{
	}

	private bool IsQuickApproachNeeded()
	{
		return false;
	}

	private int GetPointIndexWithLevel(int point, int level)
	{
		return 0;
	}

	private void QuickApproachKillPoints()
	{
	}

	private void OnArmKillPointsCome(object[] param)
	{
	}

	private void PlayPointsUpAnim()
	{
	}

	private IEnumerator IEPointsUpAnim()
	{
		return null;
	}

	private int GetShowLevelByPoint(int point)
	{
		return 0;
	}

	private int GetRealLevelByPoint(int point)
	{
		return 0;
	}

	private void PrepareShowLevelEmptyPoint(int showLevel)
	{
	}

	private void LightingKillPoint(int index)
	{
	}

	private void OnKillLeader(object[] param)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
