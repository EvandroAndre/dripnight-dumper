using GCommon;

namespace COW;

public class GameFunctionSwitchDataManager : SingletonModule<GameFunctionSwitchDataManager>
{
	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public bool CheckIsFunctionAvailable(FunctionType fType, bool ShowTips = false)
	{
		return false;
	}

	public bool CheckCanShowRankGuide()
	{
		return false;
	}

	public void SetLevelLimit(FunctionType type, int levelLimit)
	{
	}
}
