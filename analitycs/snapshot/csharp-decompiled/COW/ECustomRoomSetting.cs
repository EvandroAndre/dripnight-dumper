namespace COW;

public enum ECustomRoomSetting : uint
{
	ECustomRoomSetting_HideKillInfo = 1u,
	ECustomRoomSetting_UnlimitedAmmo = 2u,
	ECustomRoomSetting_NoFallingDamage = 4u,
	ECustomRoomSetting_NoLoadout = 8u,
	ECustomRoomSetting_NoAirdrop = 0x10u,
	ECustomRoomSetting_NoSkill = 0x20u,
	ECustomRoomSetting_NoVehicle = 0x40u,
	ECustomRoomSetting_UnlimitedThrowables = 0x80u,
	ECustomRoomSetting_PlayerHP_Start = 0x100u,
	ECustomRoomSetting_PlayerHP_End = 0x400u,
	ECustomRoomSetting_PlayerEP_Start = 0x800u,
	ECustomRoomSetting_PlayerEP_End = 0x2000u,
	ECustomRoomSetting_PlayerSpeed_Start = 0x4000u,
	ECustomRoomSetting_PlayerSpeed_End = 0x10000u,
	ECustomRoomSetting_PlayerJumpHeight_Start = 0x200000u,
	ECustomRoomSetting_PlayerJumpHeight_End = 0x800000u,
	ECustomRoomSetting_AccTotalStats = 0x1000000u,
	ECustomRoomSetting_RoundNum_Start = 0x2000000u,
	ECustomRoomSetting_RoundNum_End = 0x4000000u,
	ECustomRoomSetting_InitCSEco_Start = 0x8000000u,
	ECustomRoomSetting_InitCSEco_End = 0x10000000u,
	ECustomRoomSetting_NoPowerGun = 0x20000000u,
	ECustomRoomSetting_HideEnemyCloth = 0x40000000u
}
