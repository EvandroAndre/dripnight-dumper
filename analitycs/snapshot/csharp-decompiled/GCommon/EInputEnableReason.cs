namespace GCommon;

public enum EInputEnableReason : uint
{
	None = 0u,
	Legacy = 1u,
	CameraMode = 2u,
	SuperEmote = 4u,
	LobbySocialMovingJoystickHidden = 8u,
	LobbySocialPopupWindow = 0x10u
}
