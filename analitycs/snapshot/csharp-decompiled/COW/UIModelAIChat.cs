using System.Collections.Generic;
using COW.GamePlay;
using COW.Gameplay.UGC;
using GCommon;
using proto;

namespace COW;

public class UIModelAIChat : UIBaseModel
{
	private Dictionary<BHGGAEEHJCO, float> m_DictIdToTeamDamage;

	private Dictionary<uint, float> m_DictIdToBeDamaged;

	private List<string> m_MyWeapon;

	private List<string> m_MyActiveSkill;

	private List<string> m_MyPassiveSkill;

	private List<string> m_MyPetSkill;

	private float m_BeKilledDistance;

	private float m_KillingDistance;

	private int m_MyKillCount;

	private int m_MyDeathCount;

	private int m_MyAssistCount;

	private BHGGAEEHJCO m_MyPlayerID;

	private string m_PlayerKillMe;

	private float m_HeadShotKillRate;

	private uint m_IceWallResistDamage;

	private uint m_IceWallUse;

	private uint m_RescueTimes;

	private uint m_ReviveTeammateTimes;

	private uint m_HpAdded;

	private float m_PlayerResistDamgeRate;

	private uint m_ThrowingKillNum;

	private float m_MovingDistance;

	private uint m_ActiveSkillDamage;

	private bool m_IsWeaponGetted;

	private bool? isAIFloatingWindowCanShow;

	private bool? m_IsUsingOsSpeechRecognition;

	public const int AI_CHAT_DEPTH_COMMON = 60;

	public const int AI_CHAT_DEPTH_COMMON_SPECIAL = 300;

	public const int AI_CHAT_DEPTH_UGC = 300;

	public const int AI_CHAT_DEPTH_UGC_SPECAIL = 2000;

	public const string REQUEST_CHANNEL = "CLIENT";

	public const string REQUEST_USAGE_GROUP_BR = "BR";

	public const string REQUEST_USAGE_GROUP_UGC = "UGC";

	public const string REQUEST_USAGE_GROUP_IN_GAME = "IN_GAME";

	private ulong m_AIChatCanUsageTimeStamp;

	private GIErrorDetail m_AIChatBannedInfo;

	private Dictionary<uint, List<AIAssistantSuggestedQuestionsTableDesc>> m_DictSceneIDToFastChatDataList;

	public bool IsWeaponGetted
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public float BeKilledDistance
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float KillingDistance
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public int MyKillCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int MyDeathCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int MyAssistCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public BHGGAEEHJCO MyPlayerID
	{
		get
		{
			return default(BHGGAEEHJCO);
		}
		set
		{
		}
	}

	public string PlayerKillMe
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public List<string> MyWeapon => null;

	public List<string> MyActiveSkill => null;

	public List<string> MyPassiveSkills => null;

	public List<string> MyPetSkill => null;

	public float HeadShotKillRate
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public uint IceWallResistDamage
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public uint IceWallUse
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public uint RescueTimes
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public uint ReviveTeammateTimes
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public uint HpAdded
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public float PlayerResistDamgeRate
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public uint ThrowingKillNum
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public float MovingDistance
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public uint ActiveSkillDamage
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public bool IsAIFloatingWindowCanShow => false;

	public bool IsUsingOsSpeechRecognition => false;

	public bool IsCustomRoomOpen => false;

	public ulong AIChatCanUsageTimeStamp
	{
		get
		{
			return 0uL;
		}
		set
		{
		}
	}

	public GIErrorDetail AIChatBannedInfo
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

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

	public void ClearData()
	{
	}

	public bool CorrectMessageContent(string msg, out string result)
	{
		result = null;
		return false;
	}

	public object[] GetAIChatPromptData(EAIChatScene sceneType)
	{
		return null;
	}

	public string GetAIChatPromptInput(EAIChatPromptInput inputType)
	{
		return null;
	}

	public void OnUpdatePlayerTotalDamage(BHGGAEEHJCO id, uint newValue)
	{
	}

	private List<AIAssistantSuggestedQuestionsTableDesc> GetFastChatDataListBySceneID(uint sceneID)
	{
		return null;
	}

	public void ProcessAISuggestedQuestionsDesc(List<AIAssistantSuggestedQuestionsTableDesc> fastChatDataList)
	{
	}

	public List<AIAssistantSuggestedQuestionsTableDesc> GetFastChatDataListBySceneID(uint sceneID, int num)
	{
		return null;
	}

	private void Shuffle<T>(List<T> list)
	{
	}

	public bool IsAIChatEnable()
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
