using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;
using message;

namespace COW;

public class UIHudOBCountController : UIBaseController
{
	private UIHudOBCountView m_View;

	private int m_NormalCount;

	private int m_FriendCount;

	private int m_TotalCount;

	private bool m_IsNameListDirty;

	private bool m_IsBtnPressed;

	private int m_LikedInqueueCount;

	private Queue<byte> m_TeammateIndexQueue;

	private Queue<string> m_friendObQueue;

	private float playTimeStamp;

	private float interval;

	private bool m_NeedReposition;

	private ResourceID InGameOBIcon;

	private ResourceID MixOBIcon;

	private ResourceID FriendOBIcon;

	private string FRIEND_OB_COUNT_FORMAT;

	private List<GameObject> m_NameGo;

	private List<UILabel> m_NameLabels;

	private List<UISprite> m_NameIcons;

	private List<UILabel> m_TeamIndexs;

	private List<GameObject> m_FriendNameGo;

	private List<UILabel> m_FriendNameLabels;

	private int m_TeamCount;

	private int m_NotTeamCount;

	private List<HDLLGEKBMOD> m_TeamList;

	private List<HDLLGEKBMOD> m_NotTeamList;

	private List<HDLLGEKBMOD> m_FriendList;

	private Color BlueColor;

	private const int NORMAL_MAXSHOW = 5;

	private const int FRIEND_MAXSHOW = 3;

	private const int BORDER_UP_PADDING = 0;

	private const int BORDER_BOTTOM_PADDING = 8;

	private const int NORMALE_TITLE_HEIGHT = 32;

	private const int NORMALE_ITEM_HEIGHT = 30;

	private const int FRIEND_TITLE_HEIGHT = 32;

	private const int FRIEND_ITEM_HEIGHT = 30;

	private const int OMIT_ITEM_HEIGHT = 16;

	private const int LINE_HEIGHT = 16;

	private const int TEAM_INDEX_OFFSET = -61;

	private int m_NormalIndex;

	private int m_FriendIndex;

	private UIClickMask m_ClickMask;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override bool RecyleDontDestroy()
	{
		return false;
	}

	public static bool DontDestroy()
	{
		return false;
	}

	protected override void OnUIInit()
	{
	}

	public override void OnUIReInit()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void UpdateCount()
	{
	}

	private void OnOBCountChange(object[] data)
	{
	}

	private void OnFriendOBCountChange(int data)
	{
	}

	private void OnOBTargetChange(object[] data)
	{
	}

	private bool CanShowFriendCount(Player beTrackedPlayer)
	{
		return false;
	}

	private Player GetBeTrackedPlayer()
	{
		return null;
	}

	private bool BeTrackedPlayerHasTeammateOB(Player beTrackedPlayer)
	{
		return false;
	}

	private void OnLikeCountChanged(object[] data)
	{
	}

	private void OnFriendLikeCountChanged(object[] data)
	{
	}

	private void ShowLike()
	{
	}

	private void PlayInitState()
	{
	}

	private void Update()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void InitPlayerNameList()
	{
	}

	private void OnOBCountPressed(GameObject go)
	{
	}

	private void LocalTest()
	{
	}

	private void TryRepositionPlayerNameTable()
	{
	}

	private void RequestObserverNames()
	{
	}

	private void OnUpdateOBPlayerNameList(object[] data)
	{
	}

	private string GetPlayerNameByID(BHGGAEEHJCO pid)
	{
		return null;
	}

	private void RefreshNameLabel()
	{
	}

	private void OnUpdateOBObserverNameList(object[] data)
	{
	}

	private void RefreshOBObserverNameLists(List<HDLLGEKBMOD> teamList, List<HDLLGEKBMOD> notTeamList, List<HDLLGEKBMOD> friendList)
	{
	}

	private void BubbleSort(List<HDLLGEKBMOD> list)
	{
	}

	private void AddMask()
	{
	}

	private void RemoveMask()
	{
	}

	private bool CheckOBPlayerIsSelf(BHGGAEEHJCO playerID)
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_RecyleDontDestroy()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIReInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
