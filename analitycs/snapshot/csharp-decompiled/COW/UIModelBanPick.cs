using System;
using System.Collections.Generic;
using GCommon;
using tcp;

namespace COW;

public class UIModelBanPick : UIBaseModel
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<ulong, string> _003C_003E9__52_0;

		public static Converter<ulong, string> _003C_003E9__61_0;

		public static Converter<ulong, string> _003C_003E9__61_1;

		public static Converter<ulong, string> _003C_003E9__62_0;

		public static Converter<ulong, string> _003C_003E9__62_1;

		internal string _003COnHelpPickResultNtf_003Eb__52_0(ulong id)
		{
			return null;
		}

		internal string _003CLogPhaseInfoRawData_003Eb__61_0(ulong id)
		{
			return null;
		}

		internal string _003CLogPhaseInfoRawData_003Eb__61_1(ulong id)
		{
			return null;
		}

		internal string _003CRoomBPPhaseInfoToLogString_003Eb__62_0(ulong id)
		{
			return null;
		}

		internal string _003CRoomBPPhaseInfoToLogString_003Eb__62_1(ulong id)
		{
			return null;
		}
	}

	private UIModelLoadout m_ModelLoadout;

	private ulong m_RoomID;

	private ECSBPPhase m_BPStatus;

	public const uint PropID_StageChange = 2u;

	public const uint PropID_PlayerPrePickChange = 4u;

	public const uint PropID_CurrentBanPlayerChange = 8u;

	public const uint PropID_PreBanSkillChanhge = 16u;

	public const uint Prop_TotalBanResultChange = 32u;

	public const uint Prop_PickPlayerChange = 64u;

	public const uint Prop_PickPlayerSelectChange = 128u;

	public const uint Prop_PlayerLockSkillChange = 256u;

	public const uint Prop_OnReciveHelpPick = 512u;

	public const uint Prop_OnHelpPickAnswer = 1024u;

	public const uint Prop_OnPlayerPassiveSkillChange = 2048u;

	public const uint Prop_OnPlayerRequestChangeSkill = 4096u;

	public const uint Prop_OnPlayerChangeSkillAnswer = 8192u;

	public const uint Prop_OnBanResultChange = 16384u;

	public const uint Prop_OnHelpPickResult = 32768u;

	public const uint Prop_OnExchangeSkillComplete = 65536u;

	public const uint Prop_CurrentPlayerSkillChange = 131072u;

	public const uint Prop_BPErrorCodeChange = 262144u;

	public const uint Prop_OnReceiveAskBan = 524288u;

	private RoomBPPhaseInfo m_RoomPhaseInfo;

	private CSBPContext m_Context;

	private uint m_CurrentPlayerSkillId;

	private bool m_IsCurrentPlayerLockSkill;

	private UIModelLoadout ModelLoadout => null;

	public ulong RoomID => 0uL;

	public ECSBPPhase BPStatus => ECSBPPhase.None;

	public CSBPContext Context => null;

	public uint CurrentPlayerSkillId => 0u;

	public bool IsCurrentPlayerLockSkill => false;

	public override uint GetModelType()
	{
		return 0u;
	}

	private void SyncCurrentSkillToLoadoutModel()
	{
	}

	private static string ListToLogString<T>(List<T> list)
	{
		return null;
	}

	public void OnBPPhaseStartNtf(RoomBPPhaseStartNtf resData)
	{
	}

	public void OnBPTurnChangeNtf(RoomBPTurnChangeNtf resData)
	{
	}

	private void DisposeContext(RoomPlayerInfo myInfo)
	{
	}

	public void RequestBPSkillOperate(uint skillID, ERoom.BPOperateType operate)
	{
	}

	public void OnBPSkillOperateNtf(RoomBPSkillOperateNtf resData)
	{
	}

	public void OnAdjustPassiveSkillLoadout(PlayerPlanItem planItem)
	{
	}

	public void OnBPAdjustPassiveSkillLoadoutNtf(RoomBPAdjustLoadoutNtf resData)
	{
	}

	public void OnRequestHelpPick(uint skillID)
	{
	}

	public void RequestHelpPickNtf(RoomBPGrabSkillNtf resData)
	{
	}

	public void RequestHelpPickResponse(bool isAccept, ulong requestPlayerId)
	{
	}

	public void OnRequestHelpPickResponseNtf(RoomBPGrabSkillResponseNtf resData)
	{
	}

	public void OnHelpPickResultNtf(RoomBPGrabSkillResultNtf resData)
	{
	}

	public void OnClickExChangeSkill(ulong receiverID)
	{
	}

	public void OnRequestExChangeSkillNtf(RoomBPExchangeSkillNtf resData)
	{
	}

	public void OnClickAnswerExchangeSkill(bool isAccept, ulong requestPlayerId)
	{
	}

	public void OnAnswerExchangeSkillNtf(RoomBPExchangeSkillResponseNtf resData)
	{
	}

	public void OnExchangeSkillCompleteNtf(RoomBPExchangeSkillResultNtf resData)
	{
	}

	public void RefreshReconnectRoomData(RoomBPPhaseInfo phaseInfo)
	{
	}

	public void OnReconnectBPRoom(RoomBPPhaseInfo phaseInfo)
	{
	}

	public List<uint> GetAvailableSkills()
	{
		return null;
	}

	private void LogPhaseInfoRawData(string caller, ulong roomId, RoomBPPhaseInfo phaseInfo)
	{
	}

	private void RoomBPPhaseInfoToLogString(RoomBPPhaseInfo phaseInfo)
	{
	}

	public void HandleBPErrorCode(uint errorCode)
	{
	}
}
