using UnityEngine;
using message;

namespace COW;

public class UITeamGatherPointMapIconController : MonoBehaviour
{
	public UISprite mStataIcon;

	private MJIKOLNFGHD m_CurrentState;

	private byte mBindTeam;

	public GameObject mUsingEffect;

	public GameObject mUsingEffect_Enemy;

	private Color mDisableColor;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void SetState(MJIKOLNFGHD state, byte teamId)
	{
	}

	private void RefreshState()
	{
	}
}
