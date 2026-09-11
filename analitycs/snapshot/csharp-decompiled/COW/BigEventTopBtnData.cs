using proto;

namespace COW;

public class BigEventTopBtnData
{
	public uint sugarTokenId;

	public uint storeTokenId;

	public UIModelBigEvent.EBigEventEntranceID entranceID;

	public ELimitedEvent.EventID eventID;

	public uint gopos;

	public string goposParam;

	public string goposDesc;

	public BigEventTopBtnData(uint sugarTokenId, uint storeTokenId, UIModelBigEvent.EBigEventEntranceID entranceID, ELimitedEvent.EventID eventID, uint gopos = 284u, string goposParam = "V2", string goposDesc = "")
	{
	}
}
