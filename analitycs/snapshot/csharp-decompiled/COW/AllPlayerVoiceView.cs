using System.Collections.Generic;
using UnityEngine;

namespace COW;

public class AllPlayerVoiceView : MonoBehaviour
{
	public enum RoomVoiceGroup
	{
		None,
		Enemy,
		Teammates
	}

	public UISprite NameBg;

	public UILabel NameLabel;

	public UIButton MuteToggleBtn;

	public UISprite MutedSprite;

	public UISprite NotMuteSprite;

	public UIColor NameBgColor;

	private TweenAlpha NoiceTween;

	private RoomVoiceGroup m_VoiceGroup;

	public Vector2 ViewSize;

	private HashSet<string> m_TeammateIDs;

	private bool m_IsMute;

	private static readonly Color enemyNameBG;

	private static readonly Color teammateNameBG;

	private static readonly Color enemyNameBGColor;

	private static readonly Color teammateNameBGColor;

	private HashSet<string> m_EnemyIds;

	public bool IsMute
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	public void UpdateTeammateIDs()
	{
	}

	private void OnDestroy()
	{
	}

	public void InitTeamVoiceView()
	{
	}

	public void InitEnemyVoiceView()
	{
	}

	private void OnMuteToggle()
	{
	}

	private void DoMute()
	{
	}

	private void RefreshView(bool isMute, bool isInit = false)
	{
	}

	private void OnSelfJoined(object[] data)
	{
	}

	private void OnPlayerJoin(object[] data)
	{
	}

	private void ResetVoice()
	{
	}

	public void RecoverCurrentVoice()
	{
	}
}
