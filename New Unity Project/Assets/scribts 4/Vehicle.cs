using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Vehicle
{
	public float speed;
	public string color;

	public void VehicleSpeed()
	{
		Debug.Log("speed"); // prin("speed");
	}
	public void VehicleColor()
	{
		Debug.Log(color); // prin("speed");

	}
	// Call the default constructor
	public Vehicle()
	{
		Debug.Log("Vehicle() called");
	}
	// Create and call constructor which modifies speed of the vehicle
	public Vehicle(float speed)
	{
		this.speed = speed;
		Debug.Log(speed);
		Debug.Log("Vehicle(speed) called");
	}

	// Create and call constructor which modifies speed and color of the vehicle
	public Vehicle(float speed, string colorval)
	{
		this.speed = speed;
		this.color = colorval;
		Debug.Log(speed + " " + color);
		Debug.Log("Vehicle(speed, color) called");
	}
	public void PrintParams()
	{
		Debug.Log("speed = " + speed);
		Debug.Log("color = " + color);
	}
}