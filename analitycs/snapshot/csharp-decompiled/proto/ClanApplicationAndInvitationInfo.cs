using System.Collections.Generic;
using COW;

namespace proto;

public class ClanApplicationAndInvitationInfo : IGameAssistItemData
{
	public ulong inviter_id;

	public string inviter_name;

	public AccountInfoBasic basic_info;

	public EClan.ApplicationType application_type;

	public bool friend_in_clan;

	private ELobbyAssistDataType m_SubType;

	private ulong m_AssistId;

	private bool m_HasRead;

	public bool HasAddDataToRead;

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
