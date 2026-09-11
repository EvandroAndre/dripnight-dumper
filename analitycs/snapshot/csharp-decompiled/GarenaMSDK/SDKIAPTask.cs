namespace GarenaMSDK;

internal enum SDKIAPTask
{
	None,
	ScanIAPInventory,
	ObtainPendingTransactions,
	LoadIAPItems,
	LoadRebateOptions,
	LoadSomeIAPItems,
	LoadSomeRebateOptions,
	PurchaseProduct,
	PurchaseRebateCard,
	RedeemRebateOption,
	LoadEventConfigs,
	LoadEventIAPItems,
	PurchaseEventProduct
}
