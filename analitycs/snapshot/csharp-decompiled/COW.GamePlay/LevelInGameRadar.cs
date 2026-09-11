using System.Collections.Generic;
using UnityEngine;

namespace COW.GamePlay;

public class LevelInGameRadar : BaseLevelObject
{
	public GameObject RotatePart;

	public uint RadarID;

	public Dictionary<uint, uint> TeamScanCostDic;

	public Dictionary<uint, uint> TeamRefreshCostDic;

	public float ScanStopTime;

	public float CDFinishTime;

	public float UnWorkTime;

	public uint ScanRadius;

	public Vector3 CenterPos;

	public List<Vector3> PlayerPositions;

	public EEKJJAMLGEO CurRadarState;

	public bool InScan;

	private bool OIPPHPMHHIC;

	private GameObject LLLGJAFNPMM;

	public void SetEnityInfo(uint NBLHNPAHGNA)
	{
	}

	protected override string GetObjectTag()
	{
		return null;
	}

	protected override void OnAwake()
	{
	}

	protected override void OnStart()
	{
	}

	public override void OnRecycle()
	{
	}

	public override bool Recycle()
	{
		return false;
	}

	protected override void OnOnDestroy()
	{
	}

	protected override void OnUpdateVisibleStateByStreamer(Vector3 MHAAFMCMHAC, Vector3 PAFBAHJAAGC)
	{
	}

	public override void OnUpdate(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	private void IICNPHNPLAL(bool EOGOGFLCEHL)
	{
	}

	public void OnRadarRefreshInfo(float HJBNKGJKBLP, float ILHLIAMIFMF, uint DIDCIGAPFJO, float ANJJMKMNKLM, uint HHGKNMACHGB, uint OBMFMAKFDDL, uint IOJLAKPPCPH, bool BJIFODOENIC)
	{
	}

	public void OnRadarUpdatePlayerPos(Vector3 BALJLOMIDNI)
	{
	}

	public bool IsInCD()
	{
		return false;
	}

	public float GetLeftCD()
	{
		return 0f;
	}

	public void GetScanCost(uint IKMGPLIHPFE, out uint FNCANCCLOKC)
	{
		FNCANCCLOKC = default(uint);
	}

	public void GetRefreshCost(uint IKMGPLIHPFE, out uint FNCANCCLOKC)
	{
		FNCANCCLOKC = default(uint);
	}

	public override void RecycleForInGameReload()
	{
	}

	public void _003C_003EiFixBaseProxy_OnAwake()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnStart()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnRecycle()
	{
	}

	public new bool _003C_003EiFixBaseProxy_Recycle()
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnOnDestroy()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUpdateVisibleStateByStreamer(Vector3 P0, Vector3 P1)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUpdate(float P0, float P1)
	{
	}

	public void _003C_003EiFixBaseProxy_RecycleForInGameReload()
	{
	}
}
