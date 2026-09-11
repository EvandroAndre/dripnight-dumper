using System;
using System.Collections.Generic;
using COW.GamePlay.UGCRuntime;
using UnityEngine;

namespace COW;

public class UGCPlayerRepItem
{
	public const int PROP_ID_HP = -14000;

	public const int PROP_ID_HPMAX = -14001;

	public const int PROP_ID_ISAI = -14002;

	public const int PROP_ID_STATE = -14003;

	public const int PROP_ID_LASTSURVIVALTIME = -14004;

	public const int PROP_ID_GODSTATE = -14005;

	public const int PROP_ID_HOSTTEAMENTITY = -14006;

	public const int PROP_ID_LASTCHECKPOINTID = -14007;

	public const int PROP_ID_NEXTCHECKPOINTID = -14008;

	public const int PROP_ID_BORNPOSITION = -14009;

	public const int PROP_ID_REVIVEPOSITION = -14010;

	public const int PROP_ID_FACTION = -14011;

	public const int PROP_ID_UGCWEAPONDAMAGERATE = -14012;

	public const int PROP_ID_HUMANMODEL = -14013;

	public const int PROP_ID_RUNSPEEDSCALE = -14014;

	public const int PROP_ID_JUMPHEIGHTSCALE = -14015;

	public const int PROP_ID_IDENTITY = -14016;

	public const int PROP_ID_ZOMBIELEVEL = -14017;

	public const int PROP_ID_DIRECTPOSITION = -14018;

	public const int PROP_ID_NICKNAME = -14019;

	public const int PROP_ID_INJUREDSCALE = -14020;

	public const int PROP_ID_EP = -14021;

	public const int PROP_ID_EPMAX = -14022;

	public const int PROP_ID_WEAPONINHAND = -14023;

	public const int PROP_ID_REMOVEALLEQUIPMENTONDEATH = -14024;

	public const int PROP_ID_SKIPKNOCKDOWN = -14025;

	public const int PROP_ID_AIMASSISTTYPE = -14026;

	public const int PROP_ID_CANBELOCKEDBYAIMASSIST = -14027;

	public const int PROP_ID_MUTEVOICE = -14028;

	public const int PROP_ID_MUTEQUICKCHAT = -14029;

	public const int PROP_ID_CHATCHANNEL = -14030;

	public const int PROP_ID_MOVEMENTSTATUS = -14031;

	public const int PROP_ID_SPRINTSTATUS = -14032;

	public const int PROP_ID_ATTACKSTATUS = -14033;

	public const int PROP_ID_JUMPSTATUS = -14034;

	public const int PROP_ID_PICKUPITEMDISABLED = -14035;

	public const int PROP_ID_DROPITEMDISABLED = -14036;

	public const int PROP_ID_HOSTILEPLAYERS = -14037;

	public const int PROP_ID_FRIENDLYPLAYERS = -14038;

	public const int PROP_ID_FACTIONENTITY = -14039;

	public const int PROP_ID_FACTIONINDEX = -14040;

	public const int PROP_ID_CURRENTCAMERACONFIG = -14041;

	public const int PROP_ID_CUSTOMGRAVITY = -14042;

	public const int PROP_ID_HELMET = -14043;

	public const int PROP_ID_VEST = -14044;

	public const int PROP_ID_CROUCHSPEEDSCALE = -14045;

	public const int PROP_ID_DASHSPEEDSCALE = -14046;

	public const int PROP_ID_KNOCKDOWNSPEEDSCALE = -14047;

	public const int PROP_ID_CREEPSPEEDSCALE = -14048;

	public const int PROP_ID_HEADBONESSCALE = -14049;

	public const int PROP_ID_BODYBONESSCALE = -14050;

	public const int PROP_ID_LIMBBONESSCALE = -14051;

	public const int PROP_ID_USERUID = -14052;

	public const int PROP_ID_UGCHEADSHOTDAMAGEDECREASESCALE = -14053;

	public const int PROP_ID_PLAYERAVATAR = -14054;

	public const int PROP_ID_GENDER = -14055;

	public const int PROP_ID_WEAPONSKINID = -14056;

	public const int PROP_ID_BORNPOSITIONVEC3 = -14057;

	public const int PROP_ID_REVIVEPOSITIONVEC3 = -14058;

	public const int PROP_ID_DIRECTPOSITIONVEC3 = -14059;

	public const int PROP_ID_DIRECTFORWARDVEC3 = -14060;

	public const int PROP_ID_BONES = -14061;

	public const int PROP_ID_PLAYERBAGENTITY = -14062;

	public const int PROP_ID_TEMPORARYSHIELD = -14063;

	public const int PROP_ID_VEHICLESKINIDS = -14064;

	public const int PROP_ID_ANIMSKIPFALLINGLAND = -14065;

	public const int PROP_ID_FALLDAMAGEDISABLED = -14066;

	public const int PROP_ID_HANDHELDITEM = -14067;

	public const int PROP_ID_DISABLEPICKUPITEMS = -14068;

	public const int PROP_ID_RESPLAYERUUID = -14069;

	public const int PROP_ID_ASKBUYTARGET = -14070;

	public const int PROP_ID_CURRENTEMOTECLIP = -14071;

	public const int PROP_ID_ISCURRENTEMOTELOOP = -14072;

	public const int PROP_ID_KNOCKDOWN = -14073;

	public const int PROP_ID_SHOWDAMAGENUM = -14074;

	public const int PROP_ID_BAGSKINID = -14075;

	public const int PROP_ID_CANFREEQUIT = -14076;

	public const int PROP_ID_TRANSFORMCLOTHINFO = -14077;

	public const int PROP_ID_CURRENTNEWCAMERA = -14078;

	public const int PROP_ID_BINDEDCUSTOMPLAYER = -14079;

	public const int PROP_ID_PLATFORMPLAYERLEVEL = -14080;

	private UGCEntityDataStore _repDataMgr;

	public Action<bool> OnRemoveAllEquipmentOnDeathChangeEvent;

	public Action<bool> OnSkipKnockdownChangeEvent;

	public Action<int> OnAimAssistTypeChangeEvent;

	public Action<bool> OnCanBeLockedByAimAssistChangeEvent;

	public Action<bool> OnMuteVoiceChangeEvent;

	public Action<bool> OnMuteQuickChatChangeEvent;

	public Action<string> OnChatChannelChangeEvent;

	public Action<int> OnMovementStatusChangeEvent;

	public Action<int> OnSprintStatusChangeEvent;

	public Action<int> OnAttackStatusChangeEvent;

	public Action<int> OnJumpStatusChangeEvent;

	public Action<bool> OnPickupItemDisabledChangeEvent;

	public Action<bool> OnDropItemDisabledChangeEvent;

	public Action<List<object>> OnHostilePlayersChangeEvent;

	public Action<List<object>> OnFriendlyPlayersChangeEvent;

	public Action<string> OnFactionEntityChangeEvent;

	public Action<int> OnFactionIndexChangeEvent;

	public Action<string> OnCurrentCameraConfigChangeEvent;

	public Action<float> OnCustomGravityChangeEvent;

	public Action<Vector3> OnHeadBonesScaleChangeEvent;

	public Action<Vector3> OnBodyBonesScaleChangeEvent;

	public Action<Vector3> OnLimbBonesScaleChangeEvent;

	public Action<float> OnUGCHeadshotDamageDecreaseScaleChangeEvent;

	public Action<string> OnPlayerAvatarChangeEvent;

	public Action<int> OnGenderChangeEvent;

	public Action<List<object>> OnWeaponSkinIDChangeEvent;

	public Action<Vector3> OnBornPositionVec3ChangeEvent;

	public Action<Vector3> OnRevivePositionVec3ChangeEvent;

	public Action<string> OnBonesChangeEvent;

	public Action<string> OnPlayerBagEntityChangeEvent;

	public Action<List<object>> OnVehicleSkinIDsChangeEvent;

	public Action<bool> OnAnimSkipFallingLandChangeEvent;

	public Action<bool> OnFallDamageDisabledChangeEvent;

	public Action<List<object>> OnDisablePickUpItemsChangeEvent;

	public Action<string> OnResPlayerUUIDChangeEvent;

	public Action<int> OnAskBuyTargetChangeEvent;

	public Action<string> OnCurrentEmoteClipChangeEvent;

	public Action<bool> OnIsCurrentEmoteLoopChangeEvent;

	public Action<int> OnKnockDownChangeEvent;

	public Action<bool> OnShowDamageNumChangeEvent;

	public Action<int> OnBagSkinIDChangeEvent;

	public Action<bool> OnCanFreeQuitChangeEvent;

	public Action<string> OnTransformClothInfoChangeEvent;

	public Action<string> OnCurrentNewCameraChangeEvent;

	public Action<string> OnBindedCustomPlayerChangeEvent;

	private bool _003CRemoveAllEquipmentOnDeath_003Ek__BackingField;

	private bool _003CSkipKnockdown_003Ek__BackingField;

	private int _003CAimAssistType_003Ek__BackingField;

	private bool _003CCanBeLockedByAimAssist_003Ek__BackingField;

	private bool _003CMuteVoice_003Ek__BackingField;

	private bool _003CMuteQuickChat_003Ek__BackingField;

	private string _003CChatChannel_003Ek__BackingField;

	private int _003CMovementStatus_003Ek__BackingField;

	private int _003CSprintStatus_003Ek__BackingField;

	private int _003CAttackStatus_003Ek__BackingField;

	private int _003CJumpStatus_003Ek__BackingField;

	private bool _003CPickupItemDisabled_003Ek__BackingField;

	private bool _003CDropItemDisabled_003Ek__BackingField;

	private List<object> _003CHostilePlayers_003Ek__BackingField;

	private List<object> _003CFriendlyPlayers_003Ek__BackingField;

	private string _003CFactionEntity_003Ek__BackingField;

	private int _003CFactionIndex_003Ek__BackingField;

	private string _003CCurrentCameraConfig_003Ek__BackingField;

	private float _003CCustomGravity_003Ek__BackingField;

	private Vector3 _003CHeadBonesScale_003Ek__BackingField;

	private Vector3 _003CBodyBonesScale_003Ek__BackingField;

	private Vector3 _003CLimbBonesScale_003Ek__BackingField;

	private float _003CUGCHeadshotDamageDecreaseScale_003Ek__BackingField;

	private string _003CPlayerAvatar_003Ek__BackingField;

	private int _003CGender_003Ek__BackingField;

	private List<object> _003CWeaponSkinID_003Ek__BackingField;

	private Vector3 _003CBornPositionVec3_003Ek__BackingField;

	private Vector3 _003CRevivePositionVec3_003Ek__BackingField;

	private string _003CBones_003Ek__BackingField;

	private string _003CPlayerBagEntity_003Ek__BackingField;

	private List<object> _003CVehicleSkinIDs_003Ek__BackingField;

	private bool _003CAnimSkipFallingLand_003Ek__BackingField;

	private bool _003CFallDamageDisabled_003Ek__BackingField;

	private List<object> _003CDisablePickUpItems_003Ek__BackingField;

	private string _003CResPlayerUUID_003Ek__BackingField;

	private int _003CAskBuyTarget_003Ek__BackingField;

	private string _003CCurrentEmoteClip_003Ek__BackingField;

	private bool _003CIsCurrentEmoteLoop_003Ek__BackingField;

	private int _003CKnockDown_003Ek__BackingField;

	private bool _003CShowDamageNum_003Ek__BackingField;

	private int _003CBagSkinID_003Ek__BackingField;

	private bool _003CCanFreeQuit_003Ek__BackingField;

	private string _003CTransformClothInfo_003Ek__BackingField;

	private string _003CCurrentNewCamera_003Ek__BackingField;

	private string _003CBindedCustomPlayer_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public bool RemoveAllEquipmentOnDeath
	{
		get
		{
			return _003CRemoveAllEquipmentOnDeath_003Ek__BackingField;
		}
		private set
		{
			_003CRemoveAllEquipmentOnDeath_003Ek__BackingField = value;
		}
	}

	public bool SkipKnockdown
	{
		get
		{
			return _003CSkipKnockdown_003Ek__BackingField;
		}
		private set
		{
			_003CSkipKnockdown_003Ek__BackingField = value;
		}
	}

	public int AimAssistType
	{
		get
		{
			return _003CAimAssistType_003Ek__BackingField;
		}
		private set
		{
			_003CAimAssistType_003Ek__BackingField = value;
		}
	}

	public bool CanBeLockedByAimAssist
	{
		get
		{
			return _003CCanBeLockedByAimAssist_003Ek__BackingField;
		}
		private set
		{
			_003CCanBeLockedByAimAssist_003Ek__BackingField = value;
		}
	}

	public bool MuteVoice
	{
		get
		{
			return _003CMuteVoice_003Ek__BackingField;
		}
		private set
		{
			_003CMuteVoice_003Ek__BackingField = value;
		}
	}

	public bool MuteQuickChat
	{
		get
		{
			return _003CMuteQuickChat_003Ek__BackingField;
		}
		private set
		{
			_003CMuteQuickChat_003Ek__BackingField = value;
		}
	}

	public string ChatChannel
	{
		get
		{
			return _003CChatChannel_003Ek__BackingField;
		}
		private set
		{
			_003CChatChannel_003Ek__BackingField = value;
		}
	}

	public int MovementStatus
	{
		get
		{
			return _003CMovementStatus_003Ek__BackingField;
		}
		private set
		{
			_003CMovementStatus_003Ek__BackingField = value;
		}
	}

	public int SprintStatus
	{
		get
		{
			return _003CSprintStatus_003Ek__BackingField;
		}
		private set
		{
			_003CSprintStatus_003Ek__BackingField = value;
		}
	}

	public int AttackStatus
	{
		get
		{
			return _003CAttackStatus_003Ek__BackingField;
		}
		private set
		{
			_003CAttackStatus_003Ek__BackingField = value;
		}
	}

	public int JumpStatus
	{
		get
		{
			return _003CJumpStatus_003Ek__BackingField;
		}
		private set
		{
			_003CJumpStatus_003Ek__BackingField = value;
		}
	}

	public bool PickupItemDisabled
	{
		get
		{
			return _003CPickupItemDisabled_003Ek__BackingField;
		}
		private set
		{
			_003CPickupItemDisabled_003Ek__BackingField = value;
		}
	}

	public bool DropItemDisabled
	{
		get
		{
			return _003CDropItemDisabled_003Ek__BackingField;
		}
		private set
		{
			_003CDropItemDisabled_003Ek__BackingField = value;
		}
	}

	public List<object> HostilePlayers
	{
		get
		{
			return _003CHostilePlayers_003Ek__BackingField;
		}
		private set
		{
			_003CHostilePlayers_003Ek__BackingField = value;
		}
	}

	public List<object> FriendlyPlayers
	{
		get
		{
			return _003CFriendlyPlayers_003Ek__BackingField;
		}
		private set
		{
			_003CFriendlyPlayers_003Ek__BackingField = value;
		}
	}

	public string FactionEntity
	{
		get
		{
			return _003CFactionEntity_003Ek__BackingField;
		}
		private set
		{
			_003CFactionEntity_003Ek__BackingField = value;
		}
	}

	public int FactionIndex
	{
		get
		{
			return _003CFactionIndex_003Ek__BackingField;
		}
		private set
		{
			_003CFactionIndex_003Ek__BackingField = value;
		}
	}

	public string CurrentCameraConfig
	{
		get
		{
			return _003CCurrentCameraConfig_003Ek__BackingField;
		}
		private set
		{
			_003CCurrentCameraConfig_003Ek__BackingField = value;
		}
	}

	public float CustomGravity
	{
		get
		{
			return _003CCustomGravity_003Ek__BackingField;
		}
		private set
		{
			_003CCustomGravity_003Ek__BackingField = value;
		}
	}

	public Vector3 HeadBonesScale
	{
		get
		{
			return _003CHeadBonesScale_003Ek__BackingField;
		}
		private set
		{
			_003CHeadBonesScale_003Ek__BackingField = value;
		}
	}

	public Vector3 BodyBonesScale
	{
		get
		{
			return _003CBodyBonesScale_003Ek__BackingField;
		}
		private set
		{
			_003CBodyBonesScale_003Ek__BackingField = value;
		}
	}

	public Vector3 LimbBonesScale
	{
		get
		{
			return _003CLimbBonesScale_003Ek__BackingField;
		}
		private set
		{
			_003CLimbBonesScale_003Ek__BackingField = value;
		}
	}

	public float UGCHeadshotDamageDecreaseScale
	{
		get
		{
			return _003CUGCHeadshotDamageDecreaseScale_003Ek__BackingField;
		}
		private set
		{
			_003CUGCHeadshotDamageDecreaseScale_003Ek__BackingField = value;
		}
	}

	public string PlayerAvatar
	{
		get
		{
			return _003CPlayerAvatar_003Ek__BackingField;
		}
		private set
		{
			_003CPlayerAvatar_003Ek__BackingField = value;
		}
	}

	public int Gender
	{
		get
		{
			return _003CGender_003Ek__BackingField;
		}
		private set
		{
			_003CGender_003Ek__BackingField = value;
		}
	}

	public List<object> WeaponSkinID
	{
		get
		{
			return _003CWeaponSkinID_003Ek__BackingField;
		}
		private set
		{
			_003CWeaponSkinID_003Ek__BackingField = value;
		}
	}

	public Vector3 BornPositionVec3
	{
		get
		{
			return _003CBornPositionVec3_003Ek__BackingField;
		}
		private set
		{
			_003CBornPositionVec3_003Ek__BackingField = value;
		}
	}

	public Vector3 RevivePositionVec3
	{
		get
		{
			return _003CRevivePositionVec3_003Ek__BackingField;
		}
		private set
		{
			_003CRevivePositionVec3_003Ek__BackingField = value;
		}
	}

	public string Bones
	{
		get
		{
			return _003CBones_003Ek__BackingField;
		}
		private set
		{
			_003CBones_003Ek__BackingField = value;
		}
	}

	public string PlayerBagEntity
	{
		get
		{
			return _003CPlayerBagEntity_003Ek__BackingField;
		}
		private set
		{
			_003CPlayerBagEntity_003Ek__BackingField = value;
		}
	}

	public List<object> VehicleSkinIDs
	{
		get
		{
			return _003CVehicleSkinIDs_003Ek__BackingField;
		}
		private set
		{
			_003CVehicleSkinIDs_003Ek__BackingField = value;
		}
	}

	public bool AnimSkipFallingLand
	{
		get
		{
			return _003CAnimSkipFallingLand_003Ek__BackingField;
		}
		private set
		{
			_003CAnimSkipFallingLand_003Ek__BackingField = value;
		}
	}

	public bool FallDamageDisabled
	{
		get
		{
			return _003CFallDamageDisabled_003Ek__BackingField;
		}
		private set
		{
			_003CFallDamageDisabled_003Ek__BackingField = value;
		}
	}

	public List<object> DisablePickUpItems
	{
		get
		{
			return _003CDisablePickUpItems_003Ek__BackingField;
		}
		private set
		{
			_003CDisablePickUpItems_003Ek__BackingField = value;
		}
	}

	public string ResPlayerUUID
	{
		get
		{
			return _003CResPlayerUUID_003Ek__BackingField;
		}
		private set
		{
			_003CResPlayerUUID_003Ek__BackingField = value;
		}
	}

	public int AskBuyTarget
	{
		get
		{
			return _003CAskBuyTarget_003Ek__BackingField;
		}
		private set
		{
			_003CAskBuyTarget_003Ek__BackingField = value;
		}
	}

	public string CurrentEmoteClip
	{
		get
		{
			return _003CCurrentEmoteClip_003Ek__BackingField;
		}
		private set
		{
			_003CCurrentEmoteClip_003Ek__BackingField = value;
		}
	}

	public bool IsCurrentEmoteLoop
	{
		get
		{
			return _003CIsCurrentEmoteLoop_003Ek__BackingField;
		}
		private set
		{
			_003CIsCurrentEmoteLoop_003Ek__BackingField = value;
		}
	}

	public int KnockDown
	{
		get
		{
			return _003CKnockDown_003Ek__BackingField;
		}
		private set
		{
			_003CKnockDown_003Ek__BackingField = value;
		}
	}

	public bool ShowDamageNum
	{
		get
		{
			return _003CShowDamageNum_003Ek__BackingField;
		}
		private set
		{
			_003CShowDamageNum_003Ek__BackingField = value;
		}
	}

	public int BagSkinID
	{
		get
		{
			return _003CBagSkinID_003Ek__BackingField;
		}
		private set
		{
			_003CBagSkinID_003Ek__BackingField = value;
		}
	}

	public bool CanFreeQuit
	{
		get
		{
			return _003CCanFreeQuit_003Ek__BackingField;
		}
		private set
		{
			_003CCanFreeQuit_003Ek__BackingField = value;
		}
	}

	public string TransformClothInfo
	{
		get
		{
			return _003CTransformClothInfo_003Ek__BackingField;
		}
		private set
		{
			_003CTransformClothInfo_003Ek__BackingField = value;
		}
	}

	public string CurrentNewCamera
	{
		get
		{
			return _003CCurrentNewCamera_003Ek__BackingField;
		}
		private set
		{
			_003CCurrentNewCamera_003Ek__BackingField = value;
		}
	}

	public string BindedCustomPlayer
	{
		get
		{
			return _003CBindedCustomPlayer_003Ek__BackingField;
		}
		private set
		{
			_003CBindedCustomPlayer_003Ek__BackingField = value;
		}
	}

	public string UGCEntityID
	{
		get
		{
			return _003CUGCEntityID_003Ek__BackingField;
		}
		private set
		{
			_003CUGCEntityID_003Ek__BackingField = value;
		}
	}

	public UGCPlayerRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
