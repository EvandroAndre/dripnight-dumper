using GCommon;
using UnityEngine;

namespace COW.GamePlay;

internal class VehicleDriverCamera : VehicleCameraBase
{
	private enum AJAIJOLPCNC
	{
		None,
		PreMove,
		Aiming,
		PostMove,
		ResetFree
	}

	private class DABMFIDFJGA
	{
		public Vector3 JLIGFBBECMC;

		public Quaternion IKKKHHFJKPF;
	}

	private class CLKBFAMHAIM
	{
		private float[] JCONDDPFBKK;

		private int DFDAPIDCHMF;

		private int NOFMENDCLPK;

		private int BCBPFCMLJAF;

		private float _003CJNMKFIILNIG_003Ek__BackingField;

		public float CCGLDPJGMMD
		{
			get
			{
				return 0f;
			}
			protected set
			{
			}
		}

		public int NHPFOMNHMGM => 0;

		public CLKBFAMHAIM(int LBFBCOIHEJO)
		{
		}

		public float JIOPAGNLPBF(float PCOPDDLBLMI)
		{
			return 0f;
		}

		public float GKGJNLPEBDA()
		{
			return 0f;
		}
	}

	public static VehicleDriverCamera Instance;

	public int Samples;

	public float AccThreshold;

	public float MaxAdditionalDist;

	public float MinAdditionalDist;

	public float m_CurrentAdditionalDist;

	public float AdditionalDistAccSpeed;

	public float AdditionalDistDecSpeed;

	public float AdditionalDistLerpSpeed;

	public bool DetailedCollisionChecks;

	public bool TransToWantedHeightOnce;

	private Vehicle FFKNHOHOJFH;

	private Transform KLEBNCGMEMK;

	private bool AHPANMAOGEP;

	private CLKBFAMHAIM BIAIIFKOPHN;

	private CLKBFAMHAIM GLIDGLIMHFF;

	private UserControlAxisData BHDNADJKJAL;

	private UserControlAxisData CIGNIAIKBGG;

	private UserControlAxisData FDGKANLDFJC;

	public float m_ControlEularsLerpSpeed;

	public float m_ControlDirLerpSpeed;

	public float m_ControlRotScaleX;

	public float m_ControlRotScaleY;

	public float m_AimSensitivity;

	private Quaternion FLNPONDMJED;

	private Quaternion HBFBLBPMMCJ;

	private bool CNLNHFGAKDF;

	private Vector3 PODCKGGILAK;

	public float m_ControlDirectionResetTime;

	public float ControlDirectionLerp;

	public bool m_MultBaseRot;

	private float MDCKPFGKJIO;

	private bool OLHAOPPGMIG;

	private bool _003CENFCGHNEJHE_003Ek__BackingField;

	private UserControlAxisData HNPPDABKACF;

	private const float HMLFOJOLJDF = 40f;

	private const float APBKIAHCOEE = 60f;

	private AJAIJOLPCNC HKDCDCAMCBG;

	private DABMFIDFJGA APKHKONMDIH;

	private DABMFIDFJGA HIJBOJOEKOE;

	private DABMFIDFJGA BLGBIPHIGBM;

	public float AimPosLerpSpeed;

	public float AimRotLerpSpeed;

	public bool IsHelicopter;

	public Vector3 EulerAngleOffset;

	public bool HBPPKJLNDMA
	{
		get
		{
			return false;
		}
		protected set
		{
		}
	}

	public bool HEKELGMLLHK => false;

	protected override void ODOLOHHIKGN()
	{
	}

	private UserControlAxisData KFOMHNHCJDO(int JGPBCBHECJE)
	{
		return null;
	}

	private bool KGCEDMGGJEB()
	{
		return false;
	}

	private void IDFAGLMFLFP()
	{
	}

	protected override void AAJBLNPFLOB()
	{
	}

	private void HJKEHBGOJHF()
	{
	}

	private void CCEHOEPPBCF(Vector3 AKEONFDELJK)
	{
	}

	private bool FOEIEELFMDN()
	{
		return false;
	}

	private bool MFLMJNHNOMJ()
	{
		return false;
	}

	public void StartAiming()
	{
	}

	public void StopAiming()
	{
	}

	private void PPGJPEHBMMA()
	{
	}

	private void FAKDJJEKJDA()
	{
	}

	private void PPNNLKIMAGD()
	{
	}

	private void FHCDIPJELFE(ref DABMFIDFJGA CKIOPFBGFKB, Transform MJIFGJPGLAM)
	{
	}

	private void HIGOHLBPIHP(ref Vector3 HDFILHFDBKB, ref Quaternion IPKKCHLDJMA)
	{
	}

	private void FHCDIPJELFE(ref DABMFIDFJGA CKIOPFBGFKB, Vector3 MJIFGJPGLAM)
	{
	}

	private bool NNPEKPIJICI(DABMFIDFJGA IDNFJMOLNPH, DABMFIDFJGA BDIKGCJGOCG, float HKJKEJONGMC)
	{
		return false;
	}

	private bool NNPEKPIJICI(DABMFIDFJGA IDNFJMOLNPH, Vector3 HDFILHFDBKB, Quaternion IPKKCHLDJMA, float HKJKEJONGMC)
	{
		return false;
	}

	private void HADJOAMOPEG(ref Vector3 HDFILHFDBKB)
	{
	}

	public override void OnCameraChanged()
	{
	}

	public void EnableFreeCamera(bool AOOAGBBHDFA)
	{
	}

	public bool NeedBlend2BaseRot(out float HIAIHOIFBHL)
	{
		HIAIHOIFBHL = default(float);
		return false;
	}

	public bool HelicopterNeedBlendAim(out float HIAIHOIFBHL)
	{
		HIAIHOIFBHL = default(float);
		return false;
	}

	public new void _003C_003EiFixBaseProxy_ODOLOHHIKGN()
	{
	}

	public void _003C_003EiFixBaseProxy_AAJBLNPFLOB()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnCameraChanged()
	{
	}
}
