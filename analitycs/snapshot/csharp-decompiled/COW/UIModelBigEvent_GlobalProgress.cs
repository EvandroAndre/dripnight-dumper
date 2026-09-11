using System;
using System.Collections.Generic;
using GCommon;
using Spine.Unity;
using UnityEngine;
using proto;

namespace COW;

public class UIModelBigEvent_GlobalProgress : UIBaseModel
{
	public class SpineGo
	{
		protected List<GameObject> m_ListEffects;

		protected GameObject gameObject;

		protected Transform transform;

		protected SkeletonAnimation skeletonAnimation;

		protected void Init(ResourceID res_id, Transform parent)
		{
		}

		public void LinkSpine(GameObject goSpine)
		{
		}

		protected GameObject CreateGameObject(ResourceID res_id, Transform parent)
		{
			return null;
		}

		public void Play(string animation, bool loop = false)
		{
		}

		public void AddAnimation(string animation, bool loop = false)
		{
		}

		public void SetActive(bool value)
		{
		}

		protected void ClearEffect()
		{
		}

		public virtual void Destroy()
		{
		}

		public virtual string GetIdleAnim(uint stage_id)
		{
			return null;
		}
	}

	public class EntranceSpineGo : SpineGo
	{
		private Transform m_Parent;

		private DragonSpineGo m_DragonSpineGo;

		private FemaleSpineGo m_FemaleSpineGo;

		private SpineAlphaSync m_DragonSpineAlphaSync;

		private SpineAlphaSync m_FemaleSpineAlphaSync;

		private GameObject roarObj;

		private Animation roarAni;

		private uint m_RoarDelayCallID;

		private uint m_RoarSoundDelayCallID;

		public void Init(Transform parent)
		{
		}

		public void Play()
		{
		}

		public override void Destroy()
		{
		}

		private void _003CPlay_003Eb__11_0()
		{
		}

		private void _003CPlay_003Eb__11_1()
		{
		}

		public void _003C_003EiFixBaseProxy_Destroy()
		{
		}
	}

	public class DragonSpineGo : SpineGo
	{
		private Transform m_Parent;

		public string GetBornAnim(uint stage_id)
		{
			return null;
		}

		public override string GetIdleAnim(uint stage_id)
		{
			return null;
		}

		public string _003C_003EiFixBaseProxy_GetIdleAnim(uint P0)
		{
			return null;
		}
	}

	public class FemaleSpineGo : SpineGo
	{
		private Transform m_Parent;

		public string GetBornAnim(uint stage_id)
		{
			return null;
		}

		public override string GetIdleAnim(uint stage_id)
		{
			return null;
		}

		public string _003C_003EiFixBaseProxy_GetIdleAnim(uint P0)
		{
			return null;
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003E9__27_1;

		internal CommonRewardItemInfo _003CRequestClaimProcessRewards_003Eb__27_1(BaseItemInfo item)
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass25_0
	{
		public UIModelBigEvent_GlobalProgress _003C_003E4__this;

		public uint useType;

		internal void _003CRequestGlobalProgressSetting_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass26_0
	{
		public UIModelBigEvent_GlobalProgress _003C_003E4__this;

		public uint useType;

		internal void _003CRequestGetCurrentGlobalProgressValue_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass27_0
	{
		public UICommonRewardWndController.WndStyleEnum style;

		public UIModelBigEvent_GlobalProgress _003C_003E4__this;

		public uint useType;

		public uint processId;

		internal void _003CRequestClaimProcessRewards_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass28_0
	{
		public UIModelBigEvent_GlobalProgress _003C_003E4__this;

		public uint useType;

		internal void _003CRequestGetRewardState_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private Dictionary<uint, ulong> m_DictUseTypeToCurrentGloabalProgressValue;

	public Dictionary<uint, Dictionary<uint, CustomEventProcessSettingDesc>> DictUseTypeToDictProcessSettings;

	private Dictionary<uint, List<BigEventTemplateTokenTips>> m_DictUseTypeToListTokenTips;

	private readonly Dictionary<uint, List<uint>> m_DictUseTypeToListProcessIdHaveClaimedReward;

	public const int PropID_GetProcessSettingDesc = 2;

	public const int PropID_GetRewardStateInfo = 4;

	public const int PropID_GetGlobalProgressValue = 8;

	public const int PropID_ClaimProcessRewards = 16;

	private long m_LastClickCDTime;

	public const string FirstInEvt = "MechadrakeB_FirstInAnim_Evt";

	public const string Main_Enter = "UIFX_MechadrakeB_MainPage_Ani";

	public const string Token_UpGrade = "UIFX_MechadrakeB_number";

	public const string DRAGON_SPINE_SPECIAL = "MechadrakeB_Dragon_Special";

	public const string DRAGON_SPINE_IDLE = "MechadrakeB_Dragon_Idle";

	public const string FEMALE_SPINE_SPECIAL = "MechadrakeB_Dragon_Special";

	public const string FEMALE_SPINE_IDLE = "MechadrakeB_Female_Idle";

	public const string RoarEvt = "UIFX_MechadrakeB_Dragon_RoarSmoke_Ani";

	public const int STAGE_1 = 1;

	public const int STAGE_2 = 2;

	public const string Mission_In_Ani = "UIFX_MechadrakeB_MissionPopupWnd_In_Ani";

	public const string Mission_Out_Ani = "UIFX_MechadrakeB_MissionPopupWnd_Out_Ani";

	public override uint GetModelType()
	{
		return 0u;
	}

	public override void Init()
	{
	}

	public override void Login(object[] data)
	{
	}

	public override void Logout(object[] data)
	{
	}

	private void ClearCachedData()
	{
	}

	public bool HasGetProcessSetting(uint useType)
	{
		return false;
	}

	private CustomEventProcessSettingDesc GetProcessSettingByProcessId(uint useType, uint processId)
	{
		return null;
	}

	public List<AwardDesc> GetRewardsByProcessId(uint useType, uint processId)
	{
		return null;
	}

	public float GetCurrentGlobalProgressPercentage(uint useType)
	{
		return 0f;
	}

	public ulong GetCurrentGlobalProgressValue(uint useType)
	{
		return 0uL;
	}

	public bool TryGetCurrentGlobalProgressValue(uint useType, out ulong progressValue)
	{
		progressValue = default(ulong);
		return false;
	}

	private ulong GetMaxGloabalProgressValue(uint useType)
	{
		return 0uL;
	}

	public ulong GetGlobalProgressEndValueByProcessId(uint useType, uint process)
	{
		return 0uL;
	}

	public float GetGlobalProgressPercentageByProcessId(uint useType, uint process)
	{
		return 0f;
	}

	public int GetCanClaimRewardCount(uint useType)
	{
		return 0;
	}

	public bool GetRewardStateByIndex(uint useType, uint processId, out EActivity.State state)
	{
		state = default(EActivity.State);
		return false;
	}

	public bool IsLobbyEntranceTipsNeedShow(uint useType)
	{
		return false;
	}

	public void RequestGlobalProgressSetting(uint useType, bool forceReq = false)
	{
	}

	public void RequestGetCurrentGlobalProgressValue(uint useType)
	{
	}

	public void RequestClaimProcessRewards(uint useType, uint processId, UICommonRewardWndController.WndStyleEnum style = UICommonRewardWndController.WndStyleEnum.COMMON)
	{
	}

	public void RequestGetRewardState(uint useType)
	{
	}

	public bool HaveRequestRewardState()
	{
		return false;
	}

	public string GetFirstInAnimKey()
	{
		return null;
	}

	public ResourceID GetGPTextureTitleVFX(uint useType)
	{
		return default(ResourceID);
	}

	public ResourceID GetGPProgressBGVFX(uint useType)
	{
		return default(ResourceID);
	}

	public ResourceID GetGPMainBgVFX(uint useType)
	{
		return default(ResourceID);
	}

	public ResourceID GetGPItemNumberVFX(uint useType)
	{
		return default(ResourceID);
	}

	public ResourceID GetGPExchangeStoreVFX(uint useType)
	{
		return default(ResourceID);
	}

	public ResourceID GetGPBoardExchangeStoreVFX(uint useType)
	{
		return default(ResourceID);
	}

	public ResourceID GetGPProgressBarVFX(uint useType)
	{
		return default(ResourceID);
	}

	private bool GetResult(string str)
	{
		return false;
	}

	public bool TryClick()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
