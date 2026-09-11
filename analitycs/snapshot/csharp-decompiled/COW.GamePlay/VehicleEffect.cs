using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW.GamePlay;

internal class VehicleEffect : MonoBehaviour
{
	private enum CEDAAPILFGO
	{
		None,
		Low,
		Middle,
		High,
		Max
	}

	public enum PHIGBDKIDMO
	{
		None,
		Left,
		Right
	}

	public enum IMLAJFIKEFN
	{
		None,
		Front,
		Back,
		Tailing
	}

	private sealed class HCHFCENNIEP
	{
		public TrailRenderer NFCFLHBMKFA;

		public VehicleEffect KOKNHFGCGLN;

		internal void HCAKAPNGOAB()
		{
		}
	}

	private sealed class DKKOKOKDOFJ : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int CBPPJACCGOH;

		private object MHDKFGLHFKH;

		public VehicleEffect KOKNHFGCGLN;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public DKKOKOKDOFJ(int CBPPJACCGOH)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	public Vehicle attachVehicle;

	public PHIGBDKIDMO shoalEffectType;

	public GameObject shoalEffect;

	private VisualInstanceHolder IBJAIGIAEAA;

	public IMLAJFIKEFN m_WaterEffectType;

	public Transform m_WaterEffectPos;

	private VehicleInWaterEffectParams PBNPIIIAELD;

	public GameObject waterEffect;

	private VisualInstanceHolder FJBALEMCPAM;

	public ParticleSystem[] dustEffect;

	public GameObject[] dustGameObject;

	public Transform[] dustSpawnPos;

	public float dustSimSpeed;

	public Transform[] trailSpawnPos;

	public Transform hornPlayPos;

	private VisualInstanceHolder LBPLDKNEADE;

	public Transform maxSpeedLinePos;

	private bool FEMGKBJNDHM;

	private List<int> OIANKMAKMOM;

	protected List<int> HKPHDCFHBDN;

	private bool IELONEOGLFC;

	private CEDAAPILFGO NCGNNOJJIHL;

	private Coroutine JDOPIHGNNEP;

	private float MIIJDPJCPIG;

	private float BGBKJGDKAEC;

	private int JFFNABEIIFA;

	private int HCHLDGHLEFH;

	private bool NGBHOOBKBCP;

	private bool HCOAHLKLFBD;

	private List<TrailRenderer> DHJDLBDDDFC;

	private List<KHELHFKOEMA> FNLAFECKBON;

	private bool OCHKBAIBFOP => false;

	public bool FGMDKNNKGNJ => false;

	private void Awake()
	{
	}

	private void FixedUpdate()
	{
	}

	private void FPKELLPCOBI()
	{
	}

	private CEDAAPILFGO AEKFOMPDEGN()
	{
		return CEDAAPILFGO.None;
	}

	private bool JCBFJHLDBBN()
	{
		return false;
	}

	private bool EMGNDJFCILL()
	{
		return false;
	}

	private IEnumerator FLBMNDNDDNE()
	{
		return null;
	}

	private void HOJKBGMJMNM()
	{
	}

	private void PDAIFHFBCFM()
	{
	}

	private void JCHLMODGKKD(ParticleSystem KLMHOHAKFAK)
	{
	}

	private void DPGCPEOIFDF()
	{
	}

	private void APBCPAABHKP()
	{
	}

	private void ENJLJMCJOEI()
	{
	}

	public void SetVisible(bool OGECPGHMIHA)
	{
	}

	public void OnTriggerEnter(Collider GLJGHEAPBOF)
	{
	}

	public void OnTriggerExit(Collider GLJGHEAPBOF)
	{
	}

	private void JIABMAHDDCH()
	{
	}

	private ResourceID EJNMEAKHBLM()
	{
		return default(ResourceID);
	}

	private void PMPJGMNOKOO()
	{
	}

	private ResourceID LFBDDOPMNBI()
	{
		return default(ResourceID);
	}

	private void EOCJOEKOAOC(ref VisualInstanceHolder IDMFJBFINDH, ResourceID AOFCDPKJKJO, bool EOGOGFLCEHL, Transform FKODMCNOBDM, bool KBCHPBFCGAK)
	{
	}

	private void MAOHHAIFHFM(GameObject CLACOPMJHDI)
	{
	}

	public void UpdateWaterEffects(bool NCPIMBDABPG, float DHKLOLJALAN)
	{
	}

	private bool EPGHIIAGBFF()
	{
		return false;
	}

	public void PlayHorn(bool OGECPGHMIHA)
	{
	}

	private void BFNKJHEIEHN()
	{
	}
}
