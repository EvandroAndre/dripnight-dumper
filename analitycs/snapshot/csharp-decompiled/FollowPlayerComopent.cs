using COW.GamePlay;
using GCommon;
using UnityEngine;

public class FollowPlayerComopent : MonoBehaviour
{
	public float m_FollowSpeed;

	private BHGGAEEHJCO m_FollowPlayerID;

	private ResourceID m_ResID;

	private bool m_IsDestroy;

	private Transform m_CachTransform;

	private ResourceID m_PickEffectResID;

	private ResourceID m_PickSoundResID;

	private void Awake()
	{
	}

	public void InitComopnent(BHGGAEEHJCO playerId, ResourceID resID, ResourceID pickEffectResID, ResourceID pickSoundResID)
	{
	}

	private void Update()
	{
	}

	private void OnGetClosePlayer(Player player)
	{
	}

	private void RecyleOrDestroy()
	{
	}
}
