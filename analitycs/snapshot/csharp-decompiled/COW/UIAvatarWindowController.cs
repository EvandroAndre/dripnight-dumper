using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;
using message;
using proto;
using tcp;

namespace COW;

public class UIAvatarWindowController : UIBaseController, IUIModelDataChangeObserver
{
	private enum EnterGroupEffectType
	{
		None,
		Rank,
		EnterGroupAnim
	}

	public class TeamAvatar
	{
		public ulong account_id;

		public UIMaleAvatar avatar;

		public UIPetAvatar pet_avatar;

		public uint AsyncCreatePetTicket;

		public int pos_id_internal;

		public uint avatar_id;

		public uint show_weapon_id;

		public tcp.WeaponSkinStat show_weapon_skin_stat;

		public uint pve_weapon_id;

		public uint hand_weapon_id;

		public uint group_anim_id;

		public uint show_bag_id;

		public bool has_changeavatarid;

		public bool forcerefreshbag;

		public bool has_leaveteam;

		public ulong DuoPlayerAccountId;

		public uint TransformerLevel;

		public Vector3 OriginalPos;

		public int pos_id
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}
	}

	public class TeamAvatarPos
	{
		public Vector3 pos;

		public Quaternion rotation;

		public Vector3 pos_pet;

		public TeamAvatarPos(Vector3 p, Quaternion r, Vector3 pet_p)
		{
		}
	}

	public class AvatarSetting
	{
		public Vector3 avatar_pos;

		public Vector3 avatar_rotation;

		public Vector3 avatar_scale;

		public Vector3 camera_pos;

		public Vector3 camera_rotaion;

		public float avatar_input_angle;

		public bool avatar_input;
	}

	public class AvatarPetSetting
	{
		public Vector3 avatar_pos;

		public bool showState;

		public float avatar_input_angle;

		public AvatarPetSetting(Vector3 pet_pos)
		{
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<int> _003C_003E9__165_0;

		public static Predicate<int> _003C_003E9__218_0;

		public static Predicate<int> _003C_003E9__221_2;

		public static Predicate<int> _003C_003E9__221_1;

		public static Func<GroupMemberInfo, ulong> _003C_003E9__254_0;

		public static Predicate<int> _003C_003E9__305_0;

		internal bool _003CFixTeammatePosID_003Eb__165_0(int s)
		{
			return false;
		}

		internal bool _003CShowAvatarsCoroutine_003Eb__218_0(int s)
		{
			return false;
		}

		internal bool _003CShowAvatars_003Eb__221_2(int s)
		{
			return false;
		}

		internal bool _003CShowAvatars_003Eb__221_1(int s)
		{
			return false;
		}

		internal ulong _003COnPlayerJoin_003Eb__254_0(GroupMemberInfo member)
		{
			return 0uL;
		}

		internal bool _003COnShowAvatarRefreshReserveFakeMember_003Eb__305_0(int s)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass198_0
	{
		public TeamAvatar p;

		internal bool _003CGetOtherEnterGroupEffectType_003Eb__0(GroupMemberInfo a)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass199_0
	{
		public TeamAvatar p;

		internal bool _003CEnterGroupEffectOthers_003Eb__0(GroupMemberInfo a)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass201_0
	{
		public TeamAvatar p;

		public UIAvatarWindowController _003C_003E4__this;

		internal void _003COnEnterGroupPlayRankEffect_003Eb__0(bool isInterrupt)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass212_0
	{
		public TeamAvatar ta;

		public UIAvatarWindowController _003C_003E4__this;

		internal void _003CUpdateAvatarPetShow_003Eb__0(uint ticket, UIPetAvatar petAvatar)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass213_0
	{
		public uint cloth;

		internal bool _003CUpdateGroupAvatarsClothesAndBackpack_003Eb__0(tcp.AccountCollectionCustomItemInfo x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass216_0
	{
		public UIAvatarWindowController _003C_003E4__this;

		public TeamAvatar ta;

		internal void _003CRecreateTeamAvatar_003Eb__0(uint ticket, UIPetAvatar petAvatar)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass218_0
	{
		public TeamAvatar ta;

		public int emptyId;

		public UIAvatarWindowController _003C_003E4__this;

		internal void _003CShowAvatarsCoroutine_003Eb__1(uint ticket, UIPetAvatar petAvatar)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass221_0
	{
		public TeamAvatar ta;

		public UIAvatarWindowController _003C_003E4__this;

		internal void _003CShowAvatars_003Eb__0(uint ticket, UIPetAvatar petAvatar)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass222_0
	{
		public ulong leaver_id;

		internal bool _003COnGroupLeaveNtf_003Eb__0(TeamAvatar s)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass223_0
	{
		public UIAvatar avatar;

		internal bool _003CIsAvatarTeammate_003Eb__0(TeamAvatar s)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass240_0
	{
		public ulong accountId;

		internal bool _003CGetTeamTargetWeaponSkinId_003Eb__0(TeamAvatar o)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass244_0
	{
		public TeamAvatar ta;

		internal bool _003CRefreshTeamatePVEWeapon_003Eb__0(GroupMemberInfo a)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass250_0
	{
		public GroupMemberInfo mem;

		internal bool _003COnGroupReadyNtf_003Eb__0(TeamAvatar s)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass251_0
	{
		public ulong accountId;

		internal bool _003COnSyncOptionalMapResNtf_003Eb__0(TeamAvatar s)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass255_0
	{
		public GroupMemberInfo stopper;

		internal bool _003ConGroupStopNtf_003Eb__0(TeamAvatar s)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass273_0
	{
		public TeamAvatar teamInfo;

		internal bool _003CDoTeamAvatarsNeedRefresh_003Eb__0(GroupMemberInfo o)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass273_1
	{
		public uint clothId;

		internal bool _003CDoTeamAvatarsNeedRefresh_003Eb__1(tcp.AccountCollectionCustomItemInfo a)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass305_0
	{
		public KeyValuePair<ulong, int> posKV;

		internal bool _003COnShowAvatarRefreshReserveFakeMember_003Eb__1(GroupReservationShowInfo x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass306_0
	{
		public KeyValuePair<ulong, int> posKV;

		internal bool _003COnShowAvatarRefreshRematchFakeMember_003Eb__0(tcp.RematchPlayer x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass311_0
	{
		public GroupReservationShowInfo info;

		internal bool _003CRemoveReserve_003Eb__0(GroupMemberInfo x)
		{
			return false;
		}

		internal bool _003CRemoveReserve_003Eb__1(GroupMemberInfo x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass352_0
	{
		public TeamAvatar p;

		internal bool _003CBatchPlayEmote_003Eb__0(TeammateEmoteInfo x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass353_0
	{
		public TeamAvatar p;

		internal bool _003CBatchStopEmote_003Eb__0(TeammateEmoteInfo x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass354_0
	{
		public ulong accountId;

		internal bool _003CPlayEmote_003Eb__0(TeammateEmoteInfo x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass368_0
	{
		public TeamAvatar p;

		internal bool _003CShowAvatarTransform_003Eb__0(GroupMemberInfo o)
		{
			return false;
		}
	}

	private sealed class _003CChatBubbleCoroutine_003Ed__150 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIAvatarWindowController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CChatBubbleCoroutine_003Ed__150(int _003C_003E1__state)
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

	private sealed class _003CEnterGroupPlayIdleEffectCoroutine_003Ed__193 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIAvatarWindowController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CEnterGroupPlayIdleEffectCoroutine_003Ed__193(int _003C_003E1__state)
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

	private sealed class _003CEnterGroupPlayIdleEffectCoroutine_003Ed__194 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TeamAvatar p;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CEnterGroupPlayIdleEffectCoroutine_003Ed__194(int _003C_003E1__state)
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

	private sealed class _003CGroupJoinCoroutine_003Ed__202 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIAvatarWindowController _003C_003E4__this;

		public object[] data;

		public int coroutineKey;

		private List<ulong> _003CjoinedMemberIds_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CGroupJoinCoroutine_003Ed__202(int _003C_003E1__state)
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

	private sealed class _003CPlayAvatarShowPose_003Ed__245 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIAvatarWindowController _003C_003E4__this;

		public UIMaleAvatar avatar;

		public float seconds;

		private EFrontendUIType _003CpreCamera_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayAvatarShowPose_003Ed__245(int _003C_003E1__state)
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

	private sealed class _003CShowAvatarsCoroutine_003Ed__218 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIAvatarWindowController _003C_003E4__this;

		private _003C_003Ec__DisplayClass218_0 _003C_003E8__1;

		public List<ulong> joinedMemberIds;

		private Dictionary<int, TeamAvatar> _003CteammatePositionMapping_003E5__2;

		private GroupMemberInfo _003Cmember_003E5__3;

		private UIMaleAvatar _003Cteammate_003E5__4;

		private UIFrontEndScene _003Ccurrent_scene_003E5__5;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CShowAvatarsCoroutine_003Ed__218(int _003C_003E1__state)
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

	private sealed class _003CTeammateChatBubbleCoroutine_003Ed__151 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIAvatarWindowController _003C_003E4__this;

		public TeamAvatar ta;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CTeammateChatBubbleCoroutine_003Ed__151(int _003C_003E1__state)
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

	private bool m_ShowHidePetInTakePhoto;

	private bool m_ShowHidePetInPortrait;

	private UIAvatarWindowView m_View;

	private UIMaleAvatar m_Avatar;

	private Vector3 _003COriginalAvatarPos_003Ek__BackingField;

	private uint m_LocalPlayerShowHCWeaponID;

	private GameObject m_LocalPlayerShowHCWeaponObj;

	private GameObject m_LocalPlayerShowHCBoxObj;

	private GameObject m_Teammate1ShowHCBoxObj;

	private UIPetAvatar m_PetAvatar;

	private bool m_SelfPetAvatarReadyState;

	private List<uint> m_AsyncLoadPetTickets;

	private uint m_SelfPetAsyncLoadTicket;

	private GameObject m_PetAvatarReplacer;

	private proto.PetInfo m_CurrentShowPetInfo;

	private GameObject m_ReplacerMock;

	private UIPetAvatarReplacer m_UIPetAvatarReplacer;

	private float m_PetLobbyScale;

	private GameObject m_AvatarCamera;

	private PostEffectManager m_PostEffect;

	private Camera m_Camera;

	private UIAvatarInputHandler m_AvatarInput;

	private List<TeamAvatar> m_teamAvatars;

	private List<UIBaseGroupMemberInfoController> m_NamePanels;

	private List<GameObject> m_AvatarParticleList;

	private UIModelGroup m_ModelGroup;

	private UIModelTeamReserve m_ModelTeamReserve;

	private UIModelPresence m_ModelPresence;

	private UIModelAvatar m_ModelAvatar;

	private UIModelCSLadderMatch m_ModelLadderCS;

	private UIModelLadderMatch m_ModelLadderBR;

	private UIModelRankingTips m_ModelRankingTips;

	private UIModelUser m_ModelUser;

	private UIModelCollectionCustom m_ModelCollectionCustom;

	private bool m_AvatarShowCached;

	private EFrontendUIType m_CurrentCameraUIType;

	private GameObject avatarLight;

	private GameObject m_guidePetAcion;

	private GameObject m_AvatarGuideEffect;

	private List<int> m_AvailableTeamNums;

	private Dictionary<ulong, int> m_ReservePosIdDict;

	private bool m_HaveReserveFakeMember;

	private Dictionary<ulong, int> m_RematchPosIdDict;

	private bool m_HaveRematchFakeMember;

	private bool m_NeedMoveCameraGradual;

	private Vector3 m_TargetCameraPos;

	public float CameraMoveMaxDistance;

	private uint m_StreakScrollDelayCall;

	private List<int> m_StreakScrollIndexs;

	private UIModelHippoCrisis m_ModelHippoCrisis;

	public Vector3 OriginalPos;

	private Dictionary<int, TeamAvatarPos> m_DictPosition;

	private Dictionary<int, TeamAvatarPos> m_DictPentaPosition;

	private Dictionary<int, TeamAvatarPos> m_DictHCAvatarPosition;

	private static readonly float[] m_AvatarYOffSet;

	private static readonly float[] m_PentaAvatarYOffSet;

	private Vector3 m_V2PetReplacerPos;

	private Vector3 m_V2PentaPetReplacerPos;

	private float m_RankEffectOffsetToNamePanelPos;

	private float m_GameAssistantPosOffsetY;

	private Vector3[] m_NamePanelPosArray;

	private Vector3[] m_NamePanelHCPosArray;

	private Vector3[] m_PentaNamePanelPosArray;

	private Vector3[] chatBubblePosition;

	private Vector3[] HCChatBubblePosition;

	private Vector3[] chatBubblePositionNotFive;

	private Vector3[] chatBubblePositionFive;

	private const float LobbyDefaultAvatarScale = 380f;

	private Dictionary<int, AvatarSetting> AVATAR_SETTING;

	private Dictionary<int, AvatarPetSetting> AVATAR_PET_SETTING;

	private Dictionary<int, AvatarPetSetting> AVATAR_PET_REPLACE_SETTING;

	private Dictionary<int, ResourceID> MALE_AVATAR_HC_STANDIDLE_RES;

	private Dictionary<int, ResourceID> FEMALE_AVATAR_HC_STANDIDLE_RES;

	private Vector3[] m_LaunchTagPosAray_Normal;

	private Vector3[] m_LaunchTagPosAray_Penta;

	private float[] m_LaunchTagScaleArray;

	private Dictionary<int, uint> m_HCAvatarWeaponDict;

	private UIModelPet m_ModelPet;

	private UIModelFriends m_ModelFriends;

	private UIModelCollection m_ModelCollection;

	private UIModelPVE m_ModelPVE;

	private UIModelTailor m_ModelTailor;

	private UIModelWeaponSkinUpgrader m_ModelWeaponSkinUpgrader;

	private ulong _003CTargetShowPopMenuAccountID_003Ek__BackingField;

	private bool m_isInLobby;

	private bool m_isInHippoCrisisLobby;

	private bool m_isInOneLobby;

	private Dictionary<int, IEnumerator> m_OnGroupJoinIEnumerators;

	private Queue<GroupMemberInfo> m_WaitingJoinMembers;

	private static bool s_AsyncCreateAvatarOnceDone;

	private bool m_IsHideTeammatePet;

	private UIHDStandLobbyInputHandler m_HDStandLobbyInputHandler;

	private UIHDPetInputHandler m_HDPetInputHandler;

	private Animator m_CameraAnim;

	private UIModelGameAssistantIntroduction m_UIModelGameAssistantIntroduction;

	private UIModelLoadout m_ModelLoadout;

	private UIGameAssistantLobbyBubbleController m_GameAssistantLobbyBubbleController;

	private UIGameAssistantLobbyRankingTipsBubbleController m_GameAssistantLobbyRankingTipsBubbleController;

	private bool m_CurrentGroupShowPrimeSetShareGuide;

	private int m_PendingNamePanelRefreshCount;

	private bool m_isAvatarInGroup;

	private bool m_isPetInEmote;

	private bool m_isEnterYard;

	private GameObject m_InCaptainLobbyVFX;

	private Animator m_InCaptainLobbyVFXAni;

	private List<ResourceID> m_PrimeSetShareAnimationResourceIDs;

	private Dictionary<int, BitArrayBoolean> m_AvatarVisibleDict;

	private const uint ISVISIBLE_NORMAL = 1u;

	private const uint ISVISIBLE_FAKEMEMBER = 2u;

	private const uint ISVISIBLE_TAKEPHOTO = 4u;

	public bool TakePhoto_TeammateShow;

	public bool TakePhoto_NameShow;

	private float CacheCamFovForFixAvatarPositionV2;

	private ulong m_CooperateEmoteLeaderAccountId;

	public UIMaleAvatar Avatar => null;

	public Vector3 OriginalAvatarPos
	{
		get
		{
			return _003COriginalAvatarPos_003Ek__BackingField;
		}
		private set
		{
			_003COriginalAvatarPos_003Ek__BackingField = value;
		}
	}

	public List<TeamAvatar> TeamAvatars => null;

	private List<UIBaseGroupMemberInfoController> NamePanels => null;

	public ulong TargetShowPopMenuAccountID
	{
		get
		{
			return _003CTargetShowPopMenuAccountID_003Ek__BackingField;
		}
		set
		{
			_003CTargetShowPopMenuAccountID_003Ek__BackingField = value;
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	private void OnAvatarClothUpdate(object[] data)
	{
	}

	private void OnAvatarUpdate(object[] data)
	{
	}

	private void OnTransformerShowUpdate()
	{
	}

	private void CheckClothPrivilege()
	{
	}

	private void QuitAvatarTransform()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void CreatePetAvatar(object[] data)
	{
	}

	private void OnSelfOwnedPetCreated(uint ticket, UIPetAvatar petAvatar)
	{
	}

	private void OnTeammatePetCreated(uint ticket, UIPetAvatar petAvatar, TeamAvatar ta, int posId)
	{
	}

	private bool IsInGroupPhotoInterface()
	{
		return false;
	}

	public void CreateAvatarLight(EFrontendUIType uitype)
	{
	}

	public void CreateTeammateLight()
	{
	}

	private void OnShowPetActionGuide(object[] param)
	{
	}

	private void OnHidePetActionGuide(object[] param)
	{
	}

	private void OnShowAvatarGuideEffect(object[] param)
	{
	}

	private void OnHideAvatarGuideEffect(object[] param)
	{
	}

	private void OnClickPet()
	{
	}

	private void OnDestoryAvatarParticle(object[] data)
	{
	}

	private void OnCreateAvatarParticle(object[] data)
	{
	}

	private void OnAvatarInitReady(bool isLocal)
	{
	}

	private void OnWardrobeEnter(object[] data)
	{
	}

	private void OnProfileEnter(object[] data)
	{
	}

	private void OnPetWindowEnter(object[] data)
	{
	}

	private void OnPVEPrepareEnter(object[] data)
	{
	}

	private void ChangeAvatarCamera(object[] data)
	{
	}

	private void OnAvatarCameraStateChange(object[] data)
	{
	}

	private void SetAvatarAnimatorState(bool state)
	{
	}

	private void OnAvatarInputEnableState(object[] data)
	{
	}

	private void OnAvatarStateChange(object[] data)
	{
	}

	private TeamAvatar GetTeamAvatarByAccount(ulong accountId)
	{
		return null;
	}

	private TeamAvatar GetTeamAvatarByPosId(int posId)
	{
		return null;
	}

	private IEnumerator ChatBubbleCoroutine()
	{
		return null;
	}

	private IEnumerator TeammateChatBubbleCoroutine(TeamAvatar ta)
	{
		return null;
	}

	private void OnGroupChangeNtf(object[] data)
	{
	}

	public void OnNamePanelRefreshComplete()
	{
	}

	private void ResetAllAvatarsPosAndRot()
	{
	}

	public void SetUIPosByGyro(Vector3 pos)
	{
	}

	public void SetAvatarPosByGyro(Vector3 pos)
	{
	}

	public void SetTeamAvatarPosByGyro(TeamAvatar ta, Vector3 pos)
	{
	}

	private void RecordOriginalPosAndApplyGyroPos()
	{
	}

	private void RecordOriginalPosAndApplyGyroPos(TeamAvatar ta)
	{
	}

	private Vector3 TryGetAvatarPosByMappingGyroOffset(Vector3 originPos)
	{
		return default(Vector3);
	}

	private void CheckStreakScroll()
	{
	}

	private void DoStreakScroll(bool needScrollStreakIcon)
	{
	}

	private void StreakScroll()
	{
	}

	private void FixTeammatePosID(TeamAvatar teammate)
	{
	}

	private void OnPetHdMoveChanged(object[] data)
	{
	}

	private void OnHCLobbyGroupEnter(object[] data)
	{
	}

	private void OnLobbyGroupEnter(object[] data)
	{
	}

	private Vector3 GetNamePanelsPositionByPosId(int posId)
	{
		return default(Vector3);
	}

	private Vector3 GetLaunchTagPositionByPosId(int posId)
	{
		return default(Vector3);
	}

	private float GetLaunchTagScalenByPosId(int posId)
	{
		return 0f;
	}

	private void OnGroupInfoClear(object[] data)
	{
	}

	private void PrepareTodayBattleReportDataOnLobbyEnter()
	{
	}

	private void OnHCLobbyEnter(object[] data)
	{
	}

	private void OnLobbyEnter(object[] data)
	{
	}

	private void OnEnterPortraitCloseup(object[] data)
	{
	}

	private void OnEnterAvatarProfile(object[] data)
	{
	}

	private void OnEnterLeaderBoard(object[] data)
	{
	}

	private void OnEnterWeaponSkinUpgrader(object[] data)
	{
	}

	private void OnEnterLegendClothVault(object[] data)
	{
	}

	private void OnExitLegendClothVault(object[] data)
	{
	}

	private void OnDisableTeamAvatar(object[] data)
	{
	}

	private void OnMallEnter(object[] data)
	{
	}

	private void OnForgeEnter(object[] data)
	{
	}

	private void OnGachaEnter(object[] data)
	{
	}

	private void OnCollectionEnter(object[] data)
	{
	}

	private void OnIAPBundleEnter(object[] data)
	{
	}

	private void OnProfileShareEnter(object[] data)
	{
	}

	private void OnGainItemEnter(object[] data)
	{
	}

	private void OnElitePassEnter(object[] data)
	{
	}

	private void AutoModifyCamera()
	{
	}

	private void OnGroupQuitClearAvatar(object[] data)
	{
	}

	private IEnumerator EnterGroupPlayIdleEffectCoroutine()
	{
		return null;
	}

	private IEnumerator EnterGroupPlayIdleEffectCoroutine(TeamAvatar p)
	{
		return null;
	}

	private void OnGroupCreate(object[] data)
	{
	}

	private void EnterGroupEffectSelf()
	{
	}

	private bool CanPlayGroupAnimSelf()
	{
		return false;
	}

	private EnterGroupEffectType GetOtherEnterGroupEffectType(TeamAvatar p)
	{
		return EnterGroupEffectType.None;
	}

	private void EnterGroupEffectOthers(TeamAvatar p)
	{
	}

	private void OnEnterGroupPlayRankEffect(int rank, bool isBRRank, int anotherRank, uint peakRankPos = 0u)
	{
	}

	private void OnEnterGroupPlayRankEffect(TeamAvatar p, int rank, bool isBRRank, int anotherRank, uint peakRankPos = 0u)
	{
	}

	private IEnumerator GroupJoinCoroutine(int coroutineKey, object[] data)
	{
		return null;
	}

	private void OnGroupJoin(object[] data)
	{
	}

	private void OnGroupPetShowAction(object[] data)
	{
	}

	private TeamAvatarPos GetHCLobbyAvatarPositionByPosId(int posId)
	{
		return null;
	}

	public TeamAvatarPos GetAvatarPositionByPosId(int posId)
	{
		return null;
	}

	public static float GetAvatarYOffset(int idx)
	{
		return 0f;
	}

	public Vector3 GetAvatarPositionV2ByPosId(int posId)
	{
		return default(Vector3);
	}

	private void LocalPositionToScreenPosition(UIRoot root, ref Vector3 local)
	{
	}

	private Dictionary<int, TeamAvatarPos> GetAvatarPosDictByGroupMode(CMDBIPLGLGA groupMode)
	{
		return null;
	}

	private void CancelAsyncCreatePet(ref uint ticket)
	{
	}

	private void UpdateAvatarPetShow()
	{
	}

	private void UpdateGroupAvatarsClothesAndBackpack(bool updateOptionalAvatarRes = false, bool lockAvatarState = false, bool releaseAvatarState = false)
	{
	}

	private void RefreshPinData()
	{
	}

	private void RefreshRebuildAvatar()
	{
	}

	private void RecreateTeamAvatar(GroupMemberInfo member, TeamAvatar ta)
	{
	}

	private void UpdateWaitingJoinMembers()
	{
	}

	private IEnumerator ShowAvatarsCoroutine(List<ulong> joinedMemberIds)
	{
		return null;
	}

	private Vector3 GetTeamAvatarChatBubblePos(TeamAvatar ta)
	{
		return default(Vector3);
	}

	private Vector3 CalcAvatarChatBubblePos(UIMaleAvatar avatar)
	{
		return default(Vector3);
	}

	private void ShowAvatars()
	{
	}

	private void OnGroupLeaveNtf(object[] data)
	{
	}

	public bool IsAvatarTeammate(UIAvatar avatar)
	{
		return false;
	}

	private void ClearLocalPlayerShowHCWeapon()
	{
	}

	private void ClearPlayerShowHCBox()
	{
	}

	private void PlayAvatarShowHCPose()
	{
	}

	private void RefreshLocalPlayerShowHCWeapon()
	{
	}

	private void ShowLocalPlayerHCBox()
	{
	}

	private void ShowTeammate1PlayerHCBox()
	{
	}

	private ResourceID GetHCAvatarStandIdleRes(bool isFemale, int index)
	{
		return default(ResourceID);
	}

	private void PlayAvatarShowPose(bool takeWeapon = false, bool force = false)
	{
	}

	private bool ShowPVEWeapon()
	{
		return false;
	}

	private void OnRefreshWeapon(object[] data)
	{
	}

	private void OnRefreshWeaponOnHand(object[] data)
	{
	}

	private void OnPlayerBackpackUpdate(object[] data)
	{
	}

	private void TryShowPrimeSetShareGuide()
	{
	}

	private void RefreshLocalPlayerBySetShare(bool lockAvatarState = false, bool releaseAvatarState = false)
	{
	}

	private void RefreshSelfWeaponOnHand(bool force = false)
	{
	}

	private void RefreshTeamateWeaponOnHand()
	{
	}

	public uint GetTeamTargetWeaponSkinId(uint skinId, ulong accountId)
	{
		return 0u;
	}

	private uint GetTargetWeaponSkinId(uint skinId, TeamAvatar ta)
	{
		return 0u;
	}

	private void UpdataGroupReadyState(object[] data)
	{
	}

	private void UpdataMemberNamePanels()
	{
	}

	private void RefreshTeamatePVEWeapon()
	{
	}

	private IEnumerator PlayAvatarShowPose(UIMaleAvatar avatar, float seconds)
	{
		return null;
	}

	private void OnStopAvatarShowPose(object[] data)
	{
	}

	private void OnInviteBtnClick(int member_idx, ulong friendid, string lockRegion)
	{
	}

	private void OnGroupQuit()
	{
	}

	private void OnGroupDismissNtf(object[] data)
	{
	}

	private void OnGroupReadyNtf(object[] data)
	{
	}

	private void OnSyncOptionalMapResNtf(object[] data)
	{
	}

	private void OnTeammateMuteStateChange(object[] data)
	{
	}

	private void OnTeammateProfileSpeakerStateChange(object[] data)
	{
	}

	private void OnPlayerJoin(object[] data)
	{
	}

	private void onGroupStopNtf(object[] data)
	{
	}

	private Vector3 ScreenToLocalPosition(Vector3 pos)
	{
		return default(Vector3);
	}

	private void Update()
	{
	}

	private void SetAvatarRelatedPos(EFrontendUIType uiType)
	{
	}

	public AvatarSetting GetCurrentAvatarSetting(EFrontendUIType type)
	{
		return null;
	}

	private void UpdatePetAvataReplacer()
	{
	}

	private void SetAvatarPet()
	{
	}

	private void PetTransformFit(AvatarPetSetting setting)
	{
	}

	private void ShowPetLobbyAction(object[] param)
	{
	}

	private bool ShowWeaponInCurrentUI()
	{
		return false;
	}

	private void ShowTeamAvatars(bool isVisible, uint visibleBit, bool? isChangeAvatarPos = null, bool? isChangeAvatarRot = null)
	{
	}

	private void OnResetGachaAvatar(object[] data)
	{
	}

	private void ShowWeaponAnim(uint skinId, UIMaleAvatar avatar, tcp.WeaponSkinStat stat, bool force = false)
	{
	}

	private void ShowWeaponAnimInternal(UIMaleAvatar avatar, AFOLPMOCBOG cData, WeaponSkinData lData, bool force = false)
	{
	}

	private void ShowHCWeaponAnim(TeamAvatar ta)
	{
	}

	public bool CheckIsDualWield(WeaponSkinData data)
	{
		return false;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void RefreshTeamAvatars(bool updateOptionalAvatarRes = false, bool lockAvatarState = false, bool releaseAvatarState = false)
	{
	}

	private bool DoTeamAvatarsNeedRefresh()
	{
		return false;
	}

	private bool GetHasUnlockEffectItem(List<InventoryTailorChangeNtf.ChangeUnlockInfo> unlocks)
	{
		return false;
	}

	public float GetAllNeedDownloadSize()
	{
		return 0f;
	}

	public void DownLoadAllTeamateEquipment()
	{
	}

	private bool CheckPetAbStateChanged(UIPetAvatar pet, GroupMemberPetInfo info)
	{
		return false;
	}

	private void TryRefreshTransform()
	{
	}

	private void UpdateTeamWeaponInfo()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void DestroyAvatar(UIMaleAvatar a)
	{
	}

	private void OnPlayerUpdateShadowPos(object[] data)
	{
	}

	public void SetCameraEnable(bool enable)
	{
	}

	private void UpdateLocalPlayerShadowPos()
	{
	}

	private void ShowLocalPlayerShadow(bool show)
	{
	}

	private void LightShadowStateChanged(GameObject lightObj, bool castShadow)
	{
	}

	private void OnLobbyVisibleChange(object[] data)
	{
	}

	private void OnHippoCrisisLobbyShowChange(object[] data)
	{
	}

	private void ShowTeamInfoOnLobbyVisibleChange()
	{
	}

	private void OnPetEmoteChanged(bool isInEmote)
	{
	}

	private void OnAvatarEnterGroup(object[] data)
	{
	}

	private void OnEnterGroupChangeToCaptainLobby(object[] data)
	{
	}

	private void InCaptainLobbyVFXInstant(bool isEnter)
	{
	}

	private void HideCaptainLobbyVFXInstant(object[] data)
	{
	}

	private void LeaveCaptainLobby(object[] data)
	{
	}

	private void OnLobbyYardEnter(object[] data)
	{
	}

	private void OnHDLobbySceneItemViewEnter(object[] data)
	{
	}

	private void HDResetAvatar()
	{
	}

	private void OnLobbyYardVisibilityChanged(object[] data)
	{
	}

	private void OnShowAvatarRefreshReserveFakeMember()
	{
	}

	private void OnShowAvatarRefreshRematchFakeMember()
	{
	}

	private void OnClearRematchPosId()
	{
	}

	private void OnGroupModeAvatarEmoteEnd(object[] args)
	{
	}

	private int GetPosId(ulong accountId)
	{
		return 0;
	}

	private void OnClearReservePosId()
	{
	}

	private void RemoveReserve()
	{
	}

	private void OnPrimeSetShareNtf(GEvent _data)
	{
	}

	private List<ResourceID> GetNeedDownloadPrimeSetShareResources()
	{
		return null;
	}

	private bool CheckAndDownloadPrimeSetShareAnimations()
	{
		return false;
	}

	private bool CheckBeReserverStatus(FriendAccountInfo info)
	{
		return false;
	}

	private void HideGameAssistantBubble()
	{
	}

	public void ShowHidePetInTakePhoto(bool show)
	{
	}

	public void ShowHidePetInPortrait(bool show)
	{
	}

	private void HideGameAssistantRankingTipsBubble()
	{
	}

	private void ShowPetAvatarReplcaer()
	{
	}

	private void RefreshPetAndAssist()
	{
	}

	private void OnStartMatchMakingRefreshGameAssistantBubble(object[] data)
	{
	}

	private void RefreshGameAssistantBubble()
	{
	}

	public void RefreshRankingTipsBubble(bool isNeedRefresh = true)
	{
	}

	public Vector3 GetPetAvatarPos()
	{
		return default(Vector3);
	}

	public Vector3 GetGameAssistantBubblePos()
	{
		return default(Vector3);
	}

	private Vector3 GetGameAssistantBubblePosByNoPet()
	{
		return default(Vector3);
	}

	public void RefreshTeamAvatarsVisible(bool isVisible, int idx)
	{
	}

	public void ResetAvatarRoation(int pos_id)
	{
	}

	public void TakePhotoShowTeammate(bool show)
	{
	}

	public void TakePhotoShowPlayerName(bool isshow)
	{
	}

	private void OnTakePhotoClose(object[] objects)
	{
	}

	private void OnTakePhotoShow(object[] objects)
	{
	}

	public void ShowHideGameAssistant(bool isShow)
	{
	}

	public void ForceHideGameAssistantBubble()
	{
	}

	public void RestoreGameAssistantBubble()
	{
	}

	private void ForceCreateAndShowPetGuideBubbleForDebug()
	{
	}

	public void RefreshNamePanelsTakePhoto()
	{
	}

	public void OnShowHideHCLobby(bool isShowHCLobby)
	{
	}

	public void SetAvatarInputHandle(UIAvatarInputHandler uiAvatarInputHandler)
	{
	}

	public void RecordCurCameraFov()
	{
	}

	private void ShowEmotes(GEvent _data)
	{
	}

	private void BatchPlayEmote(GEventShowEmote data)
	{
	}

	private void BatchStopEmote(GEventShowEmote data)
	{
	}

	private void PlayEmote(UIMaleAvatar avatar, ulong accountId, uint emoteId, List<TeammateEmoteInfo> teammateEmoteInfoList, EDuoEmoteStage eDuoEmoteStage, EmoteExtralInfo extralInfo)
	{
	}

	private bool SetAvatarPosition(UIMaleAvatar avatar, uint emoteID, EDuoEmoteStage eDuoEmoteStage)
	{
		return false;
	}

	private void BeforeBatchPlayEmote(uint emoteID)
	{
	}

	private void AfterAvatarPlayEmote(uint emoteID, ulong accountID)
	{
	}

	private void PlayDuoEmote(GEvent _data)
	{
	}

	private void StopEmote(ulong accountId)
	{
	}

	private void StopEmoteWithInfo(GEvent emoteInfoObj)
	{
	}

	private void StopEmoteWhenEmoteFinish(GEvent _data)
	{
	}

	private void TryStopCurrentDuoEmote(ulong accountId)
	{
	}

	private void TryStopCurrentCooperateEmote(ulong accountId)
	{
	}

	private void StopCooperateEmote(ulong accountId, uint emoteId, UIMaleAvatar currentAvatar)
	{
	}

	private void StopDuoEmote(ulong accountId, uint emoteId)
	{
	}

	private void EmoteFinishEventEmitter(object[] data)
	{
	}

	private void ReceiveDuoEmoteInviteBehavior(GEvent _data)
	{
	}

	private void ShowAvatarTransform(GEvent _data)
	{
	}

	private void PlayAvatarTransformInTeammates(UIMaleAvatar avatar, ulong accountId, uint transformID, uint transformLevel, uint transformState, uint transformExtraInfo)
	{
	}

	private void ShowLocalAvatarTransformer(GEvent _data)
	{
	}

	private void _003COnEnterGroupPlayRankEffect_003Eb__200_0(bool isInterrupt)
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
}
