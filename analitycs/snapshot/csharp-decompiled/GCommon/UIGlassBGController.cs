using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GCommon;

public class UIGlassBGController : MonoBehaviour
{
	private sealed class _003CWaitToSetGlassColor_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIGlassBGController _003C_003E4__this;

		public Color color;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CWaitToSetGlassColor_003Ed__8(int _003C_003E1__state)
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

	public UITexture Glass;

	public UISprite Black;

	public bool ShowBlackBG;

	private void Start()
	{
	}

	public void SetDepth(int depth)
	{
	}

	public void SetBlackAlpha(float alpha)
	{
	}

	public void SetBlackDepth(int depth)
	{
	}

	public void SetGlassColor(Color color)
	{
	}

	private IEnumerator WaitToSetGlassColor(Color color)
	{
		return null;
	}
}
