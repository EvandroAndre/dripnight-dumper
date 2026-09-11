namespace COW;

public enum ECustomRoomSetting2 : uint
{
	ECustomRoomSetting_NoUAV = 1u,
	ECustomRoomSetting_NoBomb = 2u,
	ECustomRoomSetting_Replay = 4u,
	ECustomRoomSetting_NoZeppelin = 8u,
	ECustomRoomSetting_NoHud = 0x10u,
	ECustomRoomSetting_FriendDmg = 0x20u,
	ECustomRoomSetting_FightClubRoundNum_Start = 0x40u,
	ECustomRoomSetting_FightClubRoundNum_End = 0x80u,
	ECustomRoomSetting_ReviveSwitchStart = 0x100u,
	ECustomRoomSetting_ReviveSwitchEnd = 0x400u,
	ECustomRoomSetting_InGameChat = 0x800u,
	ECustomRoomSetting_ShopFlow = 0x1000u,
	ECustomRoomSetting_UseRandomMap = 0x2000u,
	ECustomRoomSetting_NoAuxAim = 0x4000u,
	ECustomRoomSetting_AutoRevival = 0x8000u,
	ECustomRoomSetting_SaveZoneSpeed = 0x10000u,
	ECustomRoomSetting_SaveZoneDamage = 0x20000u,
	ECustomRoomSetting_SpecialCSEnv_Start = 0x40000u,
	ECustomRoomSetting_SpecialCSEnv_End = 0x100000u,
	ECustomRoomSetting_GameMission = 0x200000u,
	ECustomRoomSetting_BackPackLogo = 0x400000u,
	ECustomRoomSetting_GlobalMission = 0x800000u,
	ECustomRoomSetting_FightReplay = 0x1000000u,
	ECustomRoomSetting_AirdropType_Start = 0x2000000u,
	ECustomRoomSetting_AirdropType_End = 0x4000000u,
	ECustomRoomSetting_NoHotZone = 0x8000000u,
	ECustomRoomSetting_BRMoveSafeZone = 0x10000000u,
	ECustomRoomSetting_HeadShotOnly = 0x20000000u,
	ECustomRoomSetting_DoubleKillScore = 0x40000000u
}
