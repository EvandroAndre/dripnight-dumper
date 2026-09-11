using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public abstract class UIFrontEndPreviewItemDescBaseController : UIFrontEndPreviewUIComponentTemplateBaseController<UIFrontEndPreviewItemDescBaseView>
{
	private sealed class _003C_003Ec__DisplayClass36_0
	{
		public uint petId;

		internal bool _003CRefreshItemDesc_003Eb__0(PetInfo x)
		{
			return false;
		}
	}

	private List<GameObject> m_IconObjects;

	private AvatarSkillData m_AvatarSkillData;

	protected UIVirtualBrandTipsController m_UIVirtualBrandTipsController;

	protected UIFrontEndPreviewPrivilegeContainerController m_PrivilegeController;

	protected UIFrontEndPreviewPrivilegeShowContainerController m_PrivilegeShowContainerController;

	private Vector3 m_OriginalDescWidgetPosition;

	private Vector3 m_OriginalDescScrollviewPosition;

	private static Dictionary<int, string> m_GenderSpr;

	protected UIModelBigEvent.TokenTipsData m_TokenTipsData;

	private Vector3 m_NoBackPackHyperBookPosition;

	private Vector3 m_WithBackPackHyperBookPosition;

	private Vector3 m_NoWeaponChangeIPCollabPosition;

	private Vector3 m_WithWeaponChangeIPCollabPosition;

	private UIPanel m_FinishMovePanel;

	private const int m_FinishMovePanelDepth = 100;

	protected override void InitView()
	{
	}

	private void DescLabelCallBack(int lines)
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public virtual void SetItemDescLocalPosition(Vector3 pos)
	{
	}

	public void HideIPTag()
	{
	}

	public virtual void SetIpTag(ResourceID resourceID)
	{
	}

	public virtual void SetSpecialData(string name, string desc, bool flag)
	{
	}

	public virtual void OnSetOriginal()
	{
	}

	public virtual void OnCloseUIExceptMagn()
	{
	}

	public virtual void OnCloseAllUI()
	{
	}

	public virtual void SetNewQuaityIcon(uint id)
	{
	}

	protected bool IsNoIconItem(uint id)
	{
		return false;
	}

	public void UpdateDescLabelYPos(int offset)
	{
	}

	protected virtual void SetItemDescBg()
	{
	}

	protected virtual void OnItemDescBgChanged()
	{
	}

	public virtual void SetNewQuaitySpIcon(EInventory.AwardType type)
	{
	}

	public virtual void SetNewQuaitySpIcon(ESpecialItemWithoutDataType type)
	{
	}

	public virtual void WeaponSkinUpgradeInfoIconClick(string info, List<ResourceID> spritesResId)
	{
	}

	public virtual Vector2 GetItemNameWorldPos()
	{
		return default(Vector2);
	}

	public virtual Vector2 GetItemDescWorldPos()
	{
		return default(Vector2);
	}

	public virtual void OnDisVisbleIconTableInfo()
	{
	}

	public virtual void RefreshItemDesc(uint itemid, UIGrid iconGrid)
	{
	}

	private void SetNumLimitItemDesc(uint id)
	{
	}

	public virtual void ShowEffectClothIcon(UIGrid iconGrid)
	{
	}

	public virtual void SetItemDesc(string name, string description)
	{
	}

	public virtual void OnRefreshWeaponPropertyScore(bool showIcon, bool weaponSkinUpgradeInfoIcon, bool notificationIcon)
	{
	}

	public virtual void OnRefreshVirtualBtn(uint itemID, bool show)
	{
	}

	public virtual void OnRefreshEmotePrivilegeIcon(bool show)
	{
	}

	public virtual void SetSkillVisble(bool isVisble)
	{
	}

	public virtual void SetAlignmentVisble(bool show)
	{
	}

	public virtual void OnSetNotificationBtnVisble(bool need_show, bool needCombine = false)
	{
	}

	public virtual void SetShowIconVisble(bool need_show)
	{
	}

	public virtual void SetWeaponSkinUpgradeInfoIconVisble(bool need_show)
	{
	}

	public virtual void OnShowAvatarSkill(AvatarSkillData skilldata)
	{
	}

	public virtual void ShowAvatarAlignment(uint avatarID)
	{
	}

	public virtual void OnShowPetSkill(CSSharedItemData skilldata)
	{
	}

	protected virtual void OnForgeAwardBtnClick()
	{
	}

	public virtual void ShowIPTag(uint id)
	{
	}

	protected virtual void OnShowIconBtnClick()
	{
	}

	protected virtual void OnNotificationIconBtnClick()
	{
	}

	private void OnWeaponSkinUpgradeInfoIconClick()
	{
	}

	private void OnCollectionEmotePrivilegeIconClick()
	{
	}

	private void ResetTable()
	{
	}

	private void OnTailorClothClick()
	{
	}

	private void OnTokenExchangeClick()
	{
	}

	private void OnHyperBookClick()
	{
	}

	private void OnBooyahPassBtnClick()
	{
	}

	private void OnIPCollabBtnClick()
	{
	}

	public void SetTailorClothTagVisible(bool isVisible)
	{
	}

	public void SetTokenExchangeVisible(bool isVisible)
	{
	}

	public void SetHyperBookVisible(bool isVisible)
	{
	}

	public void RefreshHyperBookPosition()
	{
	}

	public void RefreshIPCollabPosition()
	{
	}

	public void SetBooyahPassVisible(bool isVisible)
	{
	}

	public void SetIPCollabVisible(bool isVisible)
	{
	}

	private void HideQuickMessageLinkForIPCollab()
	{
	}

	public void ShowBooyahPassWithOutItemDesc()
	{
	}

	public void SetTokenExchangeData(UIModelBigEvent.TokenTipsData tokenTipsData)
	{
	}

	public void SetScrollViewPanelDepth(int depth)
	{
	}

	public void SetHyperBookPanelDepth(int depth)
	{
	}

	public void SetBooyahPassPanelDepth(int depth)
	{
	}

	public void SetIPCollabPanelDepth(int depth)
	{
	}

	public void SetPrivilegeGridShow(bool isVisable)
	{
	}

	private bool NeedSetPrivilegeShowContainer(uint itemId)
	{
		return false;
	}

	public void SetPrivilegeShowContainerVisible(bool isVisible)
	{
	}

	public void SetPrivilegeShowContainerData(uint itemId)
	{
	}

	protected bool IsFinishMoveShowUIHud(uint itemId)
	{
		return false;
	}

	private void RefreshFinishMovePanel(uint itemid)
	{
	}

	public void _003C_003EiFixBaseProxy_InitView()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
