using System.Collections.Generic;
using COW.GamePlay;
using UnityEngine;

public class Debug_ColliderTrigger : MonoBehaviour
{
	public struct ServerColliderShape
	{
		public byte ShapeType;

		public byte Layer;

		public bool IsTrigger;

		public Vector3 Position;

		public Quaternion Rotation;

		public Vector3 Scale;

		public Vector3 Extent;
	}

	public Mesh BoxMesh;

	public Mesh SphereMesh;

	public Mesh CapsuleMesh;

	public Shader DebugColliderShader;

	public bool activateDebugCollider;

	private Material _DebugColliderMat;

	private Material _DebugTriggerMat;

	private bool ShowColliderFlag;

	private bool ShowTriggerFlag;

	private Material _DebugServerColliderMat;

	private GameObject _tmpCollider_TriggerObj;

	private GameObject _tmpColliderObj;

	private GameObject _tmpTriggerObj;

	private GameObject _tmpServerColliderObj;

	private bool m_showCollider;

	private bool m_showTrigger;

	private bool m_showServerCollider;

	private bool m_showClientOnlyCollider;

	private GameObject _tmpBoxColliderObj;

	private GameObject _tmpBoxTriggerObj;

	private GameObject _tmpSphereColliderObj;

	private GameObject _tmpSphereTriggerObj;

	private GameObject _tmpCapsuleColliderObj;

	private GameObject _tmpCapsuleTriggerObj;

	private GameObject _tmpMeshColliderObj;

	private GameObject _tmpMeshTriggerObj;

	private GameObject _tmpServerBoxObj;

	private GameObject _tmpServerSphereObj;

	private GameObject _tmpServerCapsuleObj;

	private Dictionary<string, List<GameObject>> debugMeshRendererDic;

	private static Debug_ColliderTrigger _003Cinstance_003Ek__BackingField;

	public static Debug_ColliderTrigger instance
	{
		get
		{
			return _003Cinstance_003Ek__BackingField;
		}
		private set
		{
			_003Cinstance_003Ek__BackingField = value;
		}
	}

	private void Awake()
	{
	}

	public void Init()
	{
	}

	private void OnDestroy()
	{
	}

	public void UnloadGameObject(string sceneName)
	{
	}

	private void AddMeshColShow()
	{
	}

	private void OnShowCollider(object[] data)
	{
	}

	private void OnShowTrigger(object[] data)
	{
	}

	private void OnShowClientCollider(object[] data)
	{
	}

	private void OnShowServerCollider(object[] data)
	{
	}

	private static T[] FilterClientOnlyNonTrigger<T>(T[] colliders) where T : Collider
	{
		return null;
	}

	public static bool IsClientOnlyCollider(Component c)
	{
		return false;
	}

	private void OnRebuildCollider(object[] data)
	{
	}

	private void OnDestroyCollider(object[] data)
	{
	}

	private void DestroyAllAssets()
	{
	}

	private void InitColliderMats()
	{
	}

	private void InitAllMesh()
	{
	}

	private void CreateColliderMesh()
	{
	}

	private void CreateServerSubRoots(GameObject root)
	{
	}

	public void PaintCollider(BoxCollider[] boxColliders, SphereCollider[] sphereColliders, CapsuleCollider[] capsuleColliders, MeshCollider[] meshColliders, string sceneName = null)
	{
	}

	private bool CheckRequireName(string name)
	{
		return false;
	}

	private Transform FindStreamAnchor(Transform trans)
	{
		return null;
	}

	private string GetRootNode(Transform colliderTrans)
	{
		return null;
	}

	private void CreateBoxMesh(GameObject _tmpColliderObj, GameObject _tmpTriggerObj)
	{
	}

	private void ProcessClimbingTrigger(ClimbingTrigger climbingTrigger)
	{
	}

	private void PaintBoxCollider(BoxCollider[] boxColliders, string sceneName = null)
	{
	}

	private void CreateSphereMesh(GameObject _tmpColliderObj, GameObject _tmpTriggerObj)
	{
	}

	public void PaintSphereCollider(SphereCollider[] sphereColliders, string sceneName = null)
	{
	}

	private void CreateCapsuleMesh(GameObject _tmpColliderObj, GameObject _tmpTriggerObj)
	{
	}

	public void PaintCapsuleCollider(CapsuleCollider[] capsuleColliders, string sceneName = null)
	{
	}

	private void CreateMeshMesh(GameObject _tmpColliderObj, GameObject _tmpTriggerObj)
	{
	}

	public void PaintMeshCollider(MeshCollider[] meshColliders, string sceneName = null)
	{
	}

	public void RebuildAllMesh()
	{
	}

	public void DestroyAllMesh()
	{
	}

	public void ShowColliders(bool isShow = true)
	{
	}

	public void ShowTriggers(bool isShow = true)
	{
	}

	public void ShowServerColliders(bool isShow = true)
	{
	}

	public void ClearServerColliderObjects()
	{
	}

	private void ClearChildren(GameObject go)
	{
	}

	public void PaintServerColliders(IList<ServerColliderShape> shapes)
	{
	}

	private void PaintOneServerCollider(ServerColliderShape s)
	{
	}

	private Color GetColorByLayer(bool isTrigger, uint layer)
	{
		return default(Color);
	}
}
