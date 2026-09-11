using System.Collections.Generic;
using COW.HUD;
using GCommon;
using UnityEngine;
using message;

namespace COW.GamePlay;

internal class LevelObjectWukongIllusion : LevelObjectSpawnedAttackable, JAHCGMCCBGK
{
	private const float GNLPBMLLGLD = 0.6f;

	private const float JPGFKNPIKDO = 1f;

	private static readonly int FIGGABMDFEM;

	private int MPMDANNOIAN;

	private int MLMNIAIGKIN;

	private KIOOCMCLGBN MAOHIOEAMEA;

	private float DHLGGINDPKK;

	private LevelForceField.OPKFOCPHOIF LAPJPJICGJD;

	private UIHudSkillLevelObjOwnerController GGMNANMOOMP;

	private Animator FOKJMIGNFKF;

	private readonly string OFGABDNKIFE;

	private VFXCreateHelper AFJAGKLBLLP;

	private Vector3 LKJDNAPNCDH;

	private MaterialPropertyBlock LEMCNJKFLNH;

	private GameObject KJPBGDMIBKB;

	private Renderer[] BHEHBMHLOMP;

	private Material[][] JLCDPPMJHAP;

	public override bool IDFBHMDOBLL => false;

	public override int DCMNDCMNAAH => 0;

	public override bool HLFBNDNFMCL => false;

	public static ResourceID GetResourceIDBySubType(int OJANLPFFBOC)
	{
		return default(ResourceID);
	}

	protected override string GetObjectTag()
	{
		return null;
	}

	private void CAPNCFMOPOL()
	{
	}

	private void GDEAFNHJCON()
	{
	}

	public override void TakeDamage(GLLLEDKLLDA PMMCGNJHOOA, LOAEBBHPMEK AOJANNHGCEA = null, List<float> LFLPGCMLPFM = null, uint FKDEIFDNMJD = 0u)
	{
	}

	public override bool IsVisible()
	{
		return false;
	}

	public override bool IsStreamerVisible()
	{
		return false;
	}

	public bool IsVisibleToLocalViewer()
	{
		return false;
	}

	public override uint GetAttackableID()
	{
		return 0u;
	}

	public override float GetAttackableRadius()
	{
		return 0f;
	}

	public override bool CanAssitByWeapon(Player KALJPOOLDAD, FDAEPHMIEPC KEDHIAANLGO)
	{
		return false;
	}

	public override Vector3 GetAttackableCenterWS()
	{
		return default(Vector3);
	}

	public override bool NeedAssit()
	{
		return false;
	}

	private void FNMGMFGOJME()
	{
	}

	public override void OnRecycle()
	{
	}

	public void RegisterCameraModeVisibilityEvent()
	{
	}

	protected override void OnOnDestroy()
	{
	}

	public override void SyncAction(object[] DJAPBCKDFKA)
	{
	}

	public override void OnFixedUpdate(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	private void MNEFOPPHJJN(IHMEKFLGGMM EPOOCGNJOFD, uint OJFBGFOOKEK)
	{
	}

	protected override void OnUpdateVisibleStateByStreamer(Vector3 MHAAFMCMHAC, Vector3 PAFBAHJAAGC)
	{
	}

	private void GFPMLKAHJPJ(int OBMFMAKFDDL)
	{
	}

	private void EINLACJKCJP(uint OBMFMAKFDDL, uint OLBPPGANKJL)
	{
	}

	private void FFLNMBCEHHP()
	{
	}

	private bool MOIBHJJMHEI()
	{
		return false;
	}

	private bool EJGEBFPICBA()
	{
		return false;
	}

	protected override void FLFHMOGHICH(bool GMLCCOIKJGD)
	{
	}

	private void GGHGJOKLEKO(bool EOGOGFLCEHL)
	{
	}

	private Player AJMAIIICNEM(BHGGAEEHJCO OBMFMAKFDDL)
	{
		return null;
	}

	protected override void OnModelShowed()
	{
	}

	protected override void JHEFLJNCBPJ()
	{
	}

	private void EKDBDCGGONB()
	{
	}

	private void GBODHBHKFKI()
	{
	}

	private void DHBFDFEPEJG(float ELBHJLODPLH)
	{
	}

	private void CICKKCKGKDL(Renderer[] MKFLDKEBBMJ)
	{
	}

	private void CCGGIPFFENL(Renderer[] MKFLDKEBBMJ)
	{
	}

	private Renderer[] AJFCKCDJAIA()
	{
		return null;
	}

	private void AEHLGFAMKJJ()
	{
	}

	private void CNHOFCIGACJ()
	{
	}

	private void AKGFDBMMBFJ()
	{
	}

	private void BFMHFBFBNNL()
	{
	}

	public void _003C_003EiFixBaseProxy_TakeDamage(GLLLEDKLLDA P0, LOAEBBHPMEK P1, List<float> P2, uint P3)
	{
	}

	public bool _003C_003EiFixBaseProxy_get_CanBeLockedByAimAssist()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_IsVisible()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_IsStreamerVisible()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_get_IsMovableEntity()
	{
		return false;
	}

	public uint _003C_003EiFixBaseProxy_GetAttackableID()
	{
		return 0u;
	}

	public float _003C_003EiFixBaseProxy_GetAttackableRadius()
	{
		return 0f;
	}

	public bool _003C_003EiFixBaseProxy_CanAssitByWeapon(Player P0, FDAEPHMIEPC P1)
	{
		return false;
	}

	public Vector3 _003C_003EiFixBaseProxy_GetAttackableCenterWS()
	{
		return default(Vector3);
	}

	public bool _003C_003EiFixBaseProxy_NeedAssit()
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnRecycle()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnOnDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_SyncAction(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnFixedUpdate(float P0, float P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUpdateVisibleStateByStreamer(Vector3 P0, Vector3 P1)
	{
	}

	public void _003C_003EiFixBaseProxy_FLFHMOGHICH(bool P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnModelShowed()
	{
	}

	public void _003C_003EiFixBaseProxy_JHEFLJNCBPJ()
	{
	}
}
