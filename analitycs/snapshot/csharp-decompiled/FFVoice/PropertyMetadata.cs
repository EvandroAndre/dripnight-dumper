using System;
using System.Reflection;

namespace FFVoice;

internal struct PropertyMetadata
{
	public MemberInfo Info;

	public bool IsField;

	public Type Type;
}
