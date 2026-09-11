using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UICouponTipsController : UIPopupWindowController
{
	private sealed class _003CSetPosition_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UICouponTipsController _003C_003E4__this;

		public Vector3 itemPos;

		private Transform _003CcontentTr_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CSetPosition_003Ed__13(int _003C_003E1__state)
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

	private UICouponTipsView m_View;

	private List<Item> m_ItemList;

	private List<GameObject> m_ItemContainers;

	private const int m_MinContentWidth = 215;

	private const int m_Padding = 17;

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

	protected override bool UseCustomizedAnimation()
	{
		return false;
	}

	public override int MinGroupDepth()
	{
		return 0;
	}

	public void SetData(string title, string tips, Vector3 itemPos, Item item1 = null, Item item2 = null)
	{
	}

	public void SetData(string title, string tips, Vector3 itemPos, List<Item> list)
	{
	}

	private void RefreshItem()
	{
	}

	private IEnumerator SetPosition(Vector3 itemPos)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return false;
	}

	public int _003C_003EiFixBaseProxy_MinGroupDepth()
	{
		return 0;
	}
}
