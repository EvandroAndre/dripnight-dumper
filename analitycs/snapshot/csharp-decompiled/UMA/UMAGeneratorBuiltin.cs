using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace UMA;

public abstract class UMAGeneratorBuiltin : UMAGeneratorBase
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<bool> _003C_003E9__71_0;

		internal bool _003C_002Ector_003Eb__71_0()
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass12_0
	{
		public UMAData data;

		internal bool _003CRemoveFromCleanList_003Eb__0(UMAData d)
		{
			return false;
		}
	}

	private sealed class _003CSetupFluxFramebyFrame_003Ed__56 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UMAGeneratorBuiltin _003C_003E4__this;

		public UMAData data;

		private bool _003ChasFlux_003E5__2;

		private List<GameObject> _003CgameObjects_003E5__3;

		private int _003CCount_003E5__4;

		private int _003Ci_003E5__5;

		private List<HangStringProperty> _003Cfluxassets_003E5__6;

		private int _003Cj_003E5__7;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CSetupFluxFramebyFrame_003Ed__56(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		void IEnumerator.Reset()
		{
		}
	}

	[NonSerialized]
	protected UMAData umaData;

	[NonSerialized]
	protected List<UMAData> umaDirtyList;

	private LinkedList<UMAData> cleanUmas;

	private LinkedList<UMAData> dirtyUmas;

	private UMAGeneratorCoroutine activeGeneratorCoroutine;

	private UMAGeneratorCoroutine reusedGeneratorCoroutine;

	public Transform textureMergePrefab;

	public UMAMeshCombiner meshCombiner;

	private Dictionary<string, Transform> tmpTransforms;

	private static List<Transform> s_reusedChildrenList;

	public static bool EnableFixWorkSyncRemoveData;

	public static bool OptGc;

	public int InitialScaleFactor;

	public bool fastGeneration;

	public static bool EnableGC;

	private int forceGarbageCollect;

	public int garbageCollectionRate;

	private int garbageCollectionRateNew;

	private Stopwatch stopWatch;

	public static int lastExceptionFrame;

	public static int logExceptionInterval;

	[NonSerialized]
	public long ElapsedTicks;

	[NonSerialized]
	public long DnaChanged;

	[NonSerialized]
	public long TextureChanged;

	[NonSerialized]
	public long SlotsChanged;

	[NonSerialized]
	public bool ReuseDynamicBone;

	[NonSerialized]
	private bool ReuseMaterial;

	private Dictionary<int, List<Material>> recycledMaterials;

	private List<UMAMaterial> recyclingUmaMaterials;

	private List<Material> recyclingMaterials;

	private const int RecycleMaterialMaxCntEach = 5;

	private List<DynamicBone> dbBones;

	private List<HangCollider> hangColliders;

	private List<HangPivot> hangPivots;

	private static bool s_SetupFluxCoroutineFinish;

	private WaitUntil waitUntilFluxSetupEnd;

	public void RemoveFromCleanList(UMAData data)
	{
	}

	public int GetInitialScaleFactor(UMAData data)
	{
		return 0;
	}

	public virtual void OnEnable()
	{
	}

	public virtual void Awake()
	{
	}

	public override void OnDestroy()
	{
	}

	public void SetGarbageCollectionRateNew(int rate, bool clearcount = false)
	{
	}

	private void Update()
	{
	}

	public void EnableReuseMaterial()
	{
	}

	public override void WorkSync(UMAData umaData)
	{
	}

	public override void RemoveData(UMAData data)
	{
	}

	public override void Work()
	{
	}

	private TextureProcessBaseCoroutine CreateAndPrepareTextureProcess(UMAData data)
	{
		return null;
	}

	public virtual bool HandleDirtyUpdate(UMAData data, bool fastGen)
	{
		return false;
	}

	private void PrepareGeneratedMaterialsToRecycle(UMAData umaData)
	{
	}

	private void RecycleGeneratedMaterials(SkinnedMeshRenderer renderer)
	{
	}

	protected void SetupDynamicBones(bool bforceDyanamic)
	{
	}

	private void InitFlux(Transform root, out GameObject Hang, out HangManager hangManager)
	{
		Hang = null;
		hangManager = null;
	}

	private void ClearFluxRes(GameObject root)
	{
	}

	private static bool IsHangStringValid(HangString.StringType stringSetting, HangString.StringType avatarStringSetting)
	{
		return false;
	}

	protected void SetupFlux(UMAData data)
	{
	}

	protected IEnumerator SetupFluxFramebyFrame(UMAData data)
	{
		return null;
	}

	private DynamicBone GetAndRemoveDynamicBone(List<DynamicBone> list, GameObject go, bool net)
	{
		return null;
	}

	protected void FilterDynamicBone(Transform tr, List<Transform> validDynamicBones)
	{
	}

	protected void AddColliderForDynamicBone(DynamicBone db, UMADynamicBoneColliderProperties[] dbcps)
	{
	}

	private Transform FindTransformByName(Transform root, string name)
	{
		return null;
	}

	private void RemoveDirty()
	{
	}

	public virtual void OnDirtyUpdate()
	{
	}

	private void UpdateUMAMesh(bool updatedAtlas)
	{
	}

	public override void addDirtyUMA(UMAData umaToAdd)
	{
	}

	public override bool IsIdle()
	{
		return false;
	}

	public override int QueueSize()
	{
		return 0;
	}

	public virtual bool UMAReady()
	{
		return false;
	}

	public virtual void UpdateUMABody(UMAData umaData)
	{
	}

	private void InitGeneratorCoroutine()
	{
	}

	private void ResetGeneratorCoroutine()
	{
	}
}
