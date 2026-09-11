using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIReviveBoxRulerIconController : UIBaseController
{
	private uint _003CReviveBoxID_003Ek__BackingField;

	private Vector3 _003CPosition_003Ek__BackingField;

	private float _003CMarkPosY_003Ek__BackingField;

	private UIReviveBoxRulerIconView m_View;

	private VisualInstanceHolder m_UIFXHolder;

	private bool m_HasTeammateInfo;

	public uint ReviveBoxID
	{
		get
		{
			return _003CReviveBoxID_003Ek__BackingField;
		}
		private set
		{
			_003CReviveBoxID_003Ek__BackingField = value;
		}
	}

	public Vector3 Position
	{
		get
		{
			return _003CPosition_003Ek__BackingField;
		}
		set
		{
			_003CPosition_003Ek__BackingField = value;
		}
	}

	public float MarkPosY
	{
		get
		{
			return _003CMarkPosY_003Ek__BackingField;
		}
		private set
		{
			_003CMarkPosY_003Ek__BackingField = value;
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void Bind(LevelReviveBox reviveBox, float markPosY)
	{
	}

	public void RefreshTeammateInfo(LevelReviveBox reviveBox)
	{
	}

	public void Release()
	{
	}

	public void SetUIFXVisible(bool visible)
	{
	}

	private void StartUIFX()
	{
	}

	private void ReleaseUIFX()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
