using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCPersonaRepItem
{
	public const int PROP_ID_PERSONAID = -415000;

	public const int PROP_ID_PERSONANICKNAME = -415001;

	public const int PROP_ID_PERSONAAVATAR = -415002;

	private UGCEntityDataStore _repDataMgr;

	public Action<string> OnPersonaIDChangeEvent;

	public Action<string> OnPersonaNickNameChangeEvent;

	public Action<string> OnPersonaAvatarChangeEvent;

	private string _003CPersonaID_003Ek__BackingField;

	private string _003CPersonaNickName_003Ek__BackingField;

	private string _003CPersonaAvatar_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public string PersonaID
	{
		get
		{
			return _003CPersonaID_003Ek__BackingField;
		}
		private set
		{
			_003CPersonaID_003Ek__BackingField = value;
		}
	}

	public string PersonaNickName
	{
		get
		{
			return _003CPersonaNickName_003Ek__BackingField;
		}
		private set
		{
			_003CPersonaNickName_003Ek__BackingField = value;
		}
	}

	public string PersonaAvatar
	{
		get
		{
			return _003CPersonaAvatar_003Ek__BackingField;
		}
		private set
		{
			_003CPersonaAvatar_003Ek__BackingField = value;
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

	public UGCPersonaRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
