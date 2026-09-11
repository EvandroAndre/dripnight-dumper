using System;
using System.Collections.Generic;
using COW.GamePlay;
using COW.GamePlay.UGCRuntime;
using UnityEngine;
using message;

namespace COW;

public abstract class ItemEditAttributeUIData_V2
{
	public delegate void DataChangeDelegate(long propID, MutableValue newValue, string logicEntityID);

	public int m_DataIndex;

	public string m_LogicEntityID;

	public bool enable;

	protected string m_AttributeTitleNameKey;

	protected string m_ValueName;

	protected string m_ValueUGCType;

	protected string m_EntityType;

	protected long m_propID;

	protected PJKGGCKLOFF m_condition;

	public bool isSecondLevelAttr;

	public ItemEditAttributeUIData_V2 mRelatedUIData;

	public Dictionary<string, ItemEditAttributeUIDataValueDesc> mRelatedDescription;

	public ItemEditAttributeUIDataValueDesc mDescription;

	private MutableValue m_CurUIValue;

	private string m_TipTxtKey;

	private bool m_ShowButton;

	private string m_ButtonIcon;

	private Action<int> m_ButtonCallBack;

	public bool IsDataCustomized;

	public DataChangeDelegate OnDataChange;

	public string AttributeTitleNameKey
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string ValueName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string ValueUGCType
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string EntityType
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public long PropID => 0L;

	public PJKGGCKLOFF Condition
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	protected MutableValue CurUIValue
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	protected MutableValue CurValue
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public MutableValue DefaultValue
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string TipTxtKey
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool ShowButton
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public string ButtonIcon
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Action<int> ButtonCallBack
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual EUGCMutableValueType MutableValueType => EUGCMutableValueType.None;

	public ItemEditAttributeUIDataValueDesc GetEffectDescription()
	{
		return null;
	}

	public virtual SceneEditItemAttributeUIType GetUIType()
	{
		return SceneEditItemAttributeUIType.ItemUIType_Sub_Input_Plus;
	}

	public virtual void SetCurValue(MutableValue newValue)
	{
	}

	public virtual ItemEditAttributeCacheValue_V2 GetItemEditAttributeCacheValue()
	{
		return null;
	}

	public virtual void InitDefaultValue()
	{
	}

	public virtual MutableValue GetMutableValue(bool clone)
	{
		return null;
	}

	public virtual bool GetBool()
	{
		return false;
	}

	public virtual int GetInt()
	{
		return 0;
	}

	public virtual long GetInt64()
	{
		return 0L;
	}

	public virtual float GetFloat()
	{
		return 0f;
	}

	public virtual string GetString()
	{
		return null;
	}

	public virtual Vector2 GetVector2()
	{
		return default(Vector2);
	}

	public virtual Vector3 GetVector3()
	{
		return default(Vector3);
	}

	public virtual Quaternion GetQuaternion()
	{
		return default(Quaternion);
	}

	public virtual void SetCurValue(bool value)
	{
	}

	public virtual void SetCurValue(int value)
	{
	}

	public virtual void SetCurValue(float value)
	{
	}

	public virtual void SetCurValue(long value)
	{
	}

	public virtual void SetCurValue(string value)
	{
	}

	public virtual void SetCurValue(Vector2 value)
	{
	}

	public virtual void SetCurValue(Vector3 value)
	{
	}

	public virtual void SetCurValue(Quaternion value)
	{
	}

	public virtual void SetCurValueWithoutOnChange(UGCSimpleValue newValue)
	{
	}

	public virtual void SetCurValueWithoutOnChange(IPIFNFDIIKK entityRepValue)
	{
	}

	public virtual void SetCurValueWithoutOnChange(UGCVarValueDataV2 value)
	{
	}

	public virtual void SetCurValueWithoutOnChange(MutableValue value)
	{
	}

	public virtual void SetCurValueWithoutOnChange(string valueType, string value)
	{
	}

	public virtual void SetCurValueWithoutOnChange(bool newValue)
	{
	}

	public virtual void SetCurValueWithoutOnChange(int newValue)
	{
	}

	public virtual void SetCurValueWithoutOnChange(long newValue)
	{
	}

	public virtual void SetCurValueWithoutOnChange(float newValue)
	{
	}

	public virtual void SetCurValueWithoutOnChange(string newValue)
	{
	}

	public virtual void SetCurValueWithoutOnChange(Vector2 newValue)
	{
	}

	public virtual void SetCurValueWithoutOnChange(Vector3 newValue)
	{
	}

	public virtual void SetCurValueWithoutOnChange(Quaternion newValue)
	{
	}

	public virtual void SetPropID(long propID)
	{
	}
}
