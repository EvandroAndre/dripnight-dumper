using System;
using System.Collections;
using System.Collections.Generic;
using IFix.Core;
using UnityEngine;
using message;

namespace IFix;

public class ILFixInterfaceBridge : AnonymousStorey, IDisposable, IEnumerator, IEnumerator<object>, IEnumerator<GameObject>, IEnumerable<GameObject>, IEnumerable, IEnumerator<OLEDMLOHNFH>, IEnumerable<OLEDMLOHNFH>
{
	private int methodId_0;

	private int methodId_1;

	private int methodId_2;

	private int methodId_3;

	private int methodId_4;

	private int methodId_5;

	private int methodId_6;

	private int methodId_7;

	private int methodId_8;

	private int methodId_9;

	object IEnumerator<object>.Current => null;

	object IEnumerator.Current => null;

	GameObject IEnumerator<GameObject>.Current => null;

	OLEDMLOHNFH IEnumerator<OLEDMLOHNFH>.Current => null;

	void IDisposable.Dispose()
	{
	}

	private bool MoveNext()
	{
		return false;
	}

	bool IEnumerator.MoveNext()
	{
		//ILSpy generated this explicit interface implementation from .override directive in MoveNext
		return this.MoveNext();
	}

	void IEnumerator.Reset()
	{
	}

	IEnumerator<GameObject> IEnumerable<GameObject>.GetEnumerator()
	{
		return null;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	IEnumerator<OLEDMLOHNFH> IEnumerable<OLEDMLOHNFH>.GetEnumerator()
	{
		return null;
	}

	public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine)
		: base(0, null, 0, null, null)
	{
	}

	public void RefAsyncBuilderStartMethod()
	{
	}
}
