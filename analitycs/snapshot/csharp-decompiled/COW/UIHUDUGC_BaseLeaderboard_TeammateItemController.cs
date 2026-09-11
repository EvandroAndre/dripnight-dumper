using COW.GamePlay;
using GCommon;
using message;

namespace COW;

internal abstract class UIHUDUGC_BaseLeaderboard_TeammateItemController : UIEasyListItemController
{
	protected Player m_Player;

	public void SetPlayer(Player player)
	{
	}

	public BHGGAEEHJCO GetPlayerID()
	{
		return default(BHGGAEEHJCO);
	}

	protected virtual void SetSelf(bool isSelf)
	{
	}

	protected virtual void ShowProfileInfo(BaseProfileInfo profileInfo)
	{
	}

	public virtual void RefreshInfo(HPGAEEBKCIE infoType)
	{
	}

	public virtual void RefreshAllInfo()
	{
	}

	protected int GetInfoValue(HPGAEEBKCIE infoType)
	{
		return 0;
	}

	public override void SetViewData(object data, int data_index)
	{
	}
}
