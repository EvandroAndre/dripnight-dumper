using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;
using message;

namespace COW;

public class UIHudPlayerSkillBuffController : UIBaseController
{
	private enum ScreenQuadrant
	{
		TopLeft,
		TopRight,
		BottomLeft,
		BottomRight
	}

	private enum EHudRepositionMask
	{
		None = 0,
		Buffs = 1,
		GunBuff = 2,
		Skills = 4,
		Debuff = 8,
		All = 7
	}

	private enum ELongPressType
	{
		exp = 1,
		level,
		weaponDamageRate
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<ulong> _003C_003E9__73_0;

		internal int _003CProcessBuffHUDDataChange_003Eb__73_0(ulong a, ulong b)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass117_0
	{
		public string skillType;

		internal bool _003COnPetSkillChangeIcon_003Eb__0(UIHudSkillTemplateController i)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass118_0
	{
		public string skillType;

		internal bool _003COnPetSkillCoolDownAnim_003Eb__0(UIHudSkillTemplateController i)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass144_0
	{
		public string skillTypeStr;

		internal bool _003CAddPetSkillByPetSkillData_003Eb__0(UIHudSkillTemplateController temp)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass166_0
	{
		public string petSkillType;

		internal bool _003CRemovePetSkillByType_003Eb__0(UIHudSkillTemplateController temp)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass71_0
	{
		public OAICFPKEJNE bevData;

		internal bool _003COnBuffBehaviorChanged_003Eb__0(OAICFPKEJNE temp)
		{
			return false;
		}

		internal bool _003COnBuffBehaviorChanged_003Eb__1(OAICFPKEJNE temp)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass85_0
	{
		public OAICFPKEJNE weaponBehavorData;

		internal bool _003COnLocalPlayerHitOther_003Eb__0(UIHudBuffTemplateController temp)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass86_0
	{
		public OAICFPKEJNE buffBehaviorData;

		internal bool _003COnWeaponBuffEffect_003Eb__0(UIHudBuffTemplateController temp)
		{
			return false;
		}
	}

	private EHudPlayerSkillBuffType m_HudPlayerSkillBuffType;

	private UIHudPlayerSkillBuffView m_View;

	private Player m_Player;

	private UIHudBuffPopOverController m_BuffPopOver;

	private UIHudPlayerDebuffController m_PlayerDebuffCtrl;

	private UIHudSkillEffectCountingController m_ActiveSkillCountingCtrl;

	private UIHudSkillEffectCountingController m_ActiveSkillCountingCtrl2;

	private Vector3 m_InitDebuffPos;

	private BitArrayBoolean isBuffVisible;

	private const uint ISActiveSkill = 1u;

	private const uint ISSkillStrengthenArmor = 2u;

	private const uint ISBuffTemplate = 4u;

	private const uint ISPassiveSkill = 32u;

	private const int BuffWidth = 40;

	private uint AndrewSkillId;

	private List<OAICFPKEJNE> m_CurrentBuffBehaivorList;

	private Dictionary<ulong, UIHudBuffTemplateController> m_CurBuffHUDDataUIDToUIItemMap;

	private List<ulong> m_CurBuffHUDDataIDOrderList;

	private List<UIHudBuffTemplateController> m_ItemControllers;

	private List<ulong> m_PetSkillsList;

	private List<ulong> m_SkillsList;

	private List<ulong> m_BuffList;

	private List<ulong> m_ParentBuffList;

	private List<ulong> m_GunBuffList;

	private Dictionary<uint, BuffShowTipsData> m_SpecialBuffs;

	private List<BuffShowTipsData> m_SpecialList;

	private int m_CurrentMissionCount;

	private Dictionary<uint, UIhudSkillPassiveBuffController> m_PassiveSkillCtrls;

	private uint GameStreamerID;

	private uint m_KillEnemyToAddSpSkillId;

	private AFFJBJKEPOM m_KillEnemyToAddSp;

	private Vector3 LevelSysOriginPosition;

	private Vector3 TableGroupOriginPosition;

	private const int MaxBuffCount = 3;

	private VisualInstanceHolder m_BuffListVfxHolder;

	private Vector3 m_BuffListVfxRelativePos;

	private bool m_RefreshTipsPos;

	private float m_LabelOffsetX1;

	private float m_LabelOffsetX2;

	private float m_LabelOffsetY1;

	private float m_LabelOffsetY2;

	private BHGGAEEHJCO m_BindPlayer;

	private List<UIHudSkillTemplateController> m_PetSkillCtrlList;

	private UIHudSkillTemplateController m_TeamSharedSkillCtrl;

	private UIHudOBActiveSkillController m_OBActiveSkillCtrl;

	private List<UIHudDynamicSkillTemplateController> m_DynamicSkillCtrls;

	private Dictionary<string, UIHudSkillTemplateController> m_SkillDict;

	private Dictionary<string, UIHudDynamicSkillTemplateController> m_DynamicSkillDict;

	private const uint DynamicSkillCnt = 5u;

	private Player mLastSkillPlayer;

	private Vector3 m_OBSize;

	private UIVFXTrackController m_ExpVFXTrackCtrl;

	private uint m_AddExpDelayCallID;

	private uint m_PetLineDelayCallId;

	private bool m_LongPressed;

	private ELongPressType m_LongPressedType;

	private ELongPressType m_CurShowType;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	private UITable GetBuffsAndDebuffTable()
	{
		return null;
	}

	private UITable GetGunBuffTable()
	{
		return null;
	}

	private UITable GetSkillsTable()
	{
		return null;
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override void OnDestroy()
	{
	}

	public void BindPlayer(BHGGAEEHJCO pID)
	{
	}

	private void OnHudPlayerStatsVisibleChanged(bool isVisible)
	{
	}

	private void RefreshLayout()
	{
	}

	private void RepositionDebuffTableOnly(object[] data)
	{
	}

	private void RepositionTables(EHudRepositionMask mask)
	{
	}

	private void RepositionTables(object[] data)
	{
	}

	private void OnBindNoLocalPlayerRefreshBuffShow()
	{
	}

	private void OnBindNoLocalPlayerRefreshBuffShowEX()
	{
	}

	private void InitBuffs()
	{
	}

	private void InitBuffsEX()
	{
	}

	protected int SortBufferData(Transform tr1, Transform tr2)
	{
		return 0;
	}

	public void ActiveAllBuff(bool value)
	{
	}

	public void ChangeDebuffPos(uint flag, bool v)
	{
	}

	private void OnActiveSkillCountingStart(object[] param)
	{
	}

	private void ChangeSpecialList()
	{
	}

	private void HideExtraBuffs()
	{
	}

	private void OnActiveSkillCountingEnd(object[] param)
	{
	}

	private void OnLocalPlayerDead(object[] param)
	{
	}

	public void ShowBuffBehaviourChange(uint id, bool showIcon, bool showDuration)
	{
	}

	private void OnBuffBehaviorChangedEX(OAICFPKEJNE bevData, byte stype, float duration, bool needDuration = true)
	{
	}

	private void OnBuffBehaviorChanged(OAICFPKEJNE bevData, byte stype, float duration, bool needDuration = true)
	{
	}

	protected void OnBuffECAHUDDataBatchChange(GEvent gEvent)
	{
	}

	private void ProcessBuffHUDDataChange(bool isRefreshUI, bool isNeedSort, List<CDKLBIDALAC> updateInfoList)
	{
	}

	private void ProcessSingleBuffHUDDataChange(bool isRefreshUI, CDKLBIDALAC updateInfo)
	{
	}

	private void UpdateBuffUIContent(ulong hudDataUID, UIHudBuffTemplateController itemUI, List<uint> updateTypeList)
	{
	}

	protected void OnBuffBehaviorChangedParam(object[] param)
	{
	}

	private void RefreshUI()
	{
	}

	private bool ShowLeftGunBuff()
	{
		return false;
	}

	private void RefreshUIEX(CDKLBIDALAC updateInfo = null)
	{
	}

	private bool UpdateGunBuffParent(UIHudBuffTemplateController targetCon, ulong uId)
	{
		return false;
	}

	private void BuffChangeUpdate(int gunBuffNew, int gunBuffOld)
	{
	}

	private void TryUpdateBuffTips()
	{
	}

	private void OnUpdateDebuff(object[] param)
	{
	}

	protected void OnWeaponBuffActive(object[] data)
	{
	}

	protected void OnLocalPlayerHitOther(GEvent data)
	{
	}

	protected void OnWeaponBuffEffect(object[] data)
	{
	}

	private Vector3 GetOpenDownPos(BuffPopOverType value)
	{
		return default(Vector3);
	}

	private List<ulong> GetBuffsInfo(BuffPopOverType value)
	{
		return null;
	}

	private UIWidget GetMaskContainer(BuffPopOverType value)
	{
		return null;
	}

	private void ShowBuffsPopInfo(int value)
	{
	}

	public void AddPetSkill(uint id)
	{
	}

	public void RemovePetSkill(uint id)
	{
	}

	public void ClearPetSkill()
	{
	}

	public void RepositionSkills()
	{
	}

	private void UpdatePetLinePosition()
	{
	}

	public void AddSkill(uint id)
	{
	}

	public void ClearSkill()
	{
	}

	private void OnMissionMiniInfoChange(bool value)
	{
	}

	private void OnUpdateSkillIcon(object[] param)
	{
	}

	private void UpdateActiveIcon(UIHudSkillEffectCountingController ctrl)
	{
	}

	private void RefreshObBuffs()
	{
	}

	private void OnStreamerOBCountChange(int count)
	{
	}

	private void OnPlayerKillEnemyAddSpKillCountChange(int count)
	{
	}

	private void ShowPassiveBuff(int count, ref uint baseID, AvatarSkillData skillData)
	{
	}

	private void HidePassiveBuff(uint skillId)
	{
	}

	public void OnClickCopyPresetBtn()
	{
	}

	private void ReplayForceUpdateUI(object[] data)
	{
	}

	private void OnPetSkillChangeIcon(GEvent evt)
	{
	}

	private void OnPetSkillCoolDownAnim(GEvent evt)
	{
	}

	public void OnPlayerSkillCoolDownAnim(GEvent evt)
	{
	}

	public void OnPetSkillFlashAnim(GEvent evt)
	{
	}

	public void OnPlayerSkillFlashAnim(GEvent evt)
	{
	}

	public void OnPetSkillBrightAnim(GEvent evt)
	{
	}

	public void OnPlayerSkillBrightAnim(GEvent data)
	{
	}

	private void OnAddPlayer(object[] data)
	{
	}

	private void OnObservePlayer(object[] data)
	{
	}

	private void CleanAllPetSkillCtrl()
	{
	}

	private void OnPlayerPostInit(object[] data)
	{
	}

	private void RecycleSkillTemplateCtrl(UIHudSkillTemplateController skillTemplateController)
	{
	}

	private void SetCopyPresetBtnVisibleAndModifySize(bool visible)
	{
	}

	private void OnHudCustomizeSettingChanged(object[] data)
	{
	}

	private void ModifySizeForHudFour(bool isOB)
	{
	}

	private void RefreshSkillStatus(NOEPOMJAAIE reason = NOEPOMJAAIE.ESkillChangeReason_Unknown, HashSet<uint> newSkillIDs = null)
	{
	}

	private void PlayVFXTrack(Vector3 startPos, Vector3 endPos)
	{
	}

	private void RecycleUnusedSkillItems(List<UIHudSkillTemplateController> showingSkillCtrls)
	{
	}

	private bool IsDoubleActiveSkillMode()
	{
		return false;
	}

	private void ShowOBActiveSkillIcon(Player player)
	{
	}

	private void UpdateOBActiveSkillIcon(AvatarSkillData data, Player player)
	{
	}

	private void UpdateOBActiveSkillIcon(CEKLEBBHLIG data, Player player)
	{
	}

	private void InitSkillTemplatePool()
	{
	}

	private void OnPetSkillChanged(object[] data)
	{
	}

	private void OnAddPetSkill(object[] data)
	{
	}

	private void AddPetSkill(NetworkPet pet, List<UIHudSkillTemplateController> showingSkillCtrls = null)
	{
	}

	private void AddPetSkillByPetSkillData(object[] data)
	{
	}

	private UIHudSkillTemplateController OpenSkillTemplateFromPool(Transform transform, List<UIHudSkillTemplateController> showingSkillCtrls = null)
	{
		return null;
	}

	private void Update()
	{
	}

	private void UpdateTipsPosition()
	{
	}

	private ScreenQuadrant GetScreenQuadrant(Vector3 screenPos, Vector2 screenCenter)
	{
		return ScreenQuadrant.TopLeft;
	}

	private string GetZombiePlusLongPressDescription(ELongPressType pressType)
	{
		return null;
	}

	private void OnEXPChanged(object[] data)
	{
	}

	private void RefreshExp()
	{
	}

	private void RefreshLevel()
	{
	}

	private void OnLevelChanged(object[] data)
	{
	}

	private void OnHudSelectionChanged(object[] param)
	{
	}

	private void OnShowBuffListVFX(GEvent gEvent)
	{
	}

	public void ShowBuffListCustomVFX(ResourceID resID, float lifeTimeSec)
	{
	}

	private void HideBuffListCustomVFX()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void RemovePetSkillByType(object[] data)
	{
	}

	private void OnSkillChanged(object[] data)
	{
	}

	public Vector3 GetBuffIconPos()
	{
		return default(Vector3);
	}

	private void _003COnUIInit_003Eb__47_0(bool press)
	{
	}

	private void _003COnUIInit_003Eb__47_1(bool press)
	{
	}

	private void _003CRepositionSkills_003Eb__94_0()
	{
	}

	private void _003COnEXPChanged_003Eb__157_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
