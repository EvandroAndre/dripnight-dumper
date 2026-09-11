using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIRecPresetItemController : UIEasyListItemController, IUIModelDataChangeObserver
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<string> _003C_003E9__52_0;

		internal void _003CBuyPet_003Eb__52_0(string st)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass50_0
	{
		public int slotId;

		public UIRecPresetItemController _003C_003E4__this;

		internal void _003CInitUI_003Eb__0()
		{
		}

		internal void _003CInitUI_003Eb__1()
		{
		}
	}

	private UIRecPresetItemView m_View;

	private RecommendPlanItem m_PlanData;

	private UIModelLoadout m_ModelLoadout;

	private UIModelAvatarProfile m_ModelAvatarProfile;

	private UIModelInventory m_ModelInventory;

	private UIModelPet m_ModelPet;

	private UIModelMall m_ModelMall;

	private UIModelFriends m_ModelFriends;

	private List<Transform> m_SlotPosList;

	private List<Transform> m_TipsSlotPosList;

	private List<UIButton> m_PurchaseAvatarBtnList;

	private List<UIButton> m_SkillTipsBtnList;

	private List<UIAvatarSkillSlotController> m_SlotCtrlList;

	private UIAvatarSkillTipsController m_SkillTipsCtrl;

	private UIRecommendPresetWindowLoadoutItemController m_LoadoutItemController;

	private List<UILoadoutTagController> m_TagControllerList;

	private UIPrivilegeIconController m_PrivilegeIconController;

	private Color32 Blue;

	private Color32 Green;

	private uint m_TagCarouselCallID;

	private string m_TagCarouselAnimName;

	private bool m_BuyPetProcess;

	private bool m_OwnOneSkill;

	private bool m_OwnLoadout;

	private bool m_OwnPetSkill;

	private float m_DefaultDescInputWidth;

	private Vector3 m_DefaultLabelPosition;

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

	private void StopTagCarousel()
	{
	}

	private void StartTagCarousel()
	{
	}

	private void UpdateTagCarouselDisplay()
	{
	}

	private void PlayTagsAnimationForward(string clipName)
	{
	}

	private void ResetTagCarouselAnimation()
	{
	}

	private void RefreshTagCarousel()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	private void OnClickDetailInfoBtn()
	{
	}

	private void OnNoLikeIconClick()
	{
	}

	private void OnClickPurchaseAvatarBtn(int slot)
	{
	}

	private void OnClickSkillTipsBtn(int slot)
	{
	}

	public void OnClickPlayerInfoBtn()
	{
	}

	private void OnClickApply()
	{
	}

	private void OnClickDisable()
	{
	}

	private void OnClickPetPurchaseBtn()
	{
	}

	private void OnClickPetTipsBtn()
	{
	}

	private void OnBuyPetClick()
	{
	}

	private void OnClickLoadoutPurchaseBtn()
	{
	}

	private void OnClickLoadoutTipsBtn()
	{
	}

	private void ResizePlanDescLabel(string content)
	{
	}

	private void InitUI()
	{
	}

	private void BuyAvatarBySlot(int slot)
	{
	}

	private void BuyPet()
	{
	}

	private void OnClickLoadoutShop()
	{
	}

	private void InitSkillContent()
	{
	}

	private void InitLoadout()
	{
	}

	private void RefreshPlanData()
	{
	}

	private void RefreshLikeInfo()
	{
	}

	private void RefreshRoleInfo()
	{
	}

	private void RefreshPlayerInfo(object[] data)
	{
	}

	private void SetPrivilegeIcon(uint mainType, uint subType)
	{
	}

	private void RefreshPrivilegeIcon()
	{
	}

	private void RefreshAvatarSkill()
	{
	}

	private void RefreshMainSkill()
	{
	}

	private void RefreshAvatarIcon(uint avatarId)
	{
	}

	private void RefreshPetSkill()
	{
	}

	private void RefreshLoadout()
	{
	}

	private void RefreshPlanDesc()
	{
	}

	private void RefreshApplyBtnState()
	{
	}

	private void ClearOwnFlag()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
