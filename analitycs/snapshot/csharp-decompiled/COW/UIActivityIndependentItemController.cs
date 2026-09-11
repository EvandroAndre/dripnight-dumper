using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIActivityIndependentItemController : UIActivityOperationController
{
	private sealed class _003C_003Ec__DisplayClass12_0
	{
		public AwardDesc awardDesc;

		internal void _003CSetViewData_003Eb__0()
		{
		}
	}

	private sealed class _003CResetPosition_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIActivityIndependentItemController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CResetPosition_003Ed__13(int _003C_003E1__state)
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

	protected ClientActivityDesc m_Desc;

	protected UIActivityIndependentItemView m_View;

	protected UIModelActivity m_Model;

	protected List<UIStandardItemMiniController> m_ItemList;

	private bool _003CShowModel_003Ek__BackingField;

	protected UIModelActivity.ActivityOperateStatus m_OperateStatus;

	public bool ShowModel
	{
		get
		{
			return _003CShowModel_003Ek__BackingField;
		}
		set
		{
			_003CShowModel_003Ek__BackingField = value;
		}
	}

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

	public virtual void SetViewData(ClientActivityDesc desc)
	{
	}

	private IEnumerator ResetPosition()
	{
		return null;
	}

	public virtual void RefreshItemState()
	{
	}

	protected virtual void OnOperate()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
