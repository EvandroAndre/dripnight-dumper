using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIEVOGunCustomizePopupWindowController : UIPopupWindowController, IUIModelDataChangeObserver
{
	private UIEVOGunCustomizePopupWindowView m_View;

	private UIModelWeaponSkinUpgrader m_ModelWeaponSkinUpgrader;

	private UIModelCollection m_ModelCollection;

	private SkinOwnAndOpenInfo m_SkinOwnAndOpenInfo;

	private SkinOwnAndOpenInfo m_PrevSkinOwnAndOpenInfo;

	private WeaponSkinStat m_WeaponSkinStat;

	private WeaponSetData m_WeaponSetData;

	private WeaponSkinStat m_ConfirmWeaponSkinStat;

	private bool m_HasCofirmed;

	private List<UICollectionScoreItemController> m_CollectionScoreItemList;

	private List<UICollectionScoreItemController> m_PrevCollectionScoreItemList;

	private uint m_CurrentWeaponPowerId;

	private uint m_CurrentWeaponSkillId;

	private bool m_CanUseSpecialSound;

	private uint m_GoPos;

	private string m_SubGoPos;

	private bool m_IsAttributeLock;

	private bool m_IsAbilityLock;

	private bool m_IsSoundLock;

	private bool m_HasEVOType1Attribute;

	private bool m_HasEVOType1Ability;

	private bool m_HasInitSound;

	private readonly string CUSTOMIZE_POPUP_WINDOW_TIPS;

	private readonly string CUSTOMIZE_POPUP_WINDOW_NOT_OWNED_GUN;

	private readonly string CUSTOMIZE_POPUP_WINDOW_NOT_REACHED_LEVEL;

	private readonly string CUSTOMIZE_POPUP_WINDOW_LUCK_RIGHT;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override string Rule()
	{
		return null;
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void SetViewData(SkinOwnAndOpenInfo skinOwnAndOpenInfo)
	{
	}

	private void InitEvent()
	{
	}

	private void InitUI()
	{
	}

	private void InitView()
	{
	}

	private void SetPropertyData(SkinOwnAndOpenInfo skinOwnAndOpenInfo, UIGrid grid, EvoWeaponType type)
	{
	}

	private void RefreshWeaponSkillDesc(SkinOwnAndOpenInfo skinOwnAndOpenInfo, UILabel label)
	{
	}

	private int GetMinLevelForAbility(WeaponSkinData wpData)
	{
		return 0;
	}

	private void InitItemSelection()
	{
	}

	private void OnBtnConfirmClick()
	{
	}

	private void ChangeWeaponSkinStat()
	{
	}

	private void SelectWeaponSkinAttribute(int type)
	{
	}

	private void SelectWeaponSkinAbility(int type)
	{
	}

	private void GetPrevEVOGunGotoParam()
	{
	}

	private void OnBtnPrevEVOGunGoto()
	{
	}

	private void OnBtnSoundPlaying()
	{
	}

	private void OnToggleSoundChanged()
	{
	}

	private uint GetRequiredLevelForRights(WeaponSkinFeature feature)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void _003CInitEvent_003Eb__32_0()
	{
	}

	private void _003CInitEvent_003Eb__32_1()
	{
	}

	private void _003CInitEvent_003Eb__32_2()
	{
	}

	private void _003CInitEvent_003Eb__32_3()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public string _003C_003EiFixBaseProxy_Rule()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
