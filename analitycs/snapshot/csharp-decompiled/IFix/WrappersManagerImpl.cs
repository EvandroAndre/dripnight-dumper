using System;
using IFix.Core;

namespace IFix;

public class WrappersManagerImpl : WrappersManager
{
	private VirtualMachine virtualMachine;

	public WrappersManagerImpl(VirtualMachine virtualMachine)
	{
	}

	public static ILFixDynamicMethodWrapper GetPatch(int id)
	{
		return null;
	}

	public static bool IsPatched(int id)
	{
		return false;
	}

	public Delegate CreateDelegate(Type type, int id, object anon)
	{
		return null;
	}

	public object CreateWrapper(int id)
	{
		return null;
	}

	public object InitWrapperArray(int len)
	{
		return null;
	}

	public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine)
	{
		return null;
	}
}
