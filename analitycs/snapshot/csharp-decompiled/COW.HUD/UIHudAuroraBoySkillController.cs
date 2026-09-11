using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW.HUD;

internal class UIHudAuroraBoySkillController : UIBaseController
{
	private Transform CachedTransform;

	private LPDBCAOACKJ m_EnemyQueue;

	private GMPGMPFNMFP m_HitInfo;

	private readonly uint m_TraceFlag;

	private Dictionary<uint, uint> m_EnemyIconMap;

	private Dictionary<uint, Vector2> m_EnemyIconOldPos;

	private Dictionary<uint, Vector2> m_EnemyIconDampVelocity;

	private HashSet<uint> m_EnemyIconLastResult;

	private HashSet<uint> m_EnemyIconChecking;

	private List<uint> m_PlayerIdCache;

	private readonly ResourceID m_SkydivingHudVfx;

	private uint m_SkydivingHudFullScreenId;

	private uint m_SkydivingHudVfxId;

	private Animation m_SkydivingHudVfxAnim;

	private string m_AnimIn;

	private string m_AnimOut;

	private uint m_SkydivingHudVfxAnimDelayCall;

	private ResourceID m_EnemyIconRes;

	private bool m_SkillSkydiving;

	private LGONIIMINHO m_AuroraboySkill;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void SetData(LGONIIMINHO skill)
	{
	}

	public override void Hide()
	{
	}

	private void ReleaseVfx()
	{
	}

	private void LateUpdate()
	{
	}

	private void Check1PSkydiving()
	{
	}

	private void SkydivingProduceEnemyQueue()
	{
	}

	private void SkydivingConsumEnemyQueue()
	{
	}

	private bool CheckShowOrHideIcon(BHGGAEEHJCO playerId)
	{
		return false;
	}

	private void SkydivingUpdateEnemyIconPos()
	{
	}

	private void ShowEnemyIcon(BHGGAEEHJCO playerId, Vector2 iconPos)
	{
	}

	private void HideEnemyIcon(BHGGAEEHJCO playerId)
	{
	}

	private void RemoveAllEnemyIcon()
	{
	}

	private void SkydivingFullScreenVfxVisibilityChange(bool show)
	{
	}

	private void _003CSkydivingFullScreenVfxVisibilityChange_003Eb__35_0(uint _id, ResourceID _resId, GameObject _instance)
	{
	}

	private void _003CSkydivingFullScreenVfxVisibilityChange_003Eb__35_1()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_Hide()
	{
	}
}
