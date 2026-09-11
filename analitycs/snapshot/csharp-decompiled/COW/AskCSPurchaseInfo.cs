using System.Collections.Generic;
using COW.GamePlay;

namespace COW;

public class AskCSPurchaseInfo
{
	public BHGGAEEHJCO SenderID;

	public List<uint> AskItemIDs;

	public BHGGAEEHJCO PayerID;

	public int Sequence;
}
