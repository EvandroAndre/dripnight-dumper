using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UMA;
using UnityEngine;

namespace COW;

public class UIAnimedAvatar : UIAvatar, IPausable, IAvatarProvider
{
	public enum GunType
	{
		None,
		ShortGun,
		ShortGunIdle,
		BigGun,
		BigGunIdle,
		SmallGun,
		SmallGunIdle,
		Grenade,
		GrenadeIdle,
		ShotGun,
		ShotGunIdle,
		Gatling,
		GatlingIdle,
		Fist,
		FistAttack,
		DoubleWeapon,
		DoubleWeaponIdle,
		Katana,
		KatanaIdle,
		Rifle,
		RifleIdle
	}

	private class TransCache
	{
		public Transform Parent;

		public Vector3 Pos;

		public Vector3 Scale;

		public Quaternion Rot;

		public TransCache(Transform tr)
		{
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<AnimationClip> _003C_003E9__187_0;

		public static Predicate<AnimationClip> _003C_003E9__187_1;

		public static Predicate<AnimationClip> _003C_003E9__305_0;

		public static Predicate<AnimationClip> _003C_003E9__384_0;

		internal bool _003CBuildEffectsTriggerBackpackAndAttach_003Eb__187_0(AnimationClip clip)
		{
			return false;
		}

		internal bool _003CBuildEffectsTriggerBackpackAndAttach_003Eb__187_1(AnimationClip clip)
		{
			return false;
		}

		internal bool _003CStartShowPose_003Eb__305_0(AnimationClip s)
		{
			return false;
		}

		internal bool _003CInitGunShowTime_003Eb__384_0(AnimationClip s)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass203_0
	{
		public UIAnimedAvatar _003C_003E4__this;

		public uint flag;

		public ResourceID resId;

		public bool loop;

		public bool playIdleAlternate;

		public GroupAnimData groupAnimData;

		public float playIdleDeltaTime;

		public bool showMvpAnim;

		internal void _003CPlayAnimClipAtLobby_003Eb__0()
		{
		}

		internal void _003CPlayAnimClipAtLobby_003Eb__1(uint tid, bool ret, UnityEngine.Object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass235_0
	{
		public ResourceID soundId2;

		internal void _003CCoPlayWeaponAnimationd_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass235_1
	{
		public ResourceID soundId2;

		internal void _003CCoPlayWeaponAnimationd_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass376_0
	{
		public UIAnimedAvatar _003C_003E4__this;

		public bool show;

		public Action _003C_003E9__1;

		internal void _003CShowWeaponNotImmiately_003Eb__0()
		{
		}

		internal void _003CShowWeaponNotImmiately_003Eb__1()
		{
		}
	}

	private sealed class _003CCoPlayAnimClipAtLobby_003Ed__206 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIAnimedAvatar _003C_003E4__this;

		public GroupAnimData groupAnimData;

		public bool showMvpAnim;

		public ResourceID resId;

		public bool playIdleAlternate;

		public bool loop;

		public float playIdleDeltaTime;

		private int _003CwaitedFrames_003E5__2;

		private Animation _003CcameraAnimation_003E5__3;

		private float _003Clength_003E5__4;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoPlayAnimClipAtLobby_003Ed__206(int _003C_003E1__state)
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

	private sealed class _003CCoPlayEmotionAnimationd_003Ed__240 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public uint emotionID;

		public bool loop;

		public UIAnimedAvatar _003C_003E4__this;

		public EDuoEmoteStage duoEmoteStage;

		public EmoteExtralInfo extralInfo;

		private EmoteData _003CemotionData_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoPlayEmotionAnimationd_003Ed__240(int _003C_003E1__state)
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

	private sealed class _003CCoPlayLastKillAnimation_003Ed__274 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIAnimedAvatar _003C_003E4__this;

		public ResourceID lastKillAnimID;

		public bool isLoop;

		public bool needGotoStandIdle;

		public float idleTime;

		private int _003CwaitedFrames_003E5__2;

		private float _003ClengthNormalToLastKill_003E5__3;

		private float _003ClengthLastKill_003E5__4;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoPlayLastKillAnimation_003Ed__274(int _003C_003E1__state)
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

	private sealed class _003CCoPlayTransformerAndSwitchAtLobby_003Ed__224 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TransformData data;

		public UIAnimedAvatar _003C_003E4__this;

		public EAvatarModelIngameType avatarModelIngameType;

		public bool showSound;

		public bool isFromProfile;

		public Action successAction;

		private int _003CwaitedFrames_003E5__2;

		private float _003CanimEndTime_003E5__3;

		private ResourceID _003CanimResId_003E5__4;

		private EAvatarModelIngameType _003CbeforeAvatarTransModelType_003E5__5;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoPlayTransformerAndSwitchAtLobby_003Ed__224(int _003C_003E1__state)
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

	private sealed class _003CCoPlayTransformerAtLobby_003Ed__221 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIAnimedAvatar _003C_003E4__this;

		public TransformData data;

		public bool isAutoPlayAfterSingleAnim;

		public bool loop;

		private int _003CwaitedFrames_003E5__2;

		private float _003CanimEndTime_003E5__3;

		private TransformAvatarEffect _003CtransformAvatarEffect_003E5__4;

		private Animator _003CtransformerAnimator_003E5__5;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoPlayTransformerAtLobby_003Ed__221(int _003C_003E1__state)
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

	private sealed class _003CCoPlayTriggerEffectAnimationd_003Ed__266 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIAnimedAvatar _003C_003E4__this;

		public ResourceID animResId;

		public bool isLoop;

		public float idleTime;

		private int _003CwaitedFrames_003E5__2;

		private float _003Clength_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoPlayTriggerEffectAnimationd_003Ed__266(int _003C_003E1__state)
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

	private sealed class _003CCoPlayWeaponAnimationd_003Ed__235 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIAnimedAvatar _003C_003E4__this;

		public ResourceID effectID;

		public ResourceID animResId;

		public bool playWeaponAnim;

		public ResourceID soundID;

		public ResourceID? extraSoundId;

		public bool loop;

		public float emoteIdleDeltaTime;

		public bool effectLoop;

		public ResourceID? endIdleResId;

		public bool endIdleAnimLoop;

		private int _003CwaitedFrames_003E5__2;

		private float _003Clength_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoPlayWeaponAnimationd_003Ed__235(int _003C_003E1__state)
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

	private sealed class _003CCoShowNewTagAfterFreeEmote_003Ed__207 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIAnimedAvatar _003C_003E4__this;

		public float time;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoShowNewTagAfterFreeEmote_003Ed__207(int _003C_003E1__state)
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

	private sealed class _003CPlayEmoteCoInternal_003Ed__265 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public uint emotionID;

		public UIAnimedAvatar _003C_003E4__this;

		public bool isPreview;

		public EDuoEmoteStage duoEmoteStage;

		public EmoteExtralInfo extralInfo;

		public bool loop;

		public bool showEmoteCameraAnim;

		public Camera camera;

		private EmoteData _003CemotionData_003E5__2;

		private int _003CwaitedFrames_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayEmoteCoInternal_003Ed__265(int _003C_003E1__state)
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

	private sealed class _003CPlayEmoteWhenPreviewCo_003Ed__248 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public uint emotionID;

		public bool loop;

		public bool playIdleInterval;

		public UIAnimedAvatar _003C_003E4__this;

		public bool showEmoteCameraAnim;

		public Camera camera;

		private EmoteData _003CemotionData_003E5__2;

		private float _003CdanceEmoteDistanceValue_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayEmoteWhenPreviewCo_003Ed__248(int _003C_003E1__state)
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

	private sealed class _003CPlayFinishMoveCoInternal_003Ed__468 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public uint finishMoveId;

		public UIAnimedAvatar _003C_003E4__this;

		public PreviewCustomCamera previewFinishMove;

		private LIAFPDJNAPH _003CfinishMoveData_003E5__2;

		private int _003CwaitedFrames_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayFinishMoveCoInternal_003Ed__468(int _003C_003E1__state)
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

	private sealed class _003CPlayFinishMoveWhenPreviewCo_003Ed__467 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public uint finishMoveId;

		public UIAnimedAvatar _003C_003E4__this;

		public bool loop;

		public PreviewCustomCamera previewFinishMove;

		public bool playIdleAlternate;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayFinishMoveWhenPreviewCo_003Ed__467(int _003C_003E1__state)
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

	private sealed class _003CPlayGunCoroutine_003Ed__285 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIAnimedAvatar _003C_003E4__this;

		public GunType type;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayGunCoroutine_003Ed__285(int _003C_003E1__state)
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

	private sealed class _003CPlaySuperEmoteCoInternal_003Ed__258 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public uint superEmoteId;

		public UIAnimedAvatar _003C_003E4__this;

		public bool loop;

		public PreviewCustomCamera previewSuperEmote;

		private CollectionSuperEmote _003CsuperEmoteData_003E5__2;

		private int _003CwaitedFrames_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlaySuperEmoteCoInternal_003Ed__258(int _003C_003E1__state)
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

	private sealed class _003CPlaySuperEmoteWhenPreviewCo_003Ed__257 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public uint superEmoteId;

		public UIAnimedAvatar _003C_003E4__this;

		public bool loop;

		public PreviewCustomCamera previewSuperEmote;

		public bool playIdleAlternate;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlaySuperEmoteWhenPreviewCo_003Ed__257(int _003C_003E1__state)
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

	private sealed class _003CSetGunAnimTrigger_003Ed__360 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIAnimedAvatar _003C_003E4__this;

		public GunType type;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CSetGunAnimTrigger_003Ed__360(int _003C_003E1__state)
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

	private sealed class _003CSetPlayShowPos_003Ed__303 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIAnimedAvatar _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CSetPlayShowPos_003Ed__303(int _003C_003E1__state)
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

	private sealed class _003CUGCPlayAnimClipLoopCo_003Ed__247 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIAnimedAvatar _003C_003E4__this;

		public AnimationClip clip;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CUGCPlayAnimClipLoopCo_003Ed__247(int _003C_003E1__state)
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

	private sealed class _003CWaitForSecondsWithPause_003Ed__209 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIAnimedAvatar _003C_003E4__this;

		public float waitTime;

		private float _003CelapsedTime_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CWaitForSecondsWithPause_003Ed__209(int _003C_003E1__state)
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

	protected const string IDLE_ANIM_PATTERN = "lobby";

	protected const string CHANGE_CLOTHES_ANIM_PATTERN = "customanim";

	protected const string SHOW_POSE_PATTERN = "special01";

	protected const float PLAY_IDLE_DELTA_TIME = 3f;

	protected const float PLAY_EMOTE_IDLE_DELTA_TIME = 7f;

	protected const float PLAY_FINISH_MOVE_IDLE_DELTA_TIME = 3f;

	private AvatarTakePhotoSetting m_AvatarTakePhotoSetting;

	protected Animator m_PlayerAnimator;

	protected AvatarPropManager m_AvatarPropManager;

	protected AvatarDynamicEffectManager m_DynamicEffectManager;

	private EmotionManager m_EmotionManager;

	private PropertyData m_CurrentAvatarPropData;

	private PropertyData m_CurrentClothPropData;

	protected uint m_TransfromSoundTicket;

	protected bool m_PlayingShowPose;

	protected float m_ShowPoseTime;

	protected float m_ShowPoseAnimInterval;

	protected float m_ShowPoseCoolDownSeconds;

	protected bool m_IsCustomStandIdle;

	protected bool m_IsPlayEmoteAnim;

	protected bool m_IsPlayLobbyEmoteAnim;

	public int TeamPosId;

	protected BitArrayBoolean m_IsVisible;

	public const uint ISVISIBLE_COMMON = 1u;

	public const uint ISVISIBLE_ANIMATION = 2u;

	public const uint ISVISIBLE_PREIVEW = 4u;

	public const uint ISVISIBLE_ANIMATIONEVENT = 8u;

	public const uint ISVISIBLE_TRANSFORMER = 16u;

	public const uint ISVISIBLE_ENTERGROUPEFFECT = 32u;

	public const uint ISVISIBLE_GROUPANIM = 64u;

	public const uint ISVISIBLE_CUSTOM = 128u;

	public Action AvatarCoLobbyFinishedCallback;

	protected ReplaceAnimData m_ChangeClothesAnim;

	protected ReplaceAnimData m_IdleAnim;

	private Dictionary<int, float> m_GunShowTimeDic;

	private GunType m_UseGunType;

	private bool m_NeedToPlayGun;

	private float m_PlayGunTime;

	private bool m_FirstPlayGunIdle;

	private float m_ShowGunIdleSeconds;

	private bool m_PreviewPlayGun;

	protected ResourceID m_GunResId;

	protected ResourceID m_GunDefaultResId;

	private ResourceID m_GunParticleId;

	private ResourceID m_GunFireEffectId;

	private ResourceID m_MeleeRunEffectId;

	protected ResourceID m_GunResIdSecond;

	protected AFOLPMOCBOG m_CollectionResData;

	private ResourceID m_GunFireSoundId;

	private bool m_DualWield;

	private bool m_FistUseForeArm;

	private bool m_FistRightZScaleInverse;

	private bool m_DoubleWeapon;

	private bool m_FistDoubleWeapon;

	protected AnimationClip m_IdleSpecialAnim;

	private ResourceID m_StandIdleAnimRes;

	private ResourceID m_ShowPoseAnimRes;

	private uint m_delayCallShowWeapon;

	protected AvatarAbInfos m_AvatarAbInfos;

	protected float m_PlayIdleTime;

	protected bool m_CanRecordIdle;

	protected bool m_CanPlaySpecialIdle;

	protected bool m_RealPlaySpecialIdle;

	protected float m_PlayIdleDeltaTime;

	protected bool m_CanPlayIdleAlternative;

	protected bool m_RealPlayIdleAlternative;

	protected bool m_RootScaleAndSkinEnabled;

	protected bool m_IsPlayFacialAnim;

	private bool m_IsDoubleAnim;

	private bool m_IsRecycleProp;

	private bool m_SkipSpecailAnim;

	private float m_RandomSpeicalIdleTime;

	protected bool m_IsSkipCustom;

	protected bool m_IsAvatarReady;

	private float m_AvatarPosY;

	private BattleFlagConfigData m_BattleFlagConfigData;

	protected GameObject m_OneShotObj;

	public GameObject LightObj;

	public ResourceID LightResID;

	private Transform m_characterRoot;

	private UIAvatarBoneNodeAdapter m_BoneNodeAdapter;

	protected UIAvatarTransformer m_AvatarTransformer;

	protected bool m_IsTransformed;

	protected bool m_BackpackDirtyDuringTransform;

	protected bool m_IsPlayingAvatarTransform;

	private uint m_PlayingAvatarTransformID;

	private EAvatarModelIngameType m_AvatarTransModelType;

	public ResourceID? EmoteEffectRes;

	private ResourceID m_CurEmoteSoundResID;

	private int m_CurrentEmotionEffIdx;

	private bool m_DoNotCallUpdateCallack;

	protected GameObject m_backpack;

	private uint _003CEmoteID_003Ek__BackingField;

	protected EDuoEmoteStage DuoEmoteStage;

	public bool IsEmotePreview;

	private uint m_CooperateEmoteRandSeed;

	private bool _003CIsFreezeEmote_003Ek__BackingField;

	private uint _003CGroupEmoteID_003Ek__BackingField;

	private EmoteExtralInfo _003CExtralInfo_003Ek__BackingField;

	private int _003CSkillEffectSpecialMatIndex_003Ek__BackingField;

	public Camera GachaFeatureCamera;

	private uint m_EmoteSoundTicket;

	private uint m_FreezeLoopSoundTicket;

	private uint m_GroupAnimLoadAsync;

	protected GameObject m_MvpCamera;

	protected CameraAnimationManager m_EmoteCameraAnimationManager;

	protected uint m_DelayCallPlayExtraSound;

	private bool _003CUsingClothProp_003Ek__BackingField;

	private bool m_UsingAvatarProp;

	public double FistSpecialAnimTime;

	public Action OnFistSpecialAnimEnd;

	public int CurAnimationStateInfoHash;

	private float CurAnimationStateInfoTime;

	protected uint UMAMaterialAnimPackBagID;

	protected uint UMAMaterialAnimPackBagLevel;

	private IEnumerator freezeEmoteEndCor;

	private bool m_AnimPaused;

	private GameObject m_transformerAvatar;

	private IEnumerator playEmontionAnimCor;

	private bool m_isBreakFFEmotePlay;

	private IEnumerator m_ugcAnimCor;

	private PreviewCustomCamera m_PreviewSuperEmote;

	public float GachaHideModelSuperEmoteCameraDepth;

	public float GachaSuperEmoteCameraDepth;

	public bool IsGachaHideModel;

	private IEnumerator playLastKillAnimCor;

	private bool _003CIsWeaponIdleAnimReplaced_003Ek__BackingField;

	protected AnimationClip CachedIdleAnimClip;

	private ResourceID MaleCustomStandIdleResAnim;

	private ResourceID FemaleCustomStandIdleResAnim;

	private Dictionary<Transform, TransCache> m_TmpDynamicBones;

	private string doubleSpecialanim;

	private string doubleIdleanim;

	private LobbyAvatarLookAtComponent m_LookAtComponent;

	private bool canShowWeapon;

	private bool m_DynamicBonesActive;

	private static List<DynamicBone> _dynamicBones;

	private static List<HangManager> _hangManagers;

	private PreviewCustomCamera m_PreviewFinishMove;

	private PreviewCustomCamera m_PreviewClothAnim;

	public float GachaHideModelFinishMoveCameraDepth;

	public float GachaFinishMoveCameraDepth;

	public uint WeaponSkinOnHand => 0u;

	public bool RealPlaySpecialIdle => false;

	public bool IsPlayFacialAnim => false;

	protected UIAvatarTransformer AvatarTransformer => null;

	public bool IsPlayingAvatarTransform => false;

	public EAvatarModelIngameType AvatarTransModelType => EAvatarModelIngameType.Normal;

	public bool IsTransformed => false;

	public AvatarTransformData AvatarTransformingData => null;

	public uint AvaterTransformingLevel => 0u;

	public TransformData CurrentTransformData => null;

	public int CurrentEmotionEffIdx
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool DoNotCallUpdateCallback
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public uint EmoteID
	{
		get
		{
			return _003CEmoteID_003Ek__BackingField;
		}
		set
		{
			_003CEmoteID_003Ek__BackingField = value;
		}
	}

	public bool IsFreezeEmote
	{
		get
		{
			return _003CIsFreezeEmote_003Ek__BackingField;
		}
		set
		{
			_003CIsFreezeEmote_003Ek__BackingField = value;
		}
	}

	public uint GroupEmoteID
	{
		get
		{
			return _003CGroupEmoteID_003Ek__BackingField;
		}
		set
		{
			_003CGroupEmoteID_003Ek__BackingField = value;
		}
	}

	public EmoteExtralInfo ExtralInfo
	{
		get
		{
			return _003CExtralInfo_003Ek__BackingField;
		}
		set
		{
			_003CExtralInfo_003Ek__BackingField = value;
		}
	}

	public int SkillEffectSpecialMatIndex
	{
		get
		{
			return _003CSkillEffectSpecialMatIndex_003Ek__BackingField;
		}
		set
		{
			_003CSkillEffectSpecialMatIndex_003Ek__BackingField = value;
		}
	}

	public bool UsingClothProp
	{
		get
		{
			return _003CUsingClothProp_003Ek__BackingField;
		}
		set
		{
			_003CUsingClothProp_003Ek__BackingField = value;
		}
	}

	public bool UsingAvatarProp
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public Animator PlayerAnimator => null;

	public GameObject TransformerAvatar => null;

	public PreviewCustomCamera CurPreviewSuperEmote => null;

	private bool IsIdleAnimReplaced => false;

	public bool IsWeaponIdleAnimReplaced
	{
		get
		{
			return _003CIsWeaponIdleAnimReplaced_003Ek__BackingField;
		}
		set
		{
			_003CIsWeaponIdleAnimReplaced_003Ek__BackingField = value;
		}
	}

	private static List<DynamicBone> dynamicBones => null;

	private static List<HangManager> hangManagers => null;

	public PreviewCustomCamera CurPreviewFinishMove => null;

	public SkinnedMeshRenderer[] GetTransformedRenderers()
	{
		return null;
	}

	public void MakeTransformEffectVisible(bool flag)
	{
	}

	protected bool GetOriginalModelFemale()
	{
		return false;
	}

	public void TryStopEmotionAndRebuildWeapon()
	{
	}

	protected Transform GetCharacterRoot()
	{
		return null;
	}

	public bool GetAvatarReady()
	{
		return false;
	}

	public bool GetCollectionBackpackReady()
	{
		return false;
	}

	public Dictionary<uint, bool> GetAbClothesReady()
	{
		return null;
	}

	public bool CHeckNoDiffFromClothes(Dictionary<uint, bool> temp)
	{
		return false;
	}

	public override void InitAvatar(bool isLocal, bool isPreview = false, int textureScale = 1, FrontEndPreviewComponent frontEndPreviewComponent = null, bool isTeammate = false)
	{
	}

	protected override void CharacterUpdateCallBack(UMAData umaData)
	{
	}

	private void SetUpDynamicEffect()
	{
	}

	private void ResetAnims()
	{
	}

	protected override void OnSetAvatarDone(CSSharedAvatarData aData)
	{
	}

	protected override void ChangeRace(string race)
	{
	}

	public void UpdatePropItem()
	{
	}

	public bool CheckAvatarHasWeapon()
	{
		return false;
	}

	protected void Update()
	{
	}

	protected virtual void DoUpdate()
	{
	}

	private void CheckFistAnimEnd()
	{
	}

	private void CheckEmoteAnimationEnd()
	{
	}

	public void SetLobbyTakePhotoEmoteExitCallBack(Action<float, bool> cb)
	{
	}

	public void ResetLobbyTakePhotoEmoteExitCallBack()
	{
	}

	public override void ResetAvatar()
	{
	}

	public void ResetWeaponShow()
	{
	}

	protected GameObject BuildEffectsTriggerBackpackAndAttach(BackPackData backPackData, bool actualFemale)
	{
		return null;
	}

	public void ClearBackpack()
	{
	}

	protected void DestroyBackpack(bool clearInternalState = true)
	{
	}

	public void ForceUpdateBackPackUma()
	{
	}

	public void ClearBackPackSlot()
	{
	}

	public void ClearBackPackPrefab()
	{
	}

	protected void ProcessPackbagMaterialAnimEffect(uint itemID, uint level)
	{
	}

	protected void SetPackbagMaterialAnimIDAndLevel(uint itemID, uint level)
	{
	}

	protected void CleanPackbagMaterialAnimEffect()
	{
	}

	protected void LoadMaterialAnimEffect(uint itemID, int type, uint level)
	{
	}

	public bool CheckLobbyEmoteAnim()
	{
		return false;
	}

	public void SetAvatar(UIMaleAvatar avatar)
	{
	}

	public Camera GetMvpCamera()
	{
		return null;
	}

	public void CloseMvpCamera()
	{
	}

	public void PlayAnimClipAtLobby(ResourceID resId, bool needdelayshow = false, bool loop = false, bool playIdleAlternate = false, uint groupAnimID = 0u, GroupAnimData groupAnimData = null, float playIdleDeltaTime = 7f, bool async = false, bool isPlayLobbyEmoteAnim = true, bool showMvpAnim = false)
	{
	}

	public void RegisterCoAtLobbyCallback(Action callback)
	{
	}

	private IEnumerator CoPlayAnimClipAtLobby(ResourceID resId, bool loop = false, bool playIdleAlternate = false, GroupAnimData groupAnimData = null, float playIdleDeltaTime = 7f, bool showMvpAnim = false)
	{
		return null;
	}

	private IEnumerator CoShowNewTagAfterFreeEmote(float time)
	{
		return null;
	}

	private IEnumerator WaitForSecondsWithPause(float waitTime)
	{
		return null;
	}

	public void Pause()
	{
	}

	public void Resume()
	{
	}

	public void StopGroupAnimAsyncCallBack()
	{
	}

	public virtual void UpdateSpotlight()
	{
	}

	public virtual void SetSpotLightVisible(bool isVisible)
	{
	}

	public void PlayTransformeAfterSingleAnim()
	{
	}

	public void PlayTransformerAtLobby(TransformData data, bool loop = true, bool isCheckLowestDisplay = true, int PlayAnimIndex = 0, bool isAutoPlayAfterSingleAnim = false)
	{
	}

	private void ShowTransformerByIndex(TransformData data, int PlayAnimIndex = 1)
	{
	}

	private IEnumerator CoPlayTransformerAtLobby(TransformData data, bool loop, bool isAutoPlayAfterSingleAnim)
	{
		return null;
	}

	public override ITransformNode GetTransformNode(string name)
	{
		return null;
	}

	public void PlayTransformerAndSwitchAtLobby(TransformData data, EAvatarModelIngameType avatarModelIngameType, Action successAction = null, bool showSound = true, bool isFromProfile = false)
	{
	}

	private IEnumerator CoPlayTransformerAndSwitchAtLobby(TransformData data, EAvatarModelIngameType avatarModelIngameType, Action successAction = null, bool showSound = true, bool isFromProfile = false)
	{
		return null;
	}

	public bool ApplyAvatarTransformer(TransformData data, int modelIndex = 1, bool failWithIsTransformed = false, bool enableInputHandle = true, bool isFromProfile = false, bool loadLobbyTransformVFX = true)
	{
		return false;
	}

	public bool QuitAvatarTransformer(bool force = false, bool isFromProfile = false)
	{
		return false;
	}

	private void LoadLobbyTransformVFX(AvatarTransformData transformData, GameObject transformerObj, uint avatarTransformType)
	{
	}

	public void TryUpdateShowingWepon()
	{
	}

	protected void TryQuitAvatarTransformerWhenUpdateState()
	{
	}

	private void BindTransformerAnimator(Animator targetAnimator, bool needChangeGender = false, bool needSetRunTimeAnimator = true)
	{
	}

	private void UpdateAvatarTransformIdle()
	{
	}

	private void SetCharacterRootVisible(bool visible)
	{
	}

	public void PlayWeaponAnimation(ResourceID animResId, ResourceID effectID, ResourceID soundID, bool loop = false, float emoteIdleDeltaTime = 0f, bool effectLoop = false, bool playWeaponAnim = false, ResourceID? extraSound = null, ResourceID? endIdleAnim = null, bool endIdleAnimLoop = false)
	{
	}

	public void PlayTriggerEffectAnim(ResourceID animationResourceID, bool isLoop, float idleTime)
	{
	}

	private IEnumerator CoPlayWeaponAnimationd(ResourceID animResId, ResourceID effectID, ResourceID soundID, bool loop = false, float emoteIdleDeltaTime = 0f, bool effectLoop = false, bool playWeaponAnim = false, ResourceID? extraSoundId = null, ResourceID? endIdleResId = null, bool endIdleAnimLoop = false)
	{
		return null;
	}

	public void CancelExtraSoundDelayCall()
	{
	}

	private void PlaySwitchAnimInWeapon()
	{
	}

	public void PlayEmotionAnimation(uint emotionID, bool loop = false, bool isCheckLowestDisplay = true, EDuoEmoteStage duoEmoteStage = EDuoEmoteStage.None, ResourceID? emoteEffect = null, EmoteExtralInfo extralInfo = null, bool needResetPosition = true, uint cooperateEmoteRandSeed = 0u)
	{
	}

	private IEnumerator CoPlayEmotionAnimationd(uint emotionID, bool loop = false, EDuoEmoteStage duoEmoteStage = EDuoEmoteStage.None, EmoteExtralInfo extralInfo = null)
	{
		return null;
	}

	public void PlayEmoteWhenPreview(uint emotionID, bool loop = false, bool isCheckLowestDisplay = true, bool playIdleAlternate = true, bool showEmoteCameraAnim = false, Camera camera = null)
	{
	}

	private float GetDuoEmoteBGMClipLength(EmoteData emotionData, EDuoEmoteStage duoEmoteStage)
	{
		return 0f;
	}

	public void UGCPlayAnimClipLoop(AnimationClip clip)
	{
	}

	public void UGCPlayAnimClipStop()
	{
	}

	private IEnumerator UGCPlayAnimClipLoopCo(AnimationClip clip, bool loop)
	{
		return null;
	}

	private IEnumerator PlayEmoteWhenPreviewCo(uint emotionID, bool loop = false, bool playIdleInterval = true, bool showEmoteCameraAnim = false, Camera camera = null)
	{
		return null;
	}

	private bool PlayEmotePreHandle(uint emotionID, bool isCheckLowestDisplay, ResourceID? emoteEffect = null, bool needResetPosition = true)
	{
		return false;
	}

	public void PlaySuperEmoteWhenPreview(uint superEmoteId, bool loop = false, bool isCheckLowestDisplay = true, bool playIdleAlternate = true, PreviewCustomCamera previewSuperEmote = null)
	{
	}

	private IEnumerator PlaySuperEmoteWhenPreviewCo(uint superEmoteId, bool loop = false, bool playIdleAlternate = true, PreviewCustomCamera previewSuperEmote = null)
	{
		return null;
	}

	private IEnumerator PlaySuperEmoteCoInternal(uint superEmoteId, bool loop = false, PreviewCustomCamera previewSuperEmote = null)
	{
		return null;
	}

	private bool PlaySuperEmotePreHandle(uint superEmoteId, bool isCheckLowestDisplay)
	{
		return false;
	}

	protected void ClearEmoteData()
	{
	}

	protected void ClearSuperEmoteData()
	{
	}

	protected void ClearSkillEffectMat()
	{
	}

	protected void CleanLastAnimLegacy()
	{
	}

	public void CleanupAnimationAttachedData()
	{
	}

	private IEnumerator PlayEmoteCoInternal(uint emotionID, bool loop = false, EDuoEmoteStage duoEmoteStage = EDuoEmoteStage.None, EmoteExtralInfo extralInfo = null, bool isPreview = false, bool showEmoteCameraAnim = false, Camera camera = null)
	{
		return null;
	}

	private IEnumerator CoPlayTriggerEffectAnimationd(ResourceID animResId, bool isLoop, float idleTime)
	{
		return null;
	}

	public void SetEmoteSoundWhenEmotionEffIdxChange()
	{
	}

	private void PlayLobbyEmoteSoundById(ResourceID soundId, bool loop, bool restrictToLocalOrPreviewAvatar)
	{
	}

	public void PlayEmoteSound(ResourceID resourceID, bool loop, float volumeRate = 1f)
	{
	}

	public void PlayTransformSound(ResourceID soundID)
	{
	}

	public void StopEmoteSound()
	{
	}

	public void PlayLastKillAnimation(ResourceID lastKillAnimID, bool isLoop = false, float idleTime = 0f, bool needGotoStandIdle = false)
	{
	}

	private IEnumerator CoPlayLastKillAnimation(ResourceID lastKillAnimID, bool isLoop = false, float idleTime = 0f, bool needGotoStandIdle = false)
	{
		return null;
	}

	private void PlayLastKillAnimationInternal(ResourceID lastKillAnimID)
	{
	}

	private float GetLastKillAnimLength(ResourceID lastKillAnimID)
	{
		return 0f;
	}

	public void StopPlayLastKillAnim()
	{
	}

	public void StopLastKillAnim()
	{
	}

	public void SetActive(bool isShow)
	{
	}

	protected void ResetAvatarRoationInAvatarWnd()
	{
	}

	public bool GetIsPlayEmotion()
	{
		return false;
	}

	public bool GetFistUseForeArm()
	{
		return false;
	}

	public bool GetFistRightZScaleInverse()
	{
		return false;
	}

	public void StopPlayEmotionAnim(bool needResetPosition = true)
	{
	}

	private IEnumerator PlayGunCoroutine(GunType type)
	{
		return null;
	}

	public void StopEmotionAndRebuildWeapon()
	{
	}

	public void StopEmotionAnimation(bool needResetPosition = true)
	{
	}

	public void RevertAvatarTansformerAndReset()
	{
	}

	public uint GetPlayingAvatarTransformID()
	{
		return 0u;
	}

	public void SuspendEmotionAnimation()
	{
	}

	private void EnsureMotionManager()
	{
	}

	private void ForceEnsureMotionManager()
	{
	}

	protected void SetTrigger(string s)
	{
	}

	protected void ResetTrigger(string s)
	{
	}

	private void UpdateShowPoseAnim()
	{
	}

	public void SetSpecialIdeEnabled(bool flag)
	{
	}

	private void UpdateSpecialIdleAnim()
	{
	}

	private void UpdatePlayIdleAlternativeAnim()
	{
	}

	public bool GetIsRecylceProp()
	{
		return false;
	}

	public void SetRecycleProp(bool flag)
	{
	}

	private void PlayShowPoseAnim()
	{
	}

	private void ForcePlayShowPoseAnim()
	{
	}

	private IEnumerator SetPlayShowPos()
	{
		return null;
	}

	private void StopShowPoseAnim(bool cleareffect = true)
	{
	}

	public virtual void StartShowPose()
	{
	}

	public void ForceStartShowPose()
	{
	}

	public void UpdateWeaponOnHand(uint skinID, bool needPlayGunAnim = true)
	{
	}

	private bool IsDualWeild(WeaponSkinData data)
	{
		return false;
	}

	public virtual void StopShowPose(bool cleareffect = true, bool stopForZoomIn = false)
	{
	}

	public void SetShowPosing(bool b)
	{
	}

	protected void SetIsCustomStandle(bool b)
	{
	}

	public bool IsShowSpecialIdle()
	{
		return false;
	}

	private void UpdateClothesChangeAnim()
	{
	}

	private void TryPlayPreviewAvatarAnimation()
	{
	}

	private void TryChangeSpeicalAnimCtrl()
	{
	}

	private void PlayPreviewPose()
	{
	}

	private bool IsSpecialPreviewOnlyAvatar()
	{
		return false;
	}

	private void OverrideClothesAnim(ReplaceAnimData data, bool changeClothes)
	{
	}

	private void OverrideClothesAnim(ResourceID id, bool changeAnim)
	{
	}

	private void OverrideClothesAnim(AnimationClip clip, bool changeAnim)
	{
	}

	protected void ResetOverrideWeaponIdleAnim()
	{
	}

	private string GetClothesAnimClipName(bool changeAnim)
	{
		return null;
	}

	private void PlayClothesChangeAnim(bool isAlternative)
	{
	}

	private void StopClothesChangeAnim(bool cleareffect = true)
	{
	}

	public void PlayCustomAnim(ResourceID rid)
	{
	}

	public AnimationClip ReplaceAnimByName(ResourceID rid, string name)
	{
		return null;
	}

	public void SetSkipCustomParm(bool flag)
	{
	}

	public void StopAvatarAnim(bool cleareffect, bool resetOverrideIdleAnim = true, bool stopForZoomIn = false)
	{
	}

	public ResourceID GetClothesChangeAnim(AvatarWardrobeData aData)
	{
		return default(ResourceID);
	}

	public ResourceID GetClothesIdleAnim(AvatarWardrobeData aData)
	{
		return default(ResourceID);
	}

	public void PlayClothesAnims(uint wId, bool playChangeAnim, bool playIdleAnim, bool waitDirty = true, bool playIdleAlternative = false)
	{
	}

	internal bool PlayClothesAnims(AvatarWardrobeData aData, bool playChangeAnim, bool playIdleAnim, bool playIdleAlternative = false)
	{
		return false;
	}

	public void SetAvatarIdleAnim(ResourceID resID)
	{
	}

	protected bool PlayClothesChangeAnim(ResourceID resId, ResourceID effectID)
	{
		return false;
	}

	protected bool PlayClothesIdleAnim(ResourceID resId)
	{
		return false;
	}

	protected bool CheckAndOverrideAnim(ReplaceAnimData data, ResourceID id, ResourceID effectID)
	{
		return false;
	}

	internal void StopClothesChangeAnims()
	{
	}

	protected void ResetClothesDefaultAnims()
	{
	}

	public void ResetClothesOverrideAnims()
	{
	}

	private void UpdateGunAnimation()
	{
	}

	private void PlayGunAnimation(GunType type)
	{
	}

	private ResourceID DefaultStandIdleRes(bool isFemale)
	{
		return default(ResourceID);
	}

	private ResourceID DefaultShowPoseRes(bool isFemale)
	{
		return default(ResourceID);
	}

	public void SetCustomStandIdleResAnim(ResourceID male, ResourceID female)
	{
	}

	public void UpdateCustomAnimClip(CSSharedAvatarData aData, bool female, bool force = false)
	{
	}

	public void ResetCustomAnimClip()
	{
	}

	private void SetOverrideAnim(AnimationClip clip, bool isBaseClip, string clipName)
	{
	}

	private ResourceID GetIdleAnimResByGunType(GunType type)
	{
		return default(ResourceID);
	}

	private void ForcePlayAnim(GunType type)
	{
	}

	private IEnumerator SetGunAnimTrigger(GunType type)
	{
		return null;
	}

	private void ResetAvatarOtherAnim()
	{
	}

	protected string GetGunAnimTriggerName(GunType type)
	{
		return null;
	}

	public void StartShowAvatar()
	{
	}

	public void SetRootFlagAndSkinEnabled(bool flag)
	{
	}

	public void ForceSetRootFlagAndSkinEnabled(bool flag)
	{
	}

	public void ResetAvatarReady()
	{
	}

	public void PlayDoubleSpecialAnim(FrontEndPreviewComponent frontEndPreviewComponent)
	{
	}

	public void SetSkipAnimParm(bool flag)
	{
	}

	public void SaveAvatarPosY()
	{
	}

	public void ShowProfileHideOrShow(bool flag)
	{
	}

	public void SetCharcterRootAndSkinVisble(bool enabled)
	{
	}

	public void InitAvatarVisibleState()
	{
	}

	public void ResetVisibleFlag()
	{
	}

	public bool IsSkinnedRendererActive()
	{
		return false;
	}

	public void SetCharcterRootScaleAndSkinVisble(bool bVisible, uint flag = 1u, bool setRootPosition = true)
	{
	}

	public void ShowWeaponNotImmiately(bool show = true)
	{
	}

	public void SetAvatarTakePhotoSetting(bool IsShowBackpak, bool IsShowWeapon)
	{
	}

	public void ClearAvatarTakePhotoSetting()
	{
	}

	public void ShowWeapon(bool show = true)
	{
	}

	public void PlayWithGun(AFOLPMOCBOG data, ResourceID defaultid, bool rebind = true, bool dualWeild = false)
	{
	}

	public AFOLPMOCBOG GetCollectionResData()
	{
		return null;
	}

	public void PlayWithGun(AFOLPMOCBOG data, ResourceID weaponresid, ResourceID weaponpaticleid, ResourceID weaponfireeffectid, ResourceID weaponfiresoundid, ResourceID weapondefaultid, ResourceID weaponMeleeRunEffectId, bool rebind = true, bool dualWeild = false)
	{
	}

	public AnimationClip[] GetAnimaitionclips()
	{
		return null;
	}

	private void InitGunShowTime()
	{
	}

	public void PlayMeleeRunEffect()
	{
	}

	public void PlayFireEffect(bool right, bool effectOnly)
	{
	}

	public void PlayWithSkyBoard(ResourceID skyboardid)
	{
	}

	public void PlayGunAnim(GunType type)
	{
	}

	public void ForcePlayGunAnim(GunType type)
	{
	}

	private void CalculateShowTime()
	{
	}

	public void SetAvatarShowPoseInterval(uint avatarid)
	{
	}

	public void PlayDoubleIdleAnim()
	{
	}

	public void PlayStandIdle()
	{
	}

	public void PlayOnlyIdle()
	{
	}

	public void StopPlayGunCoroutine()
	{
	}

	public void ResetAnimAvatar()
	{
	}

	public void OnlyPlayFistIdle()
	{
	}

	public void StopGunAnim(bool stopCortine = false)
	{
	}

	protected void UpdateShowingWepon()
	{
	}

	private void ForceUpdateShowingWeapon()
	{
	}

	public void RequestSpawnBattleFlagOnHand()
	{
	}

	public void RequestSpawnBattleFlagOnGround()
	{
	}

	public void HideBattleFlagOnHand()
	{
	}

	public void ClearCachedBattleFlag()
	{
	}

	private void CacheTransforms(Transform tr, Dictionary<Transform, TransCache> map, bool clearParent)
	{
	}

	protected void RebindPlayerAnimator()
	{
	}

	public void EnableLookAt(EFrontendUIType uiType, FrontEndPreviewComponent frontEndPreviewComponent = null)
	{
	}

	public void DisableLookAt()
	{
	}

	private void UpdateSetLookAt(CSSharedAvatarData aData)
	{
	}

	private void InitLookAtComponentWithAvatarData(CSSharedAvatarData aData = null, AvatarLookAtData ldata = null, int uiType = -1, FrontEndPreviewComponent frontEndPreviewComponent = null)
	{
	}

	public virtual void UpdateAnimator(CSSharedAvatarData aData, bool female)
	{
	}

	private bool CheckCanRandomAnimClip(ResourceID id)
	{
		return false;
	}

	private AnimationClip GetSpeicalIdleAnimClip(ResourceID id)
	{
		return null;
	}

	private AnimationClip GetCommonIdleAnimClip(ResourceID id)
	{
		return null;
	}

	protected AnimationClip LoadAnimClip(ResourceID id)
	{
		return null;
	}

	public void ModifyAnimState()
	{
	}

	protected void OverrideAnimClip(AnimationClip clip, AnimationClip baseClip)
	{
	}

	public void PlayEffect(ResourceID id, AvatarEffect.EEffectGroup group, bool fistAnim = false, Action fistCallBack = null)
	{
	}

	public void StartRecordIdle()
	{
	}

	public void ResetRecordIdle()
	{
	}

	public bool CanShowWeapon()
	{
		return false;
	}

	public void OnAnimationVisibilityChanged(int visilbe)
	{
	}

	public void OnAnimEvent(BFNFCKGEHDI e, object[] para)
	{
	}

	private void OnFreezeEmoteIdleEnter()
	{
	}

	protected void StopFreezeLoopSound()
	{
	}

	private void OnDisableDynamicBones()
	{
	}

	private void OnEnableDynamicBones()
	{
	}

	public void OnDisableFlux()
	{
	}

	public void OnEnableFlux()
	{
	}

	public void SetAnimatorStatus(bool acitve)
	{
	}

	public void HideDynamicCharacter()
	{
	}

	public void ShowDynamicCharacter()
	{
	}

	public void DisableCharacterRoate()
	{
	}

	public void EnableAvatarInputHandlerComp(bool flag)
	{
	}

	public void EnableCharacterRoate()
	{
	}

	public void KeepCharacterRotateState(int flag)
	{
	}

	public void ResetAvatarRotation()
	{
	}

	public void ResetAvatarPosition()
	{
	}

	public void AnimationOver()
	{
	}

	public void PlayIdleSkipEffect(GameObject prefab)
	{
	}

	private void DestoryPaticleEffect()
	{
	}

	public virtual void UpdateAnimationEvent(bool flag = true, bool effectFlag = true)
	{
	}

	private void SetDynamicCharacterVisble(bool visble)
	{
	}

	public void StopAnimEfects(AvatarEffect.EEffectGroup group)
	{
	}

	public void PlaySkipEffect(AvatarEffect.EEffectGroup group)
	{
	}

	public void PlayCommonIdleAnimEffect(AvatarEffect.EEffectGroup group)
	{
	}

	public void PlaySpeicalIdleAnimEffect(AvatarEffect.EEffectGroup group)
	{
	}

	public void SaveDoubleAnims(string doublespecial, string doubleidle)
	{
	}

	private void SetDoubleAnims(string doublespecial, string doubleidle)
	{
	}

	private void SetOverrideDoubleAnim(AnimationClip clip, string pattern)
	{
	}

	private AnimationClip GetAnimClipByPattern(RuntimeAnimatorController controller, bool baseClip, string pattern)
	{
		return null;
	}

	public void PlayFinishMoveWhenPreview(uint finishMoveId, bool loop = false, bool isCheckLowestDisplay = true, bool playIdleAlternate = true, PreviewCustomCamera previewFinishMove = null)
	{
	}

	private bool PlayFinishMovePreHandle(uint finishMoveId, bool isCheckLowestDisplay = true)
	{
		return false;
	}

	private IEnumerator PlayFinishMoveWhenPreviewCo(uint finishMoveId, bool loop = false, bool playIdleAlternate = true, PreviewCustomCamera previewFinishMove = null)
	{
		return null;
	}

	private IEnumerator PlayFinishMoveCoInternal(uint finishMoveId, bool loop = false, PreviewCustomCamera previewFinishMove = null)
	{
		return null;
	}

	private void ClearFinishMoveData()
	{
	}

	public void SetPreviewClothAnim(PreviewCustomCamera previewClothAnim)
	{
	}

	public void ClearPreviewClothAnim()
	{
	}

	public EDuoEmoteStage GetDuoEmoteStage()
	{
		return EDuoEmoteStage.None;
	}

	public void SetCooperateEmoteRandSeed(uint randomSeed)
	{
	}

	public uint GetCooperateEmoteRandSeed()
	{
		return 0u;
	}

	public bool IsAvatarIdle()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_InitAvatar(bool P0, bool P1, int P2, FrontEndPreviewComponent P3, bool P4)
	{
	}

	public new void _003C_003EiFixBaseProxy_CharacterUpdateCallBack(UMAData P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnSetAvatarDone(CSSharedAvatarData P0)
	{
	}

	public void _003C_003EiFixBaseProxy_ChangeRace(string P0)
	{
	}

	public void _003C_003EiFixBaseProxy_ResetAvatar()
	{
	}

	public ITransformNode _003C_003EiFixBaseProxy_GetTransformNode(string P0)
	{
		return null;
	}
}
