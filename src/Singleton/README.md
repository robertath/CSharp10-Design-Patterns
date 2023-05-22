# Singleton Pattern

### Definition
▪ Ensure a class of which only a single instance can exist, and provide a global point of access it
	
### Used when
▪ There must be exactly one instance of a class, and it must be accessible to clients from a well-know access point
▪ When the sole instance should be extensible by subclassing, and clients should be able to use an extended instance without modifying their code
▪ Ex. Data logs of application.

### Consequences
▪ Strict control over how and when clients access it
▪ Avoids polluting the namespace with global variables
▪ Subclassing allows configuring the application with an instance of the class you need at runtime
▪ Multiple instances can be allowed without having to alter the client
▪ Violates the single responsibility principle



### Related to
▪ Difference of flyweight: The flyweight guarantees the exist of only one instance of many elements, is a bigger singleton.
