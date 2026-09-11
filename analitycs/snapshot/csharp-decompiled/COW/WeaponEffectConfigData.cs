using COW.GamePlay;
using GCommon;

namespace COW;

public class WeaponEffectConfigData : CSVBaseData, IGetId
{
	public uint quality;

	public uint effectMyHand;

	public uint effectMyBack;

	public uint effectTeammateHand;

	public uint effectTeammateBack;

	public uint effectEnemyHand;

	public uint effectEnemyBack;

	public uint effectMyFire;

	public uint effectTeammateFire;

	public uint effectEnemyFire;

	public uint effectMyHit;

	public uint effectTeammateHit;

	public uint effectEnemyHit;

	public uint effectMyKill;

	public uint effectTeammateKill;

	public uint effectEnemyKill;

	public uint effectMyAnnounce;

	public uint effectTeammateAnnounce;

	public uint effectEnemyAnnounce;

	public bool ShowMyLastKillVFX;

	public bool ShowTeammateLastKillVFX;

	public bool ShowEnemyLastKillVFX;

	public bool ShowMyLastKillAnim;

	public bool ShowTeammateLastKillAnim;

	public bool ShowEnemyLastKillAnim;

	public bool ShowMyReloadEffect;

	public bool ShowTeammateReloadEffect;

	public bool ShowEnemyReloadEffect;

	public bool ShowMyGunTraceEffect;

	public bool ShowTeammateGunTraceEffect;

	public bool ShowEnemyGunTraceEffect;

	public bool PlayMyFireSound;

	public bool PlayTeammateFireSound;

	public bool PlayEnemyFireSound;

	public bool ShowMyKillCountOnEffectKill;

	public bool ShowTeammateKillCountOnEffectKill;

	public bool ShowEnemyKillCountOnEffectKill;

	public bool ShowMyExecution;

	public bool ShowTeamExecution;

	public bool ShowEnemyExecution;

	public bool ShowObserverExecution;

	public bool ShowMyChangeWeaponEffect;

	public bool ShowTeamChangeWeaponEffect;

	public bool ShowEnemyChangeWeaponEffect;

	public uint GetId()
	{
		return 0u;
	}

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	internal bool IsExectutionEffectVisible(Player player)
	{
		return false;
	}

	internal bool IsChangeWeaponEffectVisible(Player player)
	{
		return false;
	}

	internal bool IsKillEffectVisible(Player killer)
	{
		return false;
	}

	internal bool IsTeamLastKillVFXVisible(Player killer)
	{
		return false;
	}

	internal bool IsMatchLastKillVFXVisible(Player killer)
	{
		return false;
	}

	internal bool IsTeamLastKillAnimVisible(Player killer)
	{
		return false;
	}

	internal bool IsMatchLastKillAnimVisible(Player killer)
	{
		return false;
	}

	internal bool IsKillCountOnKillEffectVisible(Player owner)
	{
		return false;
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}
}
