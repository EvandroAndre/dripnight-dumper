using System.Collections.Generic;

namespace COW;

public class AssistRelayMartRebateInfo : IGameAssistItemData
{
	private const ELobbyAssistDataType RELAY_MART_TITLE_TYPE = ELobbyAssistDataType.RelayMartCode;

	private bool m_NeedHideLine;

	private ulong m_AccountId;

	private uint m_RebateAmount;

	private ulong _003CAssist_Id_003Ek__BackingField;

	private ELobbyAssistDataType _003CSubType_003Ek__BackingField;

	private bool _003CHasRead_003Ek__BackingField;

	public uint RebateAmount => 0u;

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
			return false;
		}
		set
		{
		}
	}

	public bool HasRead
	{
		get
		{
			return _003CHasRead_003Ek__BackingField;
		}
		set
		{
			_003CHasRead_003Ek__BackingField = value;
		}
	}

	public void SetData(ulong accountId, uint rebateAmount)
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
