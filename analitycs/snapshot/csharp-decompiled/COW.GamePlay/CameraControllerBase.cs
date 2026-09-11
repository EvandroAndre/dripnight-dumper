using UnityEngine;

namespace COW.GamePlay;

internal abstract class CameraControllerBase : MonoBehaviour
{
	public CameraControllerManager m_Manager;

	public bool ClearTargetOnDisableOnce;

	protected Camera ALGPBKBHFAL;

	protected FDACAOPGNJK PINPCAAAFIL;

	protected Transform KKEIFKMPONM;

	protected OGKLHMFJGIG OMPCJEIDJML;

	private EKDONCPJPLJ _003CFGMGKEHKAID_003Ek__BackingField;

	private float _003CGOPLAFJGDED_003Ek__BackingField;

	private float _003CIEPLPBKOIJH_003Ek__BackingField;

	protected NDDJDACNGDF MPOIJNEFANB;

	protected bool POGPMGFAABL;

	public Camera EDKHMJLPAAO
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public FDACAOPGNJK MFAGHGKLBKH
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Transform IBNDLMBBEDB => null;

	public EKDONCPJPLJ BNJPACCMJEJ
	{
		get
		{
			return EKDONCPJPLJ.Default;
		}
		protected set
		{
		}
	}

	public float DPMIFADBJMN
	{
		get
		{
			return 0f;
		}
		protected set
		{
		}
	}

	public float OEJMHJACNFB
	{
		get
		{
			return 0f;
		}
		protected set
		{
		}
	}

	public virtual Vector3 FNAMPFFAMBD => default(Vector3);

	public virtual Quaternion DEIEGHLADGP => default(Quaternion);

	private void OnDisable()
	{
	}

	public void StartCameraShake(float CNKMEPFCJOM, float LLJBJNFLEJJ)
	{
	}

	public void EndCameraShake()
	{
	}

	public void StartEnforcedCameraShake(float CNKMEPFCJOM, Vector2 DIEOCHCOJDE, bool KOHINJIFPGG = false)
	{
	}

	public void EndEnforcedCameraShake()
	{
	}

	private void LateUpdate()
	{
	}

	protected virtual void AAJBLNPFLOB()
	{
	}

	protected virtual void ODOLOHHIKGN()
	{
	}

	public virtual void OnCameraChanged()
	{
	}

	public virtual void OnCameraUnLoaded()
	{
	}

	public void SetCameraBlockType(NDDJDACNGDF CCNBNLAPJFM)
	{
	}
}
