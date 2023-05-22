# Creational

Pattern | Description | Consequences
--- | --- | --- |
Singleton | ▪ Ensure a class of which only a single instance can exist, and provide a global point of access it
			▪ Ex. Data logs of application.
			▪ Difference of flyweight: The flyweight guarantees the exist of only one instance of many elements, is a bigger singleton.
		  | ▪ Strict control over how and when clients access it
			▪ Avoids polluting the namespace with global variables
			▪ Subclassing allows configuring the application with an instance of the class you need at runtime
			▪ Multiple instances can be allowed without having to alter the client
			▪ Violates the single responsibility principle





