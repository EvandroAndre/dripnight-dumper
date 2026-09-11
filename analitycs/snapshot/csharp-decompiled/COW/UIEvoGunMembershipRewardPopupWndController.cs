using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIEvoGunMembershipRewardPopupWndController : UIPopupWindowController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<MembershipAwardDesc> _003C_003E9__10_0;

		internal int _003CRefreshEvoPassAwardList_003Eb__10_0(MembershipAwardDesc x, MembershipAwardDesc y)
		{
			return 0;
		}
	}

	private sealed class _003CShowVFXCoroutine_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIEvoGunMembershipRewardPopupWndController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CShowVFXCoroutine_003Ed__12(int _003C_003E1__state)
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

	private UIEvoGunMembershipRewardPopupWndView m_View;

	private Vector3 PrivilegeItemSize;

	private UITable2.Margin PrivilegeItemMargin;

	private UIModelEvoPass m_ModelEvoPass;

	private Coroutine m_ShowVFXCoroutine;

	private Animation m_VFXAnimation;

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

	private void InitTemplate()
	{
	}

	private void RefreshEvoPassAwardList()
	{
	}

	private void StartVFX()
	{
	}

	private IEnumerator ShowVFXCoroutine()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitTemplate_003Eb__9_0()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitTemplate_003Eb__9_1()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}
