using System;
using System.Collections.Generic;
using UnityEngine;

namespace COW.GamePlay;

internal class PlayerForceTutorialLocal : PlayerForceTutorial
{
	private sealed class EFOIOBPKDNJ
	{
		public PlayerForceTutorialLocal KOKNHFGCGLN;

		public uint FCCLKPCBCDA;

		internal void NBBMJLKLLOK()
		{
		}
	}

	private sealed class OCMIEDADDAB
	{
		public PlayerForceTutorialLocal KOKNHFGCGLN;

		public bool LOBGHMOOMHK;

		public Action KEHKIKKCMBP;

		public Action FPOMKOPIJJL;

		internal void NFELIHFKJDD()
		{
		}

		internal void PJINBFBMCEO()
		{
		}

		internal void NOBHGCDINMF()
		{
		}
	}

	private float JMIJIINPKGM;

	private uint GJKJLMLKKEF;

	private ForceTutorialCameraAnimationManager OAOMFGIJMHI;

	private ForceTutorialSkillCameraManager BFJIAKDEAKA;

	private Transform NGAAPPLGOHA;

	private List<uint> FHMPEOMLLBK;

	public bool IsInvincible;

	private BJFAEJPOLOA PENKLBBHLHI;

	private Vector3 FOJHDIJBFNP;

	private Quaternion IKKJKGLBCBK;

	public BJFAEJPOLOA IHBJAGAJLDF
	{
		get
		{
			return BJFAEJPOLOA.None;
		}
		set
		{
		}
	}

	public void EnsureExecutionSkillData()
	{
	}

	public override void InitProperties(object OOCMJCKJHMG, bool PGGEHAIHHFG = true)
	{
	}

	public void InitAimRotation(Vector3 BAPEDKECNLH)
	{
	}

	public override int TakeDamage(int PMNNBDDKCCE, BHGGAEEHJCO FNOOENEHBJP, GLLLEDKLLDA PMMCGNJHOOA = null, int HPPACPHIPCP = -1, Vector3 BAAJEMEJACH = default(Vector3), Vector3 KHNFEFFKMEB = default(Vector3), List<float> LFLPGCMLPFM = null, LOAEBBHPMEK AOJANNHGCEA = null, uint FKDEIFDNMJD = 0u)
	{
		return 0;
	}

	public override void StopFire(FDAEPHMIEPC KEDHIAANLGO)
	{
	}

	private void PNMNGMJCNEL()
	{
	}

	private void GBDMCLEJLOP()
	{
	}

	public void DisableMoving()
	{
	}

	public void ResetSpeedAndState()
	{
	}

	public override void Dead(int LPHNICDPDBN, uint ENJBDKJIKJO, BHGGAEEHJCO FNOOENEHBJP, bool IECLLKLGNME = false, bool GGLDMJEFGCG = false, bool FCGHCIOGMGK = false, bool FAJBOHLHDHO = false)
	{
	}

	public void TakeHeal(int BPNHEGPBDHP)
	{
	}

	public void GiveIceWall(uint FFEEBMALOJD)
	{
	}

	public void GiveItem(uint GEHJJDLAGJJ, uint PAPBHPJKHOP)
	{
	}

	public void TeleportPlayerToDestination(LevelTutorialTrigger NFEMHCKDKOB)
	{
	}

	private Vector3 OPODIHOBALB(Vector3 PFJFADHEJLJ, Transform HEHAMAIDDHD)
	{
		return default(Vector3);
	}

	public void ChangeItemOnHand(HDAEFOANBGJ DBPNIDJEAAE)
	{
	}

	public bool GrenadeOnHand()
	{
		return false;
	}

	private void GBMFIMABJII()
	{
	}

	public void ActiveSkillTakeEffect()
	{
	}

	private void HMDKFMCLKCI(uint MDPGBPLMAFO)
	{
	}

	public void ChangeCamera()
	{
	}

	public void ChangeToSkillCamera(BJFAEJPOLOA CCNBNLAPJFM)
	{
	}

	public void ChangeBackToFolowCameraWithMask(bool LOBGHMOOMHK = false, bool LFGHOPIIJKB = true, Action KEHKIKKCMBP = null)
	{
	}

	public void ChangeBackToFolowCamera(bool LOBGHMOOMHK = false, float JDKLLDAPFHO = 1f)
	{
	}

	private void FBNGNDFHIPP()
	{
	}

	public void StartPlayAnim()
	{
	}

	public void AfterPlayOpeningAnimation()
	{
	}

	public Transform GetForceTutorialCameraReferenceTransform()
	{
		return null;
	}

	public ForceTutorialSkillCameraManager GetForceTutorialSkillCameraManager()
	{
		return null;
	}

	public Vector3 GetSavedCameraPosition()
	{
		return default(Vector3);
	}

	public Quaternion GetSavedCameraRotation()
	{
		return default(Quaternion);
	}

	protected override bool LNGHMIHPOAH(OKEAMEELLBB PFJFADHEJLJ)
	{
		return false;
	}

	public void ShowInGameUI()
	{
	}

	public void HideInGameUI()
	{
	}

	public new void _003C_003EiFixBaseProxy_InitProperties(object P0, bool P1)
	{
	}

	public new int _003C_003EiFixBaseProxy_TakeDamage(int P0, BHGGAEEHJCO P1, GLLLEDKLLDA P2, int P3, Vector3 P4, Vector3 P5, List<float> P6, LOAEBBHPMEK P7, uint P8)
	{
		return 0;
	}

	public new void _003C_003EiFixBaseProxy_StopFire(FDAEPHMIEPC P0)
	{
	}

	public new void _003C_003EiFixBaseProxy_Dead(int P0, uint P1, BHGGAEEHJCO P2, bool P3, bool P4, bool P5, bool P6)
	{
	}

	public bool _003C_003EiFixBaseProxy_LNGHMIHPOAH(OKEAMEELLBB P0)
	{
		return false;
	}
}
