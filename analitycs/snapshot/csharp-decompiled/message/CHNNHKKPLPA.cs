namespace message;

public enum CHNNHKKPLPA : uint
{
	EFinancialTransactionFlag_MultiplePkgFromBot = 1u,
	EFinancialTransactionFlag_InstantConsumable = 2u,
	EFinancialTransactionFlag_Replacer = 4u,
	EFinancialTransactionFlag_WithGunBuff = 8u,
	EFinancialTransactionFlag_WithFreeCard = 0x10u,
	EFinancialTransactionFlag_EntitySpawner = 0x20u,
	EFinancialTransactionFlag_BuffGenerator = 0x40u
}
