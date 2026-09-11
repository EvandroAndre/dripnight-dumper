using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCEquipmentAttachmentRepItem
{
	public const int PROP_ID_DAMAGERATIOLIMB = -339000;

	public const int PROP_ID_DAMAGERATIOHEAD = -339001;

	public const int PROP_ID_MAXDURABILITYRATIO = -339002;

	public const int PROP_ID_EXTRAHPRATIO = -339003;

	public const int PROP_ID_DAMAGEREDUCTIONFACTOREXPLODE = -339004;

	public const int PROP_ID_EXTRABAGCAPACITY = -339005;

	public const int PROP_ID_REPLACEMENTPRIORITY = -339006;

	private UGCEntityDataStore _repDataMgr;

	public Action<float> OnDamageRatioLimbChangeEvent;

	public Action<float> OnDamageRatioHeadChangeEvent;

	public Action<float> OnMaxDurabilityRatioChangeEvent;

	public Action<float> OnExtraHpRatioChangeEvent;

	public Action<int> OnDamageReductionFactorExplodeChangeEvent;

	public Action<int> OnExtraBagCapacityChangeEvent;

	public Action<int> OnReplacementPriorityChangeEvent;

	private float _003CDamageRatioLimb_003Ek__BackingField;

	private float _003CDamageRatioHead_003Ek__BackingField;

	private float _003CMaxDurabilityRatio_003Ek__BackingField;

	private float _003CExtraHpRatio_003Ek__BackingField;

	private int _003CDamageReductionFactorExplode_003Ek__BackingField;

	private int _003CExtraBagCapacity_003Ek__BackingField;

	private int _003CReplacementPriority_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public float DamageRatioLimb
	{
		get
		{
			return _003CDamageRatioLimb_003Ek__BackingField;
		}
		private set
		{
			_003CDamageRatioLimb_003Ek__BackingField = value;
		}
	}

	public float DamageRatioHead
	{
		get
		{
			return _003CDamageRatioHead_003Ek__BackingField;
		}
		private set
		{
			_003CDamageRatioHead_003Ek__BackingField = value;
		}
	}

	public float MaxDurabilityRatio
	{
		get
		{
			return _003CMaxDurabilityRatio_003Ek__BackingField;
		}
		private set
		{
			_003CMaxDurabilityRatio_003Ek__BackingField = value;
		}
	}

	public float ExtraHpRatio
	{
		get
		{
			return _003CExtraHpRatio_003Ek__BackingField;
		}
		private set
		{
			_003CExtraHpRatio_003Ek__BackingField = value;
		}
	}

	public int DamageReductionFactorExplode
	{
		get
		{
			return _003CDamageReductionFactorExplode_003Ek__BackingField;
		}
		private set
		{
			_003CDamageReductionFactorExplode_003Ek__BackingField = value;
		}
	}

	public int ExtraBagCapacity
	{
		get
		{
			return _003CExtraBagCapacity_003Ek__BackingField;
		}
		private set
		{
			_003CExtraBagCapacity_003Ek__BackingField = value;
		}
	}

	public int ReplacementPriority
	{
		get
		{
			return _003CReplacementPriority_003Ek__BackingField;
		}
		private set
		{
			_003CReplacementPriority_003Ek__BackingField = value;
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

	public UGCEquipmentAttachmentRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
