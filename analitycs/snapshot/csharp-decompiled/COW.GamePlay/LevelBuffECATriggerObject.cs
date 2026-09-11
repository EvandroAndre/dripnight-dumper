using System;
using message;

namespace COW.GamePlay;

public class LevelBuffECATriggerObject : BaseLevelObject
{
	[Serializable]
	public class TriggerBuffInfo
	{
		public uint BuffECADataID;

		public KINHCHJMHKG BuffAddType;

		public bool isKeepBuffWhenExit;
	}

	public const uint ISVISIBLE_ACTIVE = 1073741824u;

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

	public virtual void PostCreateInitActiveState(bool HKGNEMEHBIG)
	{
	}

	protected override void OnStart()
	{
	}

	private void IKBLMGKMIFC(bool OJEPOBEENEK, bool EIOKHLKJEEL)
	{
	}

	protected void HDDCMEMCPFC(bool HKGNEMEHBIG)
	{
	}

	public override void SyncAction(object[] DJAPBCKDFKA)
	{
	}

	private void JINEKGGNNAH(FFLHFGLAGHG JPCGFEOIKIN)
	{
	}

	public override void OnRecycle()
	{
	}

	public override bool Recycle()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUserDefineReplicationInfo()
	{
	}

	public int _003C_003EiFixBaseProxy_GetMaxRepDataCount()
	{
		return 0;
	}

	public new void _003C_003EiFixBaseProxy_OnStart()
	{
	}

	public void _003C_003EiFixBaseProxy_SyncAction(object[] P0)
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
