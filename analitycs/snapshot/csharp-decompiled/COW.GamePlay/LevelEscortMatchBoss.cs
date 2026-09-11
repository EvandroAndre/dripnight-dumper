using GCommon;
using UnityEngine;
using message;

namespace COW.GamePlay;

internal class LevelEscortMatchBoss : BaseLevelObject
{
	private class LJBAALIHDEE : ShadowStateBase
	{
		public Vector3 AALEAHDJAMC;

		public Vector3 PHEOMEDPGED;

		public Quaternion DOGHPBHDLCJ;

		public Quaternion GBHPAJHAAMF;
	}

	public EscortMatchBoss m_EscortMatchBoss;

	public GameObject m_MovingEffect;

	private uint KIOOKMHBAMI;

	private uint NJCCAPOFNJK;

	private Vector3 OOKFIHBEJJI;

	public GameObject m_ShiledObj;

	public GameObject m_RechargeEffect;

	public GameObject m_BrokenEffect;

	public GameObject m_NormalEffect;

	public GameObject m_HitEffect;

	public GameObject m_AttackRingEffect;

	public GameObject m_DefendRingEffect;

	public TweenScale m_ShiledMoveColliderTw;

	private BoxCollider IOICMMPBHNG;

	private BoxCollider MCPMIPHBFAB;

	private Vector3 OIIADELHOFD;

	private BoxCollider IOHJMCJHCPL;

	protected uint IAPBBEEDLCG;

	private LJBAALIHDEE LAPJPJICGJD;

	private INMJJHOPIPG MAOHIOEAMEA;

	private float IODPFPGOIMG;

	private GameObject DGINKCNCIOD;

	private bool BFHDMGAONJM;

	private Animator EPJICDJEIKN;

	private INMJJHOPIPG NJFODIMFEOH;

	protected GameObject CNFHDMBGCAC;

	protected AudioResource BFNGDFONDAG;

	public uint PDIGJFFONPN => 0u;

	public uint PBOEJKAJNLO => 0u;

	public uint APAANGFENCH => 0u;

	public INMJJHOPIPG LJPNIHFIIHF => INMJJHOPIPG.ESateType_GiantIdle;

	public float JPCNOBAECFG => 0f;

	public float MNIGPKMCNOO => 0f;

	protected override void OnAwake()
	{
	}

	public override void SyncAction(object[] DJAPBCKDFKA)
	{
	}

	public void OnCurrRoundChanged()
	{
	}

	public void UpdateRingEffect()
	{
	}

	private void NMPGGANLPAO()
	{
	}

	public Vector3 GetTopPosition()
	{
		return default(Vector3);
	}

	private void MNEFOPPHJJN(Vector3 IGDHIDGLOKG, uint OJFBGFOOKEK)
	{
	}

	protected override void OnUserDefineReplicationInfo()
	{
	}

	public bool NeedCure()
	{
		return false;
	}

	public bool IsMoving()
	{
		return false;
	}

	protected void PGEGBNEGIMC(ushort OJEPOBEENEK, ushort EIOKHLKJEEL)
	{
	}

	protected void PGBKGIFIKHA(NBBIMGEOGBF BKKDNENMODE)
	{
	}

	protected void DHPHDDIFEDI(ushort OJEPOBEENEK, ushort EIOKHLKJEEL)
	{
	}

	protected override int GetMaxRepDataCount()
	{
		return 0;
	}

	protected void PGOEHFIFJBG(byte OJEPOBEENEK, byte EIOKHLKJEEL)
	{
	}

	public void OnSyncStateIndex(uint KLDLOOAAGLP)
	{
	}

	private void FIFMGCAAFMC()
	{
	}

	protected void HMPADIFMMKO(byte OJEPOBEENEK, byte EIOKHLKJEEL)
	{
	}

	protected override string GetObjectTag()
	{
		return null;
	}

	protected override void OnOnDestroy()
	{
	}

	public override void OnRecycle()
	{
	}

	public override bool Recycle()
	{
		return false;
	}

	public void ShowHitEffect(Vector3 KHNFEFFKMEB)
	{
	}

	public override void OnFixedUpdate(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	public void _003C_003EiFixBaseProxy_OnAwake()
	{
	}

	public void _003C_003EiFixBaseProxy_SyncAction(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUserDefineReplicationInfo()
	{
	}

	public int _003C_003EiFixBaseProxy_GetMaxRepDataCount()
	{
		return 0;
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

	public void _003C_003EiFixBaseProxy_OnFixedUpdate(float P0, float P1)
	{
	}
}
