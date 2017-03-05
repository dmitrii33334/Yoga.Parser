﻿namespace Yoga.Parser
{
	using System;
	using System.Collections.Generic;

	public interface INode
	{
		string Name { get; }

		IEnumerable<string> Properties { get; }

		bool Has(string name);

		object Get(string name, Type type);
	}

	public static class INodeExtensions
	{
		public static T Get<T>(this INode node, string name) => (T)node.Get(name, typeof(T));
	}
}