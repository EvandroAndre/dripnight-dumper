using UnityEngine;

namespace COW.GamePlay;

internal class VehicleCameraBase : CameraControllerBase, COW.GamePlay.CALHLIPMGMD<UGCCameraConfigRepItem>
{
	protected static uint DAEPJDKODIM;

	public float TargetFieldOfView;

	public float MinimumFOV;

	public float MaximumFOV;

	public float MaximumTilt;

	public float HeightDamping;

	public float RotationDamping;

	public float MaxRotationDamping;

	private float LDBMFEKCKJN;

	protected BCEAFFIEMBF KCPHHBLLLIN;

	protected float BDDDHNEOJDH;

	protected float AOGKJGEIKKE;

	private float _003CCENGDFDMFGN_003Ek__BackingField;

	private float _003CCJKIFDEFAIE_003Ek__BackingField;

	protected Vector3 GDGDJGMPAGK;

	protected float KBNECNINHEL;

	protected GMPGMPFNMFP PCMBDGJNBCB;

	public float PGCPFOAJHBM
	{
		set
		{
		}
	}

	public float PJNJPJJHGOG
	{
		set
		{
		}
	}

	public float HNCFNEAOAHH
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float BOKIHGPOOEA
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	protected override void ODOLOHHIKGN()
	{
	}

	public override void OnCameraChanged()
	{
	}

	protected bool OEPMCGABHIH(Vector3 CJPGEEBADCD, Vector3 BPCFPPMHPGJ, out Vector3 ODKCMGKELLL)
	{
		ODKCMGKELLL = default(Vector3);
		return false;
	}

	public float CalculateCollisionBackOffset(Vector3 MNBPEEDKIAD, Vector3 DEHAJEONOJM, float EHEDPFODENC, string KIGMDNDHFBD = null)
	{
		return 0f;
	}

	public void RefreshState(UGCCameraConfigRepItem PIHEOEJAPPO)
	{
	}

	public void InitManually(KMBEHIGOKNF LAIDKEINKFG, float FFADCBDFANJ, float HMCHAKDHAKE, float GOKHJBJHCLK, float CGGPBJKCDEG, Vector3 DFNHOKCIIJK, NHMBEJGPEMP CJPNFPLEDPA, CIDCDEOCLBA OAGMEDEPKML, FDACAOPGNJK FPJMDJMMDBL)
	{
	}

	public void UninitManually()
	{
	}

	public void _003C_003EiFixBaseProxy_ODOLOHHIKGN()
	{
	}

	public void _003C_003EiFixBaseProxy_OnCameraChanged()
	{
	}
}
