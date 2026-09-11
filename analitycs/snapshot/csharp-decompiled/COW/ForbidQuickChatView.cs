using System;
using COW.GamePlay;
using UnityEngine;

namespace COW;

public class ForbidQuickChatView : MonoBehaviour
{
	public Action OnMuteBtnClick;

	public UISprite TeamIndexBG;

	public UILabel TeamIndexLabel;

	public UILabel TeamName;

	public UIButton MuteBtn;

	public UISprite NotMuteIcon;

	public UISprite MuteIcon;

	private BHGGAEEHJCO m_PlayerID;

	private int m_TeamIndex;

	private bool m_IsMute;

	public void InitView(int team_index, string nick_name, BHGGAEEHJCO playerID)
	{
	}

	public void SetMuteState(bool isMute)
	{
	}

	public bool GetMuteState()
	{
		return false;
	}

	private void OnClickMuteBtn()
	{
	}
}
