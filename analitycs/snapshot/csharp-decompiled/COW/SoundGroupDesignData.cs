using GCommon;

namespace COW;

public class SoundGroupDesignData : CSVBaseData
{
	public int InstanceLimit3D;

	public float PitchRandomRange;

	public float VolumeRandomRange;

	public float BaseVolume;

	public ResourceID Attenuation3P;

	public ResourceID Attenuation1P;

	public int Bus3P;

	public int Bus2P;

	public int Bus1P;

	public int Priority;

	public int InstanceLimit2D;

	public float MaxPlayDistance;

	public uint GroupID;

	public byte DiscardLogic;

	public bool SendToVirtualVoice;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}
