using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIOperationSettingController : UISettingContentBase
{
	private enum OperationSettingKey
	{
		AimAssist,
		LeftShot,
		ChangeGun,
		Reload,
		SniperMode,
		GrenadeSlot,
		SmartIceWall,
		VehicleControlMode,
		AutoSliding,
		FastMethod,
		AutoPickup,
		AutoSwitchWeapon,
		UseAuxAim,
		UseAuxAimParachute,
		UseAuxAimDash,
		UseAuxAimDrive,
		CrossHairReload,
		SmartIceWallZeroShow,
		HitArmorHint,
		SmartIceWallAutoChangeBackWeapon,
		HUDButtonHint,
		ShowCDTimeTxt,
		MovingJoystickMode
	}

	private enum SettingBlock
	{
		Shot,
		Accessibility,
		Grenade,
		Move,
		Real60Frame
	}

	private sealed class _003CRefreshScroll_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIOperationSettingController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRefreshScroll_003Ed__16(int _003C_003E1__state)
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

	private UIOperationSettingView m_View;

	private OperationSettingInfo m_SettingInfo;

	private bool NeedRescrollCor;

	private Dictionary<int, UICommonSettingContentShortController> m_CtrlDict;

	private Dictionary<int, CommonSettingContentData> m_DataDict;

	private UIModelSetting m_Model;

	private readonly List<int> m_Val10;

	private readonly List<int> m_Val01;

	private readonly List<string> m_Key;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override void RefreshContent(object[] param)
	{
	}

	protected override void OnUIInit()
	{
	}

	public void ShowDefaultCDN()
	{
	}

	private void Start()
	{
	}

	private IEnumerator RefreshScroll()
	{
		return null;
	}

	private void ResetScrollViewWidth()
	{
	}

	protected override void InitSettingInfo()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private CommonSettingContentData CreateShotBlockData()
	{
		return null;
	}

	private void ResetShotBlockToDefault()
	{
	}

	private CommonSettingContentData CreateAccessibilityBlockData()
	{
		return null;
	}

	private void ResetAccessibilityBlockToDefault()
	{
	}

	private CommonSettingContentData CreateGrenadeBlockData()
	{
		return null;
	}

	private void ResetGrenadeBlockToDefault()
	{
	}

	private CommonSettingContentData CreateMoveBlockData()
	{
		return null;
	}

	private void ResetMoveBlockToDefault()
	{
	}

	private InGameSettingItemDataToggleBtns CreateCommonSettingToggleData(string CommonPrefKey, string leftLabelKey, List<int> valList, List<string> togglesKeyList, int defalutValue = 0, Action tipBtnClickCallBack = null, string newLabelPrefKey = null, Action OnCommonToggleChanged = null, uint subType = 0u)
	{
		return null;
	}

	private InGameSettingItemDataToggleBtns CreateGrenadeSlotData()
	{
		return null;
	}

	private InGameSettingItemDataToggleBtns CreateSmartIceWallData()
	{
		return null;
	}

	private InGameSettingItemDataToggleBtns CreateSmartIceWallShowData()
	{
		return null;
	}

	private InGameSettingItemDataToggleBtns CreateSmartIceWallAutoChangeBackWeaponData()
	{
		return null;
	}

	private InGameSettingItemDataToggleBtns CreateFastMethodData()
	{
		return null;
	}

	private InGameSettingItemDataToggleBtns CreateMovingJoystickModeData()
	{
		return null;
	}

	private VehicleOperationSettingData CreateVehicleDriveMethodData()
	{
		return null;
	}

	private InGameSettingItemDataToggleBtns CreateAutoSwitchWeaponData()
	{
		return null;
	}

	private InGameSettingItemDataToggleBtns CreateUseAuxAimData()
	{
		return null;
	}

	private InGameSettingItemDataToggleBtns CreateCrossHairReloadData()
	{
		return null;
	}

	private InGameSettingItemDataToggleBtns CreateHUDButtonHintData()
	{
		return null;
	}

	private InGameSettingItemDataToggleBtns CreateShowCdTimeTxtData()
	{
		return null;
	}

	private int GetGrenadeSlotSelectBtn()
	{
		return 0;
	}

	private int GetSmartIceWallSelectBtn()
	{
		return 0;
	}

	private int GetSmartIceWallShowSelectBtn()
	{
		return 0;
	}

	private int GetSmartIceWallChangeBackWeaponBtn()
	{
		return 0;
	}

	private int GetFastMethodSelectBtn()
	{
		return 0;
	}

	private int GetMovingJoystickModeSelectBtn()
	{
		return 0;
	}

	private int GetAutoSwitchWeaponSelectBtn()
	{
		return 0;
	}

	private int GetUseAuxAimSelectBtn()
	{
		return 0;
	}

	private int GetCrossHairReloadSelectBtn()
	{
		return 0;
	}

	private int GetHUDButtonHintSelectBtn()
	{
		return 0;
	}

	private int GetShowCdTimeTxtSetting()
	{
		return 0;
	}

	private void RefreshBtnsState()
	{
	}

	private void OnGrenadeSlotClick(int value)
	{
	}

	private bool IsGrenadeSoloSet()
	{
		return false;
	}

	private bool IsSmartGrenadeSet()
	{
		return false;
	}

	private bool OnGrenadeSlotSet(int value)
	{
		return false;
	}

	private bool GrenadeSlotIsEnable()
	{
		return false;
	}

	private void SetSmartIceWallShowMode(bool enable)
	{
	}

	private void SetSmartIceWallChangeBackWeapon(bool enable)
	{
	}

	private void OnSmartIceWallSwitchClick(bool enable)
	{
	}

	private void OnFastMethodClick(int value)
	{
	}

	private void OnMovingJoystickModeClick(int value)
	{
	}

	private void OnMovingJoystickModeChanged()
	{
	}

	private void OnAutoSwitchWeaponClick(bool value)
	{
	}

	private void OnSmartIceWallShowSwitchClick(bool value)
	{
	}

	private void OnSmartIceWallAutoChangeBackWeaponClick(bool value)
	{
	}

	private void OnUseAuxAimClick(int value)
	{
	}

	private void OnCrossHairReloadClick(int value)
	{
	}

	private void OnHUDButtonHintClick(int value)
	{
	}

	private void ChangeCDTimeTxtSetting(bool value)
	{
	}

	public override void ResetToDefault()
	{
	}

	private void _003CCreateGrenadeSlotData_003Eb__29_0()
	{
	}

	private void _003CCreateGrenadeSlotData_003Eb__29_1()
	{
	}

	private void _003CCreateSmartIceWallData_003Eb__30_0()
	{
	}

	private void _003CCreateSmartIceWallData_003Eb__30_1()
	{
	}

	private void _003CCreateSmartIceWallShowData_003Eb__31_0()
	{
	}

	private void _003CCreateSmartIceWallShowData_003Eb__31_1()
	{
	}

	private void _003CCreateSmartIceWallAutoChangeBackWeaponData_003Eb__32_0()
	{
	}

	private void _003CCreateSmartIceWallAutoChangeBackWeaponData_003Eb__32_1()
	{
	}

	private void _003CCreateFastMethodData_003Eb__33_0()
	{
	}

	private void _003CCreateFastMethodData_003Eb__33_1()
	{
	}

	private void _003CCreateFastMethodData_003Eb__33_2()
	{
	}

	private void _003CCreateAutoSwitchWeaponData_003Eb__36_0()
	{
	}

	private void _003CCreateAutoSwitchWeaponData_003Eb__36_1()
	{
	}

	private void _003CCreateUseAuxAimData_003Eb__37_0()
	{
	}

	private void _003CCreateUseAuxAimData_003Eb__37_1()
	{
	}

	private void _003CCreateCrossHairReloadData_003Eb__38_0()
	{
	}

	private void _003CCreateCrossHairReloadData_003Eb__38_1()
	{
	}

	private void _003CCreateHUDButtonHintData_003Eb__39_0()
	{
	}

	private void _003CCreateHUDButtonHintData_003Eb__39_1()
	{
	}

	private void _003CCreateShowCdTimeTxtData_003Eb__40_0()
	{
	}

	private void _003CCreateShowCdTimeTxtData_003Eb__40_1()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshContent(object[] P0)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_InitSettingInfo()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_ResetToDefault()
	{
	}
}
