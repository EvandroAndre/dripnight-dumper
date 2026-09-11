using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIGameModeNewPlayerUnlockFeaturePreviewController : UIGameModeGameplayAffixPreviewController
{
	private sealed class _003CClosePreviewAfterAnimation_003Ed__1 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIGameModeNewPlayerUnlockFeaturePreviewController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CClosePreviewAfterAnimation_003Ed__1(int _003C_003E1__state)
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

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override IEnumerator ClosePreviewAfterAnimation()
	{
		return null;
	}

	public IEnumerator _003C_003EiFixBaseProxy_ClosePreviewAfterAnimation()
	{
		return null;
	}
}
