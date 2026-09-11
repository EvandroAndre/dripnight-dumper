using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using UnityEngine;

namespace COW;

internal class UIHudInventoryExchangeItem : MonoBehaviour
{
	private sealed class _003CShowTutorialLater_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudInventoryExchangeItem _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CShowTutorialLater_003Ed__24(int _003C_003E1__state)
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

	public UILabel ExchangeNum;

	public UISprite ExchangeIcon;

	public UILabel ExchangeName;

	public UIButton ExchangeBtn;

	public UIWidget ExchangeWidget;

	public UIWidget ParentWidget;

	public GameObject LightMask;

	public Transform UIFXContainer;

	public Animation UIFXLabelEffect;

	public UILabel LabelEffectCount;

	public Transform HCQualityContainer;

	public UIColor QuailtyBg;

	public UISprite LightBG;

	public UILabel ValueLabel;

	public UILabel WeightLabel;

	private NAELPAAELNO m_CurrentItem;

	private int m_CurrentExchangeCount;

	private ICLMFONIIKB m_CurrentPickUp;

	private int m_PickCapacity;

	private bool m_IsUselessItem;

	private uint m_AsyncLoadUIAtlasTicket;

	private UITweener[] tweenrs;

	public void InitUI()
	{
	}

	public void ShowTutorial(bool paramShow)
	{
	}

	private IEnumerator ShowTutorialLater()
	{
		return null;
	}

	public void StopTutorial()
	{
	}

	public void SetViewData(NAELPAAELNO paramItem, ICLMFONIIKB pickItem, int pickCapacity, bool isUselessItem)
	{
	}

	public void OnBtnItemActionClick()
	{
	}

	public bool IsSameDataID(uint paramDataID)
	{
		return false;
	}

	private void ShowLightMask()
	{
	}

	private void HideLightMask()
	{
	}

	public void ShowDropItemEffect(uint count)
	{
	}

	public void Update()
	{
	}
}
