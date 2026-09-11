namespace proto;

public class HippoCostDesc
{
	public enum CostType
	{
		CostTypeNone,
		CostTypeGems,
		CostTypeCoins,
		CostTypeItem,
		CostTypeHippoMoney,
		CostTypeHippoItem
	}

	public uint cost_type;

	public uint cost_id;

	public uint cost_amount;
}
