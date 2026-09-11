using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudRescureController : UIBaseController
{
	private UIHudRescureView m_View;

	private BHGGAEEHJCO m_TargetResureID;

	private BHGGAEEHJCO m_TargetAssistableID;

	private Vector3 diffPos;

	private Vector3 currentPos;

	private Transform tr;

	private bool m_ShowRescure;

	private bool m_LastShowRescure;

	private float m_AbandomLifeTime;

	private bool m_IsInAbandomLifeProcess;

	private bool m_AbandomLifeEnable;

	private bool m_HasThivaSkill;

	private bool m_IsLocalPlayerThivaSkillInCD;

	private BitArrayBoolean m_AbandonLifeVisibility;

	private const uint ABANDONLIFE_VISIBILITY_NORMAL = 1u;

	private const uint ABANDONLIFE_VISIBILITY_INACTION = 2u;

	private VisualInstanceHolder m_RescueOtherBtnCustomVfxHolder;

	private VisualInstanceHolder m_ProcessingRescueCustomVfxHolder;

	private List<Player> m_TmpPendingPlayers;

	private VisualInstanceHolder m_FrozenEffectHolder;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override bool RecyleDontDestroy()
	{
		return false;
	}

	public static bool DontDestroy()
	{
		return false;
	}

	protected override void OnUIInit()
	{
	}

	public override void OnUIReInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void InternalCollectPendingPlayers(Player localPlayer, List<Player> pendingPlayers)
	{
	}

	private void Update()
	{
	}

	public void ModifyRescurePos(Vector3 pos)
	{
	}

	public void SetChangePos(Vector3 pos)
	{
	}

	private void OnSkillThivaRescureRateTriggered(bool inCD)
	{
	}

	private void OnRescureBtnClicked()
	{
	}

	private void OnAssistBtnClicked()
	{
	}

	public void ShowFrozenEffect()
	{
	}

	private void OnAbandonLifeClicked()
	{
	}

	private void OnPreparationCancel(GEvent param)
	{
	}

	private void OnHudSettingChanged(object[] param)
	{
	}

	private void OnDecreaseInPreparation(GEvent evt)
	{
	}

	private void OnObserverSwitch(object[] data)
	{
	}

	private void CancelAbandomLife()
	{
	}

	private void OnCancelAbandon()
	{
	}

	private void TryDisplayBuffCustomVfxWithContext(OKPKNBOLPAK context)
	{
	}

	private void TryHideBuffCustomVfx()
	{
	}

	private void ReleaseAllBuffCustomVfxHolders()
	{
	}

	private void CheckUseInidaNoBloodStyle()
	{
	}

	public bool _003C_003EiFixBaseProxy_RecyleDontDestroy()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIReInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
