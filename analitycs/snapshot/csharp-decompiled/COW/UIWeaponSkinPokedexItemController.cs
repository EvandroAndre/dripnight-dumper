using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIWeaponSkinPokedexItemController : UIBaseController, UITable2.IUITable2Item, IUIModelDataChangeObserver
{
	private sealed class _003CDelayPlayOnStartAnim_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIWeaponSkinPokedexItemController _003C_003E4__this;

		public int delayFrameCount;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDelayPlayOnStartAnim_003Ed__20(int _003C_003E1__state)
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

	private const string ON_START_ANIM_NAME = "UIWeaponSkinPokedexItem_In";

	private UIWeaponSkinPokedexItemView m_View;

	private WeaponPokedexDesc m_PokedexData;

	private WeaponSkinBaseInfo m_Data;

	private int m_Index;

	private Item m_ItemInfo;

	private float m_gapTime;

	private const int delayFrameCount = 3;

	private ResourceID m_LastSetSprite;

	private bool m_IsIconReady;

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

	public void OnItemBtnSelect()
	{
	}

	public void SetViewData(object data, bool needPlayAnim = true)
	{
	}

	private void SetWeaponSprite()
	{
	}

	private void OnWeaponSkinUpgrade(uint newSkinId)
	{
	}

	public void SetPosition(Vector2 position)
	{
	}

	public object SetTable2ItemData(int index, object data, object viewState)
	{
		return null;
	}

	public void SetTable2Visible(bool visible)
	{
	}

	private IEnumerator DelayPlayOnStartAnim(int delayFrameCount)
	{
		return null;
	}

	private void PlayOnStartAnim()
	{
	}

	private void SetAlphaForSomeGo(int alpha)
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
