using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using message;

namespace COW.GamePlay;

public class LevelObjectIIVTeleportDoor : BaseLevelObject
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<LevelObjectIIVTeleportDoorTeammateTag> _003C_003E9__47_0;

		internal int LJEGBAOPNBA(LevelObjectIIVTeleportDoorTeammateTag MDFHMBHHGGF, LevelObjectIIVTeleportDoorTeammateTag OGECPGHMIHA)
		{
			return 0;
		}
	}

	private sealed class JEAJGBHFLGA
	{
		public BHGGAEEHJCO OBMFMAKFDDL;

		public LevelObjectIIVTeleportDoor KOKNHFGCGLN;

		internal void CNOJLGPABBJ(uint JDHNCLHNJIP, ResourceID JMIMKLAELHE, GameObject KGJNMPHDKAB)
		{
		}
	}

	public FOGOEBDAGIK Action;

	public uint DoorConfigId;

	public Transform[] SpawnPoints;

	public UILabel NameLabel;

	public GameObject ToriiNode;

	private IIVTeleportDoorTorii OHJNPBEJPCP;

	public GameObject Picture;

	public GameObject UI3D;

	public Transform TeammateNode;

	public GameObject Collider;

	public GameObject AirwallEffect;

	private uint KBOGMCEJOBE;

	private int BCHBCJDKKFM;

	private int PMPGHGFHCLF;

	private bool AAAPNNHMGIL;

	private BBHAKIIFFHG MAOHIOEAMEA;

	private uint IKMPFBDAKDD;

	private uint BFKPMBAGNBC;

	private uint POHBGLJEILH;

	private uint CHKBGDEMHBM;

	private Dictionary<BHGGAEEHJCO, uint> KPLMKJEBKFN;

	private byte LPPONLDOABO;

	private float JPLDCCKOFFM;

	private uint IICODDHOGLN;

	private bool FKOCDOJPAAI;

	private bool HKBAIKNLNDE;

	private bool NPDJJFFCJOF;

	protected override string GetObjectTag()
	{
		return null;
	}

	private void EAMAGNAGLDF()
	{
	}

	public bool IsNotOpen(BBHAKIIFFHG CBCAJJJCKLH)
	{
		return false;
	}

	public bool IsOpen(BBHAKIIFFHG CBCAJJJCKLH)
	{
		return false;
	}

	public bool IsClose(BBHAKIIFFHG CBCAJJJCKLH)
	{
		return false;
	}

	public override void OnUpdate(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	private void KAFEBMDELKE()
	{
	}

	private bool HOEPOKBCEML(Vector3 HDFILHFDBKB)
	{
		return false;
	}

	public void SetInfo(uint NOANDIOONLD, uint BOGOEPNNFCP, uint DBJBCFOHNLG, int IDCHLDICNPP, int MKCCNABIKII)
	{
	}

	private void CEBBADJFPAN(uint JDHNCLHNJIP, ResourceID JMIMKLAELHE, GameObject KGJNMPHDKAB)
	{
	}

	public void DestroySelf()
	{
	}

	protected override void OnModelShowed()
	{
	}

	protected override void JHEFLJNCBPJ()
	{
	}

	public void OnLocalPlayerEnter()
	{
	}

	public void OnLocalPlayerExit()
	{
	}

	protected override void OnStart()
	{
	}

	private void OECHPGECOKF()
	{
	}

	protected override void OnOnDestroy()
	{
	}

	private void GGKMBCNKPKO()
	{
	}

	private void JJKMGLKNFCK(object[] JCONDDPFBKK)
	{
	}

	private void CPLDJIDOHPK()
	{
	}

	public override void OnRecycle()
	{
	}

	public override bool Recycle()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUpdate(float P0, float P1)
	{
	}

	public void _003C_003EiFixBaseProxy_OnModelShowed()
	{
	}

	public void _003C_003EiFixBaseProxy_JHEFLJNCBPJ()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnStart()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnOnDestroy()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnRecycle()
	{
	}

	public new bool _003C_003EiFixBaseProxy_Recycle()
	{
		return false;
	}
}
