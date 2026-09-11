using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIConfirmPlanItemController : UIBaseController, IUIModelDataChangeObserver
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<string> _003C_003E9__32_0;

		internal void _003CBuyPet_003Eb__32_0(string st)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass30_0
	{
		public int slotId;

		public UIConfirmPlanItemController _003C_003E4__this;

		internal void _003CInitUI_003Eb__0()
		{
		}

		internal void _003CInitUI_003Eb__1()
		{
		}
	}

	private UIConfirmPlanItemView m_View;

	private RecommendPlanItem m_PlanData;

	private UIModelLoadout m_ModelLoadout;

	private UIModelAvatarProfile m_ModelAvatarProfile;

	private UIModelInventory m_ModelInventory;

	private UIModelPet m_ModelPet;

	private UIModelMall m_ModelMall;

	private List<Transform> m_SlotPosList;

	private List<UIButton> m_PurchaseAvatarBtnList;

	private List<UIButton> m_SkillTipsBtnList;

	private List<UIAvatarSkillSlotController> m_SlotCtrlList;

	private UIAvatarSkillTipsController m_SkillTipsCtrl;

	private UIConfirmPlanWindowLoadoutItemController m_LoadoutItemController;

	private Color32 Blue;

	private Color32 Green;

	private bool m_BuyPetProcess;

	private bool m_IsPlayerPlan;

	private bool m_IsInEditPanel;

	private bool m_IsInUploadPanel;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnClickPurchaseAvatarBtn(int slot)
	{
	}

	private void OnClickSkillTipsBtn(int slot)
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

	private void OnClickBGBtn()
	{
	}

	private void OnBGBtnSelect(UIToggleButton button)
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

	private void InitSkillContent()
	{
	}

	private void InitLoadout()
	{
	}

	private void RefreshPlanData()
	{
	}

	private void RefreshPlanCompleteness()
	{
	}

	private void RefreshAvatarSkill()
	{
	}

	private void RefreshMainSkill()
	{
	}

	private void RefreshPetSkill()
	{
	}

	private void RefreshLoadout()
	{
	}

	public void SetData(RecommendPlanItem data)
	{
	}

	public void SetIsPlayerPlan()
	{
	}

	public void SetIsInEditPanel(bool isInEditPanel)
	{
	}

	public void SetIsInUploadPanel(bool isInUploadPanel)
	{
	}

	public void RegisterToggleBtn()
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
}
