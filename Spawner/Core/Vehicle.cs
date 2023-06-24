﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace SpawnerTLD.Core
{
	internal class Vehicle
	{
		public GameObject vehicle;
		public int variant;
		public int conditionInt = 0;
		public int fuelMixes = 1;
		public List<float> fuelValues = new List<float> { -1f };
		public List<int> fuelTypeInts = new List<int> { -1 };
		public Color color = new Color(255f / 255f, 255f / 255f, 255f / 255f);
		public string plate = String.Empty;
	}
}