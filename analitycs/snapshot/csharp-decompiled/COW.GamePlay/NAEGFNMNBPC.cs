using System.Collections.Generic;

namespace COW.GamePlay;

public class NAEGFNMNBPC : ELKDNDJLGGG
{
	public const string HEHFNMKJBGM = "SwitchItemOnHand";

	public const string OIDHLGHPBPE = "FirstBlood";

	public const string FLHIGOFIKPL = "KillStack";

	public const string BBGGCPIIKNA = "HeadShot";

	public const string OEFPOCJELAF = "OnGroundWithSkill";

	public const string NEPNBBGMIIJ = "SkillReady";

	public const string KLCILPKIPLM = "SkillSuccess";

	public const string EHHILEFOBBK = "SkillFail";

	public const string CHJLJIBEDGA = "BeHurtWithIceWall";

	public const string EHDMCMFEJOI = "BeHurtWithType";

	public const string BONOCMABCMD = "AmmoLow";

	public const string CDNDOCDNMPF = "AmmoEmpty";

	public const string NKMNKBIHMFE = "OutOfBattleHp";

	public const string BFIEOOJGMKK = "HPToLow";

	public const string OGBPFPLGDLI = "OutOfBattleVest";

	public const string NAOHKMNFGKA = "OnGroundItemCheck";

	public const string CBJIGLKCMID = "SwimSurf";

	public const string FPADLHNJLHC = "OnVehicleHp";

	public const string JEBFNFGAIEJ = "SafeZoneIn";

	public const string GOBMKGKDKKD = "SafeZoneDis";

	public const string CGLGPNCHEGL = "OnGroundSpecial01";

	public const string EEIEHEICNBA = "BagCapacityFull";

	public const string EJHNOGEIHOP = "EnemyNearBy";

	public const string BKKCFIIEDOJ = "OnGroundMainWeaponCheck";

	public const string BFFLKDOPJJB = "OnGroundMainWeaponOnHandAmmoCheck";

	public const string IPHNDAJLIAN = "Greetings";

	public const string LOGIPAAJEHE = "IntervalFire";

	public const string LBHMBJKCMGG = "GetCoin";

	public const string JOPKLGGHAOB = "GetEP";

	public const string PGMHBPLPJFG = "OpenMapWithHotZone";

	public const string CEKFBFLEJCN = "OpenTreasuryWithNoKeay";

	public const string PJBCIKAGMBB = "OpenTreasuryWithScanArea";

	public const string PODKGEFEIPI = "EnterAreaWithTime";

	public const string DBMNGCMILEG = "DamageCyberMushroom";

	public const string JLDCBLLDKAH = "WeaponCanUpgrade";

	public const string MGHEDFBPCMF = "SideWeaponCanChange";

	public const string GPGOKNKAEEG = "WeaponLongRage";

	public const string JGAFLOLFFJC = "AmmoReload";

	public const string CNEANGNPCPM = "AirLineSkyDivingCaptain";

	public const string FLODNCMKPOJ = "GetDebuff";

	public const string MHCKCADPMEB = "BeScanORSee";

	public const string ODBHFJJAGIN = "VehicleSmoking";

	public const string GPBBEIIAGMO = "TeammateDeath";

	public const string CAGKDMIFPPK = "GrandTotalElectricDamage";

	public const string ECENJCKLNHH = "EnterLuckyDrawBox";

	public const string OODCOJIJIPI = "EneterLevelObject";

	public const string ODAODDGIJAG = "CannotPlaced";

	public const string HCIDDFEJFCH = "StoreNearBy";

	public const string PIKIKBMJGOO = "GetSkillCard";

	public const string KDKLJJPDKBF = "UAVRevealed";

	public const string MJFIIMFBJKH = "BotAgentUseGuide";

	public const string IHGIJEIMELK = "DeathCanRevive";

	public const string PLODDCABIBL = "FarFromTeammate";

	public const string KDFKMGIHEEH = "TeammateUnderAttack";

	public const string CJHCBGCNCAP = "TeammateHealing";

	public const string HEAEOMFGHPO = "OpenReinforcedAnvil";

	public const string BJGBEABAABP = "OpenTeamBuffSupporter";

	public const string DBNOGNDJEKE = "CSPrepareWithLoadout";

	public const string NGFFPOGBKEE = "BRFinalRanking";

	public const string BGLIOHBPMGJ = "HPRecovered";

	protected DJFOLHHFCNM MCLIDAOMAON;

	protected BotAgentActionData JAKCKMDDDNC;

	protected float PAJACKIKGDC;

	protected float EJOLGFOABOE;

	protected uint CMGNDCNADKM;

	public static uint DHHGKPGLKLP;

	public const string KNGNOJHFIGB = "CSMapZoneStart";

	public const string FEKNLJJOMLO = "CSSafeZoneState";

	public const string GKKMPGONKIH = "CSRoundScoreState";

	public const string EHLAEOHHEKB = "CSEnemyTeamWipedOut";

	public const string PCBEBELANPA = "CSUseSkillReminder";

	public const string KEIGANNFIKC = "CSWeaponStrategyReminder";

	public const string PFHKPONIPNG = "CSShopItemRecommend";

	public const string DMCAODKGFFO = "CSReinforceWeaponAvailable";

	public const string LJFFMNLFNJH = "CSInGameAchievement";

	public const string DHJNNNKCBPF = "CSBigRoundWin";

	public const string PFNOJOLDLFN = "DragEvent_Hud_ActiveSkill";

	public const string KNDHLNCGCDH = "DragEvent_LevelObject";

	public const string NMOJKHCMHPJ = "DragEvent_Hud_Weapon";

	public const string KJGJHMFCKPE = "DragEvent_Hud_PickUp";

	public const string MAHNCIJKOLG = "DragEvent_Hud_Grenade";

	public const string AOKJIGPAIBL = "DragEvent_Hud_MapThrower";

	public const string PFKLJHHEJEO = "ManualEvent_WhatToDo";

	public const string EDKPIBMPEPD = "ManualEvent_WhereEnemy";

	public const string PIEKHKDDOKD = "ManualEvent_HowToRevive";

	public const string LOJKJBIPOOA = "IdleDetection_WhatTodo";

	protected NAEGFNMNBPC(DJFOLHHFCNM AELNCKDCENH, BotAgentActionData DKLKGHGFNCC)
	{
	}

	public virtual PHAIELOHCKM FPLIAGFALHJ()
	{
		return PHAIELOHCKM.EAIEvent_OnGameStart;
	}

	public virtual bool PDFLJIFAIDP(object[] JCONDDPFBKK)
	{
		return false;
	}

	public virtual void LGHDKEBJAOH(object[] MMHBECLBJLG)
	{
	}

	public virtual void BFBIIOKLGIL(int PMEBPPEMEFC)
	{
	}

	public virtual void AGKPDEOBHKL(List<string> DJAPBCKDFKA)
	{
	}

	public virtual void BLJEIAHKEPL()
	{
	}

	public virtual void NCBPPAPNEAI(BotAgentActionData DKLKGHGFNCC)
	{
	}

	public virtual void CCPAOPNEKHB()
	{
	}

	public virtual BotAgentActionData OBOFFLIDPDA()
	{
		return null;
	}
}
