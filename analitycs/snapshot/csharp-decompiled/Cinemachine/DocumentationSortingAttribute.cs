using System;

namespace Cinemachine;

public sealed class DocumentationSortingAttribute : Attribute
{
	public enum Level
	{
		Undoc,
		API,
		UserRef
	}

	private Level _003CCategory_003Ek__BackingField;

	public Level Category
	{
		get
		{
			return _003CCategory_003Ek__BackingField;
		}
		private set
		{
			_003CCategory_003Ek__BackingField = value;
		}
	}

	public DocumentationSortingAttribute(Level category)
	{
	}
}
