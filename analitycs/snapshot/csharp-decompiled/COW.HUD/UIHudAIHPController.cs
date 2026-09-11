using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW.HUD;

internal class UIHudAIHPController : UIHudNameBaseController, IHudNameController
{
	private UIHudInfectionHPView m_View;

	private BHGGAEEHJCO m_BindPlayerID;

	private float m_Counter;

	private float m_AIHP;

	private bool m_IsPlayer;

	private NetworkAIPawn m_BindAI;

	private Player m_BindPlayer;

	public const uint ISVISIBLE_PLAYER = 1u;

	public const uint ISVISIBLE_HP = 2u;

	private BitArrayBoolean m_Visible;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override bool NeedAutoScaleByDistance()
	{
		return false;
	}

	protected override bool NeedUpdatePosition()
	{
		return false;
	}

	protected override Vector3 TargetPosition()
	{
		return default(Vector3);
	}

	protected override bool NeedKeepInScreen()
	{
		return false;
	}

	public void BindPlayer(BHGGAEEHJCO pID)
	{
	}

	public void UnbindPlayer()
	{
	}

	public void OnHpChanged(BHGGAEEHJCO id, int oldHP, int curHP, int maxHP, bool isPlayer = false)
	{
	}

	public void OnAIRecycle(uint playerid)
	{
	}

	private void Update()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public bool _003C_003EiFixBaseProxy_NeedAutoScaleByDistance()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_NeedUpdatePosition()
	{
		return false;
	}

	public Vector3 _003C_003EiFixBaseProxy_TargetPosition()
	{
		return default(Vector3);
	}

	public bool _003C_003EiFixBaseProxy_NeedKeepInScreen()
	{
		return false;
	}
}
