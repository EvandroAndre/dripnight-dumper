using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudRouletteMedkitController : UIBaseController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__18_0;

		public static Action _003C_003E9__18_1;

		internal void _003CSetControllerCursorEvent_003Eb__18_0()
		{
		}

		internal void _003CSetControllerCursorEvent_003Eb__18_1()
		{
		}
	}

	private sealed class _003CDoShowHint_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudRouletteMedkitController _003C_003E4__this;

		public Vector3 targetPos;

		private Transform _003CcontentTr_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDoShowHint_003Ed__17(int _003C_003E1__state)
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

	private static float MaxMoveDis;

	private static float CancelRadius;

	private static float CancelRadiusSquare;

	private UIHudRouletteMedkitView m_View;

	private List<UIHudMedkitItem> m_ItemList;

	private UIHudMedkitItem m_SelectItem;

	private int m_SelectIndex;

	private float m_FixedRatio;

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

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void RefreshItemInfo(object[] data)
	{
	}

	public void SetViewData(Vector3 curDirection, bool isShow, bool globalStop)
	{
	}

	private void SetSelectItem(UIHudMedkitItem item)
	{
	}

	private IEnumerator DoShowHint(Vector3 targetPos)
	{
		return null;
	}

	protected override void SetControllerCursorEvent(Action OnShowOrCreate, Action OnHideOrDestory)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
