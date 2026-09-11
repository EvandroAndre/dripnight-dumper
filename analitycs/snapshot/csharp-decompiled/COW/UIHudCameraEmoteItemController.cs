using System;
using GCommon;

namespace COW;

public class UIHudCameraEmoteItemController : UIBaseController
{
	public enum EEmoteItemState
	{
		Normal,
		Choose,
		Playing
	}

	private UIHudCameraEmoteItemView m_View;

	private UIHudCameraEmotePanelController m_EmotePanelController;

	private uint _003CType_003Ek__BackingField;

	private uint _003CEmotionID_003Ek__BackingField;

	private uint _003CSlotID_003Ek__BackingField;

	private uint _003CTransformerID_003Ek__BackingField;

	private bool _003CIsDuoEmote_003Ek__BackingField;

	private EEmoteItemState _003CEState_003Ek__BackingField;

	private int _003CChooseIndex_003Ek__BackingField;

	private bool _003CIsPlaying_003Ek__BackingField;

	private bool m_IsABReady;

	private TransformData m_TransformData;

	private EmoteData _003CEmotionData_003Ek__BackingField;

	private EAvatarModelIngameType m_TransformerType;

	public uint Type
	{
		get
		{
			return _003CType_003Ek__BackingField;
		}
		private set
		{
			_003CType_003Ek__BackingField = value;
		}
	}

	public uint EmotionID
	{
		get
		{
			return _003CEmotionID_003Ek__BackingField;
		}
		private set
		{
			_003CEmotionID_003Ek__BackingField = value;
		}
	}

	public uint SlotID
	{
		get
		{
			return _003CSlotID_003Ek__BackingField;
		}
		private set
		{
			_003CSlotID_003Ek__BackingField = value;
		}
	}

	public uint TransformerID
	{
		get
		{
			return _003CTransformerID_003Ek__BackingField;
		}
		private set
		{
			_003CTransformerID_003Ek__BackingField = value;
		}
	}

	public bool IsDuoEmote
	{
		get
		{
			return _003CIsDuoEmote_003Ek__BackingField;
		}
		private set
		{
			_003CIsDuoEmote_003Ek__BackingField = value;
		}
	}

	public EEmoteItemState EState
	{
		get
		{
			return _003CEState_003Ek__BackingField;
		}
		private set
		{
			_003CEState_003Ek__BackingField = value;
		}
	}

	public int ChooseIndex
	{
		get
		{
			return _003CChooseIndex_003Ek__BackingField;
		}
		private set
		{
			_003CChooseIndex_003Ek__BackingField = value;
		}
	}

	public bool IsPlaying
	{
		get
		{
			return _003CIsPlaying_003Ek__BackingField;
		}
		private set
		{
			_003CIsPlaying_003Ek__BackingField = value;
		}
	}

	public EmoteData EmotionData
	{
		get
		{
			return _003CEmotionData_003Ek__BackingField;
		}
		private set
		{
			_003CEmotionData_003Ek__BackingField = value;
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpenAsChild()
	{
	}

	public void InitInfoByEmote(uint emotionID, uint slotID)
	{
	}

	public void InitInfoByTransformer(uint transformerId)
	{
	}

	public void SetTransformerType(EAvatarModelIngameType transformerType)
	{
	}

	private void RefreshDownloadState()
	{
	}

	private void OnTransformerAvatarChangeFinish(uint playerID)
	{
	}

	private void RefreshMultipleTransformState()
	{
	}

	public bool IsEmote()
	{
		return false;
	}

	public bool IsTransformer()
	{
		return false;
	}

	private void OnBtnClick()
	{
	}

	private bool IsLocalPlayerInHorseCombatState()
	{
		return false;
	}

	private void ShowTipMessage(string locKey)
	{
	}

	public void Choose(int playIndex)
	{
	}

	public void UnChoose()
	{
	}

	public void Stop(bool needRealStop = true)
	{
	}

	private void StopInGame(bool needRealStop)
	{
	}

	private void StopFrontEndGame(bool needRealStop)
	{
	}

	public void PlayInGame(Action<bool> callback)
	{
	}

	public bool PlayFrontEndGame()
	{
		return false;
	}

	private bool PlayFrontEndGame_Transformer()
	{
		return false;
	}

	private bool PlayFrontEndGame_Emote()
	{
		return false;
	}

	public void HidePlayVFX()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpenAsChild()
	{
	}
}
