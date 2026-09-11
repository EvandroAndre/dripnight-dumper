using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIWeaponSkinNewbieRecommendWndController : UIPopupWindowController, IUIModelDataChangeObserver
{
	private sealed class _003CInitData_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIWeaponSkinNewbieRecommendWndController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CInitData_003Ed__14(int _003C_003E1__state)
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

	private UIWeaponSkinNewbieRecommendWndView m_View;

	private List<NewbieWeaponRecommendData> m_NewbieRecommendWeaponTypes;

	private List<NewbieWeaponRecommendData> m_OtherWeaponTypeShow;

	private Dictionary<uint, UIWeaponSkinNewbieRecommendWeaponTypeItemController> m_ShowTypeToWeaponTypeItem;

	private List<UIWeaponSkinNewbieRecommendWeaponTypeItemController> m_AllTypesCtrls;

	private UIModelUser m_ModelUser;

	private UIModelWeaponProficiency m_ModelWeaponProficiency;

	private Coroutine m_InitCor;

	private bool m_hasInit;

	private ulong m_StartShowTime;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void Init()
	{
	}

	private void OnCenterChange(GameObject centeredobject)
	{
	}

	private IEnumerator InitData()
	{
		return null;
	}

	private void RefreshNewbieRecommendPage()
	{
	}

	private void RefreshWeaponTypesPage()
	{
	}

	private void CheckGuide()
	{
	}

	private void OnToWeaponTypesBtnClick()
	{
	}

	private void OnToNewbieRecommendTypesBtnClick()
	{
	}

	private void OnCloseBtnClick()
	{
	}

	private void CloseWhenClickRecommendWeapon(uint param)
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
