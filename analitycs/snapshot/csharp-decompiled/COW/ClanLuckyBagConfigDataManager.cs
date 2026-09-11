using GCommon;

namespace COW;

internal class ClanLuckyBagConfigDataManager : SingletonModule<ClanLuckyBagConfigDataManager>
{
	private ClanLuckyBagConfigData _003CData_003Ek__BackingField;

	public ClanLuckyBagConfigData Data
	{
		get
		{
			return _003CData_003Ek__BackingField;
		}
		set
		{
			_003CData_003Ek__BackingField = value;
		}
	}

	public ClanLuckyBagConfigData ClanLuckyBagConfigData => null;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}
}
