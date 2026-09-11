using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using message;

namespace COW;

internal class UIModelMetropolis : UIBaseModel
{
	private List<FMetroVehicleData> m_VehicleList;

	private Dictionary<uint, FMetroVehicleData> m_VehicleMap;

	private List<FMetroFlightData> m_FlightList;

	private Dictionary<uint, FMetroFlightData> m_FlightMap;

	private Dictionary<uint, List<FMetroWeaponData>> m_WeaponList;

	private Dictionary<uint, FMetroWeaponData> m_WeaponMap;

	private List<FMetroWeaponData> m_PoliceCollectWeaponList;

	private List<FMetroWeaponData> m_CriminalCollectWeaponList;

	private uint m_DrawItemID;

	private uint m_DrawCount;

	private bool m_IsDrawFromBonus;

	private uint m_PackageLevel;

	private uint m_DailyBonusCount;

	private bool m_CoinLimit;

	private uint m_GymIndex;

	private uint m_GymGuessPlayer;

	private uint m_GymGuessValue;

	private List<FMetropolisMessageData> m_PoliceMessageChannel;

	private List<FMetropolisMessageData> m_CriminalMessageChannel;

	private List<FMetropolisMessageData> m_WorldMessageChannel;

	private FMetropolisMessageData m_LastestMessage;

	private Dictionary<uint, bool> m_ChatChannelMute;

	private Dictionary<uint, int> m_ChatChannelScroll;

	private Dictionary<int, int> m_FactionPlayerCount;

	private FMetropolisTrackMissionData m_TrackMissionData;

	private EventLogger.EventTypeMetropolisChatSummary m_ChatSummary;

	public List<FMetroWeaponData> PoliceCollectWeaponList => null;

	public List<FMetroWeaponData> CriminalCollectWeaponList => null;

	public uint DrawItemID => 0u;

	public uint DrawCount => 0u;

	public bool IsDrawFromBonus
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public uint PackageLevel => 0u;

	public uint DailyBonusCount => 0u;

	public bool CoinLimit => false;

	public uint GymIndex => 0u;

	public uint GymGuessPlayer => 0u;

	public uint GymGuessValue => 0u;

	public List<FMetropolisMessageData> PoliceMessageChannel => null;

	public List<FMetropolisMessageData> CriminalMessageChannel => null;

	public List<FMetropolisMessageData> WorldMessageChannel => null;

	public FMetropolisMessageData LastestMessage => null;

	private Dictionary<uint, bool> ChatChannelMute => null;

	private Dictionary<uint, int> ChatChannelScroll => null;

	private Dictionary<int, int> FactionPlayerCount => null;

	public FMetropolisTrackMissionData TrackMissionData => null;

	public override uint GetModelType()
	{
		return 0u;
	}

	public void StartMatch()
	{
	}

	public void EndMatch()
	{
	}

	public List<FMetroVehicleData> GetVehicleList()
	{
		return null;
	}

	public List<FMetroFlightData> GetFlightList()
	{
		return null;
	}

	public List<FMetroWeaponData> GetWeaponList(FDAEPHMIEPC.DBENAPILEBC type)
	{
		return null;
	}

	public FMetroWeaponData GetWeaponByID(uint weaponID)
	{
		return null;
	}

	public void UpdateGymGuessing(uint index, uint guessPlayer, uint guessValue)
	{
	}

	public void UpdateGymIndex(uint index)
	{
	}

	public void UpdateMetropolisItemInfo(PFCIMOCDKAN msg)
	{
	}

	public void UpdateLotteryDraw(uint drawItemID, uint drawCount, bool isBonus)
	{
	}

	public void AddCollectWeapon(int faction, FMetroWeaponData weapon)
	{
	}

	public void RemoveCollectWeapon(int faction, FMetroWeaponData weapon)
	{
	}

	private void ReplaceCollectWeapon(FMetroWeaponData oldWeapon, FMetroWeaponData newWeapon)
	{
	}

	private void GetCollectWeapon()
	{
	}

	private void SaveCollectWeapon()
	{
	}

	public bool SaveSystemMessage(FLPBLFEPIKH evt)
	{
		return false;
	}

	public void SaveChatMessage(List<ClientInGameChatMessage> messages)
	{
	}

	private FMetropolisMessageData GetMessageFromChannel(EMetropolisChatChannel channel)
	{
		return null;
	}

	private void AddMessageToChannel(EMetropolisChatChannel channel, FMetropolisMessageData msg)
	{
	}

	public void MuteChannel(EMetropolisChatChannel channel, bool mute)
	{
	}

	public bool IsChannelMute(EMetropolisChatChannel channel)
	{
		return false;
	}

	public void EnableScrollChannel(EMetropolisChatChannel channel, bool enableScroll)
	{
	}

	public bool IsEnableScroll(EMetropolisChatChannel channel)
	{
		return false;
	}

	public List<FMetropolisMessageData> GetChannelMessageList(EMetropolisChatChannel channel)
	{
		return null;
	}

	public int GetRecordScrollCount(EMetropolisChatChannel channel)
	{
		return 0;
	}

	public void UpdateFactionPlayerCount(AFBOKKIDEAB faction, byte oldValue, byte newValue)
	{
	}

	public int GetPoliceFactionPlayerCount()
	{
		return 0;
	}

	public int GetCriminalFactionPlayerCount()
	{
		return 0;
	}

	private void InitVehicleData()
	{
	}

	private void InitFlightData()
	{
	}

	private void InitWeaponData()
	{
	}

	private void RefreshWeaponList()
	{
	}

	public void LogAddChatUIClick()
	{
	}

	public void LogSendChatUIMessage(EMetropolisChatChannel channel)
	{
	}

	public void LogMuteChatChannel(EMetropolisChatChannel channel)
	{
	}
}
