using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UICommonTweenTipsController : UIBaseController
{
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		public UICommonTweenTipsController _003C_003E4__this;

		public uint cnt;

		internal void _003CShowTips_003Eb__0(bool downloadResult, string spriteResult, bool haspengding)
		{
		}
	}

	private sealed class _003CHoldOnAnim_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UICommonTweenTipsController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CHoldOnAnim_003Ed__17(int _003C_003E1__state)
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

	private sealed class _003COnFinished_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UICommonTweenTipsController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003COnFinished_003Ed__16(int _003C_003E1__state)
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

	private UICommonTweenTipsView m_View;

	private Vector3 m_BasePos;

	private Vector3 m_CurrentPos;

	private Vector3 m_Offset;

	private float m_ClipLength;

	private Animation m_Anim;

	private TweenPosition m_ParentTP;

	private float m_HoldOnTime;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void MoveUp()
	{
	}

	public void SetDepth(int depth)
	{
	}

	public void ShowTips(string tips, float holdOnTime = 0f)
	{
	}

	public void ShowTips(BaseItemInfo itemInfo)
	{
	}

	public void ShowTips(ResourceID resId, uint cnt)
	{
	}

	public void ShowTips(string text, List<ResourceID> iconResList)
	{
	}

	public IEnumerator OnFinished()
	{
		return null;
	}

	public IEnumerator HoldOnAnim()
	{
		return null;
	}

	public override void Hide()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_Hide()
	{
	}
}
