using System.Collections.Generic;
using COW.GamePlay;
using COW.GamePlay.UGCRuntime;
using UnityEngine;

namespace COW.Gameplay.UGC;

public class UGCLevelBasicSphere : BaseAutoGenIDLevelObject
{
	private sealed class _003C_003Ec__DisplayClass8_0
	{
		public UGCLevelBasicSphere _003C_003E4__this;

		public string newVal;

		internal void _003COnDiffuseTextureChange_003Eb__0(bool succ, bool isReloaded, Texture2D tex)
		{
		}
	}

	public Transform scale;

	private List<Renderer> m_MeshRenderers;

	public override bool CreateDynamicallyForUGC(string entityID)
	{
		return false;
	}

	protected override string GetObjectTag()
	{
		return null;
	}

	protected override void OnAwake()
	{
	}

	public override void SetUGCStatic(bool isStatic)
	{
	}

	protected override void OnOnDestroy()
	{
	}

	public void SetSphereRadius(float radius)
	{
	}

	private void OnDiffuseTextureChange(string newVal)
	{
	}

	private void OnDiffuseColorChange(int newVal)
	{
	}

	public override void OnSyncUGCEntityProperty(long propertyIndex, UGCSimpleValue newValue)
	{
	}

	public bool _003C_003EiFixBaseProxy_CreateDynamicallyForUGC(string P0)
	{
		return false;
	}

	public string _003C_003EiFixBaseProxy_GetObjectTag()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnAwake()
	{
	}

	public void _003C_003EiFixBaseProxy_SetUGCStatic(bool P0)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnOnDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnSyncUGCEntityProperty(long P0, UGCSimpleValue P1)
	{
	}
}
