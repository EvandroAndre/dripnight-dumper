using System;
using COW.GamePlay;
using UnityEngine;

public class HangManager : MonoBehaviour
{
	public enum LANGUAGE_TYPE
	{
		JAPAN,
		ENGLISH,
		CHINESE
	}

	public LANGUAGE_TYPE LanguageType;

	public Transform FarClippingObjRef;

	public float UpdateRate;

	public int StartResetWaitFrame;

	public bool CalcFlag;

	public bool CalcHangTransCopyOnlyFlag;

	public bool DBG_DispFlag;

	public int SetupFrameCount;

	public int ResetKeepFrameCount;

	[NonSerialized]
	private int ResetCount;

	private GameObject HangObj;

	private HangString[] children;

	private float TimePass;

	private int m_PendingFixedUpdateCount;

	private Vector3 m_CacheWorldPosition;

	private IAvatarProvider m_AvatarProvider;

	private Player m_OwnerPlayer;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnTransformParentChanged()
	{
	}

	private void FixedUpdate()
	{
	}

	private void LateUpdate()
	{
	}

	public void SetAvatarProvider()
	{
	}

	public bool IsWindEnabled()
	{
		return false;
	}

	private void CacheOwnerPlayer()
	{
	}

	private bool ExcuteAsUpdateCheck()
	{
		return false;
	}

	public void Teleport()
	{
	}

	public void StringSetup()
	{
	}

	public void ResetChildren()
	{
	}

	public static float CalcInter(float v1, float v2, float t)
	{
		return 0f;
	}

	private static float CalcSpherePlateDist(Vector3 pos, Vector3 nml, float coef_d)
	{
		return 0f;
	}

	public static void CalcPlateNodePerpendicular(Vector3 c_pos, out Vector3 dst, Vector3 p0, Vector3 nml)
	{
		dst = default(Vector3);
	}

	public static int CalcTriangle3DWrongSideOutNormal(Vector3 node, Vector3 l_node, Vector3 nml)
	{
		return 0;
	}

	public static void CalcSphereHit(ref Vector3 StringPos, float StringRad, Vector3 SpherePos, float SphereRad)
	{
	}

	public static void CalcCapsuleHit(ref Vector3 StringPos, float StringRad, Vector3 CapsulePos_0, Vector3 CapsulePos_1, float CapsuleRad)
	{
	}

	public static Vector3 VectorRot(Vector3 VecSide, Vector3 VecForward, float Deg)
	{
		return default(Vector3);
	}

	public static float CalcSinTblGet(float x1, float x2, float rot)
	{
		return 0f;
	}

	public static void Anglelimit(Vector3 SideVec, Vector3 UpVec, Vector3 ForwardVec, float AngleMin, float AngleMax, ref Vector3 NodePos)
	{
	}
}
