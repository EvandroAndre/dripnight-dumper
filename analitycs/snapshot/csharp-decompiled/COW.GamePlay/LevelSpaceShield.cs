using GCommon;
using UnityEngine;
using message;

namespace COW.GamePlay;

internal class LevelSpaceShield : BaseLevelObject
{
	private PhyXShield OCAGKICHOMI;

	private bool POFBLJHEDNG;

	private BHGGAEEHJCO ONMIPNENOLM;

	public GameObject MeshColliderObj;

	public GameObject SphereColliderObj;

	public GameObject ColliderObject;

	public Animation ShieldEffectAnim;

	public MeshRenderer LowQualityMeshRenderer;

	public MeshRenderer[] QualityMeshRenderer;

	public string ANIMATION_CLIP_FRIEND_NAME;

	public string ANIMATION_CLIP_ENEMY_NAME;

	public const string ANIMATION_CLIP_FOLLOWSPACESHIELD_FRIEND_NAME = "AnimClip_FollowSpaceShield_Friend";

	public const string ANIMATION_CLIP_FOLLOWSPACESHIELD_ENEMY_NAME = "AnimClip_FollowSpaceShield_Enemy";

	public const string ANIMATION_CLIP_SUMMONER_START_NAME = "SF50_GP_Ingame_Summoner_Shield_Start";

	public const string ANIMATION_CLIP_SUMMONER_END_NAME = "SF50_GP_Ingame_Summoner_Shield_End";

	public const string ANIMATION_CLIP_MAPTHROWER_NAME = "VFX_Bounty_Shield_Start03";

	public const string ANIMATION_CLIP_TEAMGATHER_NAME = "VFX_TeamGather_Shield_Holder";

	private GameObject HBKIFEIJFOI;

	private GameObject AKDHGOCIJFI;

	private GBKEBKFOCHB AKNJLKCPKFD;

	private float LILNGMDBAEO;

	private ResourceID DMJEAMEJNDG;

	private bool DHCMHLPIMCN;

	private uint _003CIOFPMKEKIDF_003Ek__BackingField;

	private uint _003CMHAOFEEDOEN_003Ek__BackingField;

	private const int HDPMBNHMPDH = 1;

	private bool HJJJHMALPPF;

	private uint _003CFDMDPBDNIBB_003Ek__BackingField;

	private MONAJGOOPHA _003CJKMAIOGOMEO_003Ek__BackingField;

	private VisualInstanceHolder HOPCJPHEBLN;

	public GBKEBKFOCHB BDHHLDGLHMP => GBKEBKFOCHB.ESpaceShieldType_Skill;

	public float MKAGBNDEGNE
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public uint HDFCNPJDFDE
	{
		get
		{
			return 0u;
		}
		private set
		{
		}
	}

	public uint DCEPOMGMJDF
	{
		get
		{
			return 0u;
		}
		private set
		{
		}
	}

	public uint IOGONNLBJMO
	{
		get
		{
			return 0u;
		}
		private set
		{
		}
	}

	public MONAJGOOPHA OLIMKEJAICP
	{
		get
		{
			return MONAJGOOPHA.Normal;
		}
		private set
		{
		}
	}

	protected override string GetObjectTag()
	{
		return null;
	}

	protected override int GetMaxRepDataCount()
	{
		return 0;
	}

	public void Init(uint ICNLDNANPLL, uint IJFOOEENBBG)
	{
	}

	public void InitPhyx()
	{
	}

	protected override void OnUserDefineReplicationInfo()
	{
	}

	protected virtual void KFOLHOPJBAC(int OJEPOBEENEK, int EIOKHLKJEEL)
	{
	}

	protected virtual void JMHLAPNHJOF(int OJEPOBEENEK, int EIOKHLKJEEL)
	{
	}

	private static ResourceID JFLDIMHHJKG(GBKEBKFOCHB FIDJOHNAKHD, string BLAAJOHDNIE, string JEJAKIKAJFH, bool IHELNCFMHPH = false)
	{
		return default(ResourceID);
	}

	public static LevelSpaceShield CreateSpaceShiled(uint ONFPCIABJJC, uint IMEAIDCGEFD, uint ICNLDNANPLL, uint IJFOOEENBBG, Vector3 HDFILHFDBKB, bool IHELNCFMHPH, bool FPPHBFGLMDB, int POEJOGDILPP, BHGGAEEHJCO MECONKDDAEC, GBKEBKFOCHB FIDJOHNAKHD = GBKEBKFOCHB.ESpaceShieldType_Skill, string BLAAJOHDNIE = null, float GLPLIHEECAP = 1f, string JEJAKIKAJFH = null)
	{
		return null;
	}

	public void PlayExtraVFX(string EDHHDFNLCKA)
	{
	}

	private void BFIBAFKJGFI()
	{
	}

	public void PlayStartAnim()
	{
	}

	public bool IsShieldEffectVisible()
	{
		return false;
	}

	public void SetShieldHighQuality(bool HCLGHJNEFIC)
	{
	}

	public void SetDecalEffect(bool HCLGHJNEFIC)
	{
	}

	protected override void UnRegisterEntity()
	{
	}

	public override void OnRecycle()
	{
	}

	public override bool Recycle()
	{
		return false;
	}

	public void DestroyShield(IPKPNABFHDB OINKNIGKDMO)
	{
	}

	private void MBKAJFNIEEG()
	{
	}

	public override ResourceID GetOverrideMarkIconResId()
	{
		return default(ResourceID);
	}

	public void OnSpaceShieldCreate()
	{
	}

	public void PlaySummonerShieldSound()
	{
	}

	public void StopSummonerShieldSound()
	{
	}

	private void JGPNDBELPDO()
	{
	}

	private void HPHLOBMGGNI(float IMKNJGHAHPI)
	{
	}

	private void LFPICEIFODI()
	{
	}

	public override void OnReUse()
	{
	}

	private void KMCPGMMDGPC()
	{
	}

	private bool GJLDHLMDDIC()
	{
		return false;
	}

	protected override void OnUpdateVisibleStateByStreamer(Vector3 MHAAFMCMHAC, Vector3 PAFBAHJAAGC)
	{
	}

	public override void OnUpdate(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	private void MJNGGMEOBIM()
	{
	}

	private void MEJMCDKMPMH()
	{
	}

	private void FFLNMBCEHHP()
	{
	}

	public void OnOwnerVisibleFlagChangeInTranningMode(int OKKFEDNKOHP)
	{
	}

	public bool IsNeedShowSkillEffect()
	{
		return false;
	}

	private bool OEDLGPCIACI(Player HJCAJNODNNO)
	{
		return false;
	}

	public int _003C_003EiFixBaseProxy_GetMaxRepDataCount()
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_OnUserDefineReplicationInfo()
	{
	}

	public void _003C_003EiFixBaseProxy_UnRegisterEntity()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnRecycle()
	{
	}

	public new bool _003C_003EiFixBaseProxy_Recycle()
	{
		return false;
	}

	public ResourceID _003C_003EiFixBaseProxy_GetOverrideMarkIconResId()
	{
		return default(ResourceID);
	}

	public void _003C_003EiFixBaseProxy_OnReUse()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUpdateVisibleStateByStreamer(Vector3 P0, Vector3 P1)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUpdate(float P0, float P1)
	{
	}
}
