using COW.GamePlay;
using COW.GamePlay.UGCRuntime;
using UnityEngine;

namespace COW.Gameplay.UGC;

public class UGCLevelArrivalEndPoint : LevelUGCCustomizeTrigger, DDAFIHCLBBB
{
	public GameObject EndIconPrefeb;

	private GameObject m_IconInstance;

	protected override string GetObjectTag()
	{
		return null;
	}

	protected override void OnStart()
	{
	}

	public void UpdateIcon()
	{
	}

	public override void ShowVfx(bool show)
	{
	}

	protected override void OnOnDestroy()
	{
	}

	public override void OnSyncUGCEntityProperty(long propertyIndex, UGCSimpleValue newValue)
	{
	}

	public new string _003C_003EiFixBaseProxy_GetObjectTag()
	{
		return null;
	}

	public new void _003C_003EiFixBaseProxy_OnStart()
	{
	}

	public void _003C_003EiFixBaseProxy_ShowVfx(bool P0)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnOnDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnSyncUGCEntityProperty(long P0, UGCSimpleValue P1)
	{
	}
}
