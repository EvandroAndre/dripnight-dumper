using GCommon;

namespace COW;

public class HeroicMarkData : CSVBaseData
{
	public static readonly uint LEVEL_NUMBER;

	private string GradientTypeTop;

	private string GradientTypeBottom;

	private string Effect;

	private string Effect2;

	private string MasterGradientTypeTop;

	private string MasterGradientTypeBottom;

	private string MasterEffect;

	private string MasterEffect2;

	private HeroicMarkNumberLabelInfo m_LabelInfo;

	private HeroicMarkNumberLabelInfo m_MasterLabelInfo;

	public uint Level;

	public uint MarkType;

	public ResourceID BGBigICONResource;

	public ResourceID CSMarkICON;

	public int Spacing;

	public ResourceID VfxRes;

	public ResourceID VfxResSmall;

	public ResourceID BGMasterBigICONResource;

	public ResourceID CSMasterMarkICON;

	public int MasterSpacing;

	public ResourceID MasterVFXRes;

	public ResourceID MasterSmallVFXRes;

	public ResourceID BGGrandmasterBigICONResource;

	public ResourceID CSGrandmasterMarkICON;

	public ResourceID GrandmasterVFXRes;

	public ResourceID GrandmasterSmallVFXRes;

	public HeroicMarkNumberLabelInfo LabelInfo => null;

	public HeroicMarkNumberLabelInfo MasterLabelInfo => null;

	public override uint GetUIntKey()
	{
		return 0u;
	}

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public uint _003C_003EiFixBaseProxy_GetUIntKey()
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}
