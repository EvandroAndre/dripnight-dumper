using System.Collections.Generic;
using UnityEngine;
using message;

namespace COW.Gameplay.UGC;

public class UGCResCombineMeshRenderer : UGCResource
{
	public class RendererInfo
	{
		public UGCMesh ugcMesh;

		public UGCMaterial[] ugcMaterials;

		public UGCMesh[] m_cacheColMesh;

		public CIDNEIJEELI data;

		public MaterialPropertyBlock m_mpb;

		public Dictionary<string, Texture2D> m_customTexture;

		public Mesh sharedMesh;

		public Material[] sharedMaterials;

		public Vector3 lossyScale;

		public Matrix4x4 localToBatchMatrix;
	}

	public class FFItemColData
	{
		public GameObject m_cacheGO;

		public CIDNEIJEELI data;
	}

	private class CombinedRendererInfo
	{
		public Mesh mesh;

		public Material[] materials;
	}

	private class FFItemCustomData
	{
		public Texture2D mainTexture;

		public bool useOriginMainTexture;

		public Texture2D frameTexture;

		public bool useOriginFrameTexture;

		public Color mainColor;

		public Color frameColor;
	}

	private sealed class _003C_003Ec__DisplayClass15_0
	{
		public RendererInfo rendererInfo;

		public UGCResCombineMeshRenderer _003C_003E4__this;

		internal void _003CLoadFromData_003Eb__0(bool succ, UGCMesh resObj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass15_1
	{
		public int cacheIndex;

		public _003C_003Ec__DisplayClass15_0 CS_0024_003C_003E8__locals1;

		internal void _003CLoadFromData_003Eb__1(bool succ, UGCMaterial resObj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass15_2
	{
		public int cacheIndex;

		public _003C_003Ec__DisplayClass15_0 CS_0024_003C_003E8__locals2;

		internal void _003CLoadFromData_003Eb__2(bool succ, UGCMesh resObj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass19_0
	{
		public FFItemCustomData ffItemCustomData;

		public UGCResCombineMeshRenderer _003C_003E4__this;

		internal void _003CPrepareFFItemTexture_003Eb__0(bool succ, bool isReloaded, Texture2D tex)
		{
		}

		internal void _003CPrepareFFItemTexture_003Eb__1(bool succ, bool isReloaded, Texture2D tex)
		{
		}
	}

	private NMENPLHEPCD m_resRendererData;

	private List<RendererInfo> m_rendererInfoList;

	private List<FFItemColData> m_cacheFFItemObjectForCol;

	private List<CombinedRendererInfo> m_combinedRenderers;

	private FFItemCustomData[] m_ffItemDataList;

	private UGCCombineBatchRendererImpl.BatchResult m_batchResult;

	private static string ImGameObjectName;

	private Object m_unityObject;

	public NMENPLHEPCD ResRendererData
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private void ClearOtherResDependence()
	{
	}

	private void OnMeshChanged(UGCResource res)
	{
	}

	protected override void AfterOneDependLoaded()
	{
	}

	private void AddFFItemToRendererInfo(CIDNEIJEELI info, FFItemCustomData customData)
	{
	}

	private void onUGCMaterialAllTextureLoaded(bool v)
	{
	}

	public override bool LoadFromData(byte[] data)
	{
		return false;
	}

	private Color Int2Color(int c)
	{
		return default(Color);
	}

	private void PrepareFFItemTexture(CIDNEIJEELI info, FFItemCustomData ffItemCustomData)
	{
	}

	private void InitFFItemAfterAllLoaded()
	{
	}

	private void BuildBatchResult()
	{
	}

	public void BuildGameObject(GameObject obj)
	{
	}

	public GameObject Instantiate()
	{
		return null;
	}

	public override void OnUnityObjectLoaded(bool isSucc, Object resObject)
	{
	}

	private void UpdateInstantiateGameObject()
	{
	}

	public void _003C_003EiFixBaseProxy_AfterOneDependLoaded()
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
