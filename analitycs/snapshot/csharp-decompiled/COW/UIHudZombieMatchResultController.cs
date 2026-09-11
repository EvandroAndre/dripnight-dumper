using GCommon;
using UnityEngine;
using proto;

namespace COW;

internal class UIHudZombieMatchResultController : UIHudNormalMatchResultController
{
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override int[] GetInfoTypes()
	{
		return null;
	}

	protected override UIHudNormalMatchResultItemController BuildPlayerItem(Transform parent, TeammateStats player, bool single)
	{
		return null;
	}

	protected override void OnUIInit()
	{
	}

	public new int[] _003C_003EiFixBaseProxy_GetInfoTypes()
	{
		return null;
	}

	public UIHudNormalMatchResultItemController _003C_003EiFixBaseProxy_BuildPlayerItem(Transform P0, TeammateStats P1, bool P2)
	{
		return null;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
