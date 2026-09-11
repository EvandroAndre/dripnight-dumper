using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudPickupListItemController : UIBaseController
{
	private sealed class _003CPressCheckCoroutine_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudPickupListItemController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPressCheckCoroutine_003Ed__33(int _003C_003E1__state)
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

	private const string ITEM_STATE_BAN = "icon_ban";

	private const string ITEM_STATE_MAX = "UI_icon_Max";

	private const string ITEM_STATE_INC = "UI_icon_up_arrow";

	private const string ITEM_STATE_DEC = "UI_icon_down_arrow";

	private const string ITEM_STATE_REP = "icon_replace";

	private static Color ItemDisable;

	private static Color ItemNameDisable;

	private UIHudPickupListItemView m_View;

	protected ICLMFONIIKB m_CurrentItem;

	protected uint m_CurrentContainerID;

	protected int m_Index;

	private bool m_pressState;

	private float m_pressTime;

	protected bool m_longPressed;

	private bool m_BtnClickCanUse;

	private float m_currentCD;

	private float m_MarkCD;

	protected uint m_ShowItemDataID;

	private HLFMGNDDGBF CurrentPickupLevel;

	private uint m_AsyncLoadUIAtlasTicket;

	public BountyPickupStatus BountyStatus;

	private bool m_ShowAwakeIcon;

	private bool m_ShowTermIcon;

	private bool m_ShowSpecialWeponIcon;

	private UITweener[] tweenrs;

	public HENEHAGJCLI CurrentItemData => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override bool RecyleDontDestroy()
	{
		return false;
	}

	public static bool DontDestroy()
	{
		return false;
	}

	protected override void OnUIInit()
	{
	}

	public override void OnUIReInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void OnPressHud(GameObject go, bool state)
	{
	}

	private string OnBotAgentGetRunTimeData()
	{
		return null;
	}

	private void ChangePressState(bool state)
	{
	}

	private IEnumerator PressCheckCoroutine()
	{
		return null;
	}

	private void Update()
	{
	}

	private void OnEnterMarkItemCDTime(object[] param)
	{
	}

	public void RefreshPickLevel(AutoPickUpHelper helper)
	{
	}

	public bool ShowFullTutorial()
	{
		return false;
	}

	public UIButton GetTutorialBtn()
	{
		return null;
	}

	public UIWidget GetTutorialWidget()
	{
		return null;
	}

	private void ShowLightMask()
	{
	}

	private void HideLightMask()
	{
	}

	private void SetLevelEffect()
	{
	}

	private void SetTermIcon()
	{
	}

	public void SetUIData(ICLMFONIIKB item, int index = 0)
	{
	}

	private void UpdateWLIconBG(ICLMFONIIKB item)
	{
	}

	private void UpdateCarni25BG(HENEHAGJCLI itemData)
	{
	}

	private void UpdateTreasureHuntBG(HENEHAGJCLI itemData)
	{
	}

	public bool IsEqualPickUp(ICLMFONIIKB pu)
	{
		return false;
	}

	private void OnPickToBagClick()
	{
	}

	public void OnBtnItemActionClick()
	{
	}

	public virtual void OnPickUpItemAction(bool isAutoPickUp, bool isToSafeBox = false, bool equipImmediately = true)
	{
	}

	private void OnPickUpCountAdd(uint pickupUID, uint itemCount)
	{
	}

	private void OnPickUpSelectStateChange(uint paramUniqueID)
	{
	}

	private void ShowPickupItemEffect(uint count)
	{
	}

	public void SetBuffData(uint buffId)
	{
	}

	public virtual void SetHotTag(uint itemID)
	{
	}

	protected void SetHotTagState(bool show)
	{
	}

	public void SetNewTag(uint itemID)
	{
	}

	private void OnPinMark()
	{
	}

	private void RefreshActivityIconTips()
	{
	}

	private void RefreshItemName(string nameStr, bool isAllowScroll = false)
	{
	}

	public bool _003C_003EiFixBaseProxy_RecyleDontDestroy()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIReInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
