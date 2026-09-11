namespace proto;

public class CSSwitchSharedGachaPoolReq
{
	public enum SwitchType
	{
		SwitchType_None,
		SwitchType_FirstJoin,
		SwitchType_FirstSwitch,
		SwitchType_CD,
		SwitchType_PoolEmpty,
		SwitchType_GuaranteedEmpty,
		SwitchType_TierItemNotEnough,
		SwitchType_ReqItemNotEnough
	}

	public SwitchType switch_type;

	public uint chest_id;

	public uint chest_sub_id;

	public bool is_prime;
}
