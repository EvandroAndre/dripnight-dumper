using System.Collections.Generic;
using GCommon;
using message;

namespace COW;

public class UIHudTakeTurnsShopRoundItemBaseController : UIBaseController
{
	public enum ERoundType
	{
		Self,
		Opponent,
		Final
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public virtual void SetView(ERoundType roundType, int curRound, HFPCCOGIILE roundState)
	{
	}

	public virtual void PlayScaleAnim(bool enlarge)
	{
	}

	public virtual void SetScale(bool enlarge)
	{
	}

	public virtual void SetBuffIcon()
	{
	}

	public virtual void SetViewLW(int round, bool v, List<byte> chooserTeamIds)
	{
	}

	public virtual void SetRoundView(int curRound, int itemRound)
	{
	}
}
