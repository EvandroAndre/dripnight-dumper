using proto;
using tcp;

namespace COW;

public class RelationshipMessageInfo
{
	private sealed class _003C_003Ec__DisplayClass10_0
	{
		public RelationshipMessageInfo _003C_003E4__this;

		public UIRelationshipMsgType msgType;

		internal void _003CSetMessageCountDown_003Eb__0()
		{
		}
	}

	public ulong AccoutID;

	public ulong SendTimeStamp;

	public proto.EFriend.RelationType RelationType;

	public UIRelationshipMsgType MsgType;

	public bool IsRead;

	private uint m_DelayCall;

	public FriendAccountInfo SendMsgAccountInfo
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	~RelationshipMessageInfo()
	{
	}

	private void SetMessageCountDown(float validTime, UIRelationshipMsgType msgType)
	{
	}

	private void InitMessage()
	{
	}

	public void ChangeCurrentMsgType(UIRelationshipMsgType msgType)
	{
	}

	public static implicit operator RelationshipMessageInfo(SepcialFriendsAppsRes appsRes)
	{
		return null;
	}

	public static RelationshipMessageInfo CreateRelationshipMessageInfo(RelatedFriendRequestNtf appsRes, UIRelationshipMsgType msgType)
	{
		return null;
	}
}
