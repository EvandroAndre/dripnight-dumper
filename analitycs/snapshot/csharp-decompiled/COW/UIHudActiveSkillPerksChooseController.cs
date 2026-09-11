using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudActiveSkillPerksChooseController : UIBaseController
{
	private const string NINTH_GP_OPEN_ANIM_NAME = "UIFX_Ninth_GP_UIHudActiveSkillPerksChoose_Ninth_GP_In";

	private const string NINTH_GP_CLOSE_ANIM_NAME = "UIFX_Ninth_GP_UIHudActiveSkillPerksChoose_Ninth_GP_OUT";

	private UIHudActiveSkillPerksChooseView m_View;

	private LDNECDGGOJF m_SkillCard;

	private UIHudActiveSkillPerksChooseItem m_UIItem0;

	private UIHudActiveSkillPerksChooseItem m_UIItem1;

	private string m_Style;

	private VisualInstanceHolder m_StyledBgHolder;

	private Animation m_StyledBgAnimation;

	private uint m_NinthGpCloseDelayCallID;

	private bool m_IsPlayingNinthGpCloseAnimation;

	private bool m_HasCachedSkillItemOriginalParent;

	private bool m_IsSkillItemParentResetForNinthGp;

	private Transform m_ItemPos1OriginalParent;

	private Transform m_ItemPos2OriginalParent;

	private int m_ItemPos1OriginalSiblingIndex;

	private int m_ItemPos2OriginalSiblingIndex;

	private Vector3 m_ItemPos1OriginalLocalPosition;

	private Vector3 m_ItemPos2OriginalLocalPosition;

	private Quaternion m_ItemPos1OriginalLocalRotation;

	private Quaternion m_ItemPos2OriginalLocalRotation;

	private Vector3 m_ItemPos1OriginalLocalScale;

	private Vector3 m_ItemPos2OriginalLocalScale;

	private bool m_IsSkillPowerUpMode;

	private uint m_SkillPowerUpItemUniqueID;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void Show()
	{
	}

	public override void Hide()
	{
	}

	protected override void OnUIClose()
	{
	}

	public void SetData(uint originalSkillId, uint skillCardDataId)
	{
	}

	public void ChooseSkillPerksIndex(int perksIndex)
	{
	}

	public void SetSkillPowerUpData(GKGGOIJHDBO skillPowerUpItem)
	{
	}

	private void ChooseSkillPowerUpIndex(int powerUpIndex)
	{
	}

	private void TryPlaySkillPowerUpSelectedEffectIfTakingEffect()
	{
	}

	private void TryChangeStyle(string style)
	{
	}

	private void CloseThisUI()
	{
	}

	private void OnCloseBtnClick()
	{
	}

	private void OnLocalPlayerDead(object[] data)
	{
	}

	private bool IsNinthGpSkillMightyStyle()
	{
		return false;
	}

	private bool ShouldPlayNinthGpCloseAnimation()
	{
		return false;
	}

	private void CacheStyledBgAnimation()
	{
	}

	private void TryPlayNinthGpOpenAnimation()
	{
	}

	private float PlayStyledBgAnimation(string animName)
	{
		return 0f;
	}

	private void HideAfterNinthGpCloseAnimation()
	{
	}

	private void CancelNinthGpCloseDelayCall()
	{
	}

	private void ResetSkillItemsParentForNinthGpAnimation()
	{
	}

	private void CacheSkillItemOriginalParent()
	{
	}

	private void CacheSkillItemOriginalParent(Transform itemPos, ref Transform originalParent, ref int originalSiblingIndex, ref Vector3 originalLocalPosition, ref Quaternion originalLocalRotation, ref Vector3 originalLocalScale)
	{
	}

	private void ResetSkillItemParent(Transform itemPos, Transform targetParent)
	{
	}

	private void RestoreSkillItemsParent()
	{
	}

	private void RestoreSkillItemParent(Transform itemPos, Transform originalParent, int originalSiblingIndex, Vector3 originalLocalPosition, Quaternion originalLocalRotation, Vector3 originalLocalScale)
	{
	}

	private void SetSkillItemsVisible(bool visible)
	{
	}

	private void ReleaseStyledBg()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_Show()
	{
	}

	public void _003C_003EiFixBaseProxy_Hide()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
