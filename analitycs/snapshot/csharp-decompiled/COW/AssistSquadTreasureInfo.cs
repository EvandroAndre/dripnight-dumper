using System.Collections.Generic;
using proto;

namespace COW;

public class AssistSquadTreasureInfo : IGameAssistItemData
{
	private TopUpTeamInvitation m_Invitation;

	private ulong _003CAssist_Id_003Ek__BackingField;

	private ELobbyAssistDataType _003CSubType_003Ek__BackingField;

	private bool _003CNeedHideLine_003Ek__BackingField;

	public ulong Assist_Id
	{
		get
		{
			return _003CAssist_Id_003Ek__BackingField;
		}
		set
		{
			_003CAssist_Id_003Ek__BackingField = value;
		}
	}

	public ELobbyAssistDataType SubType
	{
		get
		{
			return _003CSubType_003Ek__BackingField;
		}
		set
		{
			_003CSubType_003Ek__BackingField = value;
		}
	}

	public bool NeedHideLine
	{
		get
		{
			return _003CNeedHideLine_003Ek__BackingField;
		}
		set
		{
			_003CNeedHideLine_003Ek__BackingField = value;
		}
	}

	public bool HasRead
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public void SetData(ulong senderAccountId)
	{
	}

	public bool CheckCanAddToList()
	{
		return false;
	}

	public bool CheckAssistStateIsFit(bool checkNewMessage)
	{
		return false;
	}

	public void AddDataToViewList(uint index, List<IGameAssistItemData> list)
	{
	}
}
