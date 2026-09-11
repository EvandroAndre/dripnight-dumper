using System.Collections.Generic;

namespace COW;

public class AssistReceiveGiftInfo : IGameAssistItemData
{
	public ulong SenderAccountID;

	public uint ItemID;

	public uint ItemCnt;

	public ulong MailID;

	private ELobbyAssistDataType m_SubType;

	private ulong m_AssistId;

	private bool m_HasRead;

	private bool m_NeedHideLine;

	private bool m_IsInteracted;

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

	public bool IsInteracted
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

	public void SetData(ulong senderAccountID, uint itemID, uint itemCnt, ulong mailID)
	{
	}
}
