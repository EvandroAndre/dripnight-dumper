using System.Collections.Generic;
using COW.GamePlay;
using COW.GamePlay.UGCRuntime;
using UnityEngine;

namespace COW.Gameplay.UGC;

public class UGCLevelLowGravity : BaseLevelObject
{
	public MeshRenderer meshrenderer;

	public List<MeshRenderer> vfxRenderList;

	private UGCLowGravityRepItem m_UGCLowGravityRepItem;

	public void SetModelVisible(bool visble)
	{
	}

	public override void OnUGCEntityCreated(string entityID, string archTypeID)
	{
	}

	public void SetEntityID()
	{
	}

	private void OnShowOrHideChangeEvent(bool newValue)
	{
	}

	public override bool CreateDynamicallyForUGC(string entityID)
	{
		return false;
	}

	public override void OnSyncUGCEntityProperty(long propertyIndex, UGCSimpleValue newValue)
	{
	}

	public override void OnCameraCullingMaskChanged()
	{
	}

	private void ShowVFX()
	{
	}

	protected override string GetObjectTag()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUGCEntityCreated(string P0, string P1)
	{
	}

	public bool _003C_003EiFixBaseProxy_CreateDynamicallyForUGC(string P0)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnSyncUGCEntityProperty(long P0, UGCSimpleValue P1)
	{
	}

	public void _003C_003EiFixBaseProxy_OnCameraCullingMaskChanged()
	{
	}
}
