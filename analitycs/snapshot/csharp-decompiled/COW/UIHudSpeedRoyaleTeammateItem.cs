using COW.GamePlay;
using UnityEngine;
using message;

namespace COW;

internal class UIHudSpeedRoyaleTeammateItem : MonoBehaviour
{
	public UILabel Name;

	public GameObject HPBarGO;

	public UISprite HP;

	public UISprite Mark;

	public GameObject KillerGO;

	public UILabel TeamIndex;

	public UISprite Offline;

	public UISprite DisFlag;

	public GameObject VoiceGO;

	private ETeammateState m_CurrentState;

	public void Show(bool v)
	{
	}

	public void InitInfo(Player p)
	{
	}

	public void InitWithPlayerInfo(KMGBNNHDOHF playerInfo)
	{
	}

	public void SetVoiceVisible(bool flag)
	{
	}

	public void SetMarkShow(bool show)
	{
	}

	public void SetTeammateState(ETeammateState nextState)
	{
	}

	public void SetDisconnected(bool disconnected)
	{
	}

	public void OnHPChanged(Player p)
	{
	}
}
