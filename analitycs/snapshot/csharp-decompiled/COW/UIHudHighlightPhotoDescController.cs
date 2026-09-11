using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudHighlightPhotoDescController : UIBaseController
{
	private sealed class _003CDelayEnableNumContainer_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudHighlightPhotoDescController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDelayEnableNumContainer_003Ed__6(int _003C_003E1__state)
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

	private UIHudHighlightPhotoDescView m_View;

	private Vector3 m_NameInitialPos;

	private bool m_HasCachedInitialPos;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void CacheInitialPosition()
	{
	}

	private IEnumerator DelayEnableNumContainer()
	{
		return null;
	}

	protected override void OnUIDestory()
	{
	}

	public void SetView(AlbumPhotoInfo photoInfo)
	{
	}

	public void SetPos(Vector3 leftPos, Vector3 rightPos, Vector3 bottomPos)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
