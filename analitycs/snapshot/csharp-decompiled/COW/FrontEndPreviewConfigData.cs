using GCommon;
using UnityEngine;

namespace COW;

public class FrontEndPreviewConfigData : CSVBaseData
{
	public Vector4 ViewPort;

	public Vector4 BoostParams;

	public Vector4 BoostParamsBelow;

	public Vector3 AvatarScale;

	public Vector3 AvatarPos;

	public Vector3 AvatarRoation;

	public string StringFrontendPreviewType;

	public int CameraDepth;

	public int AvatarLightType;

	public int PreviewConfigIndex;

	public uint UintAvatarType;

	public int Fov;

	public bool ShowAvatarWithLobbyClothes;

	public bool NeedDisablePostEffect;

	public bool Preview3dModelNeedAdjustRotate;

	public bool HideClothWhenPreviewAvatarWithGun;

	public bool LaunchTagDisplayServerProgress;

	public bool NeedModifyAvatarAccordingToResulotion;

	public bool NeedPlayFacialAnim;

	public bool NeedStopEffect;

	public bool PlayPose;

	public bool UseRightPreviewAdapt;

	public bool OnlyShowKillNotifyOnce;

	public bool AutoShowBoostAvatar;

	public bool AutoCalculateBoostAvatarParams;

	public bool OwnedLaunchTagCheckTime;

	public bool SkipWeaponAnim;

	public bool IsShowShadow;

	public bool ShowSpecialClothesBg;

	public bool NeedSpecialIdle;

	public bool NeedShow360WeaponModel;

	public bool NeedDisplayWeaponProperty;

	public bool HasDifferentTypeBg;

	public bool NeedCameraMoveBG;

	public bool NeedToCreateUIFrontEndPreviewCtrl;

	public bool NeedShow3DBG;

	public bool NeedDisplayVehicleSkinScore;

	public bool BackpackAutoWearing;

	public bool BackpackAdjustRotation;

	public bool CreateCacheAvatarNeedPlaySpecialAnim;

	public FrontendPreviewType FrontendPreviewType;

	public FrontEndPreviewComponent.AvatarType AvatarType => FrontEndPreviewComponent.AvatarType.localAvatar;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public override void PostDeserializeData()
	{
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public Vector3 TransStringToVector3(string head, string[] headers, string[] values)
	{
		return default(Vector3);
	}

	public Vector4 TransStringToVector4(string head, string[] headers, string[] values)
	{
		return default(Vector4);
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}

	public void _003C_003EiFixBaseProxy_PostDeserializeData()
	{
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}
}
