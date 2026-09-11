using System.Collections.Generic;
using GCommon;
using UnityEngine;

public class ResourceManagerTests : MonoBehaviour
{
	private enum TestMode
	{
		TestDelLoading,
		TestUnloadLoading,
		TestCancelDependent
	}

	private TestMode mode;

	private List<uint> tickets;

	private Dictionary<uint, ResourceID> ticketRid;

	private List<string> res;

	private bool TestCancelDeps(uint ticket)
	{
		return false;
	}

	public bool TestDelLoading(uint ticket)
	{
		return false;
	}

	public bool TestUnloadLoading(uint ticket)
	{
		return false;
	}

	private void Update()
	{
	}

	public void UnloadLoadingTest()
	{
	}

	public void TestDelWhileAsyncLoading()
	{
	}

	public void TestCancelDependent()
	{
	}

	private void AsyncStartAll(TestMode tm)
	{
	}

	private void OnLoadOver(uint ticket, bool succeed, Object obj)
	{
	}
}
