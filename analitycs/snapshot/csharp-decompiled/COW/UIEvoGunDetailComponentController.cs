using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIEvoGunDetailComponentController : UIBaseController, IUIModelDataChangeObserver, IUIEvoGunComponent
{
	private sealed class _003C_003Ec__DisplayClass70_0
	{
		public UIEvoGunDetailComponentController _003C_003E4__this;

		public SkinOwnAndOpenInfo skinOwnAndOpenInfo;

		public WeaponSkinUpdateItemDesc exchangeItem;

		public uint scale;

		internal void _003COnExchangeRemainToken_003Eb__0()
		{
		}

		internal void _003COnExchangeRemainToken_003Eb__1()
		{
		}
	}

	private sealed class _003CDelayNavigateToFeature_003Ed__50 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIEvoGunDetailComponentController _003C_003E4__this;

		public WeaponSkinFeatureShowStyle targetStyle;

		public WeaponSkinFeature targetFeature;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDelayNavigateToFeature_003Ed__50(int _003C_003E1__state)
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

	private UIEvoGunDetailComponentView m_View;

	private UIModelWeaponSkinUpgrader m_ModelWeaponSkinUpgrader;

	private UIModelCollection m_ModelCollection;

	private List<UIEVOGunPrivilegeTitleController> m_UIEVOGunPrivilegeTitleCtrlList;

	private List<UIEVOGunDetailLevelItemController> m_UIEVOGunLevelItemCtrlList;

	private List<UIEVOGunPrivilegeToggleController> m_UIEVOGunSoundCtrlList;

	private int m_CurQuickSwitchIndex;

	private EVOGunUIPrivilegeType m_QuickSwitchPrivilegeType;

	private UIEVOGunPrivilegeUpgradeAttributeController m_UIEvoGunPrivilegeUpgradeAttributesCtrl;

	private UIEvoGunPrivilegeUnlockAbilityController m_UIEvoGunPrivilegeUnlockAbilityCtrl;

	private UIEVOGunCustomPrivilegeController m_UIEVOGunCustomPrivilegeCtrl;

	private UIScopeSelectController m_UIScopeSelectCtrl;

	private uint m_EvoGunSelectedScopeId;

	private SkinOwnAndOpenInfo m_SkinOwnAndOpenInfo;

	private List<uint> m_EvoGunExchangeItemIdList;

	private List<uint> m_EvoGunExchangeItemCountList;

	private int m_CurLevelItemIndex;

	private int m_NextLevelIndex;

	private uint m_EnableBtnUpgradeCallId;

	private UIEvoGunMainController m_MainController;

	private bool m_CanUpgrade;

	private bool m_HasGetPurchaseSuccessNotify;

	private const int SHORT_LINE_NUM = 5;

	private const string SHORT_LINE_SPRITE_EVOGUN = "FF_UI_weapon_upgrade_Arc_02";

	private const string LONG_LINE_SPRITE_EVOGUN = "FF_UI_weapon_upgrade_Arc_01";

	public UIEvoGunMainController MainPageController => null;

	private bool CanAutoUpgrade => false;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void SetupDefaultStateOnInit()
	{
	}

	private void SetLevelLineDefaltState()
	{
	}

	private void RefreshViewByPageState()
	{
	}

	private void OnRewardWndFinish(object[] param)
	{
	}

	private void HideAllPrivilegeUI()
	{
	}

	private void RefreshMaxGradeRemainingEvoGunTokenForExchange()
	{
	}

	private void LogGetFragmentSuccess(string param)
	{
	}

	private void ResetLevelItemPos(int num)
	{
	}

	private void RefreshLevelLineSprite()
	{
	}

	private void SetPrivilegeToggleCtrlState(bool show, int index = 0)
	{
	}

	private void SetPrivilegePropertyCtrlState(bool show)
	{
	}

	private void SetPrivilegeSkillCtrlState(bool show)
	{
	}

	private void SetPrivilegeTitleCtrlState(bool show, int index = 0)
	{
	}

	public void RefreshView()
	{
	}

	public void ClickChangeName()
	{
	}

	public void RefreshLevelItemCon()
	{
	}

	public void RefreshPrivilegeUIInDetailComponent()
	{
	}

	private IEnumerator DelayNavigateToFeature(WeaponSkinFeatureShowStyle targetStyle, WeaponSkinFeature targetFeature, SkinOwnAndOpenInfo skinOwnAndOpenInfo)
	{
		return null;
	}

	public void RefreshRightBottomUI()
	{
	}

	public void SetSkinAndOwnOpenInfo(SkinOwnAndOpenInfo info)
	{
	}

	private static EVOGunUIPrivilegeType GetPrivilegeTypeForFeature(WeaponSkinFeature feature)
	{
		return EVOGunUIPrivilegeType.None;
	}

	private void ShowEvoGunScopeSelector(uint weaponSkinId)
	{
	}

	private void HideEvoGunScopeSelector()
	{
	}

	private UIEVOGunPrivilegeToggleController GetCurrentQuickSwitchCtrl()
	{
		return null;
	}

	private void RefreshEvoGunScopeSelectorByQuickSwitch()
	{
	}

	private void OnEvoGunScopeTypeSelected(uint scopeAttachmentId)
	{
	}

	private static List<uint> BuildScopeListForSightReskin(uint weaponSkinId)
	{
		return null;
	}

	public void RefreshPreviewComponent(int wpSKinFeature, bool isSpecialToggle = true)
	{
	}

	public void SetUpgradeBtnState(bool isEnable)
	{
	}

	public uint GetWpSkinID()
	{
		return 0u;
	}

	public void GotoNextLevel()
	{
	}

	private void RefreshRedPointView()
	{
	}

	private void OnClickPurchase()
	{
	}

	private void OnClickGetFragment()
	{
	}

	private void OnClickUpgrade()
	{
	}

	private void OnClickDetailPurchase()
	{
	}

	public void OnGotoUpgrade()
	{
	}

	private void OnExchangeRemainToken()
	{
	}

	public void OnPrivilegeItemCtrlNotify(EVOGunUIPrivilegeType uiPrivilegeType, int index = 0)
	{
	}

	public void OnLevelItemCtrlNotify(int index)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public UIEvoGunPageState GetPageState()
	{
		return UIEvoGunPageState.None;
	}

	public void OnSelectPickItem(SkinOwnAndOpenInfo infoData)
	{
	}

	public void SyncSkinOwnAndOpenInfoInMain(SkinOwnAndOpenInfo infoData)
	{
	}

	private void _003COnClickUpgrade_003Eb__67_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
