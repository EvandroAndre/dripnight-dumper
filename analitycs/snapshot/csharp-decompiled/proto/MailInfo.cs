using System.Collections.Generic;
using COW;
using ProtoBuf;

namespace proto;

public class MailInfo : IMessage, IGameAssistItemData
{
	public ulong mail_id;

	public uint type;

	public string title;

	public string content;

	public MailSenderInfo sender_info;

	public MailAttachment attachment;

	public long receive_time;

	public EMail.Status status;

	public EMail.Source source;

	public EMail.ActionType action_type;

	public string release_version;

	public string cdn_url;

	public uint go_pos;

	public string sub_go_pos;

	public long expire_time;

	public string local_mail_id;

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

	public void ParseFrom(ProtoReader reader)
	{
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
