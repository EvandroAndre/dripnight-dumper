using COW.GamePlay;
using UnityEngine;

namespace COW;

internal class UIHudRoomOBPlayerStateItem : MonoBehaviour
{
	public UILabel Name;

	public UILabel No;

	public UILabel Kill;

	public UISprite TeamBg;

	public GameObject DeathMask;

	public GameObject SelectedBG;

	public UIButton Btn;

	private PlayerData m_PlayerData;

	public void Awake()
	{
	}

	public void SetUIData(PlayerData data, int index)
	{
	}

	public void SelectedPlayer(Player targetPlayer)
	{
	}

	public void OnRowClick()
	{
	}
}
