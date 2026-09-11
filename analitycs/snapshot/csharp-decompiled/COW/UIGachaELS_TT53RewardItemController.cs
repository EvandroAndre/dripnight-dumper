using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIGachaELS_TT53RewardItemController : UIBaseController, UITable2.IUITable2Item
{
	private enum EquipmentState
	{
		STATE_NONE,
		STATE_CHECK,
		STATE_UNCHECK,
		STATE_EQUIPPED
	}

	private sealed class _003C_003Ec__DisplayClass71_0
	{
		public PetSkinData skinData;

		internal bool _003CIsCanEquip_003Eb__0(PetInfo temp)
		{
			return false;
		}
	}

	private sealed class _003CPlayProgressBarAnim_003Ed__107 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIProgressBar bar;

		public float endValue;

		public float duration;

		private float _003CstartValue_003E5__2;

		private float _003CstartTime_003E5__3;

		private float _003Cpercent_003E5__4;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayProgressBarAnim_003Ed__107(int _003C_003E1__state)
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

	private UIModelMall m_ModelMall;

	public UIGachaELS_TT53RewardItemView m_View;

	private UIStandardItemMAXBController m_childController;

	public CommonRewardItemInfo m_Info;

	public OptionalBundleShowData m_OptionalBundleInfo;

	private bool isAvatarSelected;

	private bool isPetSelected;

	private bool isPetSkinSelected;

	private uint m_PermanentGrowAnimDC;

	private uint m_PermanentMergeAnimDC;

	private bool m_HasPlayedPermanentAnim;

	private float m_Step2Duration;

	private float m_Step4Duration;

	private static Color SixthB_UnPermanentIcon_Color;

	private static Color SixthB_AfterLabel_Color;

	private CommonRewardNoLimitData m_NoLimitData;

	public int m_DataIndex;

	private bool m_HasProcessBigRewardVFX;

	private bool m_ItemAttributesPlayed;

	private bool m_IsVoucher2;

	private GameObject m_WeaponSkinMergeVFX;

	private float m_WeaponSkinMergeVFXLength;

	private const float WEAPONSKIN_MERGE_VFX_DEFAULT_LENGTH = 0.75f;

	private HashSet<int> m_BundleOpenedVFXSet;

	private GameObject m_BGUIFX;

	private GameObject m_QualityUIFX;

	private bool m_CanEquip;

	private uint m_RealItemId;

	private EquipmentState m_EquipmentState;

	private UIGachaELS_TT53RewardWndController m_CommonRewardWndController;

	private bool m_LevelUpRewardItemVfxShowed;

	private bool IsOwnedLabelEnable;

	public bool CanEquip => false;

	public uint RealItemID => 0u;

	private UIGachaELS_TT53RewardWndController CommonRewardWndController => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void SetupDefaultState()
	{
	}

	private void OnButtonCantSelectClick()
	{
	}

	private void VoucherCarousel()
	{
	}

	private void OnGoVaultBtnClick()
	{
	}

	private void OnGoWeaponBtnClick()
	{
	}

	private void OnGoPhotoGroupBtnClick()
	{
	}

	public UIWidget GetParticleWidget()
	{
		return null;
	}

	public void SetViewInfo<T>(CommonRewardItemInfo info) where T : UIStandardItemMAXBController
	{
	}

	public void SetViewData(object data, int data_index)
	{
	}

	private void ShowHidePermenentVFXContainer()
	{
	}

	public void TryShowBeforeOpenBundleVFX()
	{
	}

	private void TryShowAfterOpenBundleVFX(bool show, int data_index)
	{
	}

	public void ProcessPermanentView()
	{
	}

	public void SetViewInfo(CommonRewardItemInfo info, bool useNewItem = false)
	{
	}

	private void TryShowLevelUpRewardItemVfx()
	{
	}

	public void SetOptionalBundleInfo<T>(CommonRewardItemInfo info, OptionalBundleShowData optionalBundleInfo) where T : UIStandardItemMAXBController
	{
	}

	public void ShowView()
	{
	}

	public void SetToggleVisible(bool v)
	{
	}

	public void SetCantSeletedVisible()
	{
	}

	private void SetGoVaultVisible()
	{
	}

	private void SetGoWeaponVisible()
	{
	}

	private void SetGoPhotoGroupVisible()
	{
	}

	public void SetToggleCheckState()
	{
	}

	public void SetToggleUnCheckState()
	{
	}

	public void SetToggleEquippedState()
	{
	}

	public void RefreshToggleState(int index)
	{
	}

	private void SetRealItemID()
	{
	}

	private bool ExchangeVoucherCanShow()
	{
		return false;
	}

	private bool IsCanEquip()
	{
		return false;
	}

	public void SetToggleValue(bool v)
	{
	}

	public bool GetToggleActiveState()
	{
		return false;
	}

	public void ChangeItemState(bool show)
	{
	}

	public uint GetItemInfoID()
	{
		return 0u;
	}

	private void AddEventDelegate()
	{
	}

	private void OnClickTipsBtn()
	{
	}

	private void OnGotoPageBtnClick()
	{
	}

	private void OnClickPreviewBtn()
	{
	}

	private void OnToggleSelected()
	{
	}

	private void OnToggleSelectedWithNoLimit()
	{
	}

	private void RefreshUI()
	{
	}

	private static uint GetGoPosWithItem(CSSharedItemData itemData)
	{
		return 0u;
	}

	private static string GetGoParamWithItemSubType(CSSharedItemDataManager.ItemSubType itemSubType)
	{
		return null;
	}

	private static string GetGoPageNameWithItemSubType(CSSharedItemDataManager.ItemSubType itemSubType)
	{
		return null;
	}

	private static string GetGoPosSpriteNameWithItemSubType(CSSharedItemDataManager.ItemSubType itemSubType)
	{
		return null;
	}

	private void RefreshGotoGroup()
	{
	}

	private bool IsRewardItemConsideredUsed()
	{
		return false;
	}

	public void SetVoucherAnimEnable(bool b)
	{
	}

	public void SetUseNewGachaAnimatoin(bool useNewGachaAnimatoin, bool showTween)
	{
	}

	public void ShowVFX(bool useNewItem)
	{
	}

	private void TryCreatePermanentEffect(bool useNewItem)
	{
	}

	public void PlayAudio(bool useNewAudio = false)
	{
	}

	public void PlayAttributes(bool useNewGachaAnimatoin, bool showTween)
	{
	}

	private void ShowMergeVFXEffectOnItem(ResourceID resID)
	{
	}

	private void SetPermanentView()
	{
	}

	private void HideWeaponPermanentView()
	{
	}

	private void HideExpireTimeLabel()
	{
	}

	private void StartWeaponSkinMergeAnim()
	{
	}

	private void HideWeaponSkinMergeVFX()
	{
	}

	private void StartPermanentGrow()
	{
	}

	private void ModifyUnPermanentColor()
	{
	}

	public void StartPermanentStep1()
	{
	}

	public void StartPermanentStep2()
	{
	}

	public void StartPermanentStep4()
	{
	}

	public void StartPermanentStep5()
	{
	}

	private IEnumerator PlayProgressBarAnim(UIProgressBar bar, float endValue, float duration = 0.5f)
	{
		return null;
	}

	public object SetTable2ItemData(int index, object data, object viewState)
	{
		return null;
	}

	public void SetPosition(Vector2 position)
	{
	}

	public void SetTable2Visible(bool visible)
	{
	}

	private void SetQualityBG()
	{
	}

	private void SetUIFX()
	{
	}

	private void SetLimitAndQuantityLabel()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
