using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudStackedKillNotificationController : UIHUDFeedbackItemBaseController
{
	private sealed class _003C_003Ec__DisplayClass52_0
	{
		public UIHudStackedKillNotificationController _003C_003E4__this;

		public ResourceID killNotificationUIFXRes;

		internal void _003CProcessSpecialVFXInKillHud_003Eb__0(uint id, ResourceID resID, GameObject go)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass74_0
	{
		public UIHudStackedKillNotificationController _003C_003E4__this;

		public uint killCnt;

		public NotifyShowDataKill data;

		public bool bPriviliegeKillStyle;

		public string killCountStrLocKey;

		internal void _003CUpdateStackKillUI_003Eb__0(uint ticket, bool isSuccess, UnityEngine.Object obj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass79_0
	{
		public UIHudStackedKillNotificationController _003C_003E4__this;

		public ResourceID soundID;

		public float volume;

		internal void _003CPlayOnKillSound_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass93_0
	{
		public UIHudStackedKillNotificationController _003C_003E4__this;

		public int playIndex;

		public uint weaponSkinId;

		public string[] stateNames;

		public ResourceID[] soundResIds;

		public AnimationClip clip;

		public bool loop;

		internal void _003CDelayShowNextKillNotify_003Eb__0()
		{
		}

		internal void _003CDelayShowNextKillNotify_003Eb__1()
		{
		}
	}

	private sealed class _003CDelayShowScannerMarkVfx_003Ed__70 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudStackedKillNotificationController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDelayShowScannerMarkVfx_003Ed__70(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private const string REINFORCE_TOKEN_FORMAT = "+{0}";

	private UIHudStackedKillNotificationView m_View;

	private EntityVisualEffectManager m_EffectManager;

	private uint m_CurrentVFXUniqueID;

	private Dictionary<GameObject, uint> m_VFXGOToUniqueID;

	private List<GameObject> m_StackKillList;

	private string m_StackShowStateName;

	private bool SettingShowStackKillIcon;

	private bool CurrentShowStackKillIcon;

	private string MY_COLOR;

	private string ENEMY_COLOR;

	private LRUCacheResource m_vfxCache;

	private const int VFX_CACHE_CAPACITY = 15;

	private const string STATENAME_FIRSTBLOOD = "UIHudStackedKillNotification01";

	private const string STATENAME_DOUBLEKILL = "UIHudStackedKillNotification02";

	private const string STATENAME_TRIPLEKILL = "UIHudStackedKillNotification03";

	private const string STATENAME_QUADRAKILL = "UIHudStackedKillNotification04";

	private const string STATENAME_KILL_FIVE = "UIHudStackedKillNotification05";

	private const string STATENAME_KILL_EIGHT = "UIHudStackedKillNotification06";

	private string[] m_VFXAnimationNameArray;

	private int m_CacheVFXAnimationIndex;

	private Dictionary<string, int> m_AnimationNameIndexDict;

	private List<string> mStackKillSoundRes;

	private List<uint> mStackPrivilegeKillIconTypes;

	private List<string> mStackKillSoundResNoBlood;

	public const string SOUND_TEAMKILL = "SOUND_TEAMKILL";

	private const string SOUND_ACE = "SOUND_ACEKILL";

	private const string SOUND_AceNotification = "SOUND_AceNotification";

	private Dictionary<ResourceID, GameObject> m_DictVfx;

	private List<string> mStackKillKey;

	private List<string> mStackKillKeyPrivilege;

	private List<string> mStackKillKeyNoBlood;

	private List<string> mStackKillKeyNoBloodPrivilege;

	private Player m_CurKiller;

	private Player m_CurBeKill;

	private bool MakePixelPerfect;

	private uint m_DelayCallID;

	private const float m_IntervarTime = 0.5f;

	private uint m_TicketID;

	private uint mStackedKillSoundDelayCall;

	private GameObject m_UIFXGo;

	private ResourceID m_CurrentShowResID;

	private Animation m_CurrentUIFXAnimation;

	private static string SoundLocString;

	public EntityVisualEffectManager GetEffectManager()
	{
		return null;
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override bool RecyleDontDestroy()
	{
		return false;
	}

	public static bool DontDestroy()
	{
		return false;
	}

	protected override void OnUIInit()
	{
	}

	public override void OnUIReInit()
	{
	}

	private void OnEscortBossRuinInfo(NotifyShowDataKill data)
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void DestoryLoadUIFX()
	{
	}

	public void ProcessSpecialVFXInKillHud(WeaponSkinData skinData, bool sync = false)
	{
	}

	private void HideCurrentVFX()
	{
	}

	private GameObject GetOrCreateVFXFromManager(ResourceID vfxResID)
	{
		return null;
	}

	private GameObject CreateVFXDirectly(ResourceID vfxResID)
	{
		return null;
	}

	private void SetupVFX(GameObject vfxObject, ResourceID vfxResID)
	{
	}

	private bool ShouldSkipKillNotification(Player localP, Player killer, NotifyShowDataKill data)
	{
		return false;
	}

	private bool HandleKingKillType(byte kingKillType, Player killer)
	{
		return false;
	}

	private string GetKillCountStrLocKey(uint flags, int stacks)
	{
		return null;
	}

	private bool CheckIsNormalNotification(EUIHudKillNotification inNotificationType)
	{
		return false;
	}

	private bool UseDefaultKillNotification(Player killer, NotifyShowDataKill data)
	{
		return false;
	}

	private string GetStackShowStateName(uint flags, int stacks)
	{
		return null;
	}

	private uint KillCnt(uint flags, int stacks)
	{
		return 0u;
	}

	private bool IsThreePlusStackKill(uint flags, int stacks)
	{
		return false;
	}

	private string GetKillCountBgName(uint flags, int stacks)
	{
		return null;
	}

	private bool IsGlobalFirstBloodInBRMode(uint flags)
	{
		return false;
	}

	private bool IsFirstBlood(uint flags, int killStacks)
	{
		return false;
	}

	private void HandleKillVFX(uint killCnt)
	{
	}

	private void HandleScannerMarkSkill(uint addCoin)
	{
	}

	private IEnumerator DelayShowScannerMarkVfx()
	{
		return null;
	}

	private void HandleLoadoutReinforceToken(uint reinforceToken)
	{
	}

	private void UpdateUI(NotifyShowDataKill data, Player killer, bool ShowAceNotification)
	{
	}

	private bool CheckShowStackKillIcon(NotifyShowDataKill data, Player killer)
	{
		return false;
	}

	private void UpdateStackKillUI(NotifyShowDataKill data, Player killer, string killCountStrLocKey, bool ShowAceNotification)
	{
	}

	private void SetStackedKillerNameBG(uint skinID, string teamResourceName)
	{
	}

	private void UpdateSimpleKillUI(NotifyShowDataKill data, Player killer, string killCountStrLocKey)
	{
	}

	protected void OnKill(NotifyShowDataKill data)
	{
	}

	protected string GetOnKillSoundString(uint flags, int stacks, ref bool ShowAceNotification)
	{
		return null;
	}

	protected void PlayOnKillSound(string soundIdString, bool ShowAceNotification)
	{
	}

	public static ResourceID GetSoundResourceId(string soundIdString)
	{
		return default(ResourceID);
	}

	private void DelayOrInterruptShow()
	{
	}

	private void DoShowStackKill()
	{
	}

	private void DoShow()
	{
	}

	public override void Show()
	{
	}

	private void ResetNode()
	{
	}

	private void ShowMultiKillVfx(ResourceID resId)
	{
	}

	public override void ShowIcon(NotificationData ndata)
	{
	}

	public override float PlayKillNotifyInLobby(uint weaponSkinId, bool loop = true, bool playSound = true, int maxDepth = 30)
	{
		return 0f;
	}

	private void SetUIBeforeShowKillNotifyInLobby(bool inPrivilegePreview, int maxDepth)
	{
	}

	private void SetKillLabel(int index)
	{
	}

	private void SetPriviliegeKillLabel(int index)
	{
	}

	private void DelayShowNextKillNotify(float delayTime, string[] stateNames, int playIndex, ResourceID[] soundResIds, bool loop, uint weaponSkinId)
	{
	}

	private void PlayPrivilegeAnimation()
	{
	}

	private void PlayStackedKillIconChange(int playIndex)
	{
	}

	private void SetPrivilegeKillIconSprite(int playIndex, uint weaponSkinId)
	{
	}

	public override void Hide()
	{
	}

	private void ProcessPrivilegeVFXAdd(NotifyShowDataKill data)
	{
	}

	private void SetNormalKillUIHudStyle(uint killCnt, bool isHeadShot, bool isRedBlood)
	{
	}

	private void SetPrivilegeKillHudStyle(ResourceID inIconRes)
	{
	}

	private void SetKillCountLabel(uint killCnt, bool is34Kill, bool isPrivilegeKill, string locKey, StackedKillLabelStyles stackedKillLabelCtrl)
	{
	}

	private EPrivilegeKillIconType GetPrivilegeKillNotifyType(uint killCnt, bool isHeadShot, bool isRedBlood)
	{
		return EPrivilegeKillIconType.None;
	}

	private void InitializeVFXCache()
	{
	}

	private void CleanupVFXCache()
	{
	}

	private void RemoveVFXFromCache(ResourceID resID, GameObject go)
	{
	}

	private void HandleVFXCacheError(Exception ex)
	{
	}

	private GameObject CreateVFXGameObject(ResourceID resourceID)
	{
		return null;
	}

	private bool TryGetVFXFromCache(ResourceID resourceID, out GameObject vfxObject)
	{
		vfxObject = null;
		return false;
	}

	private GameObject CreateAndAddVFXToCache(ResourceID resourceID)
	{
		return null;
	}

	public bool _003C_003EiFixBaseProxy_RecyleDontDestroy()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIReInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_Show()
	{
	}

	public float _003C_003EiFixBaseProxy_PlayKillNotifyInLobby(uint P0, bool P1, bool P2, int P3)
	{
		return 0f;
	}

	public void _003C_003EiFixBaseProxy_Hide()
	{
	}
}
