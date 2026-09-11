using System.Collections.Generic;
using UMA;
using UnityEngine;

public class HangString : MonoBehaviour
{
	public enum StringType
	{
		Lobby,
		InGame,
		All
	}

	public enum FREEZE_AXIS
	{
		None,
		X,
		Y,
		Z
	}

	public class STRING
	{
		public Transform Trans;

		public int ParentId;

		public float Hardness;

		public float AirResistance;

		public float Radius;

		public float Length;

		public Vector3 PosNow;

		public Vector3 PosPrev;

		public Vector3 InitLocalPos;

		public Quaternion InitLocalRot;
	}

	public enum GravityType
	{
		NegY,
		X
	}

	public int CalcPriorityId;

	public Transform StringFirstBonTrans;

	public float Hardness;

	public AnimationCurve HardnessCurve;

	public float AirResistance;

	public AnimationCurve AirResistanceCurve;

	public float StringRad;

	public AnimationCurve StringRadCurve;

	public float StringGravity;

	public List<float> NodeGravity;

	public List<Transform> ExcludeTrans;

	public List<float> NodeWindForcePercentage;

	public StringType StringSetting;

	public bool RemoveWhenUMARebuild;

	public FREEZE_AXIS FreezeAxis;

	public float FarClipCalcDist;

	public List<HangCollider_Sphere> HangCollider_SphereList;

	public List<HangCollider_Capsule> HangCollider_CapsuleList;

	public List<HangCollider_Plane> HangCollider_PlaneList;

	public bool DBG_AngleLimitDisp;

	public ANGLE_LIMIT[] AngleLimit;

	public float FirstBoneRotZOffset;

	private float[] InitSpringLength;

	private float s_StringTotalLength;

	private float s_ObjectScale;

	private bool s_DistantDisabled;

	private bool s_TeleportFlag;

	private float s_ConstraintAbsorb;

	private int s_Start_SetupFrameCount;

	private bool s_Start_SetupOnceFlag;

	private int s_Start_ResetKeepFrameCount;

	private List<STRING> String;

	private HangManager script_HangManager;

	private bool IsNeedUpdate;

	private bool m_UseFixedSnapshotMode;

	private Matrix4x4 m_RenderFromSimulationMatrix;

	private Matrix4x4 m_SimulationFromRenderMatrix;

	private Matrix4x4 m_RenderFirstBoneMatrix;

	private bool m_HasRenderFirstBoneMatrix;

	private Vector3 m_LastSimulationFirstBonePosition;

	private Vector3 m_RenderOffsetFromSimulation;

	private float m_RenderInterpolationRate;

	private bool m_HasRenderPosition;

	private bool m_EnableRenderOnlyCompensation;

	public GravityType GTpye;

	public void SetHangManager(HangManager Manager)
	{
	}

	public void LateUpdateCalc(bool isNeedUpdate, float deltaTime, bool useFixedSnapshotMode, int fixedUpdateCount)
	{
	}

	private void FarClipCalc()
	{
	}

	private void StringPos2ModelPos()
	{
	}

	public void LocalTransInit()
	{
	}

	private void OnDisable()
	{
	}

	private void OnEnable()
	{
	}

	private Matrix4x4 GetFirstBoneMatrix()
	{
		return default(Matrix4x4);
	}

	private Quaternion TransformRotation(Matrix4x4 matrix, Quaternion rotation)
	{
		return default(Quaternion);
	}

	private void SetFirstBoneMatrix(Matrix4x4 matrix)
	{
	}

	private void ResetFixedSnapshotState()
	{
	}

	private void UpdateFixedSnapshotMatrices(bool useFixedSnapshotMode, Matrix4x4 renderFirstBoneMatrix, int pendingFixedUpdateCount)
	{
	}

	private bool HasRenderFromSimulationMatrix()
	{
		return false;
	}

	private bool HasRenderOutputMatrix()
	{
		return false;
	}

	private void PrepareFixedSnapshotSimulationPose(int fixedUpdateCount)
	{
	}

	private void UpdateRenderOnlyCompensation(Matrix4x4 renderFirstBoneMatrix)
	{
	}

	private Vector3 GetRenderPosition(int nodeIndex)
	{
		return default(Vector3);
	}

	private void StringCalc(float Dt, bool useFixedSnapshotMode, int fixedUpdateCount)
	{
	}

	public void StringSetup()
	{
	}

	private void AddStringNode(Transform Trans, int ParentId, float Length)
	{
	}

	private void UpdateParam()
	{
	}

	private void StringCalcSub_1_FirstBone()
	{
	}

	private void StringCalcSub_2_WindAndMove(float Dt)
	{
	}

	private void StringCalcSub_3_LimitAndTransform()
	{
	}

	private void StringCalcSub_4_ColiHit()
	{
	}

	private void StringCalcSub_5_Trans()
	{
	}

	private void AngleLimit_YZ(int NodeId)
	{
	}

	public void Teleport()
	{
	}

	public void DeserializeCollider(UMASkeleton skeleton, HangStringProperty property)
	{
	}

	public void Deserialize(UMASkeleton skeleton, HangStringProperty se)
	{
	}

	public void DeserializeAngleLimit(UMASkeleton skeleton, List<ANGLELIMIT_PROPERTY> properties)
	{
	}

	private Transform GetPivotTransform(UMASkeleton skeleton, string BaseAxis, string BaseAxisParent, Quaternion BaseAxis_quaternion)
	{
		return null;
	}
}
