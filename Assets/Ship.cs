using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Ship {

	public float FuelRemaining;
	public float FuelCapacity;
	public float ConsumptionPerParsec;

	public List<Pallet> Pallets = new List<Pallet>();
	public List<Module> Modules = new List<Module>();
}
