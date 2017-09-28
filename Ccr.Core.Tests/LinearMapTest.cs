﻿using System;
using Ccr.Core.Extensions;
using NUnit.Framework;
// ReSharper disable BuiltInTypeReferenceStyle

namespace Ccr.Core.Tests
{
	[TestFixture]
	public class LinearMapTest
	{
		[Test]
		public void LinearMap_Byte()
		{
			const Byte value = 50;
			var mappedValue = value.LinearMap((0, 100), (100, 200));
			Assert.AreEqual(mappedValue, (Byte)150);
		}
		[Test]
		public void LinearMap_SByte()
		{
			const SByte value = 50;
			var mappedValue = value.LinearMap((0, 100), (100, 110));
			Assert.AreEqual(mappedValue, (SByte)105);
		}
		[Test]
		public void LinearMap_Int16()
		{
			const Int16 value = 50;
			var mappedValue = value.LinearMap((0, 100), (1000, 2000));
			Assert.AreEqual(mappedValue, (Int16)1500);
		}

		[Test]
		public void LinearMap_Int32()
		{
			const Int32 value = 50;
			var mappedValue = value.LinearMap((0, 100), (1000, 2000));
			Assert.AreEqual(mappedValue, 1500);
		}

		[Test]
		public void LinearMap_Int64()
		{
			const Int64 value = 50L;
			var mappedValue = value.LinearMap((0, 100), (1000, 2000));
			Assert.AreEqual(mappedValue, 1500L);
		}


		[Test]
		public void LinearMap_UInt16()
		{
			const UInt16 value = 50;
			var mappedValue = value.LinearMap((0, 100), (1000, 2000));
			Assert.AreEqual(mappedValue, (Int16)1500);
		}

		[Test]
		public void LinearMap_UInt32()
		{
			const UInt32 value = 50U;
			var mappedValue = value.LinearMap((0, 100), (1000, 2000));
			Assert.AreEqual(mappedValue, 1500U);
		}

		[Test]
		public void LinearMap_Single()
		{
			const Single value = 50.0F;
			var mappedValue = value.LinearMap((0, 100), (10.00, 20.00));
			Assert.AreEqual(mappedValue, 15.00F);
		}

		[Test]
		public void LinearMap_Double()
		{
			const Double value = 50.00D;
			var mappedValue = value.LinearMap((0, 100), (1000, 2000));
			Assert.AreEqual(mappedValue, 15.00D);
		}
		[Test]
		public void LinearMap_Decimal()
		{
			const Decimal value = 50.00M;
			var mappedValue = value.LinearMap((0, 100), (10.00M, 20.00M));
			Assert.AreEqual(mappedValue, 15.00M);
		}
	}
}
