using System.Collections.Generic;
using UnityEngine;
using message;

namespace COW.GamePlay;

public class LevelReviveBox : BaseLevelObject
{
	public enum HOFKACMGEMK
	{
		Create,
		Remove
	}

	public enum JAJADDAJAKO
	{
		StartInteract,
		FinishInteract,
		CancelInteract
	}

	public SphereCollider m_Trigger;

	private ModelReviveBox DAAFGKPMOAL;

	private BHGGAEEHJCO PPOGLHKJCFI;

	private float POODBNCCPLC;

	private uint PJHNEGLIODK;

	private float GDCDDDDODAC;

	private float ABDMBBLGONB;

	public static uint LocalPlayerIntaractingID;

	private uint KJFPKLHHKFI;

	private bool NIDCOMLLIGC;

	private static readonly HashSet<uint> FMKEPBHMKHF;

	protected override string GetObjectTag()
	{
		return null;
	}

	protected override void OnUserDefineReplicationInfo()
	{
	}

	protected override int GetMaxRepDataCount()
	{
		return 0;
	}

	public override void SyncAction(object[] DJAPBCKDFKA)
	{
	}

	private void MPGLMIDLLPA(OGIMOACLPNO CBCAJJJCKLH)
	{
	}

	private void MGHFBHJOMIE()
	{
	}

	protected override void OnModelShowed()
	{
	}

	public override void DoAction(object[] DJAPBCKDFKA)
	{
	}

	private void OCHDAAKJPDJ(byte LALADOJHOBE, byte GCJPAAPKMMA)
	{
	}

	private void LHHLGCBNHML(float BCIDOHFCFHH, float MEHFHONHCAB)
	{
	}

	private void JAJNHJJELPK(uint JKEFHGNCKOP, uint LOKKNIBPCMM)
	{
	}

	private void MAHDLICBEKG(uint KMGMHMCKGID, uint AILJPICPIAF)
	{
	}

	public CJFLIDJPBIG GetState()
	{
		return CJFLIDJPBIG.EReviveBoxState_Waiting;
	}

	public float GetProgress()
	{
		return 0f;
	}

	public BHGGAEEHJCO GetInteractingPlayerID()
	{
		return default(BHGGAEEHJCO);
	}

	public BHGGAEEHJCO GetBindPlayerID()
	{
		return default(BHGGAEEHJCO);
	}

	public uint GetMaxTimes()
	{
		return 0u;
	}

	public uint GetUsedTimes()
	{
		return 0u;
	}

	public float GetSelfRemainingSeconds()
	{
		return 0f;
	}

	public float GetSelfRemainingPercent()
	{
		return 0f;
	}

	private void HKLPBMCHHEM()
	{
	}

	public float GetInteractDuration()
	{
		return 0f;
	}

	public bool CanStartInteract()
	{
		return false;
	}

	private bool PAEKEMLIHJP()
	{
		return false;
	}

	private void NMLJKNFLCDB(float DBEJONOGLFN)
	{
	}

	private void FOBOEBAEFDF()
	{
	}

	private void FNBAJCDEICC()
	{
	}

	private void AHGCNCPNNMP(float DBEJONOGLFN)
	{
	}

	private void GOGMEHDKHKH()
	{
	}

	private void PCABIKNHJBI()
	{
	}

	private void DPCBJEAKMFE(bool EOGOGFLCEHL)
	{
	}

	public void OnTriggerEnter(Collider GLJGHEAPBOF)
	{
	}

	public void OnTriggerExit(Collider GLJGHEAPBOF)
	{
	}

	private bool NNDHNPNOCPB(Collider GLJGHEAPBOF)
	{
		return false;
	}

	private void BEFIKABGFGO()
	{
	}

	private static void EKEIDJHLHHL()
	{
	}

	private void OnDisable()
	{
	}

	public override void OnRecycle()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUserDefineReplicationInfo()
	{
	}

	public int _003C_003EiFixBaseProxy_GetMaxRepDataCount()
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_SyncAction(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnModelShowed()
	{
	}

	public void _003C_003EiFixBaseProxy_DoAction(object[] P0)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnRecycle()
	{
	}
}
