using System;
using UnityEngine;

namespace Bridge
{
    public class CarManager : MonoBehaviour
    {
        public Car[] cars;

        private void Start()
        {
            cars = FindObjectsOfType<Car>();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                foreach (Car car in cars)
                {
                    car.Paint();
                }
            }
        }
    }
}