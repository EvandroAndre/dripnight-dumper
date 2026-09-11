using System;
using System.Collections.Generic;
using UnityEngine;

namespace COW.GamePlay;

internal class MultiControllerVehicle : Vehicle
{
	[Serializable]
	public class ControllerPair
	{
		public JGMIBLONLLA Shape;

		public GameObject ControllerObject;

		public CarAudioComponent VehicleAudio;

		internal VehicleControllerInterface Controller;

		public int ConfigIndex;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<VehicleControllerInterface> _003C_003E9__19_0;

		internal void HDMDPFJNKDM(VehicleControllerInterface KHDAJCLICDL)
		{
		}
	}

	private sealed class LJHGACPEODJ
	{
		public float GKKELMDDGBJ;

		internal void LBGCHFMKBFA(VehicleControllerInterface KHDAJCLICDL)
		{
		}
	}

	public ControllerPair[] Controllers;

	protected Dictionary<int, ControllerPair> KONDJJAKCCN;

	protected ControllerPair LANMOBJPBFH;

	protected JGMIBLONLLA PHAMPAOPHIE;

	protected JGMIBLONLLA MJPHBDEGAEM;

	protected uint JNJDPJIPBOK;

	private uint IKCKCKFINNN;

	protected ParachutejumpCarController IMOMLBGLDEO;

	private ParachutejumpCarController.NJFMLKBOHFB LOMHPGOAEIA;

	public override CarAudioComponent BBMIGIAIAGP => null;

	protected override void OnAwake()
	{
	}

	protected void PDLAHPLAMMF()
	{
	}

	protected override void BNAPBLBBIEJ()
	{
	}

	protected override void EHOMMMGPOFF(float DHKLOLJALAN)
	{
	}

	public override void SyncChangeShape(byte OGECPGHMIHA)
	{
	}

	public override void SendChangeShape()
	{
	}

	public void OnStopJump()
	{
	}

	protected override void HDNBCDEPLHP(Dictionary<string, VehicleControllerInfo> PNOEDGDCAOK)
	{
	}

	protected override void ODJIAANOCJH()
	{
	}

	public override void ChangeProperty(string HPLGKADLMKG, float IFOFEKIPOAP)
	{
	}

	public override void LockSpeed()
	{
	}

	public override void UnLockSpeed()
	{
	}

	protected void KFNEDGDKMPF(Action<VehicleControllerInterface> PCOPDDLBLMI)
	{
	}

	public void ChangeShape(JGMIBLONLLA GKKELMDDGBJ)
	{
	}

	protected void KHBANAHMCDL(JGMIBLONLLA GKKELMDDGBJ, bool CNHMGKJDLAD)
	{
	}

	protected override void BHIMKPGOPIP(bool HCLGHJNEFIC)
	{
	}

	private void DGCJLLNNGED(CarAudioComponent IDNFJMOLNPH, CarAudioComponent BDIKGCJGOCG)
	{
	}

	private void KHBANAHMCDL(VehicleControllerInterface KHDAJCLICDL, bool CNHMGKJDLAD)
	{
	}

	protected void CFLFFFCFPNH(VehicleControllerInterface FJEPEDPFODO, VehicleControllerInterface PKAPHLBDOPN)
	{
	}

	protected virtual void OFLJMNICLFH(JGMIBLONLLA GKKELMDDGBJ)
	{
	}

	protected void APEJCCFJMAN(bool EJGIHEELNJB)
	{
	}

	protected virtual void LHBNGFEDAGF(JGMIBLONLLA OLPAFBHENEA, JGMIBLONLLA PHGIDALCPPO, bool EJGIHEELNJB)
	{
	}

	public void InitParachutejumpController()
	{
	}

	public void onParachuteStateTick(ParachutejumpCarController.NJFMLKBOHFB AOEDHPLKMNI, float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	public override void InitStateWithPlayer(bool NIFCOJBPFAJ, byte DHGPANMNGKB, Player LNGAFJFGPNE, bool IKOJPPPAHCC = false, int OPMCCFAAOEL = -1)
	{
	}

	private void IDLJKBMDHNN()
	{
	}

	private void HHIFEBPMNBO(ParachutejumpCarController.NJFMLKBOHFB MGDIBLOKLOL)
	{
	}

	private void FPFHKIMBOFC()
	{
	}

	private void CAPANOEBLDB(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	public override void StartOnBoard()
	{
	}

	private void IJIBONHCJJO()
	{
	}

	private void EGJGFCKFFPH()
	{
	}

	private void BIGPGKKLIMK()
	{
	}

	public override void StartSkyDiving()
	{
	}

	private void EHPJCPNIHIH()
	{
	}

	private void FLCANOEOGFM()
	{
	}

	private void EBKPJABDIIL()
	{
	}

	public override void StartParachute()
	{
	}

	private void KHIJKFLODLH()
	{
	}

	private void PKCHNGBCOAC()
	{
	}

	private void KNMEEFCFKMI()
	{
	}

	private void PNBOGLJPOPF()
	{
	}

	private void MEGBILDEHKH()
	{
	}

	private void NMKGOANGHPP()
	{
	}

	private void NHNPMFGPPBN()
	{
	}

	public override void SetVisibility(uint PIDINBNGILH, bool HOCFHLLIOJK)
	{
	}

	private void ICAGADIEPAA(bool NDGMENGEGIE)
	{
	}

	protected void NBNIDMCHIIG(ParachutejumpCarController.NJFMLKBOHFB CBCAJJJCKLH)
	{
	}

	public override void SyncParachuteState(byte CBCAJJJCKLH)
	{
	}

	public override bool IsInParachuteJumpState()
	{
		return false;
	}

	public override void OnBevActionCome()
	{
	}

	private void NDFKPIKIOFO(ParachutejumpCarController.NJFMLKBOHFB EPOOCGNJOFD)
	{
	}

	public override bool IsOnBoard()
	{
		return false;
	}

	private void IBGAPPOGDMO(bool IEMPLAOIGEC)
	{
	}

	public override void StopParachutEffect()
	{
	}

	private void PMFGAHNKPOO()
	{
	}

	private void BMPPDKNNKDH()
	{
	}

	private void CCDLJDMECKL()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnAwake()
	{
	}

	public void _003C_003EiFixBaseProxy_BNAPBLBBIEJ()
	{
	}

	public void _003C_003EiFixBaseProxy_EHOMMMGPOFF(float P0)
	{
	}

	public void _003C_003EiFixBaseProxy_SyncChangeShape(byte P0)
	{
	}

	public void _003C_003EiFixBaseProxy_SendChangeShape()
	{
	}

	public CarAudioComponent _003C_003EiFixBaseProxy_get_VehicleAudio()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_HDNBCDEPLHP(Dictionary<string, VehicleControllerInfo> P0)
	{
	}

	public void _003C_003EiFixBaseProxy_ODJIAANOCJH()
	{
	}

	public void _003C_003EiFixBaseProxy_ChangeProperty(string P0, float P1)
	{
	}

	public void _003C_003EiFixBaseProxy_LockSpeed()
	{
	}

	public void _003C_003EiFixBaseProxy_UnLockSpeed()
	{
	}

	public void _003C_003EiFixBaseProxy_BHIMKPGOPIP(bool P0)
	{
	}

	public void _003C_003EiFixBaseProxy_InitStateWithPlayer(bool P0, byte P1, Player P2, bool P3, int P4)
	{
	}

	public void _003C_003EiFixBaseProxy_StartOnBoard()
	{
	}

	public void _003C_003EiFixBaseProxy_StartSkyDiving()
	{
	}

	public void _003C_003EiFixBaseProxy_StartParachute()
	{
	}

	public void _003C_003EiFixBaseProxy_SetVisibility(uint P0, bool P1)
	{
	}

	public void _003C_003EiFixBaseProxy_SyncParachuteState(byte P0)
	{
	}

	public bool _003C_003EiFixBaseProxy_IsInParachuteJumpState()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnBevActionCome()
	{
	}

	public bool _003C_003EiFixBaseProxy_IsOnBoard()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_StopParachutEffect()
	{
	}
}
