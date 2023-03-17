using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace indeksatory
{
    public class Parking : IEnumerable<Car>
    {
        public string Name { get; set; }
        private const int MaxCars = 100;
        private List<Car> _cars = new List<Car>();
        public int Count => _cars.Count;

        public Car this[string number]
        {
            get
            {
                var car = _cars.FirstOrDefault(c => c.Number == number);
                return car;
            }
        }

        public Car this[int position]
        {
            get
            {
                if (position < _cars.Count)
                {
                    return _cars[position];
                }

                return null;
            }
            set
            {
                if (position < _cars.Count)
                {
                    _cars[position] = value;
                }
            }
            
        }
        
        public int Add(Car car)
        {
            if (car == null)
            {
                throw new ArgumentNullException(nameof(car), "Car is null");
            }

            if (_cars.Count < MaxCars)
            {
                _cars.Add(car);
                return _cars.Count - 1;
            }

            return -1;
        }

        public void GoOut(string number)
        {
            if (string.IsNullOrWhiteSpace(number))
            {
                throw new ArgumentNullException(nameof(number), "Number is null");
            }

            var car = _cars.FirstOrDefault(c => c.Number == number);
            if (car != null)
            {
                _cars.Remove(car);
            }
        }

        public IEnumerator<int> GetNumbers(int max)
        {
            var current = 0;
            for (int i = 0; i < max; i++)
            {
                current += i;
                yield return current;
            }
        }

        public IEnumerator<Car> GetEnumerator()
        {
            return _cars.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class ParkingEnumerator : IEnumerator
    {
        public object Current => throw new NotImplementedException();
        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        
    }
}