using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class UICommonRewardBundleNotificationController : UIBaseController
{
	private sealed class _003COnFinish_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UICommonRewardBundleNotificationController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003COnFinish_003Ed__8(int _003C_003E1__state)
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

	private UICommonRewardBundleNotificationView m_View;

	private uint m_CloseDelayCall;

	private Action m_OnCloseAction;

	protected override void OnUIInit()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void SetData(AutoOpenBoxBundleData autoOpenBoxBundleData)
	{
	}

	public IEnumerator OnFinish()
	{
		return null;
	}

	public void SetOnCloseAction(Action onclose)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
