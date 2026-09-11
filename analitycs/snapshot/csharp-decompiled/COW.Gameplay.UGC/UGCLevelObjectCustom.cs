using System.Collections.Generic;
using COW.GamePlay;
using COW.GamePlay.UGCRuntime;
using UnityEngine;

namespace COW.Gameplay.UGC;

public class UGCLevelObjectCustom : BaseAutoGenIDLevelObject, JPHBHMMPHJG, LJJABOHJEIN
{
	private sealed class _003C_003Ec__DisplayClass39_0
	{
		public int cacheIndex;

		public UGCLevelObjectCustom _003C_003E4__this;

		internal void _003CSetMaterialIDs_003Eb__0(bool succ, UGCMaterial resObj)
		{
		}
	}

	private IUGCModuleArchTypeMgr m_ArchTypeMgr;

	private string m_ArchTypeID;

	private GameObject m_ImplGameObject;

	private MeshFilter m_ImplMeshFilter;

	private MeshRenderer m_ImplMeshRenderer;

	protected string m_AnimationControllerEntityID;

	private UGCAnimationControllerEntity m_AnimationController;

	private UGCSkeletonAvatarSystem m_avatarSystem;

	private bool m_isCacheAvatarPartVisableMask1;

	private bool m_isCacheAvatarPartVisableMask2;

	private bool m_isCacheAvatarPartVisableMask3;

	private bool m_isCacheAvatarPartVisableMask4;

	private int m_cacheAvatarPartVisableMask1;

	private int m_cacheAvatarPartVisableMask2;

	private int m_cacheAvatarPartVisableMask3;

	private int m_cacheAvatarPartVisableMask4;

	private UGCParticles m_Particles;

	private UGCEntityDataStore m_DataStore;

	private int m_ForceLayer;

	private UGCTransformClothInfoEntity m_transformClothEntity;

	private string m_curResCombineBatchUUID;

	private bool m_isMeshLoaded;

	private UGCMesh m_resMeshRendererMesh;

	private bool m_isMaterialLoaded;

	private UGCMaterial[] m_cacheUgcMaterials;

	private Material[] m_cacheMaterials;

	private bool _003CUsePhysicalCharacterController_003Ek__BackingField;

	private PhysicalCCT _003CPhysicalCCT_003Ek__BackingField;

	private Vector3 _003CInputVelocity_003Ek__BackingField;

	private Vector3 m_InputForward;

	private bool m_NeedSetForward;

	private bool IsDestroyed => false;

	public bool UsePhysicalCharacterController
	{
		get
		{
			return _003CUsePhysicalCharacterController_003Ek__BackingField;
		}
		set
		{
			_003CUsePhysicalCharacterController_003Ek__BackingField = value;
		}
	}

	public PhysicalCCT PhysicalCCT
	{
		get
		{
			return _003CPhysicalCCT_003Ek__BackingField;
		}
		protected set
		{
			_003CPhysicalCCT_003Ek__BackingField = value;
		}
	}

	public Vector3 InputVelocity
	{
		get
		{
			return _003CInputVelocity_003Ek__BackingField;
		}
		set
		{
			_003CInputVelocity_003Ek__BackingField = value;
		}
	}

	protected override void PreRegister()
	{
	}

	public override bool CreateDynamicallyForUGC(string entityID)
	{
		return false;
	}

	public override void OnUGCEntityCreated(string entityID, string archTypeID)
	{
	}

	protected override void OnOnDestroy()
	{
	}

	public override void OnSyncUGCEntityProperty(long propertyIndex, UGCSimpleValue newValue)
	{
	}

	private void SetCombineBatchResUUID(string resUUID)
	{
	}

	private void SetResUUID(string resUUID)
	{
	}

	private void ValidateMeshRendererObject()
	{
	}

	public override void OnExtraRenderLayerChanged()
	{
	}

	private void SetColliderResID(string resUUID)
	{
	}

	private void SetMeshID(string resUUID)
	{
	}

	private void SetMaterialIDs(List<object> resUUIDs)
	{
	}

	private void RefreshSelfState()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}

	private new void OnEnable()
	{
	}

	private void RefreshDynamicCombineRenderer()
	{
	}

	public override void SetUGCStatic(bool isStatic)
	{
	}

	private void InitAnimationController()
	{
	}

	public void Update()
	{
	}

	private void LateUpdate()
	{
	}

	private void UpdateAnimation()
	{
	}

	public void PlayEmoteOrClip(string emoteOrClipUUID, bool isLoop)
	{
	}

	public void PauseCurrentAnimation(bool isPause)
	{
	}

	private void OnMeshChanged(UGCResource res)
	{
	}

	private void OnMaterialChanged(UGCResource res)
	{
	}

	public void SetForceLayer(int layer)
	{
	}

	public float GetMoverMass()
	{
		return 0f;
	}

	public Vector3 GetMoverCenterOfRotation()
	{
		return default(Vector3);
	}

	public Vector3 GetMoverVelocity()
	{
		return default(Vector3);
	}

	public Vector3 GetMoverAngularVelocity()
	{
		return default(Vector3);
	}

	public void AddForceAtPosition(Vector3 value, ForceMode mode, Vector3 hitPoint)
	{
	}

	public void InitPhysicalCCT()
	{
	}

	public void OnFixedUpdateCCT()
	{
	}

	public bool Is3PCustomPlayer()
	{
		return false;
	}

	void LJJABOHJEIN.BeforeCCTUpdate()
	{
	}

	Quaternion LJJABOHJEIN.UpdateRotation(Quaternion BaseRotation, float gameTime, float deltaTime)
	{
		return default(Quaternion);
	}

	Vector3 LJJABOHJEIN.UpdateVelocity(Vector3 BaseVelocity, float gameTime, float deltaTime)
	{
		return default(Vector3);
	}

	void LJJABOHJEIN.AfterCCTUpdate()
	{
	}

	void LJJABOHJEIN.AfterUpdateGroundState()
	{
	}

	void LJJABOHJEIN.OnControllerColliderHit(ControllerColliderHit hit)
	{
	}

	void LJJABOHJEIN.OnGroundHit(Collider hitCollider, Vector3 hitNormal, Vector3 hitPoint)
	{
	}

	void LJJABOHJEIN.OnMovementHit(Collider hitCollider, Vector3 hitNormal, Vector3 hitPoint)
	{
	}

	public void APICCTMove(Vector3 movement)
	{
	}

	public void APICCTTeleport(Vector3 position)
	{
	}

	void LJJABOHJEIN.APICCTForward(Vector3 forward)
	{
	}

	private void _003CSetCombineBatchResUUID_003Eb__28_0(bool succ, UGCResCombineMeshRenderer resObj)
	{
	}

	private void _003CSetResUUID_003Eb__29_0(bool succ, UGCGameObject resObj)
	{
	}

	private void _003CSetColliderResID_003Eb__32_0(bool succ, UGCResourceCollider resObj)
	{
	}

	private void _003CSetMeshID_003Eb__35_0(bool succ, UGCMesh resObj)
	{
	}

	public void _003C_003EiFixBaseProxy_PreRegister()
	{
	}

	public bool _003C_003EiFixBaseProxy_CreateDynamicallyForUGC(string P0)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUGCEntityCreated(string P0, string P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnOnDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnSyncUGCEntityProperty(long P0, UGCSimpleValue P1)
	{
	}

	public void _003C_003EiFixBaseProxy_OnExtraRenderLayerChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_SetUGCStatic(bool P0)
	{
	}
}
