using GCommon;
using UnityEngine;
using message;

namespace COW.GamePlay;

internal class LevelSwingSpider : BaseLevelObject
{
	private enum EELMNLEHLLN
	{
		FLYING,
		ATTACHED,
		DESTROY
	}

	public Transform LineSocket;

	public LineRenderer Line;

	private GMECHKEDOJP ADECKCPNEBN;

	private EDDCGAGJBLO JJMOJGHDLIF;

	private BHGGAEEHJCO ECMHBHDLCOM;

	private Vector3 HOBBHNMNKKM;

	private Vector3 HPKLMDKGEML;

	private Vector3 FDLOHHDHAOK;

	private Vector3 JHFOIGFPMOH;

	private ResourceID DNBAKKCEFLI;

	private GMPGMPFNMFP HAJANADDJJK;

	private bool PIBNCKGHIGP;

	private EELMNLEHLLN PNJHIKMOBHC;

	private float MLIFKEOMFCJ;

	private float MFHDNGPCLJM;

	private bool INEFOJHLMFL;

	private Vector3 KOOCMIEFLBB;

	private bool BOHMKHKMEBH;

	public float CurSwingAngle;

	public float InitSwingAngle;

	public float SwingLength;

	public Vector3 RealSwingPivot;

	public float AngleVelocity;

	public Vector3 Dir2Swing;

	public uint SwingMode;

	public Quaternion SwingRotation;

	public float TargetRoll;

	public float RollSpeed;

	public GMECHKEDOJP ABHCIOHBIEF
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public EDDCGAGJBLO OGAOCNNHACP
	{
		get
		{
			return default(EDDCGAGJBLO);
		}
		set
		{
		}
	}

	public Vector3 AALEAHDJAMC => default(Vector3);

	public Vector3 KELNEHHBOLG => default(Vector3);

	public Vector3 BDPCMDMPBLG
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	protected override string GetObjectTag()
	{
		return null;
	}

	private Vector3 HEMCBJACONC()
	{
		return default(Vector3);
	}

	private Player BMEMFCCMAIN()
	{
		return null;
	}

	private void Reset()
	{
	}

	public void OnResSpawn(Player PGEGMKJKOKI, PADOHDCCBIB NBLHNPAHGNA, ResourceID OCCLMDNGINA)
	{
	}

	public void OnResAttached(Vector3 EOINMGLCHJD)
	{
	}

	private void OPHHBGFKIOA(Player PGEGMKJKOKI)
	{
	}

	public void OnResDel(byte OINKNIGKDMO)
	{
	}

	public void OnSyncForReEnter(Player PGEGMKJKOKI, BKILKGHJJGB NBLHNPAHGNA, ResourceID OCCLMDNGINA)
	{
	}

	public override void OnRecycle()
	{
	}

	public override bool Recycle()
	{
		return false;
	}

	private void IAPGAAKMBFD()
	{
	}

	public override void OnFixedUpdate(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	private Vector3 AAPGAJKGHJD(Player KDJNEHDAAFL)
	{
		return default(Vector3);
	}

	private void LateUpdate()
	{
	}

	public void OnOwnerGetOff()
	{
	}

	public void HideLine()
	{
	}

	private void PDLAMOEADAK(byte OINKNIGKDMO)
	{
	}

	public Vector3 FixedFinalPos()
	{
		return default(Vector3);
	}

	public Vector3 GetSwingForward()
	{
		return default(Vector3);
	}

	private float PJENGABHEMB(float BAGMCFGCACD)
	{
		return 0f;
	}

	public Vector3 CalcPlayerTowVelocity()
	{
		return default(Vector3);
	}

	public new void _003C_003EiFixBaseProxy_OnRecycle()
	{
	}

	public new bool _003C_003EiFixBaseProxy_Recycle()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnFixedUpdate(float P0, float P1)
	{
	}
}
