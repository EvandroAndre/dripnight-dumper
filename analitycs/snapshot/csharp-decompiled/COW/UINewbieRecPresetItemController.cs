using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UINewbieRecPresetItemController : UIBaseController, IUIModelDataChangeObserver
{
	public enum EPresetRewardState
	{
		Locked,
		CanClaim,
		CanUse
	}

	private sealed class _003C_003Ec__DisplayClass17_0
	{
		public int slotIndex;

		public UINewbieRecPresetItemController _003C_003E4__this;

		internal void _003CInitSkillContent_003Eb__0()
		{
		}
	}

	private const string EQUIPPED_STATE_KEY_PREFIX = "NewbiePreset_Equipped_";

	private const uint MAXIM_AVATAR_ID = 102000007u;

	private UINewbieRecPresetItemView m_View;

	private List<Transform> m_SlotPosList;

	private List<UIAvatarSkillSlotController> m_SlotCtrlList;

	private List<uint> m_SkillIdList;

	private uint[] m_AvatarIds;

	private UIAvatarSkillTipsController m_SkillTipsCtrl;

	private uint m_PresetId;

	private EPresetRewardState m_CurrentState;

	private uint m_ActiveSkillAvatarId;

	private UIModelLoadout m_ModelLoadout;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void InitSkillUI()
	{
	}

	private void InitSkillContent()
	{
	}

	private void InitButtons()
	{
	}

	private void SetAllButtonsHidden()
	{
	}

	private void RefreshUIByState()
	{
	}

	private bool IsRewardClaimed()
	{
		return false;
	}

	private void SetEverEquipped()
	{
	}

	private uint GetFirstActiveSkillAvatarId()
	{
		return 0u;
	}

	private void OnClickGetBtn()
	{
	}

	private void ShowRewardPopupSequence()
	{
	}

	private void ShowCongratulationPopup()
	{
	}

	private void ShowRewardBannerPopup()
	{
	}

	private void RequestGrantRewards()
	{
	}

	private List<CommonRewardItemInfo> BuildAvatarRewardInfoList()
	{
		return null;
	}

	private void OnClickUseBtn()
	{
	}

	private RecommendPlanItem BuildRecommendPlanItem()
	{
		return null;
	}

	private int FindEmptyPlanIndex(UIModelLoadout modelLoadout)
	{
		return 0;
	}

	private void CloseParentWindow()
	{
	}

	private void PlayNewbiePresetEquipEffect(int targetPlanIndex)
	{
	}

	private void OnClickSkillTipsBtn(int slotIndex)
	{
	}

	private static string GetEquippedStateKey(uint presetId)
	{
		return null;
	}

	public static bool IsPresetEverEquipped(uint presetId)
	{
		return false;
	}

	public static bool IsPlanEmpty(PlayerPlanItem plan)
	{
		return false;
	}

	public void SetAvatarData(uint[] avatarIds)
	{
	}

	private void RefreshMainAvatarIcon(uint avatarId)
	{
	}

	public void SetPresetData(uint presetId, uint unlockLevel, uint currentPlayerLevel)
	{
	}

	private void SetTitleAndDescription(uint presetId)
	{
	}

	public void SetState(EPresetRewardState state)
	{
	}

	public void ForceSetClaimedAndEquipped()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void OnPresetGuideAvatarSuccess(object[] param)
	{
	}

	private bool _003CRequestGrantRewards_003Eb__28_0(NewbiePresetDesc x)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
