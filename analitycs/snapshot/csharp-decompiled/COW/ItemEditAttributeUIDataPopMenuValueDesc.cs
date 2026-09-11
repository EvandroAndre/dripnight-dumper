using System.Collections.Generic;
using message;

namespace COW;

public class ItemEditAttributeUIDataPopMenuValueDesc : ItemEditAttributeUIDataValueDesc
{
	private List<string> m_OptionShowTxtKey;

	private List<MutableValue> m_OptionValue;

	public List<string> OptionShowTxtKey
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public List<MutableValue> OptionValue
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public ItemEditAttributeUIDataPopMenuValueDesc(MHJLOKOOGNB valueType)
		: base(MHJLOKOOGNB.Object)
	{
	}
}
