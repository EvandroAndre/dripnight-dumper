using System;
using COW.GamePlay.UGCRuntime;
using UnityEngine;

namespace COW;

public class UGCLLMChatHudRepItem
{
	public const int PROP_ID_ISVISIBLE = -416000;

	public const int PROP_ID_BINDPERSONA = -416001;

	public const int PROP_ID_OFFSET = -416002;

	public const int PROP_ID_HEIGHTSCALE = -416003;

	public const int PROP_ID_SHOWSYSTEMREPLY = -416004;

	public const int PROP_ID_PERSONANICKNAME = -416005;

	public const int PROP_ID_PERSONAAVATAR = -416006;

	public const int PROP_ID_USERNICKNAME = -416007;

	public const int PROP_ID_USERAVATAR = -416008;

	private UGCEntityDataStore _repDataMgr;

	public Action<bool> OnIsVisibleChangeEvent;

	public Action<string> OnBindPersonaChangeEvent;

	public Action<Vector2> OnOffsetChangeEvent;

	public Action<float> OnHeightScaleChangeEvent;

	public Action<bool> OnShowSystemReplyChangeEvent;

	public Action<string> OnPersonaNickNameChangeEvent;

	public Action<string> OnPersonaAvatarChangeEvent;

	public Action<string> OnUserNickNameChangeEvent;

	public Action<string> OnUserAvatarChangeEvent;

	private bool _003CIsVisible_003Ek__BackingField;

	private string _003CBindPersona_003Ek__BackingField;

	private Vector2 _003COffset_003Ek__BackingField;

	private float _003CHeightScale_003Ek__BackingField;

	private bool _003CShowSystemReply_003Ek__BackingField;

	private string _003CPersonaNickName_003Ek__BackingField;

	private string _003CPersonaAvatar_003Ek__BackingField;

	private string _003CUserNickName_003Ek__BackingField;

	private string _003CUserAvatar_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public bool IsVisible
	{
		get
		{
			return _003CIsVisible_003Ek__BackingField;
		}
		private set
		{
			_003CIsVisible_003Ek__BackingField = value;
		}
	}

	public string BindPersona
	{
		get
		{
			return _003CBindPersona_003Ek__BackingField;
		}
		private set
		{
			_003CBindPersona_003Ek__BackingField = value;
		}
	}

	public Vector2 Offset
	{
		get
		{
			return _003COffset_003Ek__BackingField;
		}
		private set
		{
			_003COffset_003Ek__BackingField = value;
		}
	}

	public float HeightScale
	{
		get
		{
			return _003CHeightScale_003Ek__BackingField;
		}
		private set
		{
			_003CHeightScale_003Ek__BackingField = value;
		}
	}

	public bool ShowSystemReply
	{
		get
		{
			return _003CShowSystemReply_003Ek__BackingField;
		}
		private set
		{
			_003CShowSystemReply_003Ek__BackingField = value;
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

	public string UserNickName
	{
		get
		{
			return _003CUserNickName_003Ek__BackingField;
		}
		private set
		{
			_003CUserNickName_003Ek__BackingField = value;
		}
	}

	public string UserAvatar
	{
		get
		{
			return _003CUserAvatar_003Ek__BackingField;
		}
		private set
		{
			_003CUserAvatar_003Ek__BackingField = value;
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

	public UGCLLMChatHudRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
