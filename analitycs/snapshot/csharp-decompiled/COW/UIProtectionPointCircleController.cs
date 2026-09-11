using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIProtectionPointCircleController : UIBaseController
{
	private sealed class _003CStartProtectPointAnimation_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIProtectionPointCircleController _003C_003E4__this;

		private float _003ClerpValue_003E5__2;

		private float _003Cspeed_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CStartProtectPointAnimation_003Ed__31(int _003C_003E1__state)
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

	private UIProtectionPointCircleView m_View;

	private UIModelPeriodicLadderMatch m_ModelLadderPeriodic;

	private UIModelCSLadderMatch m_ModelLadderCS;

	private float m_OnePointAngle;

	private uint m_MatchMode;

	private uint m_BaseScore;

	private uint m_ExtraScore;

	public string TipsDesc;

	public uint ProtectPointBef;

	public uint ProtectPointNow;

	private uint m_BreakPointNum;

	private bool m_IsMatchResultPage;

	private Color m_ExtraPointColor;

	private Color m_MinusPointColor;

	private Color m_ExtraCircleColor;

	private uint m_AnimStartPoint;

	private uint m_AnimEndPoint;

	private EProtectionState m_ProtectionState;

	public uint BaseScore => 0u;

	public uint ExtraScore => 0u;

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

	private void SetProtectTitleTipDesc()
	{
	}

	private void SetProtectionState()
	{
	}

	private void SetBefCirclePercentAndNum(uint protectPointBefore)
	{
	}

	public void SetNowCirclePercentAndNum(uint protectPointNow, bool isMatchResultPage)
	{
	}

	public void SetViewData(uint rank, uint protectPointBefore, uint protectPointNow, uint gameMode, uint matchMode, bool isMatchResultPage = false)
	{
	}

	public void DoProtectPointAnimation(uint startPoint, uint endPoint)
	{
	}

	public IEnumerator StartProtectPointAnimation()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
