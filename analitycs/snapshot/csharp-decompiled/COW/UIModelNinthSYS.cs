using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIModelNinthSYS : UIBaseModel, IBigEventModel, INinthProgressState
{
	public interface IBigEventAnimation
	{
		bool isLock { get; }
	}

	public interface IRewardPreview
	{
	}

	public enum EGamePlayTabType
	{
		BR,
		CS,
		PowerCharacter,
		MAX
	}

	public enum EGamePlaySubTabType
	{
		None,
		DeathBoxRevive,
		TeamZoneTask,
		PlaneRoute,
		WeaponAwaken,
		PowerCharacter,
		AbilityEnhancedAirdrop,
		MAX
	}

	public interface INinthSYSGamePlayContext
	{
		uint TabType { get; }

		uint SubTabType { get; }

		void OnClickSubTabItem(uint subTabType);

		void OnClickTutorialBtn(uint tabType);

		void OnClickGoposBtn(uint tabType);

		bool IsLastSubTabItem(uint subTabType);
	}

	public struct AwardPoolSelectedData
	{
		private int _003Ctype_003Ek__BackingField = 0;

		private uint _003Cid_003Ek__BackingField = 0u;

		public int type
		{
			get
			{
				return _003Ctype_003Ek__BackingField;
			}
			private set
			{
				_003Ctype_003Ek__BackingField = value;
			}
		}

		public uint id
		{
			get
			{
				return _003Cid_003Ek__BackingField;
			}
			private set
			{
				_003Cid_003Ek__BackingField = value;
			}
		}

		public AwardPoolSelectedData(int type, uint id)
		{
		}
	}

	public interface IAwardPoolPreview : IRewardPreview
	{
		AwardPoolSelectedData GetAwardPoolSelectedData();

		void OnPreviewClick(AwardPoolSelectedData data);
	}

	public interface IAwardPoolDesc : IComparable<IAwardPoolDesc>
	{
		int type { get; }

		uint id { get; }

		uint sort { get; }
	}

	public class TitleAwardDesc : IAwardPoolDesc, IComparable<IAwardPoolDesc>
	{
		private bool _003CisHigh_003Ek__BackingField;

		private uint _003CPercentage_003Ek__BackingField;

		private uint _003Csort_003Ek__BackingField;

		public int type => 0;

		public uint id => 0u;

		public bool isHigh
		{
			get
			{
				return _003CisHigh_003Ek__BackingField;
			}
			private set
			{
				_003CisHigh_003Ek__BackingField = value;
			}
		}

		public uint Percentage
		{
			get
			{
				return _003CPercentage_003Ek__BackingField;
			}
			private set
			{
				_003CPercentage_003Ek__BackingField = value;
			}
		}

		public uint sort
		{
			get
			{
				return _003Csort_003Ek__BackingField;
			}
			private set
			{
				_003Csort_003Ek__BackingField = value;
			}
		}

		public TitleAwardDesc(bool isHigh, uint percentage, uint sort)
		{
		}

		public int CompareTo(IAwardPoolDesc other)
		{
			return 0;
		}
	}

	public class SeparatorAwardDesc : IAwardPoolDesc, IComparable<IAwardPoolDesc>
	{
		private uint _003Csort_003Ek__BackingField;

		public int type => 0;

		public uint id => 0u;

		public uint sort
		{
			get
			{
				return _003Csort_003Ek__BackingField;
			}
			private set
			{
				_003Csort_003Ek__BackingField = value;
			}
		}

		public SeparatorAwardDesc(uint sort)
		{
		}

		public int CompareTo(IAwardPoolDesc other)
		{
			return 0;
		}
	}

	public class ProgressAwardDesc : IAwardPoolDesc, IComparable<IAwardPoolDesc>
	{
		private uint _003Csort_003Ek__BackingField;

		private List<BaseItemInfo> items;

		public int type => 0;

		public uint id => 0u;

		public uint sort
		{
			get
			{
				return _003Csort_003Ek__BackingField;
			}
			private set
			{
				_003Csort_003Ek__BackingField = value;
			}
		}

		// C# has no syntax for parameterized property 'Item'.
		public BaseItemInfo get_Item(int index)
		{
			return null;
		}

		public ProgressAwardDesc(uint sort)
		{
		}

		public int CompareTo(IAwardPoolDesc other)
		{
			return 0;
		}
	}

	public class ItemAwardDesc : IAwardPoolDesc, IComparable<IAwardPoolDesc>
	{
		private uint _003Cid_003Ek__BackingField;

		private uint _003Csort_003Ek__BackingField;

		private NinthSysAwardDesc.ELevel _003Clevel_003Ek__BackingField;

		private BaseItemInfo _003CitemInfo_003Ek__BackingField;

		private bool _003CisPrivilege_003Ek__BackingField;

		public int type => 0;

		public uint id
		{
			get
			{
				return _003Cid_003Ek__BackingField;
			}
			private set
			{
				_003Cid_003Ek__BackingField = value;
			}
		}

		public uint sort
		{
			get
			{
				return _003Csort_003Ek__BackingField;
			}
			private set
			{
				_003Csort_003Ek__BackingField = value;
			}
		}

		public NinthSysAwardDesc.ELevel level
		{
			get
			{
				return _003Clevel_003Ek__BackingField;
			}
			private set
			{
				_003Clevel_003Ek__BackingField = value;
			}
		}

		public BaseItemInfo itemInfo
		{
			get
			{
				return _003CitemInfo_003Ek__BackingField;
			}
			private set
			{
				_003CitemInfo_003Ek__BackingField = value;
			}
		}

		public bool isPrivilege
		{
			get
			{
				return _003CisPrivilege_003Ek__BackingField;
			}
			private set
			{
				_003CisPrivilege_003Ek__BackingField = value;
			}
		}

		public ItemAwardDesc(NinthSysAwardDesc desc, uint sort)
		{
		}

		public int CompareTo(IAwardPoolDesc other)
		{
			return 0;
		}
	}

	public enum EMissionType
	{
		BR,
		CS,
		LW,
		Daily
	}

	public interface INinthSYSMissionData : IComparable<INinthSYSMissionData>
	{
		uint type { get; }

		uint activity_id { get; }

		EActivity.State state { get; }

		uint TodayGetNum { get; }

		uint TodayLimitNum { get; }

		void Refersh();
	}

	public class NinthSYSMissionData : INinthSYSMissionData, IComparable<INinthSYSMissionData>
	{
		private ClientActivityDesc _003CActivityDesc_003Ek__BackingField;

		private ActivityClientInfo m_ActivityInfo;

		private uint _003Cactivity_id_003Ek__BackingField;

		private EActivity.State m_State;

		private uint _003Csort_id_003Ek__BackingField;

		private uint _003CTodayGetNum_003Ek__BackingField;

		private uint _003CTodayLimitNum_003Ek__BackingField;

		public uint type => 0u;

		public ClientActivityDesc ActivityDesc
		{
			get
			{
				return _003CActivityDesc_003Ek__BackingField;
			}
			private set
			{
				_003CActivityDesc_003Ek__BackingField = value;
			}
		}

		public ActivityClientInfo ActivityInfo => null;

		public uint activity_id
		{
			get
			{
				return _003Cactivity_id_003Ek__BackingField;
			}
			private set
			{
				_003Cactivity_id_003Ek__BackingField = value;
			}
		}

		public EActivity.State state => EActivity.State.State_RECEIVED;

		public uint sort_id
		{
			get
			{
				return _003Csort_id_003Ek__BackingField;
			}
			private set
			{
				_003Csort_id_003Ek__BackingField = value;
			}
		}

		public uint TodayGetNum
		{
			get
			{
				return _003CTodayGetNum_003Ek__BackingField;
			}
			private set
			{
				_003CTodayGetNum_003Ek__BackingField = value;
			}
		}

		public uint TodayLimitNum
		{
			get
			{
				return _003CTodayLimitNum_003Ek__BackingField;
			}
			private set
			{
				_003CTodayLimitNum_003Ek__BackingField = value;
			}
		}

		public uint GetPercent()
		{
			return 0u;
		}

		public NinthSYSMissionData(ClientActivityDesc desc)
		{
		}

		public void Refersh()
		{
		}

		public int CompareTo(INinthSYSMissionData other)
		{
			return 0;
		}
	}

	public class NinthSYSSpecialMissionData : INinthSYSMissionData, IComparable<INinthSYSMissionData>
	{
		private uint _003Ctype_003Ek__BackingField;

		private uint _003Cactivity_id_003Ek__BackingField;

		private EActivity.State _003Cstate_003Ek__BackingField;

		private uint _003CTodayGetNum_003Ek__BackingField;

		private uint _003CTodayLimitNum_003Ek__BackingField;

		private uint _003CTokenId_003Ek__BackingField;

		private uint _003CGoPos_003Ek__BackingField;

		private string _003CSubGoPos_003Ek__BackingField;

		private uint m_GameMode;

		public uint type
		{
			get
			{
				return _003Ctype_003Ek__BackingField;
			}
			private set
			{
				_003Ctype_003Ek__BackingField = value;
			}
		}

		public uint activity_id
		{
			get
			{
				return _003Cactivity_id_003Ek__BackingField;
			}
			private set
			{
				_003Cactivity_id_003Ek__BackingField = value;
			}
		}

		public EActivity.State state
		{
			get
			{
				return _003Cstate_003Ek__BackingField;
			}
			private set
			{
				_003Cstate_003Ek__BackingField = value;
			}
		}

		public uint TodayGetNum
		{
			get
			{
				return _003CTodayGetNum_003Ek__BackingField;
			}
			private set
			{
				_003CTodayGetNum_003Ek__BackingField = value;
			}
		}

		public uint TodayLimitNum
		{
			get
			{
				return _003CTodayLimitNum_003Ek__BackingField;
			}
			private set
			{
				_003CTodayLimitNum_003Ek__BackingField = value;
			}
		}

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

		public uint GoPos
		{
			get
			{
				return _003CGoPos_003Ek__BackingField;
			}
			private set
			{
				_003CGoPos_003Ek__BackingField = value;
			}
		}

		public string SubGoPos
		{
			get
			{
				return _003CSubGoPos_003Ek__BackingField;
			}
			private set
			{
				_003CSubGoPos_003Ek__BackingField = value;
			}
		}

		public NinthSYSSpecialMissionData(uint type, uint tokenId)
		{
		}

		public bool Init()
		{
			return false;
		}

		public void Refersh()
		{
		}

		public int CompareTo(INinthSYSMissionData other)
		{
			return 0;
		}
	}

	public enum ETaskType
	{
		None,
		UI_OUT,
		StatueAnimation,
		PrivilegeShow,
		RewardShow,
		UIEnter,
		VFXFly
	}

	public class Task
	{
		public enum ETaskState
		{
			Inactive,
			Running,
			Completed,
			Cancelled
		}

		private ETaskType _003CTaskType_003Ek__BackingField;

		private ETaskState _003CState_003Ek__BackingField;

		private float m_Duration;

		private float m_ElapsedTime;

		private Action m_OnStarted;

		private Action m_OnCompleted;

		private Action m_OnCancelled;

		public ETaskType TaskType
		{
			get
			{
				return _003CTaskType_003Ek__BackingField;
			}
			private set
			{
				_003CTaskType_003Ek__BackingField = value;
			}
		}

		public ETaskState State
		{
			get
			{
				return _003CState_003Ek__BackingField;
			}
			private set
			{
				_003CState_003Ek__BackingField = value;
			}
		}

		public bool IsRunning => false;

		public bool IsFinished => false;

		public bool IsInactive => false;

		public Task(ETaskType taskType)
		{
		}

		public Task AddOnStarted(Action onStarted)
		{
			return null;
		}

		public Task AddOnCompleted(Action onCompleted)
		{
			return null;
		}

		public Task AddOnCancelled(Action onCancelled)
		{
			return null;
		}

		public void Reset()
		{
		}

		public bool Activate()
		{
			return false;
		}

		public bool SetTaskLifeTime(float duration)
		{
			return false;
		}

		public void Update(float deltaTime)
		{
		}

		public bool Complete()
		{
			return false;
		}

		public bool Cancel()
		{
			return false;
		}
	}

	public class Sequence
	{
		private sealed class _003C_003Ec__DisplayClass10_0
		{
			public ETaskType taskType;

			internal bool _003CCompleteTask_003Eb__0(Task t)
			{
				return false;
			}
		}

		private sealed class _003C_003Ec__DisplayClass12_0
		{
			public ETaskType taskType;

			internal bool _003CDestroyTaskImmediate_003Eb__0(Task t)
			{
				return false;
			}
		}

		private sealed class _003C_003Ec__DisplayClass13_0
		{
			public ETaskType taskType;

			internal bool _003CIsFinished_003Eb__0(Task t)
			{
				return false;
			}
		}

		private sealed class _003C_003Ec__DisplayClass14_0
		{
			public ETaskType taskType;

			internal bool _003CIsActivated_003Eb__0(Task t)
			{
				return false;
			}
		}

		private sealed class _003C_003Ec__DisplayClass6_0
		{
			public ETaskType taskType;

			internal bool _003CAddTask_003Eb__0(Task t)
			{
				return false;
			}
		}

		private sealed class _003C_003Ec__DisplayClass7_0
		{
			public ETaskType taskType;

			internal bool _003CActivateTask_003Eb__0(Task t)
			{
				return false;
			}
		}

		private sealed class _003C_003Ec__DisplayClass8_0
		{
			public ETaskType taskType;

			internal bool _003CActivateTask_003Eb__0(Task t)
			{
				return false;
			}
		}

		private sealed class _003C_003Ec__DisplayClass9_0
		{
			public ETaskType taskType;

			internal bool _003CSetTaskLifeTime_003Eb__0(Task t)
			{
				return false;
			}
		}

		private List<Task> m_Tasks;

		private Action m_OnAllTasksCompleted;

		private bool m_IsCompleted;

		public bool IsCompleted => false;

		public Sequence AddOnAllTasksCompleted(Action onAllTasksCompleted)
		{
			return null;
		}

		public Task AddTask(ETaskType taskType)
		{
			return null;
		}

		public bool ActivateTask(ETaskType taskType)
		{
			return false;
		}

		public bool ActivateTask(ETaskType taskType, float duration)
		{
			return false;
		}

		public bool SetTaskLifeTime(ETaskType taskType, float duration)
		{
			return false;
		}

		public bool CompleteTask(ETaskType taskType)
		{
			return false;
		}

		public bool AllTasksCompletedExcept(ETaskType taskType)
		{
			return false;
		}

		public bool DestroyTaskImmediate(ETaskType taskType)
		{
			return false;
		}

		public bool IsFinished(ETaskType taskType)
		{
			return false;
		}

		public bool IsActivated(ETaskType taskType)
		{
			return false;
		}

		public void Update(float deltaTime)
		{
		}

		public void Dispose()
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

	public class EffectBaseGo : SimpleGo
	{
		public EffectBaseGo(bool aSync)
			: base(aSync: false)
		{
		}

		public virtual bool Update(float deltaTime)
		{
			return false;
		}
	}

	public class EffectGo : EffectBaseGo
	{
		protected float m_Duration;

		protected float m_Time;

		public EffectGo(bool aSync)
			: base(aSync: false)
		{
		}

		public void Play(ResourceID resId, float duration, Transform parent)
		{
		}

		public void Play(ResourceID resId, float duration, Transform parent, Vector3 position)
		{
		}

		public void Play(ResourceID resId, float duration, Transform parent, Vector3 position, bool local)
		{
		}

		public void Play(ResourceID resId, float delay, float duration, Transform parent)
		{
		}

		public void Play(ResourceID resId, float delay, float duration, Transform parent, Vector3 position)
		{
		}

		public void Play(ResourceID resId, float delay, float duration, Transform parent, Vector3 position, bool local)
		{
		}

		public void Reset()
		{
		}

		public void Reset(float duration)
		{
		}

		public void Reset(float delay, float duration)
		{
		}

		public override bool Update(float deltaTime)
		{
			return false;
		}

		public bool _003C_003EiFixBaseProxy_Update(float P0)
		{
			return false;
		}
	}

	public class CallbackEffectGo : EffectGo
	{
		private Action<CallbackEffectGo> m_Callback;

		private bool m_IsCallbackExecuted;

		public CallbackEffectGo(bool aSync)
			: base(aSync: false)
		{
		}

		public void AddCallback(Action<CallbackEffectGo> callback)
		{
		}

		public void Play(float duration)
		{
		}

		public override void Destroy()
		{
		}

		public override bool Update(float deltaTime)
		{
			return false;
		}

		public void _003C_003EiFixBaseProxy_Destroy()
		{
		}

		public new bool _003C_003EiFixBaseProxy_Update(float P0)
		{
			return false;
		}
	}

	public class FlyGo : EffectBaseGo
	{
		protected float m_Duration;

		protected float m_Time;

		protected Vector3 m_StartPoint;

		protected Vector3 m_EndPoint;

		protected Vector3 m_MiddlePoint;

		protected bool isLinear;

		protected float m_DelayDestroy;

		protected bool isRotation;

		public FlyGo(bool aSync)
			: base(aSync: false)
		{
		}

		public void PlayLinear(ResourceID resId, Vector3 start, Vector3 end, float duration, Transform parent, float destroy = 0f)
		{
		}

		public void PlayBezier(ResourceID resId, Vector3 start, Vector3 end, Vector3 middle, float duration, Transform parent, float destroy = 0f)
		{
		}

		protected override void OnOnEffectGoLoadedCompleteCallback(UnityEngine.Object obj, Transform parent)
		{
		}

		public override bool Update(float deltaTime)
		{
			return false;
		}

		private void LinearMotion()
		{
		}

		private void LinearBezier()
		{
		}

		public void _003C_003EiFixBaseProxy_OnOnEffectGoLoadedCompleteCallback(UnityEngine.Object P0, Transform P1)
		{
		}

		public bool _003C_003EiFixBaseProxy_Update(float P0)
		{
			return false;
		}
	}

	public class CallbackFlyGo : FlyGo
	{
		private Action<CallbackFlyGo> m_Callback;

		private bool m_IsCallbackExecuted;

		public CallbackFlyGo(bool aSync)
			: base(aSync: false)
		{
		}

		public void AddCallback(Action<CallbackFlyGo> callback)
		{
		}

		public override bool Update(float deltaTime)
		{
			return false;
		}

		public override void Destroy()
		{
		}

		public new bool _003C_003EiFixBaseProxy_Update(float P0)
		{
			return false;
		}

		public void _003C_003EiFixBaseProxy_Destroy()
		{
		}
	}

	private struct PendingGoposData
	{
		public uint EntranceId;

		public uint SubType;

		private bool m_IsValid;

		public bool IsValid => false;

		public void Reset()
		{
		}

		public void SetData(uint entranceId, uint subType)
		{
		}
	}

	private struct NinthSpecialStateTeleportPending
	{
		public Player.KDOJONOLNKG State;

		public float Radius;

		public uint TimeoutId;

		public bool IsEventRegistered;

		public bool IsValid => false;

		public void Reset()
		{
		}
	}

	public class NinthProgressLoadingProcess : LoadingProcess
	{
		private float m_ExitPoint;

		protected override void OnStartProcess()
		{
		}

		protected override EProcessStatus OnUpdateProcess()
		{
			return EProcessStatus.NotStarted;
		}

		public void _003C_003EiFixBaseProxy_OnStartProcess()
		{
		}

		public EProcessStatus _003C_003EiFixBaseProxy_OnUpdateProcess()
		{
			return EProcessStatus.NotStarted;
		}
	}

	public struct SubProgressData
	{
		private uint[] vals = null;

		// C# has no syntax for parameterized property 'Item'.
		public uint get_Item(int index)
		{
			return 0u;
		}

		public SubProgressData(uint progress)
		{
		}

		public int GetIndex(uint val)
		{
			return 0;
		}
	}

	public enum Status
	{
		Lock,
		Explore,
		Claimable,
		Claimed
	}

	public interface IProgress
	{
		int stage { get; }

		uint id { get; }

		Status status { get; }

		uint progress { get; }

		uint MinProgress { get; }

		uint MaxProgress { get; }

		List<AwardDesc> awards { get; }

		int SetProgress(uint val);

		bool SetStatus(uint[] claimed_progress);

		int GetProgressStatus(uint val);

		void Clear();
	}

	public interface ICycleProgress : IProgress
	{
		uint claimableCount { get; }

		bool isClaimed { get; }

		uint GetProgress(uint val);

		uint GetClaimableCount(uint val);
	}

	public interface INormalProgress : IProgress
	{
		uint normalCdn { get; }

		uint claimedCdn { get; }

		int GetStageIndex(uint val);

		uint GetSubProgress(int index);
	}

	public class ProgressData : IProgress
	{
		private int _003Cstage_003Ek__BackingField;

		protected uint mId;

		protected Status mStatus;

		private uint _003Cprogress_003Ek__BackingField;

		protected uint mMinProgress;

		protected uint mMaxProgress;

		private List<AwardDesc> _003Cawards_003Ek__BackingField;

		public int stage
		{
			get
			{
				return _003Cstage_003Ek__BackingField;
			}
			private set
			{
				_003Cstage_003Ek__BackingField = value;
			}
		}

		public virtual uint id => 0u;

		public virtual Status status => Status.Lock;

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

		public ProgressData(int stage, uint beforeProgress, uint currentProgress, List<AwardDesc> awards)
		{
		}

		public virtual int SetProgress(uint val)
		{
			return 0;
		}

		public virtual bool SetStatus(uint[] claimed_progress)
		{
			return false;
		}

		public virtual int GetProgressStatus(uint val)
		{
			return 0;
		}

		public virtual void Clear()
		{
		}
	}

	public class NormalProgressData : ProgressData, INormalProgress, IProgress
	{
		private uint _003CnormalCdn_003Ek__BackingField;

		private uint _003CclaimedCdn_003Ek__BackingField;

		private SubProgressData mSubProgressData;

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

		public NormalProgressData(int stage, uint beforeProgress, uint currentProgress, List<AwardDesc> awards, uint normalCdn, uint claimedCdn)
			: base(0, 0u, 0u, null)
		{
		}

		public int GetStageIndex(uint val)
		{
			return 0;
		}

		public uint GetSubProgress(int index)
		{
			return 0u;
		}
	}

	public class CycleProgressData : ProgressData, ICycleProgress, IProgress
	{
		private uint mMaxCount;

		private uint mClaimedCount;

		private uint mClaimableCount;

		public override uint id => 0u;

		public uint claimableCount => 0u;

		public bool isClaimed => false;

		public override uint MaxProgress => 0u;

		public override Status status => Status.Lock;

		public CycleProgressData(int stage, uint beforeProgress, uint currentProgress, List<AwardDesc> awards, uint max_count)
			: base(0, 0u, 0u, null)
		{
		}

		public override int SetProgress(uint val)
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

		public override bool SetStatus(uint[] claimed_progress)
		{
			return false;
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

		public Status _003C_003EiFixBaseProxy_get_status()
		{
			return Status.Lock;
		}

		public int _003C_003EiFixBaseProxy_SetProgress(uint P0)
		{
			return 0;
		}

		public bool _003C_003EiFixBaseProxy_SetStatus(uint[] P0)
		{
			return false;
		}

		public void _003C_003EiFixBaseProxy_Clear()
		{
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<Player> _003C_003E9__213_0;

		public static Action<Player> _003C_003E9__214_0;

		public static Action<Player> _003C_003E9__215_0;

		public static Action<Player> _003C_003E9__216_0;

		public static Action<Player> _003C_003E9__217_0;

		public static Action<Player> _003C_003E9__218_0;

		public static Action<Player> _003C_003E9__219_0;

		public static Comparison<NinthSysActivityTipsDesc> _003C_003E9__231_0;

		internal void _003COnCancelCarryStateCallback_003Eb__213_0(Player localPlayer)
		{
		}

		internal void _003COnCancelDancePoolStateCallback_003Eb__214_0(Player localPlayer)
		{
		}

		internal void _003COnCancelLobbyLWStateCallback_003Eb__215_0(Player localPlayer)
		{
		}

		internal void _003COnCancelSeesawStateCallback_003Eb__216_0(Player localPlayer)
		{
		}

		internal void _003COnCancelFollowEmoteStateCallback_003Eb__217_0(Player localPlayer)
		{
		}

		internal void _003COnCancelCatapultStateCallback_003Eb__218_0(Player localPlayer)
		{
		}

		internal void _003COnCancelChairStateCallback_003Eb__219_0(Player localPlayer)
		{
		}

		internal int _003CGetMissionPromptDesc_003Eb__231_0(NinthSysActivityTipsDesc a, NinthSysActivityTipsDesc b)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass188_0
	{
		public UIModelMatch matchModel;

		public UIModelNinthSYS _003C_003E4__this;

		internal void _003CExecuteClickNinthEntrance_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass69_0
	{
		public UIModelNinthSYS _003C_003E4__this;

		public string cmd;

		internal void _003CRequestSetting_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass70_0
	{
		public UIModelNinthSYS _003C_003E4__this;

		public string cmd;

		internal void _003CRequestInfo_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass72_0
	{
		public UIModelNinthSYS _003C_003E4__this;

		public string cmd;

		internal void _003CRequestClaimProgressReward_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass72_1
	{
		public bool redResult;

		internal void _003CRequestClaimProgressReward_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass73_0
	{
		public UIModelNinthSYS _003C_003E4__this;

		public string cmd;

		internal void _003CRequestRedDot_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass74_0
	{
		public UIModelNinthSYS _003C_003E4__this;

		public string cmd;

		internal void _003CRequestConsumeToken_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	public const uint PropID_NinthSYSSetting = 2u;

	public const uint PropID_NinthSYSInfo = 4u;

	public const uint PropID_NinthSYSRed = 8u;

	public const uint PropID_NinthSYSProgressStatus = 16u;

	public const uint PropID_NinthSYSProgress = 32u;

	private uint _003CGuaranteedCount_003Ek__BackingField;

	private uint _003CGuaranteedDrawCount_003Ek__BackingField;

	private bool _003CIsFreeConsume_003Ek__BackingField;

	private CSConsumeNinthSysTokenRes m_CacheConsumeTokenRes;

	private NinthSysSettingDesc _003CSettingDesc_003Ek__BackingField;

	private CSGetNinthSysInfoRes m_InfoRes;

	private bool m_IsRequestHttpError;

	private WaitingResponseHandler m_WaitingResponse;

	private bool m_RedDotFetched;

	private Dictionary<uint, NinthSysAwardDesc> m_AwardDescDict;

	private List<NinthSysActivityMultiRewardDesc> m_ActivityMultiRewardDescList;

	private List<IAwardPoolDesc> m_AwardPoolDescList;

	private bool _003CIsPlayLobbyEntranceSound_003Ek__BackingField;

	private int m_TokenAllInResult;

	private List<NinthSysSkillDesc> m_NinthSysSkillDescList;

	private List<NinthSysGamePlayDesc> m_NinthSysGamePlayDescList;

	private List<uint> m_PeakDayAllClaimValues;

	public const string GUIDEBUTTON_SPRITENAME = "FF_UI_Ninth_SYS_Btn_Big_Go";

	public const string NORMALBUTTON_SPRITENAME = "FF_UI_Ninth_SYS_Btn_Big_Claimall";

	public const string RULE_DESC = "T_54_ZP_NINTH_SYS_HELP_DESC";

	public const string PRIZE_DRAW_PROMPT_KEY = "T_54_ZP_NINTH_SYS_LUCKTIMES";

	public const string CHECK_DAY_LABEL = "T_54_ZP_NINTH_SYS_PEAKDAY_DAY";

	public const string DAILY_MISSION_PROMPT_KEY = "T_54_ZP_NINTH_SYS_MISSION_BUBBLE01";

	public const string SPECIAL_MISSION_PROMPT_KEY = "T_54_ZP_NINTH_SYS_MISSION_BUBBLE02";

	public const string RETURN_TO_STATUE_BY_CARRY = "T_54_ZP_NINTH_SYS_OTHER_STATUS04";

	public const string RETURN_TO_STATUE_BY_DANCEPOOL = "T_54_ZP_NINTH_SYS_OTHER_STATUS03";

	public const string RETURN_TO_STATUE_BY_LW = "T_54_ZP_NINTH_SYS_OTHER_STATUS01";

	public const string RETURN_TO_STATUE_BY_SEESAW = "T_54_ZP_NINTH_SYS_OTHER_STATUS05";

	public const string RETURN_TO_STATUE_BY_FOLLOW_EMOTE = "T_54_ZP_NINTH_SYS_OTHER_STATUS02";

	public const string RETURN_TO_STATUE_BY_CATAPULT = "T_54_ZP_NINTH_SYS_OTHER_STATUS07";

	public const string RETURN_TO_STATUE_BY_CHAIR = "T_54_ZP_NINTH_SYS_OTHER_STATUS06";

	public const string TELEPORT_FAILED_BY_CARRY = "T_54_ZP_NINTH_SYS_TELEPORT_STATUS04";

	public const string TELEPORT_FAILED_BY_DANCEPOOL = "T_54_ZP_NINTH_SYS_TELEPORT_STATUS03";

	public const string TELEPORT_FAILED_BY_LW = "T_54_ZP_NINTH_SYS_TELEPORT_STATUS01";

	public const string TELEPORT_FAILED_BY_SEESAW = "T_54_ZP_NINTH_SYS_TELEPORT_STATUS05";

	public const string TELEPORT_FAILED_BY_FOLLOW_EMOTE = "T_52_B_TREA25_GP_ASTROLGATE_ERROR1";

	public const string TELEPORT_FAILED_BY_CATAPULT = "T_54_ZP_NINTH_SYS_TELEPORT_STATUS07";

	public const string TELEPORT_FAILED_BY_CHAIR = "T_54_ZP_NINTH_SYS_TELEPORT_STATUS06";

	public const string SWITCH_FAILED_BY_MATCHMAKING = "T_54_ZP_NINTH_SYS_SWITCH_FAILED_MATCHMAKING";

	public const int CDNTypeMainTitle = 58001;

	public const int CDNTypePeakDay = 58002;

	public const int CDNTypeMissionTitle = 58003;

	public const int CDNTypePeakDayBigPrize = 58101;

	public const int CDNTypePeakDayBigPrize2 = 58102;

	public const int CDNType2DModel = 58004;

	public const int CDNType3DModel = 58005;

	public const string MAIN_FIRSTIN_ANIM = "UIFX_Ninth_SYS_Main_In";

	public const string MAIN_IN_ANIM = "UIFX_Ninth_SYS_Main_In";

	public const string MAIN_OUT_ANIM = "UIFX_Ninth_SYS_Main_Out";

	public const string ANIM_EVENT_FIRSTMAIN_IN = "UINinthSYS_AnimEvent_FirstMainIn";

	public const string ANIM_EVENT_CUTSCENE_END = "UINinthSYS_AnimEvent_CutScene_End";

	public const string TRANSITION_OUT_ANIM = "UIFX_Ninth_SYS_Main_Out";

	public const string TRANSITION_IN_ANIM = "UIFX_Ninth_SYS_Main_In";

	public const int AwardPoolType_Progress = 1;

	public const int AwardPoolType_Separator = 2;

	public const int AwardPoolType_Title = 3;

	public const int AwardPoolType_Item = 4;

	public const int QUALITY_LOW = 0;

	public const int QUALITY_MIDDLE = 1;

	public const int QUALITY_HIGH = 2;

	private int m_IsDefault3DLobby;

	private string m_PendingGotoMapModeSubGopos;

	private UINavigationUtil.GotoParams m_PendingGotoMapModeGotoParams;

	private readonly string GuideKey_2D;

	private readonly string GuideKey_3D;

	private readonly string SocialEnterCount;

	private PendingGoposData m_PendingGoposData;

	private bool m_IsLobbyPrompt;

	private bool m_Is2DGuide;

	private const float SPECIAL_STATE_TELEPORT_TIMEOUT = 5f;

	private NinthSpecialStateTeleportPending m_PendingSpecialStateTeleport;

	private bool m_IsCancelSpecialStateActionRunning;

	private List<INinthSYSMissionData> m_MissionDataList;

	private bool _003CSpecialMissionDataLoaded_003Ek__BackingField;

	private List<NinthSysActivityTipsDesc> m_ActivityTipsDesc;

	private readonly List<NinthSysActivityTipsDesc> m_TempEventDescList;

	public const int NORMAL_PROGRESS_COUNT = 5;

	public const int MAX_PROGRESS_COUNT = 6;

	public const string BUNDLE_REWARDPREVIEW_DESC = "T_54_ZP_NINTH_SYS_PREVIEW_DES01";

	public const string OPTIONALBUNDLE_REWARDPREVIEW_DESC = "T_54_ZP_NINTH_SYS_PREVIEW_DES01";

	public const string TREASUREBOX_REWARDPREVIEW_DESC = "T_54_ZP_NINTH_SYS_PREVIEW_DES02";

	public const int PROGRESS_STAGE_NUM = 3;

	public const int PROGRESS_STAGE_MAX_NUM = 15;

	private bool _003CProgressRedDot_003Ek__BackingField;

	private uint _003CCurrentProgress_003Ek__BackingField;

	private uint _003CNormalMaxProgress_003Ek__BackingField;

	private IProgress[] m_ProgressData;

	public uint TokenId => 0u;

	private uint TokenConsume => 0u;

	private uint TokenConsumeCycle => 0u;

	public uint GuaranteedCount
	{
		get
		{
			return _003CGuaranteedCount_003Ek__BackingField;
		}
		private set
		{
			_003CGuaranteedCount_003Ek__BackingField = value;
		}
	}

	public uint GuaranteedDrawCount
	{
		get
		{
			return _003CGuaranteedDrawCount_003Ek__BackingField;
		}
		private set
		{
			_003CGuaranteedDrawCount_003Ek__BackingField = value;
		}
	}

	public bool IsFreeConsume
	{
		get
		{
			return _003CIsFreeConsume_003Ek__BackingField;
		}
		private set
		{
			_003CIsFreeConsume_003Ek__BackingField = value;
		}
	}

	public NinthSysSettingDesc SettingDesc
	{
		get
		{
			return _003CSettingDesc_003Ek__BackingField;
		}
		private set
		{
			_003CSettingDesc_003Ek__BackingField = value;
		}
	}

	public bool HaveData => false;

	public bool IsPlayLobbyEntranceSound
	{
		get
		{
			return _003CIsPlayLobbyEntranceSound_003Ek__BackingField;
		}
		set
		{
			_003CIsPlayLobbyEntranceSound_003Ek__BackingField = value;
		}
	}

	public bool TokenAllIn => false;

	public bool IsDefault3DLobby => false;

	public bool SpecialMissionDataLoaded
	{
		get
		{
			return _003CSpecialMissionDataLoaded_003Ek__BackingField;
		}
		private set
		{
			_003CSpecialMissionDataLoaded_003Ek__BackingField = value;
		}
	}

	public bool ProgressRedDot
	{
		get
		{
			return _003CProgressRedDot_003Ek__BackingField;
		}
		private set
		{
			_003CProgressRedDot_003Ek__BackingField = value;
		}
	}

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

	public Type GetLobbyEntranceType()
	{
		return null;
	}

	public bool CanGotoWhenBigEventClosed()
	{
		return false;
	}

	public bool CanIngoreDownloadRes(UIModelBigEvent.EBigEventEntranceID entranceId)
	{
		return false;
	}

	public bool OptionalResNeedDownload()
	{
		return false;
	}

	public bool NeedDownloadNinthSysOptionalResources()
	{
		return false;
	}

	public void GotoBigEvent(string from, UIModelBigEvent.EBigEventEntranceID entranceId, ELimitedEvent.EventState activityState, string param, ulong subType3, object extra)
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

	public void OnProcessEventOpenInfo()
	{
	}

	public override uint GetModelType()
	{
		return 0u;
	}

	public void SetTokenAllInResult(bool val)
	{
	}

	public NinthSysAwardDesc GetAwardDesc(uint id)
	{
		return null;
	}

	public List<IAwardPoolDesc> GetAwardPoolDescs()
	{
		return null;
	}

	public uint GetPeakDayBigPrizeCdnID(uint activity_id, uint val)
	{
		return 0u;
	}

	public List<NinthSysSkillDesc> GetSkillDescList()
	{
		return null;
	}

	public List<NinthSysGamePlayDesc> GetGamePlayDescList()
	{
		return null;
	}

	public CSConsumeNinthSysTokenRes PopCacheConsumeTokenRes()
	{
		return null;
	}

	public bool IsTokenCusumeGuide()
	{
		return false;
	}

	public void SaveTokenCusumeGuide()
	{
	}

	public override void Logout(object[] data)
	{
	}

	protected override void OnSceneChange(object[] data)
	{
	}

	public void RequestSetting()
	{
	}

	public void RequestInfo()
	{
	}

	private void ProcessInfoData()
	{
	}

	public void RequestClaimProgressReward(uint id)
	{
	}

	public void RequestRedDot()
	{
	}

	public bool RequestConsumeToken()
	{
		return false;
	}

	public bool RequestPeakDayAllClaim()
	{
		return false;
	}

	public bool GetGiftRedDot()
	{
		return false;
	}

	public void LogClick(string posfix, UIModelBigEvent.EBigEventEntranceID entranceID)
	{
	}

	public void LogClick(string posfix)
	{
	}

	public uint GetNinthActivityEndTime()
	{
		return 0u;
	}

	public void TryGotoNavigation(UINavigationUtil.UINavigationFrom from, uint gotoPos, string sub_gopos, string backup_sub_gopos)
	{
	}

	private string[] GetV2NaviDataArray(string param)
	{
		return null;
	}

	private string[] CustomSplitV2NaviData(string param)
	{
		return null;
	}

	private object GetV2NaviDataValue<T>(string[] array, string dataKey, T dataValue)
	{
		return null;
	}

	private static int GetAwardPoolSortPriority(IAwardPoolDesc desc)
	{
		return 0;
	}

	public int GetQuality()
	{
		return 0;
	}

	public int GetRecommondedQuality()
	{
		return 0;
	}

	public bool IsNinthResReady()
	{
		return false;
	}

	public bool IsNinthLimitedEventOpen()
	{
		return false;
	}

	private void CheckIsDefault3DLobby()
	{
	}

	public void SetPendingGotoMapModeGotoParams(UINavigationUtil.GotoParams gotoParams)
	{
	}

	public void SetPendingGotoMapModeSubGopos(string mapString)
	{
	}

	public void SetPendingGotoMapModeSubGopos(uint team, uint match, uint map, uint game, int difficulty, bool needAutoExpandGroup)
	{
	}

	public void ClearPendingGotoMapModeSubGopos()
	{
	}

	private bool TryGotoMapModeInternal()
	{
		return false;
	}

	public bool TryGotoMapMode()
	{
		return false;
	}

	public void AddLobbySwitch2DGuideKey(uint val)
	{
	}

	public void RemoveLobbySwitch2DGuideKey(uint val)
	{
	}

	public void SaveLobbySwitch3DGuideKey(uint val)
	{
	}

	public uint GetLobbySwitch2DGuideKey()
	{
		return 0u;
	}

	public uint GetLobbySwitch3DGuideKey()
	{
		return 0u;
	}

	public int GetSocialEnterCount()
	{
		return 0;
	}

	public void AddSocialEnterCount()
	{
	}

	public bool TryPlayStatueAnimation(uint level, out float duration)
	{
		duration = default(float);
		return false;
	}

	public bool TryPlayTokenVFXFlyAnimation(out float duration)
	{
		duration = default(float);
		return false;
	}

	private void RefreshRewardPoolAction()
	{
	}

	public void ExecuteEnterNinthAreaUILogic()
	{
	}

	public void ExecuteExitNinthAreaUILogic()
	{
	}

	public void TryRecoverNinthUI()
	{
	}

	public void ExecuteClickNinthEntrance(UIModelBigEvent.EBigEventEntranceID entranceId, uint subType = 0u)
	{
	}

	public void ExecuteClickCloseBtn()
	{
	}

	private void SaveReturnToLobbyKey()
	{
	}

	public bool IsReturnToLobbyKey()
	{
		return false;
	}

	public void ClearLobbyPrompt()
	{
	}

	public void SetDefault3DLobby(bool isDefault3DLobby)
	{
	}

	private void BeginCancelSpecialStateThenTeleport(Player.KDOJONOLNKG state, float radius, Action<Player> cancelAction, bool registerStateChangedEvent = true)
	{
	}

	private void RegisterPendingSpecialStateEvent()
	{
	}

	private void UnregisterPendingSpecialStateEvent()
	{
	}

	private void ClearPendingSpecialStateTeleport()
	{
	}

	private void OnPendingSpecialStateChanged(uint data)
	{
	}

	private void OnPendingSpecialStateTeleportTimeout()
	{
	}

	private bool TryCompletePendingSpecialStateTeleport(bool immediately)
	{
		return false;
	}

	private bool IsSpecialStateCleared(Player localPlayer, Player.KDOJONOLNKG state)
	{
		return false;
	}

	private string GetTeleportFailedLocKey(Player.KDOJONOLNKG state)
	{
		return null;
	}

	private void OnClickReturnToLobbyCallback()
	{
	}

	private void OnClickGotoSocialAreaCallback()
	{
	}

	private bool CheckLocalPlayerInSpecialState(out string desc, out Action confirmCallback, out Action cancelCallback, out bool ignorePopWnd)
	{
		desc = null;
		confirmCallback = null;
		cancelCallback = null;
		ignorePopWnd = default(bool);
		return false;
	}

	private void OnCommonCancelCallback()
	{
	}

	private void OnCancelCarryStateCallback()
	{
	}

	private void OnCancelDancePoolStateCallback()
	{
	}

	private void OnCancelLobbyLWStateCallback()
	{
	}

	private void OnCancelSeesawStateCallback()
	{
	}

	private void OnCancelFollowEmoteStateCallback()
	{
	}

	private void OnCancelCatapultStateCallback()
	{
	}

	private void OnCancelChairStateCallback()
	{
	}

	public void SetActivityTipsDesc(List<NinthSysActivityTipsDesc> descs)
	{
	}

	public List<INinthSYSMissionData> GetMissionList()
	{
		return null;
	}

	private void LoadSpecialMissionData(ref List<INinthSYSMissionData> missionDataList)
	{
	}

	public bool GetMissionPromptDesc(out string promptDesc)
	{
		promptDesc = null;
		return false;
	}

	private NinthSysActivityTipsDesc GetActivityTipsDesc(uint activity_id, uint percent)
	{
		return null;
	}

	public bool GetProgressIconInfo(out bool isNormal, out string iconUrl)
	{
		isNormal = default(bool);
		iconUrl = null;
		return false;
	}

	public IProgress GetProgress(int index)
	{
		return null;
	}

	public int GetProgressIndex(uint val)
	{
		return 0;
	}

	public float GetProgressFillAmount(uint val)
	{
		return 0f;
	}

	public uint GetTokenConsume()
	{
		return 0u;
	}

	private bool GetAllInProgressVal(out uint val)
	{
		val = default(uint);
		return false;
	}

	private void InitProgress(List<BigEventProgressAwardDesc> progress_awards, BigEventProgressCycleAwardDesc cycle_award)
	{
	}

	private void ClearProgress()
	{
	}

	private void SetProgressStatus(uint[] claimed_progress)
	{
	}

	private void SetProgress(uint cur_progress)
	{
	}

	private bool CalcProgressRedDot()
	{
		return false;
	}

	private void _003CExecuteClickNinthEntrance_003Eb__188_2()
	{
	}

	private void _003CExecuteClickNinthEntrance_003Eb__188_1()
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnSceneChange(object[] P0)
	{
	}
}
