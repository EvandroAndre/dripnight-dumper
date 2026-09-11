using System.Collections.Generic;
using COW.GamePlay;
using GCommon;

namespace COW.HUD;

internal class UIHudEnemyReviveHintController : UIBaseController
{
	private readonly Stack<UIHudEnemyReviveHintItemController> m_HintCtrlPool;

	private Dictionary<BHGGAEEHJCO, float> m_InvisibleQueue;

	private Dictionary<BHGGAEEHJCO, UIHudEnemyReviveHintItemController> m_VisibleQueue;

	private Dictionary<BHGGAEEHJCO, UIHud3DHint> m_VisibleQueue3D;

	private List<BHGGAEEHJCO> m_PlayerIdCache;

	private readonly float m_RangeSqr;

	private readonly float m_MaxDis;

	private readonly int MaxInvisiableDuration;

	private float m_LastUpdateInvisiableRevivedPlayerTs;

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

	protected override void OnVisibilityChanged()
	{
	}

	private void LateUpdate()
	{
	}

	private void OnPlayerRevive(uint playerId)
	{
	}

	private void OnPlayerStateChange(uint playerId)
	{
	}

	private void UpdateInvisiableQueue()
	{
	}

	private void UpdateVisiableQueue()
	{
	}

	private void UpdateVisiableQueue3D()
	{
	}

	private void RemoveAllHints()
	{
	}

	private void RemoveHintUI(BHGGAEEHJCO playerId)
	{
	}

	private void HideHintUI(BHGGAEEHJCO playerId)
	{
	}

	private void ShowHintUI(BHGGAEEHJCO playerId, float angle, float distance)
	{
	}

	private void Remove3DHintUI(BHGGAEEHJCO playerId)
	{
	}

	private void Hide3DHintUI(BHGGAEEHJCO playerId)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
