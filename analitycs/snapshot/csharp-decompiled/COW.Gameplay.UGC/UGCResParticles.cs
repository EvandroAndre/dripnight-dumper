using UnityEngine;
using message;

namespace COW.Gameplay.UGC;

public class UGCResParticles : UGCResource
{
	private JNCDENEAOMG m_ResData;

	private UGCTexture m_ShapeTexture;

	private UGCMesh m_ShapeMesh;

	private UGCMaterial m_RenderMaterial;

	private UGCMesh m_RenderMesh;

	public JNCDENEAOMG ResData => null;

	public UGCTexture ShapeTexture => null;

	public UGCMesh ShapeMesh => null;

	public UGCMaterial RenderMaterial => null;

	public UGCMesh RenderMesh => null;

	public override bool LoadFromData(byte[] data)
	{
		return false;
	}

	public override void OnUnityObjectLoaded(bool isSucc, Object resObject)
	{
	}

	private void _003CLoadFromData_003Eb__15_0(bool succ, UGCTexture resObj)
	{
	}

	private void _003CLoadFromData_003Eb__15_1(bool succ, UGCMesh resObj)
	{
	}

	private void _003CLoadFromData_003Eb__15_2(bool succ, UGCMaterial resObj)
	{
	}

	private void _003CLoadFromData_003Eb__15_3(bool succ, UGCMesh resObj)
	{
	}

	public bool _003C_003EiFixBaseProxy_LoadFromData(byte[] P0)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUnityObjectLoaded(bool P0, Object P1)
	{
	}
}
