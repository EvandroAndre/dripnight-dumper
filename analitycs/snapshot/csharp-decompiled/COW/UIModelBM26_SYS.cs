using System;
using System.Collections.Generic;
using GCommon;
using Spine.Unity;
using UnityEngine;
using proto;

namespace COW;

public class UIModelBM26_SYS : UIBaseModel, IBigEventModel, IUIModelDataChangeObserver
{
	public class AnimGroupEvent
	{
		public float delay;

		public Action onTrigger;

		public AnimGroupEvent(float delay, Action onTrigger)
		{
		}
	}

	public class AnimationGroupConfig
	{
		public string groupName;

		public SpineAnimClip[] clips;

		public AnimGroupEvent[] events;

		public Action skipEvent;

		public float offset;

		public AnimationGroupConfig(string name, SpineAnimClip[] clipArr)
		{
		}

		public AnimationGroupConfig WithEvents(AnimGroupEvent[] eventArr)
		{
			return null;
		}

		public AnimationGroupConfig WithSkipEvent(Action skipEvent)
		{
			return null;
		}

		public AnimationGroupConfig Offset(float offset)
		{
			return null;
		}
	}

	protected class AnimPlaySession
	{
		private sealed class _003C_003Ec__DisplayClass7_0
		{
			public AnimGroupEvent capturedEvt;

			internal void _003CCheckAnimEventCallback_003Eb__0()
			{
			}
		}

		public string groupName;

		public uint callbackKey;

		public Action onComplete;

		public List<uint> eventDelayKeys;

		public Action onSessionComplete;

		public void CancelTimers()
		{
		}

		public void ScheduleCompletion(float duration, Action onComplete)
		{
		}

		public void CheckAnimEventCallback(AnimationGroupConfig config)
		{
		}

		public void CheckSkipAnimEventCallback(AnimationGroupConfig config)
		{
		}
	}

	public class ClientEclipseLocalization
	{
		private string _003CLanguage_003Ek__BackingField;

		private uint _003CType_003Ek__BackingField;

		private uint _003CId_003Ek__BackingField;

		private string _003CKey_003Ek__BackingField;

		private string _003CDescription_003Ek__BackingField;

		public string Language
		{
			get
			{
				return _003CLanguage_003Ek__BackingField;
			}
			set
			{
				_003CLanguage_003Ek__BackingField = value;
			}
		}

		public uint Type
		{
			get
			{
				return _003CType_003Ek__BackingField;
			}
			set
			{
				_003CType_003Ek__BackingField = value;
			}
		}

		public uint Id
		{
			get
			{
				return _003CId_003Ek__BackingField;
			}
			set
			{
				_003CId_003Ek__BackingField = value;
			}
		}

		public string Key
		{
			get
			{
				return _003CKey_003Ek__BackingField;
			}
			set
			{
				_003CKey_003Ek__BackingField = value;
			}
		}

		public string Description
		{
			get
			{
				return _003CDescription_003Ek__BackingField;
			}
			set
			{
				_003CDescription_003Ek__BackingField = value;
			}
		}

		public bool IsCurrentLanguage()
		{
			return false;
		}

		public bool IsLanguage(string language)
		{
			return false;
		}

		public string GetDescription()
		{
			return null;
		}
	}

	public class ClientEclipseShareSetting
	{
		private long _003CTime_003Ek__BackingField;

		private int _003CRateCdnId_003Ek__BackingField;

		public long Time
		{
			get
			{
				return _003CTime_003Ek__BackingField;
			}
			set
			{
				_003CTime_003Ek__BackingField = value;
			}
		}

		public int RateCdnId
		{
			get
			{
				return _003CRateCdnId_003Ek__BackingField;
			}
			set
			{
				_003CRateCdnId_003Ek__BackingField = value;
			}
		}

		public bool IsTimeValid()
		{
			return false;
		}

		public long GetRemainingTime()
		{
			return 0L;
		}
	}

	public enum ProgressStatus
	{
		Lock,
		Explore,
		Claimable,
		Claimed
	}

	public interface IProgress
	{
		uint id { get; }

		ProgressStatus status { get; }

		uint progress { get; }

		uint MinProgress { get; }

		uint MaxProgress { get; }

		List<AwardDesc> awards { get; }

		int UpdateStatus(uint val);

		int UpdateStatus(uint[] claimed_progress);

		int UpdateStatus(uint val, uint[] claimed_progress);

		void Clear();
	}

	public class ProgressData : IProgress
	{
		protected uint mId;

		protected ProgressStatus mStatus;

		private uint _003Cprogress_003Ek__BackingField;

		protected uint mMinProgress;

		protected uint mMaxProgress;

		private List<AwardDesc> _003Cawards_003Ek__BackingField;

		public virtual uint id => 0u;

		public virtual ProgressStatus status => ProgressStatus.Lock;

		public uint progress
		{
			get
			{
				return _003Cprogress_003Ek__BackingField;
			}
			private set
			{
				_003Cprogress_003Ek__BackingField = value;
			}
		}

		public virtual uint MinProgress => 0u;

		public virtual uint MaxProgress => 0u;

		public List<AwardDesc> awards
		{
			get
			{
				return _003Cawards_003Ek__BackingField;
			}
			protected set
			{
				_003Cawards_003Ek__BackingField = value;
			}
		}

		public ProgressData(uint beforeProgress, uint currentProgress, List<AwardDesc> awards)
		{
		}

		public virtual int UpdateStatus(uint progress)
		{
			return 0;
		}

		public virtual int UpdateStatus(uint[] claimed_progress)
		{
			return 0;
		}

		public virtual int UpdateStatus(uint progress, uint[] claimed_progress)
		{
			return 0;
		}

		public virtual void Clear()
		{
		}
	}

	public class NormalProgressData : ProgressData
	{
		private uint _003CnormalCdn_003Ek__BackingField;

		private uint _003CclaimedCdn_003Ek__BackingField;

		public uint normalCdn
		{
			get
			{
				return _003CnormalCdn_003Ek__BackingField;
			}
			private set
			{
				_003CnormalCdn_003Ek__BackingField = value;
			}
		}

		public uint claimedCdn
		{
			get
			{
				return _003CclaimedCdn_003Ek__BackingField;
			}
			private set
			{
				_003CclaimedCdn_003Ek__BackingField = value;
			}
		}

		public NormalProgressData(uint beforeProgress, uint currentProgress, List<AwardDesc> awards, uint normalCdn, uint claimedCdn)
			: base(0u, 0u, null)
		{
		}

		public override int UpdateStatus(uint progress, uint[] claimed_progress)
		{
			return 0;
		}

		public override int UpdateStatus(uint val)
		{
			return 0;
		}

		public override int UpdateStatus(uint[] claimed_progress)
		{
			return 0;
		}

		public override void Clear()
		{
		}

		public int _003C_003EiFixBaseProxy_UpdateStatus(uint P0, uint[] P1)
		{
			return 0;
		}

		public int _003C_003EiFixBaseProxy_UpdateStatus(uint P0)
		{
			return 0;
		}

		public int _003C_003EiFixBaseProxy_UpdateStatus(uint[] P0)
		{
			return 0;
		}

		public void _003C_003EiFixBaseProxy_Clear()
		{
		}
	}

	public class CycleProgressData : ProgressData
	{
		private uint mMaxCount;

		private uint mClaimedCount;

		private uint mClaimableCount;

		public override uint id => 0u;

		public uint claimableCount => 0u;

		public bool isClaimed => false;

		public override uint MaxProgress => 0u;

		public override ProgressStatus status => ProgressStatus.Lock;

		public CycleProgressData(uint beforeProgress, uint currentProgress, List<AwardDesc> awards, uint max_count)
			: base(0u, 0u, null)
		{
		}

		public override int UpdateStatus(uint val)
		{
			return 0;
		}

		public uint GetProgress(uint val)
		{
			return 0u;
		}

		public uint GetClaimableCount(uint val)
		{
			return 0u;
		}

		public override int UpdateStatus(uint[] claimed_progress)
		{
			return 0;
		}

		public override void Clear()
		{
		}

		public uint _003C_003EiFixBaseProxy_get_id()
		{
			return 0u;
		}

		public uint _003C_003EiFixBaseProxy_get_MaxProgress()
		{
			return 0u;
		}

		public ProgressStatus _003C_003EiFixBaseProxy_get_status()
		{
			return ProgressStatus.Lock;
		}

		public int _003C_003EiFixBaseProxy_UpdateStatus(uint P0)
		{
			return 0;
		}

		public int _003C_003EiFixBaseProxy_UpdateStatus(uint[] P0)
		{
			return 0;
		}

		public void _003C_003EiFixBaseProxy_Clear()
		{
		}
	}

	public abstract class ProgressRewardBoxGo
	{
		protected GameObject gameObject;

		protected IProgress m_ProgressData;

		protected ProgressStatus m_Status;

		protected UIModelBM26_SYS m_UIModelBM26_SYS;

		protected UILabel m_ProgressLabel;

		protected UIButton m_BoxBtn;

		protected GameObject m_NormalBoxGo;

		protected GameObject m_OpenBoxGo;

		protected GameObject m_ClaimableGo;

		protected GameObject m_NormalBoxAnimationGo;

		protected IBM26_SYSMain m_MainCtrl;

		protected int m_Index;

		protected Animation m_UnLockAnim;

		public ProgressRewardBoxGo(UIBigEventPorgressRewardBoxView view, IBM26_SYSMain ctrl)
		{
		}

		public virtual void Destroy()
		{
		}

		public virtual bool Init(int index, IProgress data)
		{
			return false;
		}

		public abstract void Refersh();

		protected virtual void RefershView()
		{
		}

		protected void OnClickBoxBtn()
		{
		}

		protected abstract void RewardPreview();
	}

	public class NormalRewardBoxGo : ProgressRewardBoxGo
	{
		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Converter<AwardDesc, BaseItemInfo> _003C_003E9__9_0;

			internal BaseItemInfo _003CRewardPreview_003Eb__9_0(AwardDesc temp)
			{
				return null;
			}
		}

		private GameObject m_NormalBoxIcon;

		private UINetworkTexture m_NormalBoxTexture;

		private GameObject m_OpenlBoxIcon;

		private UINetworkTexture m_OpenlBoxTexture;

		private GameObject m_IconUIFXTrans;

		public NormalRewardBoxGo(UIBM26_SYSProgressRewardBoxView view, IBM26_SYSMain ctrl)
			: base(null, null)
		{
		}

		public override bool Init(int index, IProgress data)
		{
			return false;
		}

		public override void Refersh()
		{
		}

		protected override void RefershView()
		{
		}

		protected override void RewardPreview()
		{
		}

		protected void InitMusicView()
		{
		}

		public override void Destroy()
		{
		}

		private void _003CInit_003Eb__6_0()
		{
		}

		public bool _003C_003EiFixBaseProxy_Init(int P0, IProgress P1)
		{
			return false;
		}

		public void _003C_003EiFixBaseProxy_RefershView()
		{
		}

		public void _003C_003EiFixBaseProxy_Destroy()
		{
		}
	}

	public class CycleRewardBoxGo : ProgressRewardBoxGo
	{
		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Converter<TreasureBoxShowData, BaseItemInfo> _003C_003E9__5_0;

			public static Converter<AwardDesc, BaseItemInfo> _003C_003E9__5_1;

			internal BaseItemInfo _003CRewardPreview_003Eb__5_0(TreasureBoxShowData temp)
			{
				return null;
			}

			internal BaseItemInfo _003CRewardPreview_003Eb__5_1(AwardDesc temp)
			{
				return null;
			}
		}

		private UILabel m_CycleBoxRedCountLabel;

		public CycleRewardBoxGo(UIBigEventCycleProgressRewardBoxView view, IBM26_SYSMain ctrl)
			: base(null, null)
		{
		}

		public override bool Init(int index, IProgress data)
		{
			return false;
		}

		protected override void RefershView()
		{
		}

		public override void Refersh()
		{
		}

		protected override void RewardPreview()
		{
		}

		public bool _003C_003EiFixBaseProxy_Init(int P0, IProgress P1)
		{
			return false;
		}

		public void _003C_003EiFixBaseProxy_RefershView()
		{
		}
	}

	public interface IBM26_SYSMain
	{
		bool IsVaild { get; }

		bool PlayStageAnim(string animName, out float animLength);

		void PlayStageEffect(ResourceID effectResId, float delayTime = 0f);

		void PlayClearStageEffect();

		void RefershProgressInfoView();

		void OpenBigEventEntranceID(UIModelBigEvent.EBigEventEntranceID entranceID);
	}

	public class SpineAnimClip
	{
		public ResourceID spineResId;

		public Transform spineRoot;

		public string[] animations;

		public bool isLoop;

		public bool isHide;

		public SpineAnimClip(ResourceID resId, Transform root, string[] anims)
		{
		}

		public SpineAnimClip(ResourceID resId, Transform root, bool isHide, string[] anims)
		{
		}
	}

	public class SimpleGo
	{
		private GameObject _003CgameObject_003Ek__BackingField;

		private Transform _003Ctransform_003Ek__BackingField;

		protected bool isAsync;

		protected uint asyncResultTicket;

		private bool _003CisReady_003Ek__BackingField;

		protected Transform parent;

		protected bool isLocal;

		protected Vector3 m_Position;

		protected ResourceID res_id;

		protected float m_Delay;

		protected uint m_DelayLoadKey;

		protected bool m_Active;

		protected Action<GameObject> m_OnLoadCompleteCallback;

		public GameObject gameObject
		{
			get
			{
				return _003CgameObject_003Ek__BackingField;
			}
			protected set
			{
				_003CgameObject_003Ek__BackingField = value;
			}
		}

		public Transform transform
		{
			get
			{
				return _003Ctransform_003Ek__BackingField;
			}
			protected set
			{
				_003Ctransform_003Ek__BackingField = value;
			}
		}

		public bool isReady
		{
			get
			{
				return _003CisReady_003Ek__BackingField;
			}
			protected set
			{
				_003CisReady_003Ek__BackingField = value;
			}
		}

		protected bool isDelaying => false;

		public bool Null => false;

		public virtual Vector3 Position => default(Vector3);

		public SimpleGo(bool aSync)
		{
		}

		protected void SetDelay(float time)
		{
		}

		public void SetParent(Transform parent, Vector3 position, bool local)
		{
		}

		public void SetParent(Transform parent)
		{
		}

		public void SetParent(Transform parent, Vector3 position)
		{
		}

		public void SetOnLoadCompleteCallback(Action<GameObject> callback)
		{
		}

		public void Load(ResourceID resId, Transform parent)
		{
		}

		public void Load(ResourceID resId, Transform parent, Vector3 position)
		{
		}

		public void Load(ResourceID resId, Transform parent, Vector3 position, bool local)
		{
		}

		public void Load(ResourceID resId, float delay, Transform parent, Vector3 position, bool local)
		{
		}

		protected virtual void OnEffectGoLoaded(uint ticket, bool succeeded, UnityEngine.Object obj)
		{
		}

		protected virtual void OnOnEffectGoLoadedCompleteCallback(UnityEngine.Object obj, Transform parent)
		{
		}

		protected virtual void OnDelayLoadCallback()
		{
		}

		public virtual void Destroy()
		{
		}

		public void SetActive(bool active)
		{
		}
	}

	public class EffectObject : SimpleGo
	{
		public EffectObject(bool aSync)
			: base(aSync: false)
		{
		}

		public virtual bool Update(float deltaTime)
		{
			return false;
		}
	}

	public class SpineSimpleGo
	{
		private sealed class _003C_003Ec__DisplayClass45_0
		{
			public Transform capturedChild;

			public SpineSimpleGo _003C_003E4__this;

			public string capturedName;

			internal void _003CPlayEffect_003Eb__0()
			{
			}
		}

		private SkeletonAnimation m_SkeletonAnimation;

		private SkeletonAnimation[] m_SkeletonAnimationArr;

		private GameObject _003CgameObject_003Ek__BackingField;

		private Transform _003Ctransform_003Ek__BackingField;

		protected uint asyncResultTicket;

		protected Transform parent;

		private bool _003CisReady_003Ek__BackingField;

		private bool _003CisLoading_003Ek__BackingField;

		protected bool isLocal;

		protected Vector3 m_Position;

		protected ResourceID res_id;

		protected float m_Delay;

		protected uint m_DelayLoadKey;

		protected Action m_LoadOverCallBack;

		private List<Action> m_PendingCallbacks;

		private string m_CacheAnim;

		private string m_CacheAddAnim;

		private bool m_Loop;

		private bool m_MulAnim;

		protected bool m_IsShow;

		private Dictionary<string, uint> m_EffectDelayKeys;

		public GameObject gameObject
		{
			get
			{
				return _003CgameObject_003Ek__BackingField;
			}
			protected set
			{
				_003CgameObject_003Ek__BackingField = value;
			}
		}

		public Transform transform
		{
			get
			{
				return _003Ctransform_003Ek__BackingField;
			}
			protected set
			{
				_003Ctransform_003Ek__BackingField = value;
			}
		}

		public bool isReady
		{
			get
			{
				return _003CisReady_003Ek__BackingField;
			}
			protected set
			{
				_003CisReady_003Ek__BackingField = value;
			}
		}

		public bool isLoading
		{
			get
			{
				return _003CisLoading_003Ek__BackingField;
			}
			protected set
			{
				_003CisLoading_003Ek__BackingField = value;
			}
		}

		public SpineSimpleGo(bool isMulAnim = false)
		{
		}

		public void Load(ResourceID resId, Transform parent, Action action, bool isShow = true)
		{
		}

		public void SetParent(Transform parent, Vector3 position, bool local)
		{
		}

		public void Load(ResourceID resId, float delay, Transform parent, Vector3 position, bool local, Action action, bool isShow = true)
		{
		}

		protected virtual void OnEffectGoLoaded(uint ticket, bool succeeded, UnityEngine.Object obj)
		{
		}

		protected virtual void OnOnEffectGoLoadedCompleteCallback(GameObject go)
		{
		}

		protected void SetDelay(float time)
		{
		}

		protected virtual void OnDelayLoadCallback()
		{
		}

		public float PlayAnimation(string name, bool loop = false)
		{
			return 0f;
		}

		public float PlayNextAnimation(string name, bool loop = false)
		{
			return 0f;
		}

		public void StopAnimation()
		{
		}

		private static void RefreshSkeletonAnimation(SkeletonAnimation skeletonAnimation)
		{
		}

		public void PlayEffect(string effectName, float duration = 1f)
		{
		}

		public void PlayHideEffect(string effectName)
		{
		}

		private Transform FindChildRecursive(Transform root, string name)
		{
			return null;
		}

		public virtual void Destroy()
		{
		}

		public string FormatTextQuality(string text)
		{
			return null;
		}
	}

	public class SpineObject
	{
		private sealed class _003C_003Ec__DisplayClass15_0
		{
			public Action<ResourceID> onLoadComplete;

			public ResourceID spineResId;

			internal void _003CLoadSpine_003Eb__0()
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass18_0
		{
			public int loadedCount;

			public int totalClips;

			public SpineObject _003C_003E4__this;

			public AnimationGroupConfig config;

			public AnimPlaySession session;

			public Action checkAllLoaded;

			public Action<ResourceID> _003C_003E9__2;

			internal void _003CPlayAnimationGroupConfig_003Eb__0()
			{
			}

			internal void _003CPlayAnimationGroupConfig_003Eb__2(ResourceID resId)
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass18_1
		{
			public AnimPlaySession capturedSession;

			public _003C_003Ec__DisplayClass18_0 CS_0024_003C_003E8__locals1;

			internal void _003CPlayAnimationGroupConfig_003Eb__1()
			{
			}
		}

		protected UIModelBM26_SYS m_ModelBM26_SYS;

		protected Dictionary<string, AnimationGroupConfig> m_AnimationGroupConfigs;

		private List<AnimPlaySession> m_ActiveSessions;

		protected bool m_Async;

		protected Dictionary<ResourceID, SpineSimpleGo> m_SpineGoDict;

		protected Dictionary<ResourceID, Transform> m_SpineRootDict;

		protected int m_SoundEffectTicket;

		protected int m_DialogSoundTicket;

		public void RegisterSpine(ResourceID spineResId, Transform spineRoot)
		{
		}

		protected SpineSimpleGo GetOrCreateSpineGo(ResourceID resId)
		{
			return null;
		}

		protected Transform GetSpineRoot(ResourceID resId)
		{
			return null;
		}

		protected void PlaySpineEffect(ResourceID resId, string effectName, float duration = 2f)
		{
		}

		protected void PlaySpineHideEffect(ResourceID resId, string effectName)
		{
		}

		public virtual void Destroy()
		{
		}

		public void LoadSpine(ResourceID spineResId, Action<ResourceID> onLoadComplete = null, bool isShow = true)
		{
		}

		public float PlayRoleAnimGroup(string groupName, Action onComplete = null, bool cancelPrevious = false)
		{
			return 0f;
		}

		public void PlayRoleSkipAnimGroup()
		{
		}

		protected float PlayAnimationGroupConfig(string groupName, Action onComplete)
		{
			return 0f;
		}

		protected float PlayAllClipsSync(SpineAnimClip[] clips)
		{
			return 0f;
		}

		private void OnSessionComplete(AnimPlaySession session)
		{
		}

		protected void CancelAnimCompleteCallback()
		{
		}
	}

	public class RoleSpineObject : SpineObject
	{
		protected IBM26_SYSMain m_MainController;

		protected Transform m_SpineRoot;

		public const string ANIM_STEP_GROUP_IDLE = "step_idle";

		public const string ANIM_STEP_GROUP_TOKEN = "step_token";

		public void InitSpine(IBM26_SYSMain mainController, Transform spineRoot)
		{
		}

		public void InitAnimStep()
		{
		}

		public void PreLoadSpine()
		{
		}

		public virtual float PlayStepIdleAnim(Action onComplete = null)
		{
			return 0f;
		}

		public virtual float PlayStepTokenAnim(Action onComplete = null)
		{
			return 0f;
		}

		public virtual float PlayStepSkipAnim()
		{
			return 0f;
		}

		private void _003CInitAnimStep_003Eb__5_0()
		{
		}

		private void _003CInitAnimStep_003Eb__5_1()
		{
		}
	}

	public class StageObject
	{
		public enum StageVisableState
		{
			DisActive,
			PreActive,
			Active
		}

		private sealed class _003C_003Ec__DisplayClass44_0
		{
			public StageObject _003C_003E4__this;

			public Action onLoadComplete;

			internal void _003CLoadStageAsync_003Eb__0(GameObject go)
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass51_0
		{
			public Action onComplete;

			internal void _003CPlayStageTokenWithTransition_003Eb__0()
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass59_0
		{
			public StageObject _003C_003E4__this;

			public StageVisableState state;

			internal void _003CDelaySetStageState_003Eb__0()
			{
			}
		}

		public const float DAILY_INACTIVE_ENTER_DELAY = 1f;

		public GameObject MainStageContainer;

		public Transform MainStageUIFXContainer;

		private GameObject _003CMainStageUIFX_003Ek__BackingField;

		public RoleSpineObject RoleSpine;

		public ResourceID StageEffectName;

		public EffectObject m_StageEffectGo;

		private int _003CStageIndex_003Ek__BackingField;

		private bool m_IsStageLoading;

		private bool m_IsShow;

		private GameObject _003CStageMaskUIFX_003Ek__BackingField;

		private int m_AmbMusicTicket;

		private GameObject _003CStageAvtiveObj_003Ek__BackingField;

		private GameObject _003CStageDisAvtiveObj_003Ek__BackingField;

		private GameObject _003CStagePreAvtiveObj_003Ek__BackingField;

		private Animation m_StageVisableAnimation;

		private string m_StageDisActiveInAnimName;

		private string m_StageDisActiveToActiveAnimName;

		private string m_MainStageContainerAnimName;

		private IBM26_SYSMain m_MainController;

		private StageVisableState m_StageVisableState;

		private uint m_StageVisableAnimDelayKey;

		public ResourceID StageSoundResId;

		public GameObject MainStageUIFX
		{
			get
			{
				return _003CMainStageUIFX_003Ek__BackingField;
			}
			private set
			{
				_003CMainStageUIFX_003Ek__BackingField = value;
			}
		}

		public int StageIndex
		{
			get
			{
				return _003CStageIndex_003Ek__BackingField;
			}
			private set
			{
				_003CStageIndex_003Ek__BackingField = value;
			}
		}

		public GameObject StageMaskUIFX
		{
			get
			{
				return _003CStageMaskUIFX_003Ek__BackingField;
			}
			private set
			{
				_003CStageMaskUIFX_003Ek__BackingField = value;
			}
		}

		public GameObject StageAvtiveObj
		{
			get
			{
				return _003CStageAvtiveObj_003Ek__BackingField;
			}
			private set
			{
				_003CStageAvtiveObj_003Ek__BackingField = value;
			}
		}

		public GameObject StageDisAvtiveObj
		{
			get
			{
				return _003CStageDisAvtiveObj_003Ek__BackingField;
			}
			private set
			{
				_003CStageDisAvtiveObj_003Ek__BackingField = value;
			}
		}

		public GameObject StagePreAvtiveObj
		{
			get
			{
				return _003CStagePreAvtiveObj_003Ek__BackingField;
			}
			private set
			{
				_003CStagePreAvtiveObj_003Ek__BackingField = value;
			}
		}

		public StageObject(GameObject container, ResourceID effectResId, ResourceID soundResId, RoleSpineObject roleSpine, IBM26_SYSMain mainController = null, int stageIndex = 0)
		{
		}

		private bool IsStageReady()
		{
			return false;
		}

		public void LoadStageAsync(Action onLoadComplete)
		{
		}

		protected bool IsStageEffectReady()
		{
			return false;
		}

		public void PlayStageMaskUIFX(bool isShow)
		{
		}

		public void PlayEffect()
		{
		}

		public void PlayRoleStageFirstAnim()
		{
		}

		public void PlayRoleStageAnim()
		{
		}

		public void PlayRoleStageAnimMax()
		{
		}

		public void PlayStageTokenWithTransition(Action onComplete)
		{
		}

		public void PlayStageSkipAnim()
		{
		}

		public void PlayStageVisable(StageVisableState state, bool playAnim = false, bool playDisActiveInAnim = false)
		{
		}

		public bool PlayMainStageContainerAnim(out float animLength)
		{
			animLength = default(float);
			return false;
		}

		private void SetStageState(StageVisableState state)
		{
		}

		private bool TryPlayStageAnim(string animName, out float animLength)
		{
			animLength = default(float);
			return false;
		}

		private void PlayStageAnimAndSetState(string animName, StageVisableState state)
		{
		}

		private void PrepareStageVisableAnim(StageVisableState targetState = StageVisableState.DisActive)
		{
		}

		private void DelaySetStageState(StageVisableState state, float animLength)
		{
		}

		private void ClearStageVisableAnimDelay()
		{
		}

		public void HideMainStageUIFX()
		{
		}

		public void ShowStageView()
		{
		}

		private ResourceID GetStageMusicResID()
		{
			return default(ResourceID);
		}

		private ResourceID GetStageSoundResID()
		{
			return default(ResourceID);
		}

		public void PlayStageShowSound()
		{
		}

		public void PlayStageMusic()
		{
		}

		public void StopStageMusic()
		{
		}

		public void Destroy()
		{
		}

		public string FormatTextQuality(string text)
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass199_0
	{
		public UIModelBM26_SYS _003C_003E4__this;

		public Action onFailed;

		internal void _003CRequestConsume_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private ResourceID m_CurrentEggSoundID;

	private Texture2D m_TransitionScreenshot;

	public const int QUALITY_LOW = 0;

	public const int QUALITY_MIDDLE = 1;

	public const int QUALITY_HIGH = 2;

	public const int CDNTypeWarmupTitle = 59001;

	public const int CDNTypeWarmupBigPrize = 59002;

	public const int CDNTypeMainTitle = 59003;

	public const int CDNTypeMainTitleBg = 59004;

	public const int CDNPeakDay = 59005;

	public const int CDNIconLogo = 59006;

	public const int CDNTypeMissionTitle = 59007;

	public const int CNDTypeMainShareGift = 59101;

	public const uint GMAEMODE_BR = 1u;

	public const uint GMAEMODE_CS = 15u;

	public const uint GMAEMODE_LW = 43u;

	public const int NORMAL_PROGRESS_COUNT = 5;

	public const int NORMAL_PROGRESS_SUB_COUNT = 1;

	public const int NORMAL_PROGRESS_VALUE = 1;

	public const int MAX_PROGRESS_COUNT = 5;

	public const int DIALOG_CHARS_PER_SECOND = 40;

	public const uint PropID_BM26_SYSRed = 2u;

	public const uint PropID_BM26_SYSSetting = 4u;

	public const uint PropID_BM26_SYSData = 8u;

	public const uint PropID_BM26_SYSInfo = 16u;

	public const uint PropID_BM26_SYSToken = 32u;

	public const uint PropID_BM26_SYSProgress = 64u;

	public const uint PropID_BM26_SYSProgressAward = 128u;

	public const float PROGRESS_ANIMATION_INTERVAL = 0.5f;

	public const float MAX_STAGE_LOAD_WAIT_TIME = 5f;

	public const string GUIDEBUTTON_SPRITENAME = "BM26_SYS_Win_btn_big1";

	public const string NORMALBUTTON_SPRITENAME = "BM26_SYS_Win_btn_big01";

	public const string REWARD_PERVIEW_DESC = "T_54_LXW_BM26_AWARD_PREVIEW_TIPS";

	public const string CYCLE_REWARD_PERVIEW_DESC = "T_54_LXW_BM26_CYCLEAWARD_PREVIEW";

	public const string BM26SYS_BRDROPNUM = "T_46_LXW_GLOOWORLDSYS_BRDROPNUM";

	public const string BM26SYS_CSDROPNUM = "T_46_LXW_GLOOWORLDSYS_CSDROPNUM";

	public const string BM26SYS_LWDROPNUM = "T_46_LXW_GLOOWORLDSYS_LWDROPNUM";

	public const string PEAKDAY_E = "T_54_LXW_BM26_PEAKDAY_E";

	public const string PEAKDAY_D = "T_54_LXW_BM26_PEAKDAY_D";

	public const string PEAKDAY_TITLE = "T_54_LXW_BM26_PEAKDAY_TITLE";

	public const string RULE_HELP_DESC = "T_54_LXW_BM26_HELP_DESC";

	public const string MAIN_FIRSTIN_ANIM = "UIFX_BM26_SYS_MainContainer_In";

	public const string MAIN_IN_ANIM = "UIFX_BM26_SYS_MainContainer_In";

	public const string MAIN_DAILY_FIRSTIN_ANIM = "UIFX_BM26_SYS_SHUIMO_IN";

	public const string MAIN_OUT_ANIM = "UIFX_BM26_SYS_MainContainer_Out";

	public const string MAIN_RED_IN_ANIM = "UIFX_BM26_SYS_Red_In";

	public const string MAIN_DIALOG_IN_ANIM = "UIFX_BM26SYS_UICarni25SysMain_Dialog_In";

	public const string MAIN_DIALOG_OUT_ANIM = "UIFX_BM26SYS_UICarni25SysMain_Dialog_Out";

	public const string MAIN_SHAREPROMPT_IN_ANIM = "UIFX_BM26SYS_Main_SharePrompt_In";

	public const string MAIN_SHAREPROMPT_OUT_ANIM = "UIFX_BM26SYS_Main_SharePrompt_Out";

	public const string UIFX_BM26SYS_First_In = "UIFX_BM26SYS_First_In";

	public const string MAIN_STAGE_CONTAINER_ANIM_FORMAT = "UIFX_BM26_SYS_MainStage{0}";

	public const string STAGE_DIS_ACTIVE_IN_ANIM_FORMAT = "UIFX_BM26_SYS_MainStage{0}_DisA_In";

	public const string STAGE_DIS_ACTIVE_TO_ACTIVE_ANIM_FORMAT = "UIFX_BM26_SYS_MainStage{0}_DisA_To_Active";

	public const string PeakDayInAni = "UIFX_Carni25_Sys_UICarni25SysPopWndSmallFrame_Appear";

	public const string PeakDayOutAni = "UIFX_Carni25_Sys_UICarni25SysPopWndSmallFrame_Disappear";

	public const string MISSION_OUT_ANIM = "UIFX_Carni25_Sys_UICarni25SysMissionPopupWnd_Out";

	public const string MISSION_IN_ANIM = "UIFX_Carni25_Sys_UICarni25SysMissionPopupWnd_In";

	public const string MISSION_DIALOG_IN_ANIM = "UIFX_UICARNI25SYSMissionPopupWnd_In";

	public const string MISSION_DIALOG_OUT_ANIM = "UIFX_UICARNI25SYSMissionPopupWnd_Out";

	public const string TOKEN_CONSUME_ENOUGH_FORMAT = "{0}/{1}";

	public const string BM26_SYS_MAIN_IDLE_ANIM = "BM26_SYS_Mainpage_Male_Idle";

	public const string BM26_SYS_MAIN_SPECIAL_ANIM = "BM26_SYS_Mainpage_Male_Special";

	public const string BM26_SYS_MAIN_WOLF_SPECIAL_ANIM = "BM26_SYS_Mainpage_Wolf_Special";

	public const string BM26_SYS_MAIN_SHARE_HINT_KEY = "T_23_Q_EVENTBANNER_SHARE_HINT";

	public const string BM26_SYS_MAIN_DIALOG_OPEN_KEY = "T_53_WYH_BM26SYS_MAIN_Dialogue0";

	private bool m_RedDotFetched;

	private uint m_SettingFetched;

	private bool m_InfoFetched;

	private bool m_ProgressRedDot;

	private object m_CacheBackgroundInfoRes;

	private uint _003CTokenId_003Ek__BackingField;

	private uint _003CTokenConsume_003Ek__BackingField;

	private CSGetBM26SysInfoRes m_CacheInfoRes;

	private uint _003CTokenAddProgress_003Ek__BackingField;

	private Dictionary<string, List<ClientEclipseLocalization>> m_DicLocalizations;

	private Dictionary<uint, List<string>> m_DicDialogType2Keys;

	private Dictionary<uint, int> m_DicDialogType2KeysIndex;

	private Dictionary<long, ClientEclipseShareSetting> m_DicShareSettings;

	private int[] m_StageUnlockOrder;

	private IProgress[] m_ProgressData;

	private uint[] m_ClaimedProgress;

	private uint _003CCurrentProgress_003Ek__BackingField;

	private int _003CCurrentProgressIndex_003Ek__BackingField;

	private uint _003CNormalMaxProgress_003Ek__BackingField;

	public bool HaveData => false;

	public uint TokenId
	{
		get
		{
			return _003CTokenId_003Ek__BackingField;
		}
		private set
		{
			_003CTokenId_003Ek__BackingField = value;
		}
	}

	public uint TokenConsume
	{
		get
		{
			return _003CTokenConsume_003Ek__BackingField;
		}
		private set
		{
			_003CTokenConsume_003Ek__BackingField = value;
		}
	}

	public uint TokenAddProgress
	{
		get
		{
			return _003CTokenAddProgress_003Ek__BackingField;
		}
		private set
		{
			_003CTokenAddProgress_003Ek__BackingField = value;
		}
	}

	public uint[] ClaimedProgress => null;

	public uint CurrentProgress
	{
		get
		{
			return _003CCurrentProgress_003Ek__BackingField;
		}
		private set
		{
			_003CCurrentProgress_003Ek__BackingField = value;
		}
	}

	public int CurrentProgressIndex
	{
		get
		{
			return _003CCurrentProgressIndex_003Ek__BackingField;
		}
		private set
		{
			_003CCurrentProgressIndex_003Ek__BackingField = value;
		}
	}

	public uint NormalMaxProgress
	{
		get
		{
			return _003CNormalMaxProgress_003Ek__BackingField;
		}
		private set
		{
			_003CNormalMaxProgress_003Ek__BackingField = value;
		}
	}

	public UIABigEventLobbyEnterWndControler GetBigEventLobbyEnterWnd()
	{
		return null;
	}

	public UIBigEventLobbyIconWndController GetBigEventLobbyIconWnd()
	{
		return null;
	}

	public bool IsLobbyEntranceTipsNeedShow(uint useType)
	{
		return false;
	}

	public bool OptionalResNeedDownload()
	{
		return false;
	}

	public bool CanGotoWhenBigEventClosed()
	{
		return false;
	}

	public bool CanIngoreDownloadRes(UIModelBigEvent.EBigEventEntranceID entranceId)
	{
		return false;
	}

	public void GotoBigEvent(string from, UIModelBigEvent.EBigEventEntranceID entranceId, ELimitedEvent.EventState activityState, string param, ulong subType3, object extra)
	{
	}

	public Type GetLobbyEntranceType()
	{
		return null;
	}

	public void OnProcessEventOpenInfo()
	{
	}

	public bool CheckProcessGiftIcon()
	{
		return false;
	}

	public bool CheckProcessRedPointTip()
	{
		return false;
	}

	public bool MissionRedDot(EActivity.SubType subType)
	{
		return false;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void OnBigEventTokenChangedCallback()
	{
	}

	public override uint GetModelType()
	{
		return 0u;
	}

	public override void ClearCache()
	{
	}

	public override void SceneChange(object[] data)
	{
	}

	public override void Init()
	{
	}

	public override void Logout(object[] data)
	{
	}

	public void RegsitNotification(UIModelBigEvent uimodelBigEvent)
	{
	}

	private void UnregsitNotification()
	{
	}

	public int GetQuality()
	{
		return 0;
	}

	public bool IsNeedMainFirstInAnim()
	{
		return false;
	}

	public void SaveMainFirstInAnim()
	{
	}

	public bool IsNeedMainDailyFirstInAnim()
	{
		return false;
	}

	public void SaveMainDailyFirstInAnim()
	{
	}

	public bool IgnoreCheckOptionalDownload()
	{
		return false;
	}

	public bool CheckOpenedActivityView()
	{
		return false;
	}

	public bool CheckBigEventInProgress(bool showTips = true)
	{
		return false;
	}

	private bool LoginOnSpecialTimeConditionCalculate(EActivity.PreConditionType condition_type, uint condition_value, ulong value)
	{
		return false;
	}

	public bool IsInLoginOnSpecialTime(ClientActivityDesc activityDesc)
	{
		return false;
	}

	public EActivity.State GetActivityState(ClientActivityDesc activityDesc)
	{
		return EActivity.State.State_RECEIVED;
	}

	public bool IsBigEventActivityFinished(EEventType activityType, EActivity.SubType subType)
	{
		return false;
	}

	public void StoreTransitionScreenshot(Texture2D screenshot)
	{
	}

	public Texture2D ConsumeTransitionScreenshot()
	{
		return null;
	}

	private void ClearTransitionScreenshot()
	{
	}

	private void StopCaptureCoroutine()
	{
	}

	public void SetTextLabel(UILabel label, uint value)
	{
	}

	public void SetTextLabel(UILabel label, string text)
	{
	}

	public float PlayAnimation(Animation animation, string strClipName)
	{
		return 0f;
	}

	public bool LoadImageFromUrl(UINetworkTexture uINetworkTexture, int cdnId, Action onSuccuss = null)
	{
		return false;
	}

	private void CreateStageUnlockOrder(BM26SysSettingDesc settingDesc)
	{
	}

	private bool TryGetStageIndexFromConfig(string stageKey, out int stageIndex)
	{
		stageIndex = default(int);
		return false;
	}

	public int GetStageIndexByUnlockIndex(int unlockIndex)
	{
		return 0;
	}

	public uint GetTipsAddProgressDefaultValue()
	{
		return 0u;
	}

	public uint GetTipsAddProgressValue(uint count)
	{
		return 0u;
	}

	public uint GetCurrentTokenCount()
	{
		return 0u;
	}

	public uint GetTipsTokenCount()
	{
		return 0u;
	}

	public uint GetAddProgressValue(uint count)
	{
		return 0u;
	}

	public void ClearBM26_SYSDataCache()
	{
	}

	private int GetBM26_SYSGuideValue()
	{
		return 0;
	}

	public bool IsBM26_SYSGuideValue(uint status)
	{
		return false;
	}

	public void SetBM26_SYSGuideValue(uint status)
	{
	}

	public void CreateProgressData(List<BigEventProgressAwardDesc> progress_awards, BigEventProgressCycleAwardDesc cycle_award)
	{
	}

	public void ClearProgressData()
	{
	}

	private void ProcessInfoProgressData(uint current_progress, uint[] claimed_progress)
	{
	}

	private void UpdateProgressData(uint current_progress)
	{
	}

	private void UpdateProgressAwardData(uint[] claimed_progress)
	{
	}

	private void UpdateCurrentProgressData(uint current_progress)
	{
	}

	private void UpdateCheckStatusData(uint defaultPropID = 0u)
	{
	}

	private bool IsProgressCheckPoint(int progressIndex)
	{
		return false;
	}

	private bool IsClaimableProgress(IProgress progressData)
	{
		return false;
	}

	private void UpdateRedDotAndNotify(bool hasClaimableProgress, uint defaultPropID = 0u)
	{
	}

	public IProgress GetProgress(int index)
	{
		return null;
	}

	public int GetProgressIndexByProgressValue(uint progressValue)
	{
		return 0;
	}

	public float GetProgressRatioValue()
	{
		return 0f;
	}

	public IProgress GetCurrentProgress()
	{
		return null;
	}

	public bool IsMaxProgress()
	{
		return false;
	}

	public ResourceID GetMainWolfExplosionEffectResId()
	{
		return default(ResourceID);
	}

	public bool IsMaxProgressValue()
	{
		return false;
	}

	public void SetProgressData(uint progress)
	{
	}

	public bool CheckProgressUnLock(int index)
	{
		return false;
	}

	public int GetProgressUnLockIndex()
	{
		return 0;
	}

	public int GetCurrentProgressIndex()
	{
		return 0;
	}

	public bool CheckProgressRedPoint()
	{
		return false;
	}

	public void RequestBM26_SYSSetting(bool showLoading = true)
	{
	}

	public void RequestBM26_SYSInfo(bool isForce = false, bool showLoading = true)
	{
	}

	public void RequestRedDotInfo()
	{
	}

	public void RequestConsume(uint token_count = 1u, Action onFailed = null)
	{
	}

	public void RequestClaimProgressReward(uint progress_id)
	{
	}

	private void ProcessInfoData(CSGetBM26SysInfoRes infoRes)
	{
	}

	public uint GetAvailableTokenCount()
	{
		return 0u;
	}

	public uint GetTokenConsume()
	{
		return 0u;
	}

	public uint GetTokenConsumeMax()
	{
		return 0u;
	}

	public int GetNextTokenEnoughState()
	{
		return 0;
	}

	private void _003CRequestBM26_SYSSetting_003Eb__196_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestBM26_SYSInfo_003Eb__197_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestRedDotInfo_003Eb__198_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestClaimProgressReward_003Eb__200_0(HttpErrorCode errorCode, object res)
	{
	}

	public void _003C_003EiFixBaseProxy_ClearCache()
	{
	}

	public void _003C_003EiFixBaseProxy_SceneChange(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
