using System;
using System.Collections.Generic;
using GCommon;
using proto;
using tcp;

namespace COW;

internal class UIModelPet : UIBaseModel
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<proto.PetInfo> _003C_003E9__58_0;

		public static Predicate<Item> _003C_003E9__109_0;

		internal bool _003CUpdatePetInfoList_003Eb__58_0(proto.PetInfo temp)
		{
			return false;
		}

		internal bool _003CGetPetLimitCard_003Eb__109_0(Item temp)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass103_0
	{
		public UIModelPet _003C_003E4__this;

		public uint pet_id;

		public uint skin_id;

		public bool notifyCommonReward;

		public Predicate<proto.PetInfo> _003C_003E9__1;

		internal void _003CSelectPetSkin_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}

		internal bool _003CSelectPetSkin_003Eb__1(proto.PetInfo temp)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass105_0
	{
		public PetSkinData SkinData;

		internal bool _003CUpdateNewItem_003Eb__0(proto.PetInfo temp)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass70_0
	{
		public PetData petCfg;

		internal bool _003CGetAllPetList_003Eb__0(proto.PetInfo temp)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass79_0
	{
		public UIModelPet _003C_003E4__this;

		public uint pet_id;

		public bool mark;

		internal void _003CRequsetChangePetLove_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass81_0
	{
		public UIModelPet _003C_003E4__this;

		public uint pet_id;

		public Predicate<proto.PetInfo> _003C_003E9__1;

		internal void _003CFeedPet_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}

		internal bool _003CFeedPet_003Eb__1(proto.PetInfo temp)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass83_0
	{
		public PetLevelUpNtf data;

		internal bool _003COnReceivedFeedData_003Eb__0(proto.PetInfo temp)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass84_0
	{
		public UIModelPet _003C_003E4__this;

		public uint pet_id;

		public Predicate<proto.PetInfo> _003C_003E9__1;

		internal void _003CRenamePet_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}

		internal bool _003CRenamePet_003Eb__1(proto.PetInfo temp)
		{
			return false;
		}
	}

	public const uint PropID_UpdatePetExp = 2u;

	public const uint PropID_UpdatePetCarry = 4u;

	public const uint PropID_UpdatePetInfo = 8u;

	public const uint PropID_RenameSuccess = 16u;

	public const uint PropID_RenameError = 32u;

	public const uint PropID_UpdatePetFeed = 64u;

	public const uint PropID_PetInfoLevelUp = 128u;

	public const uint PropID_PetActionListGet = 256u;

	public const uint PropID_PetSkinListGet = 512u;

	public const uint PropID_PetSkinSelected = 1024u;

	public const uint PropID_PetSkillListGet = 2048u;

	public const uint PropID_PetNewTagChange = 4096u;

	public const uint PropID_PetSkillSelected = 8192u;

	public const uint PropID_UpdatePetCarryFailed = 16384u;

	public const uint PropID_PetSkillSelectedFailed = 32768u;

	public const uint PropID_UpdatePetInfoFailed = 65536u;

	public const uint PropID_UpdatePetMark = 131072u;

	public const uint PropID_LimitPetExpire = 262144u;

	private const uint PETS_LIMIT_CARD = 835000002u;

	private bool _003CPetNewFlagUpdate_003Ek__BackingField;

	private proto.PetInfo m_CarryPetInfo;

	private PetLevelUpNtf last_exp_data;

	private proto.PetInfo m_CurrentSelectedPetInfo;

	private uint m_CurrentSelectedPetSkinID;

	private Dictionary<int, PetSkillInfoData> m_PetSourceSkill;

	private Dictionary<int, PetSkillInfoData> m_PetSourcePet;

	private bool isShowPetPanel;

	private List<proto.PetInfo> _003COwnPetList_003Ek__BackingField;

	private List<proto.PetInfo> _003CAllPetList_003Ek__BackingField;

	private List<uint> m_newTagList;

	private List<PetActionInfo> _003COwnActionList_003Ek__BackingField;

	private List<PetSkinInfo> _003COwnSkinList_003Ek__BackingField;

	private List<proto.PetSkillInfo> _003COwnSkillList_003Ek__BackingField;

	private bool _003CHasExpirePet_003Ek__BackingField;

	public bool PetNewFlagUpdate
	{
		get
		{
			return _003CPetNewFlagUpdate_003Ek__BackingField;
		}
		set
		{
			_003CPetNewFlagUpdate_003Ek__BackingField = value;
		}
	}

	public List<proto.PetInfo> OwnPetList
	{
		get
		{
			return _003COwnPetList_003Ek__BackingField;
		}
		private set
		{
			_003COwnPetList_003Ek__BackingField = value;
		}
	}

	public List<proto.PetInfo> AllPetList
	{
		get
		{
			return _003CAllPetList_003Ek__BackingField;
		}
		private set
		{
			_003CAllPetList_003Ek__BackingField = value;
		}
	}

	public List<PetActionInfo> OwnActionList
	{
		get
		{
			return _003COwnActionList_003Ek__BackingField;
		}
		private set
		{
			_003COwnActionList_003Ek__BackingField = value;
		}
	}

	public List<PetSkinInfo> OwnSkinList
	{
		get
		{
			return _003COwnSkinList_003Ek__BackingField;
		}
		private set
		{
			_003COwnSkinList_003Ek__BackingField = value;
		}
	}

	public List<proto.PetSkillInfo> OwnSkillList
	{
		get
		{
			return _003COwnSkillList_003Ek__BackingField;
		}
		private set
		{
			_003COwnSkillList_003Ek__BackingField = value;
		}
	}

	public bool HasExpirePet
	{
		get
		{
			return _003CHasExpirePet_003Ek__BackingField;
		}
		private set
		{
			_003CHasExpirePet_003Ek__BackingField = value;
		}
	}

	public override uint GetModelType()
	{
		return 0u;
	}

	public override void Init()
	{
	}

	public void UpdatePetCarryInfo(proto.PetInfo data)
	{
	}

	public void UpdatePetInfoList(List<proto.PetInfo> list)
	{
	}

	public void SetShowingPetPanel(bool show_state)
	{
	}

	public bool CheckNeedShowPetLevelUp()
	{
		return false;
	}

	public void ClearLastExpData()
	{
	}

	public PetLevelUpNtf GetLevelUpData()
	{
		return null;
	}

	public void SetShowNewTag(uint item_id)
	{
	}

	public bool IsHideShowNewTag(uint item_id)
	{
		return false;
	}

	public void RemoveNewTag(uint item_id)
	{
	}

	public void UpdatePetSelectedInfo(proto.PetInfo info)
	{
	}

	public void UpdatePetSkinIDSelected(uint skinID)
	{
	}

	public uint GetSelectedPetSkinID()
	{
		return 0u;
	}

	public proto.PetInfo GetSelectedPetInfo()
	{
		return null;
	}

	private List<proto.PetInfo> GetAllPetList()
	{
		return null;
	}

	public void CheckPetNewFlag()
	{
	}

	public bool CheckPetSkinNewFlag(int id, bool add_tip)
	{
		return false;
	}

	public bool CheckPetSkillFlag(int id, bool add_tip)
	{
		return false;
	}

	public bool CheckPetActionFlag(int id, bool add_tip)
	{
		return false;
	}

	public List<proto.PetInfo> GetPetInfoCanShow()
	{
		return null;
	}

	public override void Logout(object[] data)
	{
	}

	public void GetMyPetInfoData(bool force = false, uint httpOption = 2u, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	public void NotifyPetDataRefresh()
	{
	}

	public void RequsetChangePetLove(uint pet_id, bool mark)
	{
	}

	public void SelectPet(uint pet_id, bool carry_state, bool resetPetSkill = true)
	{
	}

	public void FeedPet(uint pet_id, uint food_id, uint food_count)
	{
	}

	public uint GetPetExpMaxLevel(int pet_id)
	{
		return 0u;
	}

	public void OnReceivedFeedData(PetLevelUpNtf data)
	{
	}

	public void RenamePet(uint pet_id, string name)
	{
	}

	public uint GetFoodItemByPetID(uint pet_id)
	{
		return 0u;
	}

	public int GetFoodItemExpByPetID(uint pet_id)
	{
		return 0;
	}

	public uint GetSourcePetIDBySkillID(uint skillId)
	{
		return 0u;
	}

	public uint GetSourceSkillIDByPetID(uint petId)
	{
		return 0u;
	}

	public uint GetCurrentCarryPetID()
	{
		return 0u;
	}

	public uint GetCurrentCarryPetSkinID()
	{
		return 0u;
	}

	public proto.PetInfo GetCurrentCarryPetInfo()
	{
		return null;
	}

	public proto.PetInfo GetPetInfoById(uint m_id)
	{
		return null;
	}

	public proto.PetInfo GetOwnedPetInfoById(uint id)
	{
		return null;
	}

	public proto.PetSkillInfo GetOwnedPetSkillInfoBySkillId(uint id)
	{
		return null;
	}

	public ResourceID GetPetResourceID(uint pet_id)
	{
		return default(ResourceID);
	}

	public ResourceID GetSkinResourceID(uint skin_id)
	{
		return default(ResourceID);
	}

	public PetConfigInfo GetNextPetConfigByID(uint pet_id, uint Lv)
	{
		return default(PetConfigInfo);
	}

	public PetConfigInfo GetCurrentPetConfigByID(uint pet_id, uint Lv)
	{
		return default(PetConfigInfo);
	}

	public List<PetData> GetPetConfigList()
	{
		return null;
	}

	public PetData GetPetDataByID(uint pet_id)
	{
		return null;
	}

	public List<PetActionData> GetUnlockPetAnims(uint petid)
	{
		return null;
	}

	public string GetDefaultNameByID(uint pet_id)
	{
		return null;
	}

	public void SelectPetSkin(uint skin_id, uint pet_id, bool notifyCommonReward = false)
	{
	}

	public void SelectPetSkill(uint pet_id, uint pet_skill_id)
	{
	}

	public void UpdateNewItem(Item[] newInventories)
	{
	}

	public List<ResourceID> GetCurrentCarryPetResourceIds()
	{
		return null;
	}

	public List<ResourceID> GetAllOwnedPetRelativeResource()
	{
		return null;
	}

	public bool CheckHasPetExpire()
	{
		return false;
	}

	public Item GetPetLimitCard()
	{
		return null;
	}

	public void OnLimitPetExpire(List<Item> expireItems)
	{
	}

	public bool IsOwnPet(uint petId)
	{
		return false;
	}

	public bool IsPermanentPet(uint petId)
	{
		return false;
	}

	public uint GetOnePermanentPetID()
	{
		return 0u;
	}

	public void NotiDataChangedFromExternal(uint propID, object[] param)
	{
	}

	private void _003CGetMyPetInfoData_003Eb__77_0(HttpErrorCode errorCode, object res)
	{
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
