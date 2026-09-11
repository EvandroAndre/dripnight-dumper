using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIConfirmPlanWindowController : UIPopupWindowController
{
	private UIConfirmPlanWindowView m_View;

	private RecommendPlanItem m_RecPlanData;

	private UIModelLoadout m_ModelLoadout;

	private UIModelAvatarProfile m_ModelAvatarProfile;

	private UIModelPet m_ModelPet;

	private UIConfirmPlanItemController m_RecPlanItem;

	private List<UIConfirmPlanItemController> m_PlayerPlanItemList;

	private bool m_IsPaste;

	private uint m_PlanIndex;

	private UIModelLoadout.CHANGE_LOADOUT_PLAN_STATUS m_AvatarStatus;

	private UIModelLoadout.CHANGE_LOADOUT_PLAN_STATUS m_LoadoutStatus;

	private UIModelLoadout.CHANGE_LOADOUT_PLAN_STATUS m_PetStatus;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnClickConfirm()
	{
	}

	private void ConfirmCallback()
	{
	}

	private void OnPlayerPlanSwitch(uint planIndex)
	{
	}

	private void InitUI()
	{
	}

	private void InitPlayerPlan()
	{
	}

	private void RefreshApplyState()
	{
	}

	public void SetRecommendPlan(RecommendPlanItem item, bool isPaste)
	{
	}

	private void FixSkillId()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
