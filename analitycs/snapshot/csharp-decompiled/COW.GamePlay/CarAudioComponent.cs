using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW.GamePlay;

internal class CarAudioComponent : MonoBehaviour
{
	public enum CAOOAAMEPAI
	{
		Simple,
		FourChannel
	}

	public CAOOAAMEPAI engineSoundStyle;

	public float pitchMultiplier;

	public float lowPitchMin;

	public float lowPitchMax;

	public float highPitchMultiplier;

	public float maxRolloffDistance;

	public float dopplerLevel;

	public bool useDoppler;

	public string HighAccelerationResourceName;

	public string StartUpResourceName;

	public string StopResourceName;

	public string SkidResourceName;

	private AudioSource DDFLFACIOOI;

	private AudioSource KOILLMFPEKM;

	private AudioSource CLIILMINOIJ;

	private AudioSource JFDNIOCBEEP;

	private AudioSource FIENMBHPBLE;

	private ResourceID DEIDLNHPICH;

	private ResourceID MLEIMFOECGG;

	private ResourceID DDNDJFMEOJG;

	private bool DPNDDJIEHON;

	private VehicleControllerInterface BLNLPBECAOA;

	private Vehicle BIIDAJKPALH;

	private bool LIIJJOCHBCF;

	private bool MACEBMJFDKG;

	private Dictionary<AudioClip, AudioSource> AMAOMIFPNAI;

	private bool NPNDCGCJKIK;

	private bool CMGDNKNKKBD;

	private int KEPCIIIFJGE;

	private bool FACPFCFEGKM;

	private bool JBCDKFEAMIC;

	public void StartSound(bool PBOLJALBIJJ)
	{
	}

	public void StopSound()
	{
	}

	private float DNCGAPHFAOH()
	{
		return 0f;
	}

	public void OnVisibleChanged(bool KGOHDEBHENF)
	{
	}

	private void CGEMPPKBHNF()
	{
	}

	private void Update()
	{
	}

	private AudioSource FOHPDJFMBAF(ResourceID NBMCCBJNFOK, bool CFGAMFIMLMD = true)
	{
		return null;
	}

	private void POLEBGIGPKJ(ref AudioSource ANEJGNJCJEB, ref AudioSource LBGOPHDLJKH)
	{
	}
}
