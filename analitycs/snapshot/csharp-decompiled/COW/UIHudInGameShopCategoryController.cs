using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudInGameShopCategoryController : UIBaseController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<Transform> _003C_003E9__8_0;

		public static Comparison<Transform> _003C_003E9__9_0;

		internal int _003CSetUIData_003Eb__8_0(Transform item1, Transform item2)
		{
			return 0;
		}

		internal int _003CSetUIData_003Eb__9_0(Transform item1, Transform item2)
		{
			return 0;
		}
	}

	private sealed class _003CSetUIData_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudInGameShopCategoryController _003C_003E4__this;

		public uint category;

		public List<BGMFPPDLCBB> itemList;

		public int cntPerFrame;

		private int _003Ci_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CSetUIData_003Ed__9(int _003C_003E1__state)
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

	private UIHudInGameShopCategoryView m_View;

	private int m_Category;

	private Dictionary<int, UIHudInGameShopItemController> m_ItemControllers;

	public int Category => 0;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override bool IsSuspended()
	{
		return false;
	}

	protected override void OnUIInit()
	{
	}

	public void SetUIData(uint category, List<BGMFPPDLCBB> itemList)
	{
	}

	public IEnumerator SetUIData(uint category, List<BGMFPPDLCBB> itemList, int cntPerFrame)
	{
		return null;
	}

	public void RefreshUIData(List<BGMFPPDLCBB> itemList)
	{
	}

	private void SetCategoryLabel(uint filter)
	{
	}

	public bool _003C_003EiFixBaseProxy_IsSuspended()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
