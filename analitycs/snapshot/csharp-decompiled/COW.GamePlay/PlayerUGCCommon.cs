using System.Collections.Generic;
using COW.GamePlay.UGCRuntime;
using COW.Gameplay.UGC;
using UMA;
using UnityEngine;
using message;

namespace COW.GamePlay;

internal class PlayerUGCCommon : PlayerNetwork, IUGCPlayer
{
	public override int OBGCODAEDHG => 0;

	public override UGCFactionRepItem GONPAHPNHKH
	{
		get
		{
			return null;
		}
		protected set
		{
		}
	}

	public override UGCTeamRepItem CPHIFMPOLAE
	{
		get
		{
			return null;
		}
		protected set
		{
		}
	}

	public override UGCCameraConfigRepItem BLHIJJLBGDN
	{
		get
		{
			return null;
		}
		protected set
		{
		}
	}

	public override UGCBasicCameraEntity BPIHFAEPHFC
	{
		get
		{
			return null;
		}
		protected set
		{
		}
	}

	GameObject IUGCPlayer.gameObject => null;

	protected override void LMNGOJOJFNM()
	{
	}

	protected override void OnUserDefineReplicationInfo()
	{
	}

	public override void InitEntityInfo()
	{
	}

	public override void OnRecycle()
	{
	}

	protected override bool LNGHMIHPOAH(OKEAMEELLBB PFJFADHEJLJ)
	{
		return false;
	}

	public override bool CanAssitByWeapon(Player KALJPOOLDAD, FDAEPHMIEPC KEDHIAANLGO)
	{
		return false;
	}

	public override void ForceUpdateAnimatorUMAChangeCallBack(UMAData JCONDDPFBKK)
	{
	}

	public override void OnUpdate(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	protected override void OLGMHOMPFLD(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	public override Vector3 GetAttackableCenterWS()
	{
		return default(Vector3);
	}

	protected override void OnOnDestroy()
	{
	}

	public override bool IsCameraUseTargetBackOffset()
	{
		return false;
	}

	public override void SwitchPhysXPose(EOGPGNIDOKF KCMJONOCMPN)
	{
	}

	public override bool CanAvatarTransform()
	{
		return false;
	}

	public override void OnTransformerChanged(Transform FPMLOHFMGLP)
	{
	}

	public override bool CanAssistByUGC(float PHGFEGOEOLD)
	{
		return false;
	}

	public void PlayUGCEmoteClip(string JKBCAJGFALD, bool EBKFHNJGLON, bool IOGMBNAKEGN)
	{
	}

	public override bool ShouldHideSkins4UGC(string GNJHNAEHEFP)
	{
		return false;
	}

	public override void UpdateWeaponSkinsMapping4UGC(List<uint> IFPMKHEHOHL)
	{
	}

	public override uint GetWeaponOriginalSkinID4UGC(uint LPHNICDPDBN)
	{
		return 0u;
	}

	public override uint GetWeaponPropertySkinID4UGC(uint LPHNICDPDBN)
	{
		return 0u;
	}

	public override uint GetWeaponBuffSkinID4UGC(uint LPHNICDPDBN)
	{
		return 0u;
	}

	public override void UpdateVehicleSkinMap4UGC(List<uint> OCIEGHKALIJ)
	{
	}

	public override SortedList<uint, uint> GetWeaponSkinIDs4UGC()
	{
		return null;
	}

	public new void _003C_003EiFixBaseProxy_OnUserDefineReplicationInfo()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUpdate(float P0, float P1)
	{
	}

	public void _003C_003EiFixBaseProxy_LMNGOJOJFNM()
	{
	}

	public new void _003C_003EiFixBaseProxy_InitEntityInfo()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnRecycle()
	{
	}

	public bool _003C_003EiFixBaseProxy_LNGHMIHPOAH(OKEAMEELLBB P0)
	{
		return false;
	}

	public new bool _003C_003EiFixBaseProxy_CanAssitByWeapon(Player P0, FDAEPHMIEPC P1)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_ForceUpdateAnimatorUMAChangeCallBack(UMAData P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OLGMHOMPFLD(float P0, float P1)
	{
	}

	public new Vector3 _003C_003EiFixBaseProxy_GetAttackableCenterWS()
	{
		return default(Vector3);
	}

	public new void _003C_003EiFixBaseProxy_OnOnDestroy()
	{
	}

	public int _003C_003EiFixBaseProxy_get_UGCFactionIndex()
	{
		return 0;
	}

	public UGCFactionRepItem _003C_003EiFixBaseProxy_get_UGCFactionEntity()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_DINKHOACMLM(UGCFactionRepItem P0)
	{
	}

	public UGCTeamRepItem _003C_003EiFixBaseProxy_get_UGCTeamEntity()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_LCFDKJLPGBF(UGCTeamRepItem P0)
	{
	}

	public bool _003C_003EiFixBaseProxy_IsCameraUseTargetBackOffset()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_SwitchPhysXPose(EOGPGNIDOKF P0)
	{
	}

	public bool _003C_003EiFixBaseProxy_CanAvatarTransform()
	{
		return false;
	}

	public UGCCameraConfigRepItem _003C_003EiFixBaseProxy_get_CurrentCameraConfig()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_PKBKLINGCEI(UGCCameraConfigRepItem P0)
	{
	}

	public UGCBasicCameraEntity _003C_003EiFixBaseProxy_get_CurrentUGCCamera()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_ADEEADFMGLC(UGCBasicCameraEntity P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnTransformerChanged(Transform P0)
	{
	}

	public bool _003C_003EiFixBaseProxy_CanAssistByUGC(float P0)
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_ShouldHideSkins4UGC(string P0)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_UpdateWeaponSkinsMapping4UGC(List<uint> P0)
	{
	}

	public uint _003C_003EiFixBaseProxy_GetWeaponOriginalSkinID4UGC(uint P0)
	{
		return 0u;
	}

	public uint _003C_003EiFixBaseProxy_GetWeaponPropertySkinID4UGC(uint P0)
	{
		return 0u;
	}

	public uint _003C_003EiFixBaseProxy_GetWeaponBuffSkinID4UGC(uint P0)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_UpdateVehicleSkinMap4UGC(List<uint> P0)
	{
	}

	public SortedList<uint, uint> _003C_003EiFixBaseProxy_GetWeaponSkinIDs4UGC()
	{
		return null;
	}
}
