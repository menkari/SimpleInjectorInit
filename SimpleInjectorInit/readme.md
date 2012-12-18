# SimpleInjectorInit

In deciding which IOC container to use, I naturally gravitated toward Autofac created by Nicholas Blumhardt.
But in checking out the websphere, I found there's a whole bunch of containers...So I need to figure out which 
one is best suited to the purpose of adhoc development.

This IoC starter project makes use of the following framework:

* Simple Injector
* MVC4 Framework
* .net 4.5

The biggest hurdle I currently face is the requirement of a base template in which to work with 
on a day to day basis. I have to be able to switch out classes and containers easily.

* Ease of implementation
* Pluggability
* Extensible

In order to demonstrate the capabilities of this IoC container, I will create two simple repository classes
which implement the same interface and therefore can be consumed in the same way using the DI framework.

The first will make use of a simple API call which will return a simple text: "Hello World"