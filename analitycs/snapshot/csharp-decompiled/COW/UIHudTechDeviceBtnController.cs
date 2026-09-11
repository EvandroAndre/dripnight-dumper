using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;
using message;

namespace COW;

internal class UIHudTechDeviceBtnController : UIHudButtonBaseController
{
	private sealed class _003C_003Ec__DisplayClass36_0
	{
		public Player localPlayer;

		public NAELPAAELNO item;

		public HDAEFOANBGJ slot;

		internal void _003CChangeDeviceItemToHand_003Eb__0(NAELPAAELNO equipedItem)
		{
		}
	}

	private sealed class _003CPlayBigItemDissipateEffect_003Ed__62 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudTechDeviceBtnController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayBigItemDissipateEffect_003Ed__62(int _003C_003E1__state)
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

	private sealed class _003CPlayBigItemHintEffect_003Ed__59 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudTechDeviceBtnController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayBigItemHintEffect_003Ed__59(int _003C_003E1__state)
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

	private sealed class _003CPlayReplaceEffect_003Ed__53 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudTechDeviceBtnController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayReplaceEffect_003Ed__53(int _003C_003E1__state)
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

	public const uint VISIBILITY_STATE_EighthLand = 1073741824u;

	public const uint VISIBILITY_STATE_IIVFloatingLand = 536870912u;

	public const uint VISIBILITY_STATE_GB_GPGulag = 268435456u;

	private const string ACTION_FIRE = "Action1";

	private static float MaxDragDis;

	private static float BGRangeRadius;

	private static float MaxDragDisSquare;

	private UIHudTechDeviceBtnView m_View;

	private UIHudActiveSkillController m_ActiveSkillBtn;

	private PMBJNMOBLCA m_techDevice;

	private TechDeviceTable m_techDeviceData;

	private BFAFOOGEAFK m_techDeviceType;

	private TechDeviceUseType m_useType;

	private string m_strButtonAction;

	private Vector3 m_DragIconOriginalPos;

	private Vector3 m_DragStartPos;

	private Vector3 m_DragPressPos;

	private Camera m_Camera;

	private bool m_IsButtonDrag;

	private float m_PressTime;

	private bool m_IsPressed;

	private bool m_GlobalTouchEnd;

	private UIHudIngameHighLightTipController m_passiveTip;

	private float m_lastHideTime;

	private float m_lastCdFillAmount;

	private UIClickMask m_ClickMask;

	private bool m_IsNBGP2BigItemShow;

	private uint m_ReduceCDEffectId;

	private GameObject m_CustomCDEffect;

	private uint m_ModelHolderID;

	private ResourceID m_LastEffectResId;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnDevCountChange(GEvent data)
	{
	}

	private void OnUpdateTechDeviceInfo()
	{
	}

	private bool IsPassiveHud()
	{
		return false;
	}

	protected override void OnBtnClick()
	{
	}

	private void HidePassiveHighlight()
	{
	}

	private void SendUseProto()
	{
	}

	private void ChangeDeviceItemToHand()
	{
	}

	private void RefreshTutorialLabel()
	{
	}

	protected void Update()
	{
	}

	private void UpdateSkillInfo()
	{
	}

	private void UpdatePinSkillBtn()
	{
	}

	private void UpdateCDInfo()
	{
	}

	private void UpdateShowCdLeftTimeTxt()
	{
	}

	private void UpdateEffectingInfo()
	{
	}

	protected void OnNewItemOnHand(object[] param)
	{
	}

	protected override void OnBtnUp()
	{
	}

	protected override void OnBtnDown()
	{
	}

	protected override string GetMappingName()
	{
		return null;
	}

	private bool DeviceItemIsOnHand()
	{
		return false;
	}

	private void UpdateDrag()
	{
	}

	private bool CheckPressDrag()
	{
		return false;
	}

	private bool CheckMoveDrag()
	{
		return false;
	}

	private bool IsDragEnd()
	{
		return false;
	}

	private IEnumerator PlayReplaceEffect()
	{
		return null;
	}

	protected override void OnVisibilityChanged()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void OnPinMark()
	{
	}

	public void OnPinSkillBtnPinMark()
	{
	}

	private void OnPlayerBigItemHint()
	{
	}

	private IEnumerator PlayBigItemHintEffect()
	{
		return null;
	}

	private void OnPlayerBigItemRemove()
	{
	}

	private void ResetAnimationModify()
	{
	}

	private IEnumerator PlayBigItemDissipateEffect()
	{
		return null;
	}

	private void UpdateNBGPViewShow()
	{
	}

	private void ShowCustomTechdeviceInfo()
	{
	}

	private void ShowCustomCDOverEffect(bool value)
	{
	}

	private void OnModelLoaded(uint uniqueID, ResourceID vfxResID, GameObject instance)
	{
	}

	private void OnShowIIVActiveSkillUIEffect()
	{
	}

	private void ShowReduceCDEffect()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnBtnUp()
	{
	}

	public void _003C_003EiFixBaseProxy_OnBtnDown()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
