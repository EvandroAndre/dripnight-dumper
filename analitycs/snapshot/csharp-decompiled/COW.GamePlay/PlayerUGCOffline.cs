using System.Collections.Generic;
using COW.GamePlay.UGCRuntime;
using COW.Gameplay.UGC;
using UMA;
using UnityEngine;
using message;

namespace COW.GamePlay;

internal class PlayerUGCOffline : Player, IUGCPlayer
{
	private LLIBLINGFLO CMKFNDMJBOG;

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

	public override void InitEntityInfo()
	{
	}

	public override void OnRecycle()
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

	public override void SwitchPhysXPose(EOGPGNIDOKF KCMJONOCMPN)
	{
	}

	public override bool CanAssistByUGC(float PHGFEGOEOLD)
	{
		return false;
	}

	public override void OnTransformerChanged(Transform FPMLOHFMGLP)
	{
	}

	public override bool CanAvatarTransform()
	{
		return false;
	}

	public override void ForceUpdateAnimatorUMAChangeCallBack(UMAData JCONDDPFBKK)
	{
	}

	public void PlayUGCEmoteClip(string JKBCAJGFALD, bool EBKFHNJGLON, bool IOGMBNAKEGN)
	{
	}

	public override bool IsCameraUseTargetBackOffset()
	{
		return false;
	}

	public override void InitProperties(object OOCMJCKJHMG, bool PGGEHAIHHFG = true)
	{
	}

	public List<UGCLogicEntity> AddItem(uint BCGFIJHEDBO, uint PNLDKNOFPNG)
	{
		return null;
	}

	public void RemoveItem(int BCGFIJHEDBO, int PNLDKNOFPNG)
	{
	}

	public void SwitchWeapon(int DBPNIDJEAAE)
	{
	}

	public override int TakeDamage(int PMNNBDDKCCE, BHGGAEEHJCO FNOOENEHBJP, GLLLEDKLLDA PMMCGNJHOOA = null, int HPPACPHIPCP = -1, Vector3 BAAJEMEJACH = default(Vector3), Vector3 KHNFEFFKMEB = default(Vector3), List<float> LFLPGCMLPFM = null, LOAEBBHPMEK AOJANNHGCEA = null, uint AHPBOLHPNMH = 0u)
	{
		return 0;
	}

	public override void Dead(int LPHNICDPDBN, uint ENJBDKJIKJO, BHGGAEEHJCO FNOOENEHBJP, bool IECLLKLGNME = false, bool GGLDMJEFGCG = true, bool FCGHCIOGMGK = false, bool FAJBOHLHDHO = false)
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

	public new void _003C_003EiFixBaseProxy_OnUpdate(float P0, float P1)
	{
	}

	public void _003C_003EiFixBaseProxy_OLGMHOMPFLD(float P0, float P1)
	{
	}

	public new Vector3 _003C_003EiFixBaseProxy_GetAttackableCenterWS()
	{
		return default(Vector3);
	}

	public void _003C_003EiFixBaseProxy_SwitchPhysXPose(EOGPGNIDOKF P0)
	{
	}

	public UGCCameraConfigRepItem _003C_003EiFixBaseProxy_get_CurrentCameraConfig()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_PKBKLINGCEI(UGCCameraConfigRepItem P0)
	{
	}

	public bool _003C_003EiFixBaseProxy_CanAssistByUGC(float P0)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnTransformerChanged(Transform P0)
	{
	}

	public bool _003C_003EiFixBaseProxy_CanAvatarTransform()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_ForceUpdateAnimatorUMAChangeCallBack(UMAData P0)
	{
	}

	public UGCBasicCameraEntity _003C_003EiFixBaseProxy_get_CurrentUGCCamera()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_ADEEADFMGLC(UGCBasicCameraEntity P0)
	{
	}

	public bool _003C_003EiFixBaseProxy_IsCameraUseTargetBackOffset()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_InitProperties(object P0, bool P1)
	{
	}

	public int _003C_003EiFixBaseProxy_TakeDamage(int P0, BHGGAEEHJCO P1, GLLLEDKLLDA P2, int P3, Vector3 P4, Vector3 P5, List<float> P6, LOAEBBHPMEK P7, uint P8)
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_Dead(int P0, uint P1, BHGGAEEHJCO P2, bool P3, bool P4, bool P5, bool P6)
	{
	}
}
