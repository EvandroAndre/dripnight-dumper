using System.Collections.Generic;

namespace COW;

public class AssistMemberShipCardInfo : IGameAssistItemData
{
	private ELobbyAssistDataType m_SubType;

	private ulong m_AssistId;

	public uint TodayGemReward;

	private List<ClientMemberShipCardData> m_MemberShipCardList;

	private bool m_AssistShowClaimAll;

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

	public bool AssistShowClaimAll
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public List<ClientMemberShipCardData> MemberShipCardList
	{
		get
		{
			return null;
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
