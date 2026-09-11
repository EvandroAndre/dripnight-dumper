using proto;

namespace COW;

public class GachaRuleMapping : RuleMapping
{
	private sealed class _003C_003Ec__DisplayClass2_0
	{
		public ELottery.Type gachaType;

		public string url;

		internal void _003C_002Ector_003Eb__0()
		{
		}
	}

	public ELottery.Type Type;

	public EventDelegate.Callback GotoAction;

	public GachaRuleMapping(ELottery.Type gachaType, string tabKey, string contentKey)
		: base(null, null)
	{
	}
}
