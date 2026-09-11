using System;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudAceTeamController : UIHUDFeedbackItemBaseController
{
	private UIHudAceTeamView m_View;

	private UIHudClanAceTeamController m_ClanCtrl;

	private GameObject m_UIFXGo;

	private ResourceID m_CurrentShowResID;

	private Animation m_CurrentUIFXAnimation;

	private LRUCacheResource m_vfxCache;

	private const int VFX_CACHE_CAPACITY = 10;

	private uint m_TicketID;

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

	private void ResetAndPlayView()
	{
	}

	private void HandleClanAceTeam(BHGGAEEHJCO beKilledID)
	{
	}

	private void HandleNormalKillIcon(uint weaponSkinID)
	{
	}

	private void SetTextLabelBG(uint weaponSkinID)
	{
	}

	private void SetPrivilegeLabel(uint weaponSkinID)
	{
	}

	public void SetViewData(BHGGAEEHJCO beKilledID, uint weaponSkinID = 0u)
	{
	}

	private void PlaySoundEffect()
	{
	}

	public override void ShowIcon(NotificationData data)
	{
	}

	private void ProcessPrivilegeVFXAdd(uint weaponSkinID)
	{
	}

	private void ProcessSpecialVFXInKillHud(WeaponSkinData skinData)
	{
	}

	private bool IsValidSkinData(WeaponSkinData skinData)
	{
		return false;
	}

	private bool IsShowingSameVFX(ResourceID vfxResID)
	{
		return false;
	}

	private void HideCurrentVFX()
	{
	}

	private GameObject GetOrCreateVFXFromManager(ResourceID vfxResID)
	{
		return null;
	}

	private void SetupVFX(GameObject vfxObject, ResourceID vfxResID)
	{
	}

	private void InitializeVFXCache()
	{
	}

	private void CleanupVFXCache()
	{
	}

	private void RemoveVFXFromCache(ResourceID resID, GameObject go)
	{
	}

	private void HandleVFXCacheError(Exception ex)
	{
	}

	private GameObject CreateVFXGameObject(ResourceID resourceID)
	{
		return null;
	}

	private bool TryGetVFXFromCache(ResourceID resourceID, out GameObject vfxObject)
	{
		vfxObject = null;
		return false;
	}

	private GameObject CreateAndAddVFXToCache(ResourceID resourceID)
	{
		return null;
	}

	private void _003CSetPrivilegeLabel_003Eb__15_0(uint ticket, bool isSuccess, UnityEngine.Object obj)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
