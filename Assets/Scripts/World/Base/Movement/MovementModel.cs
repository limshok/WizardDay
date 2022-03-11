using System;
using Descriptions;
using Unity.Mathematics;
using UnityEngine;
using UnityTemplateProjects.Utilities;

namespace World.Base.Movement
{
	public class MovementModel : ISystem
	{
		public event Action<float> OnUpdate;

		public readonly IMovementDescription Description;
		public Vector3 Input { get; private set; }
		public float XRotation { get; private set; }

		public MovementModel(IMovementDescription description)
		{
			Description = description;
		}

		public void SetInput(Vector3 direction)
		{
			Input = direction;
		}

		public void AddXRotation(float diff)
		{
			XRotation += diff;
		}
		public void Update(float deltaTime)
		{
			OnUpdate?.Invoke(deltaTime);
		}
	}
}