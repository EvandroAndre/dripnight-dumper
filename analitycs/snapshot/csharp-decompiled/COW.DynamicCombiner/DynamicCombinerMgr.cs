using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using GCommon;
using UnityEngine;

namespace COW.DynamicCombiner;

public class DynamicCombinerMgr : MonoSingleton<DynamicCombinerMgr>
{
	private enum RequestActionType
	{
		ChangeTransfrom,
		ChangeMaterial,
		ChangeTexture,
		ChangeMesh
	}

	private sealed class _003CIECleanAllStatic_003Ed__48 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float delayTime;

		public DynamicCombinerMgr _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CIECleanAllStatic_003Ed__48(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private static readonly int s_BlockSize;

	private static readonly int s_LoadingRange;

	private static readonly int s_LoadingRangeY;

	internal Allocator Allocator;

	private Dictionary<int, List<int>> m_InstanceID2Childs;

	private Dictionary<int, MeshFilter> m_InstanceID2MeshFilter;

	private Dictionary<int, MeshRenderer> m_InstanceID2MeshRenderer;

	private Dictionary<int, MaterialPropertyBlock> m_InstanceID2MaterialPropertyBlock;

	private Dictionary<int, KeyValuePair<int, int>> m_InstanceID2BatchFinder;

	private Dictionary<int, List<Batch>> m_BatchID2Batches;

	private Dictionary<int, List<Batch>> m_BatchID2StaticBatches;

	private Dictionary<int, List<GameObject>> m_BatchIDGos;

	private HashSet<int> m_StaticInstanceID;

	private Dictionary<int, HashSet<int>> m_LODGroupsDic;

	private Dictionary<int, LODInfo> m_CurrentLODDic;

	private Dictionary<int, Texture> m_TempProperty2Texture;

	private Queue<Batch> m_BatchCache;

	private Queue<GameObject> m_GoCache;

	private List<Task> m_TaskCache;

	private List<Batch> m_RunningBatchCache;

	private Dictionary<int, HashSet<int>> m_RequestActionCache;

	private Dictionary<string, IShaderConverter> m_Name2ShaderConverter;

	private Dictionary<ResourceID, Shader> m_ShaderCache;

	private int m_StaticHashCode;

	private int m_RefreshBoundsFrameInternal;

	private bool m_IsStaticCleared;

	private bool m_UseMultiThread;

	private int m_LODRefreshFrameCounter;

	private bool m_IsValid;

	private bool m_IsInited;

	public void InitData()
	{
	}

	public void Clear(bool needDestroyBatchGO = true)
	{
	}

	public bool GetValid()
	{
		return false;
	}

	protected override void OnDestroy()
	{
	}

	public bool TryAdd(GameObject go)
	{
		return false;
	}

	public void ChangeParent(GameObject go)
	{
	}

	public void Remove(GameObject go)
	{
	}

	public void ChangeTransform(GameObject go)
	{
	}

	public MaterialPropertyBlock GetMaterialPropertyBlock(GameObject go)
	{
		return null;
	}

	public void ChangeMaterial(GameObject go)
	{
	}

	public void ChangeTexture(GameObject go)
	{
	}

	public void ChangeMesh(GameObject go)
	{
	}

	public void CleanAllStatic(float delayTime = 0f)
	{
	}

	public int GetDynamicCount()
	{
		return 0;
	}

	public int GetStaticCount()
	{
		return 0;
	}

	public bool Contains(GameObject go)
	{
		return false;
	}

	private void Update()
	{
	}

	private IEnumerator IECleanAllStatic(float delayTime)
	{
		return null;
	}

	private bool InternalAdd(int instanceID, GameObject go)
	{
		return false;
	}

	private void AddLODGroup(int instanceID, GameObject go, LODGroup lodGroup)
	{
	}

	private void RemoveLODGroup(int instanceID)
	{
	}

	private void UpdateCurrentLOD()
	{
	}

	private void CheckLODChange(int instanceID)
	{
	}

	private void InternalChangeParent(int instanceID, GameObject go)
	{
	}

	private bool InternalRemove(int instanceID)
	{
		return false;
	}

	private void ChangeTransformRequests(HashSet<int> args)
	{
	}

	private void ChangeMaterialRequests(HashSet<int> args)
	{
	}

	private void ChangeTextureRequests(HashSet<int> args)
	{
	}

	private void ChangeMeshRequests(HashSet<int> args)
	{
	}

	private void BindBatchToGo(int batchID, Batch batch)
	{
	}

	private void UnBindBatchFromGo(int batchID, int i)
	{
	}

	private Dictionary<int, Texture> GetProperty2Texture(Material sharedMaterial, MaterialPropertyBlock materialPropertyBlock)
	{
		return null;
	}

	private bool GetIsStatic(GameObject go)
	{
		return false;
	}

	private int GetBlockID(Vector3 pos)
	{
		return 0;
	}

	private int GetBlockID(int x, int y, int z)
	{
		return 0;
	}

	private int GetBatchID(Material sharedMaterial, MaterialPropertyBlock materialPropertyBlock, Vector3 pos)
	{
		return 0;
	}

	private bool CanDynamicCombine(int instanceID, GameObject go, out int batchID)
	{
		batchID = default(int);
		return false;
	}

	private bool CheckMeshFilter(MeshFilter meshFilter)
	{
		return false;
	}

	private bool CheckRenderer(Renderer renderer)
	{
		return false;
	}

	internal Shader GetShader(ResourceID resID)
	{
		return null;
	}

	public int GetVisibleLOD(LODGroup lodGroup, LOD[] lods, Camera camera = null)
	{
		return 0;
	}

	private float GetRelativeHeight(LODGroup lodGroup, Camera camera)
	{
		return 0f;
	}

	public float DistanceToRelativeHeight(Camera camera, float distance, float size)
	{
		return 0f;
	}

	public float GetWorldSpaceSize(LODGroup lodGroup)
	{
		return 0f;
	}

	private float GetWorldSpaceScale(Transform t)
	{
		return 0f;
	}

	public int GetMaxLOD(LODGroup lodGroup)
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}
}
