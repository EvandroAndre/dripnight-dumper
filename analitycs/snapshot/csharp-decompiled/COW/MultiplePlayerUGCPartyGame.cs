using System;
using COW.GamePlay;

namespace COW;

internal class MultiplePlayerUGCPartyGame : CJBICGPJCDH, IWorkshopGame
{
	private bool hasShowEndHint;

	private SpawnAreaFences mSpawnAreaFences;

	public override Type GetUISceneType()
	{
		return null;
	}

	protected override void InitGRIData()
	{
	}

	protected override void OnSceneLoaded()
	{
	}

	public void ShowSpawnAreaFences(bool show, uint TeamIndex = 2u)
	{
	}

	private void OnPhaseChange(uint oldValue, uint newValue)
	{
	}

	protected override void OnUpdate()
	{
	}

	public new Type _003C_003EiFixBaseProxy_GetUISceneType()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_InitGRIData()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnSceneLoaded()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUpdate()
	{
	}
}
