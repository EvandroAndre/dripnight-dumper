using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW.GamePlay;

internal class OilDrums : AttackableEntity
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__16_0;

		internal void HEAKPKCGENA()
		{
		}
	}

	public GameObject m_OildrumNode;

	public GameObject m_BrokenNode;

	public VFXCreateHelper m_PreNode;

	public GameObject m_FlowingEffectNode;

	public GameObject m_ScalableEffectNode;

	private GameObject MOKFNGIBINJ;

	private uint DLKAEKHLIPP;

	private uint NMEAKIFBEKO;

	private LevelBaseDrum OEEKHHGJODG;

	private VisualInstanceHolder BCLCNBJBAHC;

	private VisualInstanceHolder CGCLELMADGI;

	private uint ODLMBJEBBAA;

	private uint GBEFFBHLLLJ;

	private JHPCDFDGGMK MAOHIOEAMEA;

	protected override int GetMaxRepDataCount()
	{
		return 0;
	}

	internal void LMNGOJOJFNM(LevelBaseDrum BEMBPBCCGJM)
	{
	}

	public override void TakeDamage(GLLLEDKLLDA PMMCGNJHOOA, LOAEBBHPMEK AOJANNHGCEA = null, List<float> LFLPGCMLPFM = null, uint FKDEIFDNMJD = 0u)
	{
	}

	public LevelBaseDrum.NLNIACDLBGF GetOilDrumType()
	{
		return LevelBaseDrum.NLNIACDLBGF.None;
	}

	public void SetOilDrumState(JHPCDFDGGMK CBCAJJJCKLH)
	{
	}

	private void PIBCHEJFDDA(bool EOGOGFLCEHL)
	{
	}

	private void FAIMFEGDMCE()
	{
	}

	private void HINFHHCGDFP(bool EOGOGFLCEHL)
	{
	}

	public void TryStopHideBrokenNodeDelayCall()
	{
	}

	public void PlayExplodeEffect(uint KIJMNGPDLCO)
	{
	}

	public void StopExplodeEfect()
	{
	}

	public void InitAllNodes()
	{
	}

	public void OnUpdate()
	{
	}

	private void MLDDLHLEEIC()
	{
	}

	public void _003C_003EiFixBaseProxy_TakeDamage(GLLLEDKLLDA P0, LOAEBBHPMEK P1, List<float> P2, uint P3)
	{
	}
}
