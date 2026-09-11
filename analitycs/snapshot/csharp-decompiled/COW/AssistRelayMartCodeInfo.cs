using System.Collections.Generic;
using proto;

namespace COW;

public class AssistRelayMartCodeInfo : IGameAssistItemData
{
	private const ELobbyAssistDataType RELAY_MART_TITLE_TYPE = ELobbyAssistDataType.RelayMartCode;

	private bool m_NeedHideLine;

	private RelayMartSharedDiscountCode m_RelayMartSharedDiscountCode;

	private ulong _003CAssist_Id_003Ek__BackingField;

	private ELobbyAssistDataType _003CSubType_003Ek__BackingField;

	private bool _003CHasRead_003Ek__BackingField;

	public RelayMartSharedDiscountCode RelayMartSharedDiscountCode => null;

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

	public void SetData(RelayMartSharedDiscountCode relayMartSharedDiscountCode)
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
