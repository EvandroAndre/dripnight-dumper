using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHUDAOHKillPointsController : UIBaseController
{
	private sealed class _003CIEPointsUpAnim_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHUDAOHKillPointsController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CIEPointsUpAnim_003Ed__14(int _003C_003E1__state)
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

	private UIHUDAOHKillPointsView m_View;

	private int m_KillPoints;

	private int m_Level;

	private int m_CurShowLevel;

	private int m_CurShowPoint;

	private Coroutine m_AnimHandle;

	private bool m_IsPlayingPointUpAnim;

	protected BigHeadDataConfig m_BigHeadDataConfig;

	private List<UIHUDArmsRacePointItem> m_PointItems;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void OnPlayerLevelChange(object[] data)
	{
	}

	private void PlayPointsUpAnim()
	{
	}

	private IEnumerator IEPointsUpAnim()
	{
		return null;
	}

	private void LightingKillPoint(int index)
	{
	}

	private void PrepareShowLevelEmptyPoint(int showLevel)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
