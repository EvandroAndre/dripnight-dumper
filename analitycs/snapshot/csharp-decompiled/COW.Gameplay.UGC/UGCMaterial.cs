using System;
using System.Collections.Generic;
using UnityEngine;
using message;

namespace COW.Gameplay.UGC;

public class UGCMaterial : UGCResource
{
	private sealed class _003C_003Ec__DisplayClass18_0
	{
		public LOMFAJCKGJM p;

		public UGCMaterial _003C_003E4__this;

		internal void _003CUpdateMaterialFromData_003Eb__0(bool succ, UGCTexture resObj)
		{
		}
	}

	private CAICJCLCEAE m_resMaterialData;

	private Material m_material;

	private List<UGCTexture> m_dependTexture;

	private List<Action<bool>> m_onAllTextureLoaded;

	private int m_needLoadTextureCount;

	private int m_loadedTextureCount;

	public bool IsAllTextureLoaded => false;

	private void RecordDependTexture(UGCTexture tex)
	{
	}

	private void ClearOtherResDependence()
	{
	}

	public override bool LoadFromData(byte[] data)
	{
		return false;
	}

	public Material GetUnityMaterial()
	{
		return null;
	}

	public static Material GetTemporaryUnityMat()
	{
		return null;
	}

	private void OnTextureChanged(UGCResource res)
	{
	}

	public override void OnUnityObjectLoaded(bool isSucc, UnityEngine.Object resObject)
	{
	}

	public override void ReleaseUnityResRef()
	{
	}

	public bool AddTextureLoadedCallback(Action<bool> callback)
	{
		return false;
	}

	private void AfterOneTextureLoaded()
	{
	}

	private void UpdateMaterialFromData(bool changeShader)
	{
	}

	public bool _003C_003EiFixBaseProxy_LoadFromData(byte[] P0)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUnityObjectLoaded(bool P0, UnityEngine.Object P1)
	{
	}

	public void _003C_003EiFixBaseProxy_ReleaseUnityResRef()
	{
	}
}
