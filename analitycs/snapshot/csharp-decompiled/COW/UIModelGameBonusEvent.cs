using System.Collections.Generic;
using GCommon;
using message;
using proto;

namespace COW;

public class UIModelGameBonusEvent : UIBaseModel
{
	private sealed class _003C_003Ec__DisplayClass12_0
	{
		public UIModelGameBonusEvent _003C_003E4__this;

		public uint matchMode;

		public uint gameMode;

		public uint mapID;

		public CMDBIPLGLGA groupMode;

		internal bool _003CGetGameBonusEventDesc_003Eb__0(GameBonusEventDesc e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass8_0
	{
		public UIModelGameBonusEvent _003C_003E4__this;

		public uint matchMode;

		public uint gameMode;

		public uint mapID;

		public CMDBIPLGLGA groupMode;

		internal bool _003CIsInDoubleBonusPeriod_003Eb__0(GameBonusEventDesc e)
		{
			return false;
		}
	}

	private CSGetGameBonusEventDescRes m_Desc;

	private const int AllGroupMode = -1;

	private const int AllGameMode = 0;

	private const int AllMatchMode = 0;

	private const int AllMapID = 0;

	public const int PropID_BonusEventDescRespond = 2;

	public override void Logout(object[] data)
	{
	}

	public void ProcessDescData(CSGetGameBonusEventDescRes desc)
	{
	}

	public bool IsInDoubleBonusPeriod(uint matchMode, uint gameMode, uint mapID, CMDBIPLGLGA groupMode, out GameBonusEventDesc eventDesc, out ulong startTime, out ulong endTime)
	{
		eventDesc = null;
		startTime = default(ulong);
		endTime = default(ulong);
		return false;
	}

	public bool IsConditionMatch(GameBonusEventDesc desc, uint matchMode, uint gameMode, uint mapID, CMDBIPLGLGA groupMode)
	{
		return false;
	}

	public override uint GetModelType()
	{
		return 0u;
	}

	public string GetBonusEventInfo(MapModeData mapModeData, CMDBIPLGLGA groupMode, out List<ResourceID> spriteList)
	{
		spriteList = null;
		return null;
	}

	public GameBonusEventDesc GetGameBonusEventDesc(uint matchMode, uint gameMode, uint mapID, CMDBIPLGLGA groupMode, ulong timeStamp)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
