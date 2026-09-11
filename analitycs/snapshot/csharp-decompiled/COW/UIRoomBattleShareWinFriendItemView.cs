using System;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIRoomBattleShareWinFriendItemView : MonoBehaviour
{
	public UIButton HeadButton;

	public UINetworkTexture HeadIcon;

	public UISprite HeadSprite;

	public UISprite FakeSprite;

	public UILabel PlayerName;

	public UISprite SelectedBG;

	public UIEffectSprite ProfileBg;

	public GameObject FakeProfileBg;

	public UILabel TimesLabel;

	public UIToggle FriendToggle;

	public GameObject Checkmark;

	private TeammateStats m_FriendStats;

	private Action<TeammateStats> m_OnSelected;

	private Action m_OnDisChoose;

	private bool m_Selected;

	private bool m_IgnoreToggleChange;

	private ulong _003CAccountId_003Ek__BackingField;

	public ulong AccountId
	{
		get
		{
			return _003CAccountId_003Ek__BackingField;
		}
		private set
		{
			_003CAccountId_003Ek__BackingField = value;
		}
	}

	public void SetData(TeammateStats friendStats, uint winCount, bool selected, Action<TeammateStats> onSelected, Action onDisChoose)
	{
	}

	public void SetWinCount(uint winCount)
	{
	}

	public void SetSelected(bool selected)
	{
	}

	private void InitToggle()
	{
	}

	private void OnToggleChanged()
	{
	}

	private void SetHeadPic(TeammateStats friendStats)
	{
	}

	private void SetNodeActive(GameObject node, bool active)
	{
	}
}
