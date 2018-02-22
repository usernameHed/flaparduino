﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class RigidbodyExt
{
	/// <summary>
	/// Allow for speed limit constant move
	/// </summary>
	public static void AccelerateTo(this Rigidbody body, Vector3 targetVelocity, float maxAccel, ForceMode forceMode = ForceMode.Acceleration)
	{
		Vector3 deltaV = targetVelocity - body.velocity;
		Vector3 accel = deltaV / Time.deltaTime;

		if (accel.sqrMagnitude > maxAccel * maxAccel)
			accel = accel.normalized * maxAccel;

		body.AddForce(accel, forceMode);
	}

	/// <summary>
	/// Return kinectic energy of a body
	/// </summary>
	public static float KineticEnergy(this Rigidbody rb)
	{
		// mass in kg
		// velocity in meters per second
		// result is joules
		return (0.5f * rb.mass * Mathf.Pow(rb.velocity.magnitude, 2));
	}
}
