using COW.GamePlay;
using UnityEngine;

namespace COW;

internal class UISPHudPlayerItem : MonoBehaviour
{
	public UIWidget Widget;

	public UILabel No;

	public UILabel Name;

	public UILabel Cnt;

	public UIButton Btn;

	public GameObject DeadMask;

	public GameObject SelectedBG;

	private PlayerData m_PlayerData;

	public void Init()
	{
	}

	public void SelectedPlayer(Player targetPlayer)
	{
	}

	public void SetUIData(PlayerData data, int height, int index)
	{
	}

	private void OnPlayerClick()
	{
	}

	public void SetPlayerStates(bool isDead)
	{
	}
}
