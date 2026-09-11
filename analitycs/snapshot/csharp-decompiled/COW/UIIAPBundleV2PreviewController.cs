using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIIAPBundleV2PreviewController : UIPopupWindowController
{
	private sealed class _003CDelayInstantVFXObj_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIIAPBundleV2PreviewController _003C_003E4__this;

		public ResourceID resId;

		public bool isChoose1From3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDelayInstantVFXObj_003Ed__7(int _003C_003E1__state)
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

	private UIIAPBundleV2PreviewView m_View;

	private uint m_PlayVFXDelayCall;

	private List<GameObject> m_VFXObjList;

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

	private bool CheckIsChoose1From3()
	{
		return false;
	}

	private IEnumerator DelayInstantVFXObj(ResourceID resId, bool isChoose1From3)
	{
		return null;
	}

	private void PlayVFX(bool isChoose1From3)
	{
	}

	private void InstantVFXObj(Transform parent, ResourceID resId)
	{
	}

	private void _003CPlayVFX_003Eb__8_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
