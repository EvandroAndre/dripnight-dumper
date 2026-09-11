using UnityEngine;
using message;

namespace COW.GamePlay;

public class LevelMotionPlatform : LevelMovePlatform
{
	protected enum BENJACONKGJ
	{
		None,
		Stable,
		Moving
	}

	public enum PMCEMHJGDFH
	{
		Position,
		Rotation,
		Scale
	}

	public PMCEMHJGDFH m_MotionType;

	public Vector3 m_StartValue;

	public Vector3 m_EndValue;

	public float m_StartMoment;

	public float m_MotionTime;

	public float m_StayTime;

	public bool m_IsReset;

	public float m_MotionX;

	public float m_MotionY;

	public float m_MotionZ;

	public HNBNCICOMKN m_MotionPlatformType;

	protected bool INAKEKIPBCB;

	protected float OMGBIPNEEPK;

	public bool DontNeedTick;

	private Quaternion GBHPAJHAAMF;

	private bool HCHOMMKPABO;

	protected BENJACONKGJ MAOHIOEAMEA;

	protected bool NKHGPPJHNEP;

	private int NMLDHCLNAGO;

	protected override string GetObjectTag()
	{
		return null;
	}

	public uint GetPlatformId()
	{
		return 0u;
	}

	protected virtual void Start()
	{
	}

	protected virtual void DGGOFBEFCGM()
	{
	}

	public void RegisterPlatformIfNeed()
	{
	}

	private void OnApplicationPause(bool LGIHOJICMDH)
	{
	}

	public bool CheckServerTickInitState(float MBIKGEPEJEJ)
	{
		return false;
	}

	public override void OnFixedUpdate(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	protected void HKGKPLCNGEF()
	{
	}

	protected bool HOJLCCCIIBE(float MBIKGEPEJEJ, out Vector3 HEICKKGLCPO)
	{
		HEICKKGLCPO = default(Vector3);
		return false;
	}

	protected void EGJCJAEBGCK(Vector3 HEICKKGLCPO)
	{
	}

	public void SetMotionData(PMCEMHJGDFH LHIAKDOIKNO, Vector3 LJFAKCLOKOM, Vector3 EPFMCKNCPNL, float BCKFJEEEKFN)
	{
	}

	public void UpdateMotionValue()
	{
	}

	public void SyncPostionWithServer(Vector3 IGDHIDGLOKG, uint CBCAJJJCKLH)
	{
	}

	public string _003C_003EiFixBaseProxy_GetObjectTag()
	{
		return null;
	}

	public new void _003C_003EiFixBaseProxy_OnFixedUpdate(float P0, float P1)
	{
	}
}
