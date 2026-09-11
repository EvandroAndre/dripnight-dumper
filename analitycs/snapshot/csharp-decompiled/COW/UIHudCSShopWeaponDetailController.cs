using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudCSShopWeaponDetailController : UIBaseController
{
	private sealed class _003C_003Ec__DisplayClass16_0
	{
		public AGACNOCEEFP weapondata;

		internal bool _003CRefreshWeapondetail_003Eb__0(WeaponTabData data)
		{
			return false;
		}
	}

	private sealed class _003CSetPosition_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudCSShopWeaponDetailController _003C_003E4__this;

		public Vector3 itemPos;

		private Transform _003CcontentTr_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CSetPosition_003Ed__12(int _003C_003E1__state)
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

	private UIHudCSShopWeaponDetailView m_View;

	private List<UIHudInventoryTagController> m_Ctrl;

	private Transform m_AttachTransform;

	private UISprite[] m_BuffTips;

	private float m_HeightDiff;

	private float m_TouchSpace;

	private float m_OringItemPosY;

	private HashSet<int> itemsNotShow;

	protected override void OnUIInit()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIDestory()
	{
	}

	private void Update()
	{
	}

	public void ShowDetail(uint weaponID, Transform targetTrans, uint buffID)
	{
	}

	private IEnumerator SetPosition(Vector3 itemPos)
	{
		return null;
	}

	private void RefreshBuff(uint buffID)
	{
	}

	private void UpdatePosition()
	{
	}

	private void RefershDetail(uint ID)
	{
	}

	private void RefreshWeapondetail(AGACNOCEEFP weapondata)
	{
	}

	private void RefreshItemDetail(uint ID, HENEHAGJCLI itemData)
	{
	}

	private UIHudInventoryTagController OpenInventoryTagFromPool(Transform transform)
	{
		return null;
	}

	public void HideDetail()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
