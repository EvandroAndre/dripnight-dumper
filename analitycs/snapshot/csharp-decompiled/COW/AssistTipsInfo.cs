using System.Collections.Generic;
using proto;

namespace COW;

public class AssistTipsInfo : IGameAssistItemData
{
	private ELobbyAssistDataType m_SubType;

	private ulong m_AssistId;

	public ClientMemberShipCardData MemberShipCardData;

	public CSGetMembershipInfoRes EvoPassData;

	public WorkshopVipInfo WorkshopVipInfo;

	private bool m_HasRead;

	private bool m_NeedHideLine;

	private string m_Title;

	private ulong m_CountDownTime;

	private GameAssistSystemRuleInfo m_RuleCdnInfo;

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

	public string Title
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public ulong CountDownTime
	{
		get
		{
			return 0uL;
		}
		set
		{
		}
	}

	public GameAssistSystemRuleInfo RuleCdnInfo
	{
		get
		{
			return null;
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
