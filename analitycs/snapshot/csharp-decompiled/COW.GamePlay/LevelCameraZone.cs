using UnityEngine;

namespace COW.GamePlay;

public class LevelCameraZone : BaseLevelObject
{
	public enum PONNBKMDCJN
	{
		Create
	}

	public uint CameraTemplateID;

	public float PlayerRotY;

	public bool RegionVarControl;

	protected override string GetObjectTag()
	{
		return null;
	}

	protected override void OnAwake()
	{
	}

	public override void SyncAction(object[] DJAPBCKDFKA)
	{
	}

	private void MDBCIIPKNDC(uint HFLFAELKAMH, Vector3 HDFILHFDBKB, Quaternion IPKKCHLDJMA, float PLCEFGLLHKD)
	{
	}

	public void DoOnInteract()
	{
	}

	public override void OnReUse()
	{
	}

	public override void OnRecycle()
	{
	}

	public override bool Recycle()
	{
		return false;
	}

	private void CDIABFOLGGG(bool OPNEJOHDLCJ)
	{
	}

	public void _003C_003EiFixBaseProxy_OnAwake()
	{
	}

	public void _003C_003EiFixBaseProxy_SyncAction(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnReUse()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnRecycle()
	{
	}

	public new bool _003C_003EiFixBaseProxy_Recycle()
	{
		return false;
	}
}
