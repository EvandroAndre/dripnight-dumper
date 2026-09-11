using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudTeleportKnockDownResultItemController : UIHudNameBaseController
{
	private UIHudTeleportKnockDownResultItemView m_View;

	public Transform CachedTransform;

	private BHGGAEEHJCO _003CMarkPlayerId_003Ek__BackingField;

	private readonly Color m_EnemyColor;

	private readonly Color m_TeammateColor;

	private readonly Color m_AimedColor;

	private bool m_MarkPlayerIsLocalPlayerTeammate;

	private bool m_IsAimed;

	public BHGGAEEHJCO MarkPlayerId
	{
		get
		{
			return _003CMarkPlayerId_003Ek__BackingField;
		}
		private set
		{
			_003CMarkPlayerId_003Ek__BackingField = value;
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetData(BHGGAEEHJCO playerId)
	{
	}

	public void SetAimed(bool aimed, bool forceRefresh = false)
	{
	}

	protected override Vector3 TargetPosition()
	{
		return default(Vector3);
	}

	protected override bool NeedKeepInScreen()
	{
		return false;
	}

	protected override bool KeepShowDownArrow()
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public Vector3 _003C_003EiFixBaseProxy_TargetPosition()
	{
		return default(Vector3);
	}

	public bool _003C_003EiFixBaseProxy_NeedKeepInScreen()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_KeepShowDownArrow()
	{
		return false;
	}
}
