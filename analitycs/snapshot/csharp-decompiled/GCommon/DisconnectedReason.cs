namespace GCommon;

public enum DisconnectedReason : uint
{
	Unknown = 0u,
	MultiLogin = 1u,
	InvalidClientVersion = 2u,
	InBlackList = 3u,
	LevelUp = 4u,
	RoleChange = 5u,
	AccountDelete = 6u,
	HighReleaseVersionLogin = 7u,
	SocketException = 8u,
	GameServerByeBye = 9u,
	DeactiveDisconnect = 10u,
	NonSocketException = 11u,
	NoSessionFound = 12u,
	ReachMaxResendCount = 999u
}
