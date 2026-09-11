using proto;

namespace COW;

public class UIModelSparkPetTest : UIModelSparkPet
{
	private bool m_OpenSparkPetTest;

	private bool m_OpenSparkPetState;

	private bool m_RepeateClaimAward;

	private bool m_IsOpenTemperDialogue;

	private bool m_IsOpenLobbyDialogue;

	private int m_SparkLevel;

	private string m_TemperDialogue;

	private string m_LobbyDialogue;

	private bool m_OpenSparkPetAnimTest;

	private ESparkPetStage m_ESparkPetStage;

	private EFriend.SparkState m_ESparkPetStateOriginal;

	private EFriend.SparkState m_ESparkPetState;

	public bool OpenSparkPetTest
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool RepeateClaimAward
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsOpenTemperDialogue
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsOpenLobbyDialogue
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public int SparkLevel
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public string TemperDialogue
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string LobbyDialogue
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool OpenSparkPetAnimTest
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public ESparkPetStage SparkPetStage
	{
		get
		{
			return ESparkPetStage.None;
		}
		set
		{
		}
	}

	public EFriend.SparkState SparkPetStateOriginal
	{
		get
		{
			return EFriend.SparkState.SparkState_NONE;
		}
		set
		{
		}
	}

	public bool OpenSparkPetState
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public EFriend.SparkState SparkPetState
	{
		get
		{
			return EFriend.SparkState.SparkState_NONE;
		}
		set
		{
		}
	}

	public override void Logout(object[] data)
	{
	}

	public ESparkPetPopType GetPopTipType()
	{
		return ESparkPetPopType.None;
	}

	public void ReadOpenSparkPetTest()
	{
	}

	public new void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
