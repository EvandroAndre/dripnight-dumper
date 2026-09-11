using message;

namespace COW;

public class UIGameModeGameplayAffixDetailsContentViewData
{
	private NIKKALKPIBO _003CGameMode_003Ek__BackingField;

	private DLBMPCCFKKM _003CMatchMode_003Ek__BackingField;

	public NIKKALKPIBO GameMode
	{
		get
		{
			return _003CGameMode_003Ek__BackingField;
		}
		private set
		{
			_003CGameMode_003Ek__BackingField = value;
		}
	}

	public DLBMPCCFKKM MatchMode
	{
		get
		{
			return _003CMatchMode_003Ek__BackingField;
		}
		private set
		{
			_003CMatchMode_003Ek__BackingField = value;
		}
	}

	public UIGameModeGameplayAffixDetailsContentViewData(NIKKALKPIBO gameMode, DLBMPCCFKKM matchMode)
	{
	}
}
