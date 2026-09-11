using System;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UINinth_GachaItemController : UIBaseController
{
	public enum ViewStage
	{
		NORMAL,
		TRANSLUCENT,
		HIGHLIGHT,
		SELECTED,
		GET_REWARD
	}

	protected Action<int> m_onClickFunc;

	protected uint m_GachaID;

	protected UINinth_GachaItemView m_View;

	private UIModelGacha m_ModelGacha;

	protected int m_Idx;

	protected GachaShowItem m_GachaShowItem;

	protected BaseItemInfo m_Info;

	private bool m_CDNReady;

	private CSSharedItemDataManager.StoreQuality m_ItemStoreQuality;

	private Vector3 m_QualityBGBaseEulerAngles;

	private Vector3 m_SelectedBGBaseEulerAngles;

	private Vector3 m_FinishedBGBaseEulerAngles;

	private bool m_RewardPartRotationCached;

	protected bool m_IsBigReward;

	private GameObject m_SelectVfx;

	private const string SELECT_VFX_NODE_NAME = "SelectVfx";

	private const int BIG_REWARD_MALE_INDEX = 0;

	private const int BIG_REWARD_FEMALE_INDEX = 1;

	private const int REWARD_PART_ROTATION_OVERRIDE_START_INDEX = 2;

	private const int REWARD_PART_X_ROTATION_OVERRIDE_INDEX = 4;

	private const float REWARD_PART_X_ROTATION_OVERRIDE_VALUE = 180f;

	private static readonly float[] REWARD_PART_Z_ROTATION_OVERRIDES;

	private const string BIG_REWARD_SWITCH_SELECTED_ANIM = "UIFX_Ninth_Gacha_GachaItemSuperLargeMale_Switch_01";

	private const string BIG_REWARD_SWITCH_UNSELECTED_ANIM = "UIFX_Ninth_Gacha_GachaItemSuperLargeMale_Switch_02";

	public int Index => 0;

	public BaseItemInfo Info => null;

	protected virtual bool IsBigRewardType => false;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void Hide()
	{
	}

	public override void Show()
	{
	}

	public void InitOnClickFunc(Action<int> onClick = null)
	{
	}

	protected void OnBtnTipClick()
	{
	}

	public void SetCDNReady(bool cndReady)
	{
	}

	public void ApplyRewardPartRotationOverride()
	{
	}

	public void SetViewInfo(uint gachaID, int idx, GachaShowItem info, bool isShowDropUp = false)
	{
	}

	private void CacheRewardPartBaseRotations()
	{
	}

	private Transform GetFinishedBGTransform()
	{
		return null;
	}

	private void ApplyRewardPartRotation(Transform t, Vector3 baseEulerAngles, bool hasOverride, int overrideIndex)
	{
	}

	private void SetVfxDisable()
	{
	}

	private void SetSelectVfxActive(bool active)
	{
	}

	private void CacheSelectVfx()
	{
	}

	private void RefreshPersistentIdleVfx()
	{
	}

	private void PlayAnimSpriteOnceVfx()
	{
	}

	private void PlaySelectFlickerVfx()
	{
	}

	protected virtual void SetQualityBG(int Quality, UISprite QualityBG, bool bRareItem)
	{
	}

	public void ShowView(ViewStage stage, float alpha = 1f, bool silent = false, bool suppressSelectVfx = false)
	{
	}

	protected void PlayHilightAudio()
	{
	}

	protected void PlayTranslucentAudio()
	{
	}

	protected void PlayGetRewardAudio()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void PlayBigRewardSwitchAnimation(bool isSelected)
	{
	}

	public void PlayIdleAnim()
	{
	}

	public static ResourceID GetOnceFXByQuality(int idx, CSSharedItemDataManager.StoreQuality quality)
	{
		return default(ResourceID);
	}

	public static ResourceID GetIdleFXByQuality(int idx, CSSharedItemDataManager.StoreQuality quality)
	{
		return default(ResourceID);
	}

	public static ResourceID GetSelectFXByQuality(int idx, CSSharedItemDataManager.StoreQuality quality)
	{
		return default(ResourceID);
	}

	private void ResizeItemIconSize()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_Hide()
	{
	}

	public void _003C_003EiFixBaseProxy_Show()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
