using GCommon;

namespace COW;

public class WorkshopPlayerAnimationBaseStateData : CSVBaseData
{
	public string ParentStateName;

	public string ParentStateTesName;

	public int ClipIndex;

	public int MotionType;

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}
