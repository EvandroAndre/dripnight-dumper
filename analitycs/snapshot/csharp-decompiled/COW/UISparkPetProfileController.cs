using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UISparkPetProfileController : UIBaseController, IUIModelDataChangeObserver
{
	private UISparkPetProfileView m_View;

	private UIRoot m_UIRoot;

	private UIModelSparkPet m_ModelSparkPet;

	private Transform m_ParentTransform;

	private uint m_RequestShowBoardDataOrder;

	private ulong m_BuddyID;

	private const string HAS_SHOW_BUDDY_LINK_BUTTON_KEY = "HasShowBuddyLinkButton";

	private const string HAS_SHOW_COSMETIC_VAULT_BUTTON_KEY = "HasShowCosmeticVaultButton";

	private const float RECOVERY_PANEL_SWITCH_DELAY = 1.5f;

	private uint m_RecoveryPanelSwitchDelayCall;

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

	private void RefreshUI()
	{
	}

	private void UpdateToggleStates()
	{
	}

	public bool IsSelfCollabSparkFeatureAvailable()
	{
		return false;
	}

	public bool IsSelfCosmeticVaultFeatureAvailable()
	{
		return false;
	}

	private bool CanDrawSparkGachaPool()
	{
		return false;
	}

	private void OnDetailButtonClick()
	{
	}

	private void OnCosmeticVaultButtonClick()
	{
	}

	private void OnChangeAppearanceButtonClick()
	{
	}

	private void OnShowInLobbyToggleClick()
	{
	}

	private void OnShareButtonClick()
	{
	}

	private void OnShowBuddySparkPetToggleClick()
	{
	}

	private void CloseWithEvent()
	{
	}

	private void OnBuddyLinkButtonClick()
	{
	}

	private void OnGetShowBoardDataSuccess(AccountPersonalShowInfo buddyInfo)
	{
	}

	public void TestProfileWithDifferentSparkPetState()
	{
	}

	public void AdjustBgSizeToContent()
	{
	}

	private void AdjustSingleBgSize(GameObject bgObject, float targetBgBottomY)
	{
	}

	public void SetPositionAvoidingScreenEdges(Vector3 targetPosition, bool preferRight, bool preferUp)
	{
	}

	public void SetParentTransform(Transform parentTransform)
	{
	}

	private void RepositionVFXToRecoverProgress(UILabel label, uint recoverProgress, float xOffset, float yOffset)
	{
	}

	private void ShowDeadRecoveryPanelTransition()
	{
	}

	private void OnDeadRecoveryPanelSwitchDelay()
	{
	}

	private void ShowDormantRecoveryPanelTransition()
	{
	}

	private void OnDormantRecoveryPanelSwitchDelay()
	{
	}

	private void CancelRecoveryPanelSwitchDelayCall()
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
