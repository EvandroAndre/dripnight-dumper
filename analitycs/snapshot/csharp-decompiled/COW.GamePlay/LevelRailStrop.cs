using System.Collections.Generic;
using UnityEngine;

namespace COW.GamePlay;

public class LevelRailStrop : LevelStrop
{
	public LineRenderer m_SecondStropLine;

	public Transform m_NodeRoot;

	public List<RailStropHookPoint> NodePoints;

	public Transform m_StartTrigger;

	public Transform m_EndTrigger;

	private List<Vector3> KBFKNDELGDM;

	private List<Vector3> KHCBJJPJIBC;

	private Dictionary<int, float> IEFOJFHANDB;

	private Dictionary<int, float> FIEJFFKCOEH;

	private Dictionary<int, Vector3> AGLNCKNGACI;

	private Dictionary<int, Vector3> CBAHHJODJHH;

	private int KDNKIMPEPNK;

	private bool GPGAOCMHPJN => false;

	public override int BNOAAMAOGIN => 0;

	public override LevelStropShelf GetStartShelf()
	{
		return null;
	}

	public override LevelStropShelf GetEndShelf()
	{
		return null;
	}

	protected override string GetObjectTag()
	{
		return null;
	}

	protected override void OnUserDefineReplicationInfo()
	{
	}

	public List<Vector3> GetAnchorNodePoints()
	{
		return null;
	}

	public List<Vector3> GetLeftNodePoints()
	{
		return null;
	}

	public List<Vector3> GetRightNodePoints()
	{
		return null;
	}

	protected override int GetMaxRepDataCount()
	{
		return 0;
	}

	protected override void OnAwake()
	{
	}

	protected override void OnStart()
	{
	}

	private void HNELCGCHGLA()
	{
	}

	private bool DFKBLAENPEF(int CAKPBGKDFBN)
	{
		return false;
	}

	public override Vector3 GetMoveDir(int CAKPBGKDFBN, bool IPNPKMJDIPC)
	{
		return default(Vector3);
	}

	public override float GetLength(int CAKPBGKDFBN, bool IPNPKMJDIPC)
	{
		return 0f;
	}

	public override bool IsLastSegment(int CAKPBGKDFBN)
	{
		return false;
	}

	public override Vector3 GetCurrentSegmentEnd(int CAKPBGKDFBN, bool IPNPKMJDIPC)
	{
		return default(Vector3);
	}

	public override Vector3 GetCurrentSegmentStartPosition(int CAKPBGKDFBN, bool IPNPKMJDIPC, float JAMCOPNBGFD = 0f)
	{
		return default(Vector3);
	}

	public float GetCurrentProgRate(Vector3 KDJNEHDAAFL, Vector3 GKIJJHHPJOK, Vector3 JLGLIDOEDHB)
	{
		return 0f;
	}

	public float GetProgRate(Vector3 KDJNEHDAAFL, bool IPNPKMJDIPC, int IIBOFOPMCLP)
	{
		return 0f;
	}

	public Vector3 GetCurrentRatePosition(float JAMCOPNBGFD, Vector3 GKIJJHHPJOK, Vector3 JLGLIDOEDHB)
	{
		return default(Vector3);
	}

	public int GetReverseIndex(int CAKPBGKDFBN)
	{
		return 0;
	}

	public Vector3 GetReversePostion(Vector3 HDFILHFDBKB, int CAKPBGKDFBN, bool IPNPKMJDIPC)
	{
		return default(Vector3);
	}

	protected void AMJOEGKGINB()
	{
	}

	public override void DoAction(object[] DJAPBCKDFKA)
	{
	}

	public override void SyncAction(object[] DJAPBCKDFKA)
	{
	}

	public LevelStropShelf _003C_003EiFixBaseProxy_GetStartShelf()
	{
		return null;
	}

	public LevelStropShelf _003C_003EiFixBaseProxy_GetEndShelf()
	{
		return null;
	}

	public string _003C_003EiFixBaseProxy_GetObjectTag()
	{
		return null;
	}

	public new void _003C_003EiFixBaseProxy_OnUserDefineReplicationInfo()
	{
	}

	public new int _003C_003EiFixBaseProxy_GetMaxRepDataCount()
	{
		return 0;
	}

	public int _003C_003EiFixBaseProxy_get_NodeCount()
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_OnAwake()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnStart()
	{
	}

	public bool _003C_003EiFixBaseProxy_IsLastSegment(int P0)
	{
		return false;
	}

	public Vector3 _003C_003EiFixBaseProxy_GetCurrentSegmentEnd(int P0, bool P1)
	{
		return default(Vector3);
	}

	public Vector3 _003C_003EiFixBaseProxy_GetCurrentSegmentStartPosition(int P0, bool P1, float P2)
	{
		return default(Vector3);
	}

	public new void _003C_003EiFixBaseProxy_DoAction(object[] P0)
	{
	}

	public new void _003C_003EiFixBaseProxy_SyncAction(object[] P0)
	{
	}
}
