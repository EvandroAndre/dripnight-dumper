using System.Collections.Generic;
using COW.GamePlay.UGCRuntime;
using UnityEngine;

namespace COW.GamePlay;

public class UGCEradicateZone : BaseAutoGenIDLevelObject
{
	private enum CGBJAIMHNDK
	{
		None = 0,
		End_State = 1,
		Pos_State = 2,
		Scale_State = 4,
		Sync_Finished = 7
	}

	private enum DDJEJCPKDMN
	{
		None,
		Wait,
		Stay,
		Shrinking,
		End,
		NoReset
	}

	public float SafeZoneHeight;

	private readonly List<Renderer> PCLAOBMKFAN;

	public Transform cylinder;

	public Transform center;

	public uint GroupID;

	private DDJEJCPKDMN MAOHIOEAMEA;

	private int LGKKLHPAAMA;

	private int POJBIOPGHGJ;

	private Vector3 OCLFLNINDAP;

	private Vector3 BMEBLGLGMNK;

	private Vector3 HOLNGIPGLMB;

	private Vector3 FGDAKKAFMBI;

	private float KPOCFACIBDN;

	private float JNPIOADKCDO;

	private float KAEFDJLABAG;

	private bool HCGHOHCFNND;

	private Color HGIAFAHPKDA;

	private bool BIPAJOAEGPD;

	private bool AKIPCGBEPFH;

	private float EHBLAGGGJJP;

	private bool CPGPNNHDHKC;

	private CGBJAIMHNDK CFDBODPDCEC;

	private EDNBIGCAAJI NIDMEONBAHL;

	public bool CBJEALJDEKM => false;

	public bool DEDPACFBKMB => false;

	private MCDLKHAOJJG CMKLCCIEJCO => null;

	private EDNBIGCAAJI DAPHFFOAFCL => null;

	public Vector3 ELECEGLAPPC => default(Vector3);

	public Color GENBHHMPBDE
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	public bool ODECAADMPEH => false;

	public bool MFJPLIBJCOF => false;

	public bool DJDIMMFEKAK => false;

	private void OACPENCBKKI(Color EKPCLIALINJ)
	{
	}

	protected override void OnAwake()
	{
	}

	private void OnDestroy()
	{
	}

	protected override string GetObjectTag()
	{
		return null;
	}

	public override bool CreateDynamicallyForUGC(string GDDEBLAFLLG)
	{
		return false;
	}

	public void SetModelVisible(bool DMLJCJFNPGI, bool PPNKPFKIFEC, bool IBDNJDLJPDG)
	{
	}

	public override bool RemoveDynamicallyForUGC(string GDDEBLAFLLG)
	{
		return false;
	}

	public override void OnSyncUGCEntityProperty(long OGDNBBJKNFD, UGCSimpleValue EIOKHLKJEEL)
	{
	}

	private void GKHMBENPIKP(int EIOKHLKJEEL)
	{
	}

	private void JCAFDBFENCG(DDJEJCPKDMN CBCAJJJCKLH)
	{
	}

	private void PPPHBBHOCFG()
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	private void BBIIKGPFJDP()
	{
	}

	public void SetShowDirty(bool EOGOGFLCEHL)
	{
	}

	public float GetRealRadius()
	{
		return 0f;
	}

	public float GetRadius()
	{
		return 0f;
	}

	public void SetRadius(float NMEEAHMNACE)
	{
	}

	public void UpdateSize()
	{
	}

	public void SetCylinderEffectVisible(bool GPFPIAMCEMI)
	{
	}

	public bool IsSafePosition(Vector3 HDFILHFDBKB)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnAwake()
	{
	}

	public string _003C_003EiFixBaseProxy_GetObjectTag()
	{
		return null;
	}

	public bool _003C_003EiFixBaseProxy_CreateDynamicallyForUGC(string P0)
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_RemoveDynamicallyForUGC(string P0)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnSyncUGCEntityProperty(long P0, UGCSimpleValue P1)
	{
	}
}
