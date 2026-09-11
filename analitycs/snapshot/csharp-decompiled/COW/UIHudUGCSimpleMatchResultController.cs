using GCommon;
using proto;

namespace COW;

internal class UIHudUGCSimpleMatchResultController : UIHudSingleFightMatchResultController
{
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override bool IsNeedShowAvatar()
	{
		return false;
	}

	protected override void OnUIOpen()
	{
	}

	protected override bool NeedCountDown()
	{
		return false;
	}

	protected override bool IsShowDetailBtn()
	{
		return false;
	}

	protected override void SetResultDescTextByRank(MatchStats stats)
	{
	}

	public bool _003C_003EiFixBaseProxy_IsNeedShowAvatar()
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public new bool _003C_003EiFixBaseProxy_NeedCountDown()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_IsShowDetailBtn()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_SetResultDescTextByRank(MatchStats P0)
	{
	}
}
