using GCommon;

namespace COW.Gameplay.UGC;

public class UIModelUGCResourceShop : UIBaseModel
{
	public readonly int MinItemCount;

	public readonly int MaxReRequestTimes;

	public override uint GetModelType()
	{
		return 0u;
	}

	public bool CheckAndResetCooling(ref float coolingStartTime, float coolingTime, string msgKey = "T_49_C_PRIME_SET27")
	{
		return false;
	}
}
