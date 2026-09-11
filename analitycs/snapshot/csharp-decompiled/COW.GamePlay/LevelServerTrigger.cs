using UnityEngine;
using message;

namespace COW.GamePlay;

public class LevelServerTrigger : BaseLevelObject
{
	public GameObject EffectRoot;

	public BoxCollider box;

	public LDDPFBJAPLA State;

	protected override string GetObjectTag()
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

	public void SetData(uint EILJPLGANJG, Vector3 HDFILHFDBKB, Quaternion IPKKCHLDJMA, string OCCLMDNGINA)
	{
	}

	public override void OnRecycle()
	{
	}

	public override bool Recycle()
	{
		return false;
	}

	protected override void OnModelShowed()
	{
	}

	protected override void OnUserDefineReplicationInfo()
	{
	}

	private void MCOHEKAPHIE(byte OJEPOBEENEK, byte EIOKHLKJEEL)
	{
	}

	public byte GetState()
	{
		return 0;
	}

	public bool CanBeUsed()
	{
		return false;
	}

	public override void DoAction(object[] DJAPBCKDFKA)
	{
	}

	public void UseTrigger()
	{
	}

	public int _003C_003EiFixBaseProxy_GetMaxRepDataCount()
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_OnAwake()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnRecycle()
	{
	}

	public new bool _003C_003EiFixBaseProxy_Recycle()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnModelShowed()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUserDefineReplicationInfo()
	{
	}

	public void _003C_003EiFixBaseProxy_DoAction(object[] P0)
	{
	}
}
