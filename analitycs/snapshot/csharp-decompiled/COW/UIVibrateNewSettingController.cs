using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIVibrateNewSettingController : UISettingContentBase
{
	private enum SettingBlock
	{
		Enemy,
		Interaction,
		Weapon,
		Vechicle,
		Feedback
	}

	private sealed class _003CRefreshScroll_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIVibrateNewSettingController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRefreshScroll_003Ed__13(int _003C_003E1__state)
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

	private UIVibrateNewSettingView m_View;

	private Dictionary<int, UICommonSettingContentController> m_CtrlDict;

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

	protected override void OnUIDestory()
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

	private void RefreshBtnsState()
	{
	}

	private CommonSettingContentData CreateEnemyBlockData()
	{
		return null;
	}

	private bool ShowEnemyBlock()
	{
		return false;
	}

	private CommonSettingContentData CreateInteractionBlockData()
	{
		return null;
	}

	private CommonSettingContentData CreateVechicleBlockData()
	{
		return null;
	}

	private bool ShowVechicleBlockData()
	{
		return false;
	}

	private CommonSettingItemDataToggleBtns CreateFootStepsData()
	{
		return null;
	}

	private CommonSettingItemDataToggleBtns CreateGunShootsData()
	{
		return null;
	}

	private CommonSettingItemDataToggleBtns CreateTakingDamageData()
	{
		return null;
	}

	private CommonSettingItemDataToggleBtns CreateWeaponVibrationData()
	{
		return null;
	}

	private CommonSettingItemDataToggleBtns CreateDrivingData()
	{
		return null;
	}

	private CommonSettingItemDataToggleBtns CreateInVehicleDamageData()
	{
		return null;
	}

	private CommonSettingItemDataToggleBtns CreateCollisionData()
	{
		return null;
	}

	private CommonSettingItemDataToggleBtns CreateRouletteData()
	{
		return null;
	}

	private CommonSettingItemDataToggleBtns CreatePickUpItemData()
	{
		return null;
	}

	private int GetFootStepsSelectBtn()
	{
		return 0;
	}

	private int GetGunShootsSelectBtn()
	{
		return 0;
	}

	private int GetTakingDamageSelectBtn()
	{
		return 0;
	}

	private int GetWeaponVibrationSelectBtn()
	{
		return 0;
	}

	private int GetDrivingSelectBtn()
	{
		return 0;
	}

	private int GetInVehicleDamageSelectBtn()
	{
		return 0;
	}

	private int GetCollisionSelectBtn()
	{
		return 0;
	}

	private int GetRouletteSelectBtn()
	{
		return 0;
	}

	private int GetPickUpItemSelectBtn()
	{
		return 0;
	}

	private void OnFootStepsClick(int value)
	{
	}

	private void OnGunShootsClick(int value)
	{
	}

	private void OnTakingDamageClick(int value)
	{
	}

	private void OnWeaponVibrationClick(int value)
	{
	}

	private void OnDrivingClick(int value)
	{
	}

	private void OnInVehicleDamageClick(int value)
	{
	}

	private void OnCollisionClick(int value)
	{
	}

	private void OnVisibleVoice_GunFireHintClicked()
	{
	}

	private void OnRouletteClick(int value)
	{
	}

	private void OnPickUpItemClick(int value)
	{
	}

	public override void ResetToDefault()
	{
	}

	private void _003CCreateFootStepsData_003Eb__21_0()
	{
	}

	private void _003CCreateFootStepsData_003Eb__21_1()
	{
	}

	private void _003CCreateGunShootsData_003Eb__22_0()
	{
	}

	private void _003CCreateGunShootsData_003Eb__22_1()
	{
	}

	private void _003CCreateTakingDamageData_003Eb__23_0()
	{
	}

	private void _003CCreateTakingDamageData_003Eb__23_1()
	{
	}

	private void _003CCreateWeaponVibrationData_003Eb__24_0()
	{
	}

	private void _003CCreateWeaponVibrationData_003Eb__24_1()
	{
	}

	private void _003CCreateDrivingData_003Eb__25_0()
	{
	}

	private void _003CCreateDrivingData_003Eb__25_1()
	{
	}

	private void _003CCreateInVehicleDamageData_003Eb__26_0()
	{
	}

	private void _003CCreateInVehicleDamageData_003Eb__26_1()
	{
	}

	private void _003CCreateCollisionData_003Eb__27_0()
	{
	}

	private void _003CCreateCollisionData_003Eb__27_1()
	{
	}

	private void _003CCreateRouletteData_003Eb__28_0()
	{
	}

	private void _003CCreateRouletteData_003Eb__28_1()
	{
	}

	private void _003CCreatePickUpItemData_003Eb__29_0()
	{
	}

	private void _003CCreatePickUpItemData_003Eb__29_1()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshContent(object[] P0)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_ResetToDefault()
	{
	}
}
