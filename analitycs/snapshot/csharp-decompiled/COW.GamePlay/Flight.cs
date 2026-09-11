using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW.GamePlay;

internal class Flight : MonoBehaviour
{
	public GameObject m_HighSpeedEffect;

	public GameObject m_MidSpeedEffect;

	public GameObject m_LowSpeedEffect;

	private AudioResource LCOAAIEHJDO;

	private AudioResource KNNINLKIEIA;

	private ResourceID LLCGCEDKBNG;

	private JLINJFLJGIB HNEENAHAKKF;

	private float CHLNCAKFLGA;

	private const float JOMGCNCIJIH = 0.1f;

	private bool JDAEONDHFPP;

	public Animator m_Animator;

	public Animator m_EffectAnimator;

	public List<Animator> m_AppendEffectAnimatorList;

	public CBEPFDCGBKB AnimaitonType;

	public Transform m_PlayerSeat;

	private string FLJAACJFMID;

	private List<Renderer> KFGJGABAOIJ;

	private void Awake()
	{
	}

	public void SetHorizontalSpeed(float IMKNJGHAHPI)
	{
	}

	public void SetSkyStatus(JLINJFLJGIB OLFCNLCGNIK)
	{
	}

	public void PlayStartFlightSkyDiving(bool BKNCALEFCOJ)
	{
	}

	public void SetFlightLevelSoundRes(ResourceID CMLHINMCENL)
	{
	}

	public void PlayFlightLevelSoundID(ResourceID CMLHINMCENL)
	{
	}

	public void StopFlightLevelSoundID()
	{
	}

	public void PlayFlightSkyDivingLoopSound(ResourceID FFKCPJAPOJI)
	{
	}

	public void StopFlightSkyDivingLoopSound()
	{
	}

	public void PlayStartFlightParachuting(bool MGLHDLJHDMO)
	{
	}

	public void PlayStartSkyDriving(bool MGLHDLJHDMO, bool ALPOEMOMFOJ = false)
	{
	}

	public void SetSkydivingSpeed(float HCGJCOGLGDL)
	{
	}

	public void SetSkysurfingSpeed(float HCGJCOGLGDL)
	{
	}

	public void UpdateEffect()
	{
	}

	public void AppendAnimSetTrigger(string JCIFFMHHBHK, bool HEFMPLEIDDB = false)
	{
	}

	public void SetVisible(bool KGOHDEBHENF)
	{
	}

	public Transform GetPlayerSeat()
	{
		return null;
	}

	public void PlayOpeningAnim()
	{
	}

	public void PlayLandAnimEffect()
	{
	}

	public void PlayFlightLevel()
	{
	}
}
