using GCommon;

namespace COW;

public class MusicRhythmData : CSVBaseData
{
	public string Category;

	public ResourceID MusicID;

	public float TailDuration;

	public float IntroDuration;

	public int BeatsPerBar;

	public float Tempo;

	public float Volume;

	public bool Loop;

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
