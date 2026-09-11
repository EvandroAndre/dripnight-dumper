using UnityEngine;

namespace COW.GamePlay;

internal class Airdrop : AttackableEntity
{
	public enum DNFFHCFAHGM
	{
		AIRDROPNORMAL,
		AIRDROPPACKAGE,
		AIRDROPLOCK,
		AIRDROPTECH,
		AIRDROPDRAGON,
		AIRDROPTYPEICEDESTRUCTIBLE,
		AIRDROPTYPEINFINITE,
		AIRDROPTYPEMETEORITE,
		AIRDROPTYPEBLOODMOON,
		AIRDROPLOTUSLAMP,
		AIRDROPBUBBLE
	}

	public static NJNJCLIGCBP AirDropMapIconEvent;

	protected LevelAirdrop LBIKADJIFFG;

	public Animator m_AirdropAnim;

	protected Vector3 EKAJFAINGNC;

	public bool IsLanding;

	public GameObject BoxModel;

	protected uint BIHDMPDAHBP;

	private bool CAOMDKGNEDJ;

	private bool NPNDCGCJKIK;

	public Vector3 ECBEKDJPNEA
	{
		set
		{
		}
	}

	public uint KPAHHAACNKP
	{
		set
		{
		}
	}

	public virtual void SetLevelObjectAirdrop(LevelAirdrop ELGIHHLAGFE)
	{
	}

	protected override void OnAwake()
	{
	}

	protected override int GetMaxRepDataCount()
	{
		return 0;
	}

	public void PlayAnimInWater()
	{
	}

	public void PlayAnimStable()
	{
	}

	public virtual void OnStable()
	{
	}

	public virtual void SyncReEnter()
	{
	}

	public virtual DNFFHCFAHGM GetAiropDropType()
	{
		return DNFFHCFAHGM.AIRDROPNORMAL;
	}

	public virtual void InitAirdropSpawnPostion(Vector3 HGHIIAFNEAE)
	{
	}

	public virtual void InitAirdropSpawnTime(float GMENAABJDNG)
	{
	}

	public virtual void SyncServerLanded()
	{
	}

	public virtual void Onland()
	{
	}

	public void _003C_003EiFixBaseProxy_OnAwake()
	{
	}
}
