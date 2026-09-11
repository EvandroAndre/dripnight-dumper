using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal abstract class UIInventoryItemControllerBase : UIBaseController
{
	private sealed class _003CTryLongPress_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIInventoryItemControllerBase _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CTryLongPress_003Ed__8(int _003C_003E1__state)
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

	protected UIItem m_Item;

	protected bool m_DragIn;

	protected UIEventListener m_eventListener;

	private Coroutine m_longPressCoroutine;

	protected int m_SelectCount;

	protected bool m_IsAmmo;

	protected List<int> m_LineList;

	protected override void OnUIInit()
	{
	}

	private void onDragStartItem(GameObject go)
	{
	}

	private void OnPressItem(GameObject go, bool state)
	{
	}

	private void StopLongPressCoroutine()
	{
	}

	private IEnumerator TryLongPress()
	{
		return null;
	}

	private void OnClickItem(GameObject go)
	{
	}

	protected override void OnUIDestory()
	{
	}

	public UIItem GetUIItem()
	{
		return null;
	}

	public virtual NAELPAAELNO GetItem()
	{
		return null;
	}

	public virtual int GetCount()
	{
		return 0;
	}

	public int GetCapacity()
	{
		return 0;
	}

	public int GetSelectCapacity()
	{
		return 0;
	}

	public uint GetUniqueNetID()
	{
		return 0u;
	}

	public bool IsEqualUniqueNetID(uint uniqueNetID)
	{
		return false;
	}

	public virtual void OnDrapStart()
	{
	}

	public void ResetNoDrag()
	{
	}

	public virtual bool OnDrapRelease(UIInventoryItemDragDropContainer container)
	{
		return false;
	}

	protected virtual bool HandleReleaseEvent(UIInventoryItemDragDropContainer container)
	{
		return false;
	}

	protected virtual void OnItemToggleChanged()
	{
	}

	public abstract UIToggle GetToggle();

	public abstract GameObject GetHighlightGO();

	public abstract void SetHighlightGoActive(bool paramActive);

	public abstract GameObject GetDragGO();

	public abstract GameObject GetNonDragGO();

	public abstract GameObject GetDragRedGo();

	public void SetSelectCount(int count)
	{
	}

	public int GetSelectCount()
	{
		return 0;
	}

	public void SetDeltaCount(int deltaCount)
	{
	}

	private bool CheckDragInLockedNumArea(int deltaCount)
	{
		return false;
	}

	public bool IsInLockedNumArea()
	{
		return false;
	}

	public virtual void ClearSelectCount()
	{
	}

	public void SetIsAmmo(bool value)
	{
	}

	public void ClearLineList()
	{
	}

	public void AddLine(int line)
	{
	}

	public List<int> GetLineList()
	{
		return null;
	}

	public int GetLineCount()
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
