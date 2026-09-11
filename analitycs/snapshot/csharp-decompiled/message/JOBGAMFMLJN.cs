namespace message;

public enum JOBGAMFMLJN : uint
{
	ETransferResult_Sucess = 0u,
	ETransferResult_Partial = 1u,
	ETransferResult_OperationForbidden = 2u,
	ETransferResult_InvalidDistance = 3u,
	ETransferResult_InvalidState = 4u,
	ETransferResult_BagFull = 5u,
	ETransferResult_ItemLimited = 6u,
	ETransferResult_WeaponLimited = 7u,
	ETransferResult_RecentDropped = 8u,
	ETransferResult_Failed = 999u
}
