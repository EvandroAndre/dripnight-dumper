using System.Collections.Generic;
using tcp;

namespace COW;

public class AssistExpiredTeamUpInfo : IGameAssistItemData
{
	private GroupInviteNtf m_TeamUpInfo;

	private ELobbyAssistDataType m_SubType;

	private ulong m_AssistId;

	private bool m_HasRead;

	private bool m_NeedHideLine;

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

	public bool NeedHideLine
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public ELobbyAssistDataType SubType
	{
		get
		{
			return ELobbyAssistDataType.None;
		}
		set
		{
		}
	}

	public ulong Assist_Id
	{
		get
		{
			return 0uL;
		}
		set
		{
		}
	}

	public GroupInviteNtf TeamUpInfo
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public ulong GetDataReadEndTime()
	{
		return 0uL;
	}

	public bool CheckAssistStateIsFit(bool checkNewMessage)
	{
		return false;
	}

	public bool CheckCanAddToList()
	{
		return false;
	}

	public void AddDataToViewList(uint index, List<IGameAssistItemData> list)
	{
	}
}
