using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIChangeWeaponPreviewMainController : UIPopupWindowController, IEasyList
{
	private sealed class _003CSelectFirstTabCor_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIChangeWeaponPreviewMainController _003C_003E4__this;

		private int _003CwaitedFrames_003E5__2;

		private UIMaleAvatar _003Cavatar_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CSelectFirstTabCor_003Ed__40(int _003C_003E1__state)
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

	private UIChangeWeaponPreviewMainView m_View;

	private uint m_ItemId;

	private EPrivilegePreviewType m_PrivilegePreviewType;

	private UIModelWeaponSkinUpgrader m_ModelWeaponSkinUpgrader;

	private UIChangeWeaponSkinStatsController m_SkinStatsController;

	private uint m_FirstSwitchWeaponSkinID;

	private uint m_SecondSwitchWeaponSkinID;

	private uint m_ThirdSwitchWeaponSkinID;

	private uint m_PreviewWeaponSkinID;

	private int m_CurrentFeatureID;

	private List<int> m_FeatureList;

	private UIScopeSelectController m_ScopeSelectController;

	private uint m_SelectedScopeId;

	private List<uint> m_EffectTriggerIDs;

	private UIPrivilegePreviewController.SwitchType m_AvatarSwitchState;

	private UIModelPreviewWebShow m_ModelPreviewWebShow;

	private UIPrivilegePreviewController m_PrivilegePreviewController;

	private UIStandardItemMiniController m_FeatureIconController;

	private GameObject m_BGEffect;

	private ulong m_StartShowTime;

	private ulong m_StartPauseTime;

	private ulong m_PauseTime;

	private Coroutine m_SelectFirstTabCor;

	private bool m_MagnifierState;

	private UIPopupWindowTopBtnController m_PopClose;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnDestroy()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public override void OnPopupWindowListChange()
	{
	}

	private void SetCameraVisiable(bool state)
	{
	}

	public EPrivilegePreviewType GetPrivilegePreviewType()
	{
		return EPrivilegePreviewType.None;
	}

	public void SetWeaponSkinID(uint weaponSkinID)
	{
	}

	public void SetItemIDAndEventClothEffectIDs(uint itemId, List<uint> effectTriggerIDs, bool isFemale, uint clothesSetID, bool selectFirstItem = true)
	{
	}

	public void SetFinalShotID(uint finalShotID)
	{
	}

	private void InitFinalShotFeatureItems()
	{
	}

	public void SetFlightID(uint flightID)
	{
	}

	private void InitFlightFeatureItems()
	{
	}

	private IEnumerator SelectFirstTabCor()
	{
		return null;
	}

	private void RefreshDesc(bool isWeapon = false)
	{
	}

	private Color GetQualityColor(uint quality)
	{
		return default(Color);
	}

	private void InitClothEventEffectItems()
	{
	}

	private void TryMergeKillAndBeKilled()
	{
	}

	private void TryMergeKillAndKnockDown()
	{
	}

	public void RefreshClothEventEffectPreview(ClothTriggerEffectPreviewData data)
	{
	}

	public void HackNB2Transformer()
	{
	}

	private void SetFeatureDesc(ClothTriggerEffectPreviewData data)
	{
	}

	private void SetFeatureDesc(WeaponSkinFeature featureId)
	{
	}

	private void SetFeatureDesc(EFinalShotFeature featureId)
	{
	}

	private void SelectFirstTab()
	{
	}

	private void HideAll()
	{
	}

	private void InitWeaponSkinPrivilegeItem()
	{
	}

	private void RefreshWebViewBtn()
	{
	}

	private void ShowScopeSelector(uint weaponSkinId)
	{
	}

	private void HideScopeSelector()
	{
	}

	private void OnScopeTypeSelected(uint scopeAttachmentId)
	{
	}

	private static List<uint> BuildScopeListForSightReskin(uint weaponSkinId)
	{
		return null;
	}

	public void SetMagnifierStateDefault()
	{
	}

	public void RefreshMagnifier(WeaponSkinFeature featureID)
	{
	}

	public void RefreshMagnifier(bool isBelow = false)
	{
	}

	private void InitSwitchButton()
	{
	}

	private void RefreshAvatarSwitchIcon()
	{
	}

	private void RefreshBGVFX()
	{
	}

	private void UpdatePreviewUIState(int wpSKinFeature)
	{
	}

	public void RefreshPreviewComponent(int weaponFeatureID)
	{
	}

	public void RefreshPreviewComponentForFinalShot(int finalShotFeatureID)
	{
	}

	public void SelectPrivilegeItem(int weaponFeatureID)
	{
	}

	public void SelectClothPrivilegeItem(uint triggerID)
	{
	}

	private void RefreshBG()
	{
	}

	private bool IsPrivilegeChange(uint skinId)
	{
		return false;
	}

	private void OnFirstSwitchClick()
	{
	}

	private void OnSecondSwitchClick()
	{
	}

	private void OnThirdSwitchClick()
	{
	}

	private void OnAvatarSwitchClick()
	{
	}

	private void OnWebGuideBtnClick()
	{
	}

	private void OnMagnifierClick()
	{
	}

	private void OnFinishMoveJumpBtnClick()
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	private void OnApplicationPauseEvent(object[] data)
	{
	}

	protected virtual void LogOnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnPopupWindowListChange()
	{
	}
}
