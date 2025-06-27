using System;
using System.Collections.Generic;
namespace DeveloperSample.Container
{

    public class Container
    {
        public Dictionary<Type,Type> BindingValues
        {
            get; set;
        }
        public Container() {
            BindingValues= new Dictionary<Type,Type>();
        }

        public void Bind(Type interfaceType, Type implementationType)
        {
            if (!interfaceType.IsInterface)
            {
                throw new ArgumentException("Invalid interface type");
            }
            if (!implementationType.IsClass)
            {
                throw new ArgumentException("Invalid implementation type");
            }
            if (!interfaceType.IsAssignableFrom(implementationType))
            {
                throw new ArgumentException("Implementation type cannot be assignable to interface type");
            }
            else
            {
                BindingValues.Add(interfaceType, implementationType);
            }
        }
        public T Get<T>()
        {
            var type= BindingValues[typeof(T)];
            return (T)(Activator.CreateInstance(type));
        }
    }
}