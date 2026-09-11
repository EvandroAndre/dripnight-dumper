using System;
using GCommon;

namespace COW;

internal class HotupdaterGame : COWGameBase
{
	private static readonly ResourceID[] SCENE_RESOURCE_LIST;

	public override ResourceID[] GetResourceID()
	{
		return null;
	}

	public override Type GetUISceneType()
	{
		return null;
	}

	public override int GetGameType()
	{
		return 0;
	}

	protected override void OnSceneLoaded()
	{
	}

	public int _003C_003EiFixBaseProxy_GetGameType()
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_OnSceneLoaded()
	{
	}
}
