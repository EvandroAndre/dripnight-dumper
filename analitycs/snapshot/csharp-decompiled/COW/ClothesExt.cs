using GCommon;

namespace COW;

public class ClothesExt : CSVBaseData
{
	public static ClothesExt Default;

	public uint iID;

	public ResourceID idleAnimResID_M;

	public ResourceID showPoseEffectResID;

	public ResourceID DecorPropIDRight;

	public ResourceID DecorPropIDLeft;

	public ResourceID DecorPropIDRoot;

	public ResourceID VFXPoseAnimIDFemale;

	public int ConditionRecipeType;

	public uint IfSpecialBackground;

	public ResourceID VFXPoseAnimIDMale;

	public ResourceID idleAnimResID_F;

	public ResourceID FootHaloResId;

	public ResourceID showPoseAnimResID_M;

	public ResourceID showPoseAnimResID_F;

	public bool EffectForceShow;

	public bool InvalidRes;

	public bool Asynchronousloading;

	public bool FrameAnim;

	public bool VFXMandatoryDisplay;

	public byte TeamID;

	public byte NewMatType;

	public bool isSpecialIdle;

	public bool IsDefault;

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}
