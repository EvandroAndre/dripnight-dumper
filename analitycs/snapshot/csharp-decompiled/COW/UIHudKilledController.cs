using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudKilledController : UIHUDFeedbackItemBaseController
{
	private sealed class _003C_003Ec__DisplayClass56_0
	{
		public UIHudKilledController _003C_003E4__this;

		public ResourceID knockDownUIFXRes;

		internal void _003CProcessSpecialVFXInKillHud_003Eb__0(uint id, ResourceID resID, GameObject go)
		{
		}
	}

	private const string REINFORCE_TOKEN_FORMAT = "+{0}";

	private UIHudKilledView m_View;

	private EntityVisualEffectManager m_EffectManager;

	private uint m_CurrentVFXUniqueID;

	private Dictionary<GameObject, uint> m_VFXGOToUniqueID;

	private GameObject m_UIFXGo;

	private uint m_HeadShotKnockDownVFXUniqueID;

	private ResourceID m_CurrentShowResID;

	private Animation m_CurrentUIFXAnimation;

	private string[] m_VFXKnockDownAnimationClips;

	private LRUCacheResource m_vfxCache;

	private const int VFX_CACHE_CAPACITY = 20;

	private UIHudKilledBigHeadNode m_BigheadNode;

	private const string NORMAL_KNOCKDOWN_ICON = "icon_KnockDown_1";

	private const string INDIA_KNOCKDOWN_ICON = "icon_KnockDown_1_India";

	private const string ASSIST_KNOCKDOWN_ICON = "icon_KnockDownAssist";

	private int m_CacheVFXAnimationIndex;

	private bool m_isHeadShot;

	private int m_BigHeadKillScore;

	public EntityVisualEffectManager GetEffectManager()
	{
		return null;
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void OnUIReInit()
	{
	}

	private void HideAllNode()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public override void HideIcon()
	{
	}

	private void ShowSimpleKillTypeIcon(bool showHeadShotKnockDownEffect)
	{
	}

	private void PlayHeadShotKnockDownAnimation()
	{
	}

	private void HideHeadShotKnockDownAnimation()
	{
	}

	private void PlayHeadShotKnockDownVFX()
	{
	}

	private void PlayHeadShotKnockDownVFX(Transform parent)
	{
	}

	private void HideHeadShotKnockDownVFX()
	{
	}

	private void ReleaseHeadShotKnockDownVFX()
	{
	}

	private void TargetPlayerMetropolisKillIcon(int weaponID, uint scannerMarkAddCoin = 0u)
	{
	}

	private void TargetPlayerKilledIcon(bool isHeadShot, BHGGAEEHJCO victimPlayerID, int killStack = -1, uint scannerMarkAddCoin = 0u, uint weaponSkinID = 0u)
	{
	}

	private ResourceID GetDefaultKillIconRes(bool isHeadShot, BHGGAEEHJCO victimPlayerID, int killStack)
	{
		return default(ResourceID);
	}

	private void BigHeadKilledIcon(bool isHeadShot, ResourceID killIconRes, bool bPriviliegeKillStyle, BHGGAEEHJCO victimPlayerID)
	{
	}

	private int GetBigHeadKillScore(bool isHeadShot, BHGGAEEHJCO victimPlayerID)
	{
		return 0;
	}

	private void OnBigHeadKillNodeInstanced(uint uniqueID, ResourceID vfxResID, GameObject instance)
	{
	}

	private void KilledIcon(bool isHeadShot, ResourceID killIconRes, bool bPriviliegeKillStyle)
	{
	}

	private void KilledIconInSimple(ResourceID killIconRes)
	{
	}

	private void TargetPlayerKnockdownIcon(uint gainCoins, int knockdownCount, uint weaponSkinID, bool isHeadShot)
	{
	}

	private ResourceID GetDefaultKnockDownIconRes()
	{
		return default(ResourceID);
	}

	private void PlayPrivilegeKnockDownVFX(int inKnockDownCount)
	{
	}

	private void TargetPlayerAssistKnockdownIcon(uint weaponSkinID)
	{
	}

	private static string GetNormalKillSpriteName(BloodType bloodType)
	{
		return null;
	}

	private static string GetHeadshotKillSpriteName(BloodType bloodType)
	{
		return null;
	}

	private static string GetBattleLevelKillSpriteName(BloodType bloodType)
	{
		return null;
	}

	private static string GetKillSpriteName(BloodType bloodType, bool isHeadShot, BHGGAEEHJCO victimPlayerID, int killStack)
	{
		return null;
	}

	private static EPrivilegeKillIconType GetPrivilegeKillType(bool isHeadShot)
	{
		return EPrivilegeKillIconType.None;
	}

	private void PlayKillAudio(int killStack, uint scannerMarkAddCoin, BHGGAEEHJCO victimPlayerID)
	{
	}

	private void PlaySoundKillAudio()
	{
	}

	public override void ShowIcon(NotificationData data)
	{
	}

	private void RefreshLeftReviveCount(BHGGAEEHJCO beKilledId)
	{
	}

	private void HandleLoadoutReinforceToken(uint reinforceToken)
	{
	}

	private void ProcessPrivilegeVFXAdd(NotifyShowDataKill KillData)
	{
	}

	private void ProcessSpecialVFXInKillHud(WeaponSkinData skinData)
	{
	}

	private GameObject GetOrCreateVFX(ResourceID vfxResID)
	{
		return null;
	}

	private void SetupVFX(GameObject vfxObject, ResourceID vfxResID)
	{
	}

	private void HideCurrentVFX()
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

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIReInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_HideIcon()
	{
	}
}
