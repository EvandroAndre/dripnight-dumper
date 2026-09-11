using UnityEngine;

namespace COW.GamePlay;

public class LevelStrop : BaseLevelObject
{
	public enum JHNOGNLMLGI
	{
		GET_ON,
		GET_OFF,
		CREATE,
		DELETE,
		SWITCH
	}

	public static float DashCameraLerpTime;

	public Transform StartPoint;

	public Transform EndPoint;

	public LineRenderer StropLine;

	public float Speed;

	private bool APNDBLCAMIP;

	private bool KOPMNDDLGHF;

	protected Collider NBABLFEJEOG;

	private LevelStropShelf DKEGJGNHJCC;

	private LevelStropShelf ADHJHDOGING;

	private float OJPGEDEDNJC;

	public bool OBOHCAIOBBD
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public Vector3 LMAEGPEAECO => default(Vector3);

	public Vector3 ELECEGLAPPC => default(Vector3);

	public virtual int BNOAAMAOGIN => 0;

	private bool GPGAOCMHPJN => false;

	protected override string GetObjectTag()
	{
		return null;
	}

	protected override void OnUserDefineReplicationInfo()
	{
	}

	protected override int GetMaxRepDataCount()
	{
		return 0;
	}

	protected virtual void HMFDPPCDFEL(bool OJEPOBEENEK, bool EIOKHLKJEEL)
	{
	}

	protected override void OnStart()
	{
	}

	protected void BLNFLHFCNEI()
	{
	}

	public void DisableSelf()
	{
	}

	public void UpdateLine()
	{
	}

	public virtual Vector3 GetMoveDir(int CAKPBGKDFBN = 0, bool IPNPKMJDIPC = true)
	{
		return default(Vector3);
	}

	public virtual LevelStropShelf GetStartShelf()
	{
		return null;
	}

	public virtual LevelStropShelf GetEndShelf()
	{
		return null;
	}

	public uint GetSwtichStropId(bool PEDBFMMOJNL = false)
	{
		return 0u;
	}

	public void SetLineVisible(bool FKJMCGEFJMD)
	{
	}

	public virtual float GetLength(int CAKPBGKDFBN = 0, bool IPNPKMJDIPC = true)
	{
		return 0f;
	}

	public virtual bool IsLastSegment(int CAKPBGKDFBN)
	{
		return false;
	}

	public virtual Vector3 GetCurrentSegmentEnd(int CAKPBGKDFBN, bool IPNPKMJDIPC)
	{
		return default(Vector3);
	}

	public virtual Vector3 GetCurrentSegmentStartPosition(int CAKPBGKDFBN, bool IPNPKMJDIPC, float JAMCOPNBGFD = 0f)
	{
		return default(Vector3);
	}

	public override void DoAction(object[] DJAPBCKDFKA)
	{
	}

	public void SetColliderState(bool HCLGHJNEFIC)
	{
	}

	public override void SyncAction(object[] DJAPBCKDFKA)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUserDefineReplicationInfo()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnStart()
	{
	}

	public int _003C_003EiFixBaseProxy_GetMaxRepDataCount()
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_DoAction(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_SyncAction(object[] P0)
	{
	}
}
