using GCommon;
using UnityEngine;
using proto;

namespace COW;

internal class UIHudPDMMatchResultController : UIHudSingleFightMatchResultController
{
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override int[] GetInfoTypes()
	{
		return null;
	}

	public override UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	protected ExtraPlayerDataForMatchResult GetExtraPlayerDataIncludingBotForMatchResult(ulong accountID, string nickName)
	{
		return null;
	}

	protected override UIHudSingleFightMatchResultItemController OpenItemController(TeammateStats data, bool single)
	{
		return null;
	}

	protected override PlayerData GetPlayerData(TeammateStats stats)
	{
		return null;
	}

	protected override void SetResultDescTextByRank(MatchStats stats)
	{
	}

	public new int[] _003C_003EiFixBaseProxy_GetInfoTypes()
	{
		return null;
	}

	public UIEasyListItemController _003C_003EiFixBaseProxy_OpenItemController(Transform P0)
	{
		return null;
	}

	public UIHudSingleFightMatchResultItemController _003C_003EiFixBaseProxy_OpenItemController(TeammateStats P0, bool P1)
	{
		return null;
	}

	public PlayerData _003C_003EiFixBaseProxy_GetPlayerData(TeammateStats P0)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_SetResultDescTextByRank(MatchStats P0)
	{
	}
}
