using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class ProfileManager : SingletonModule<ProfileManager>, IUIModelDataChangeObserver
{
	private Dictionary<ulong, BaseProfileInfo> m_ProfileInfoDic;

	private Dictionary<ulong, uint> m_ProfileInfoSourceTypeFlagDic;

	private UIModelFriends m_FriendModel;

	private UIModelClan m_ClanModel;

	private UIModelGroup m_GroupModel;

	private UIModelCustomRoom m_CustomRoomModel;

	protected override void OnCleanup()
	{
	}

	protected override void OnInit()
	{
	}

	public BaseProfileInfo GetUserProfileInfo(ulong id)
	{
		return null;
	}

	public void AddUserProfileInfo(List<ClanMember> m_ClanMembers, uint profileInfoSourceTypeFlag = 0u)
	{
	}

	public void AddUserProfileInfo(ulong id, BaseProfileInfo profileinfo, uint profileInfoSourceTypeFlag = 0u)
	{
	}

	public void CleanMessageProfileInfoFromList(IEnumerable<ulong> senderIDs)
	{
	}

	public void SceneChange(Type sceneType)
	{
	}

	void IUIModelDataChangeObserver.OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	uint IUIModelDataChangeObserver.GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}
}
