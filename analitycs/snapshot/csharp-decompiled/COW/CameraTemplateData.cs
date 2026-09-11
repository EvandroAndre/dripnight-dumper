using GCommon;
using UnityEngine;

namespace COW;

public class CameraTemplateData : CSVBaseData
{
	public Vector3 Position;

	public Vector3 SpecialTemplateAvatarRoationFemale;

	public Vector3 SpecialTemplateAvatarRoation;

	public Vector3 SpecialTemplateAvatarPositionFemale;

	public Vector3 SpecialTemplateAvatarPosition;

	public string Name;

	public float[] LookatPosition;

	public string CDN;

	public int[] LevelCameraZoneLimitId;

	public string SpecialTemplateRoateY;

	public ResourceID SpecialTemplateAnimFamale;

	public int SortID;

	public float RotationZ;

	public ResourceID SpecialTemplateAnimMale;

	public float SpecialTemplateFOV;

	public uint ID;

	public bool FixY;

	public bool IsVertical;

	public bool IsVerticalDefault;

	public bool FixX;

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
