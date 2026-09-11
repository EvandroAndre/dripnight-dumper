using System.Collections.Generic;
using UnityEngine;

namespace COW.GamePlay;

public class LevelConveyerPlatform : LevelMovePlatform
{
	public enum MCMOPCOLJKJ
	{
		Direct,
		Rotate
	}

	public int CurPointIndex;

	public float NextMoveTime;

	public int CentreIndex;

	public float PerRoundTime;

	public float StartMoment;

	public float DirectSpeed;

	public float EdgeSpeed;

	public List<Vector3> EdgePoints;

	public Vector3[] CentrePoints;

	public float[] MoveTimeArray;

	public bool IsDebug;

	private float FNGAGPIJFEM;

	public MCMOPCOLJKJ State;

	public bool IsInit;

	protected override string GetObjectTag()
	{
		return null;
	}

	public uint GetPlatformId()
	{
		return 0u;
	}

	protected override void OnAwake()
	{
	}

	protected override void OnOnDestroy()
	{
	}

	protected void Start()
	{
	}

	protected void DGGOFBEFCGM()
	{
	}

	public void RegisterPlatformIfNeed()
	{
	}

	private void OnApplicationPause(bool LGIHOJICMDH)
	{
	}

	public void UpdateTransformByTime()
	{
	}

	public override void OnFixedUpdate(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	private void FixedUpdate()
	{
	}

	public void FillPlatformPara(float CLBANKJCDJL, float KHLNKGFIFEB, float AMBBDALEOOG, List<Vector3> KIAAABOHKPB, Vector3[] OBFBKOGNPOA, float[] DAPBNBKEDJD, float AKGFEJPFJNP)
	{
	}

	private Vector3 KIGLBIGMGEO(Vector3 FEDAGIOGKGD, float AOOCNKPILEO, Vector3 MNBPEEDKIAD)
	{
		return default(Vector3);
	}

	protected void JLGNOCKFCFM(float MBIKGEPEJEJ)
	{
	}

	public string _003C_003EiFixBaseProxy_GetObjectTag()
	{
		return null;
	}

	public new void _003C_003EiFixBaseProxy_OnAwake()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnOnDestroy()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnFixedUpdate(float P0, float P1)
	{
	}
}
