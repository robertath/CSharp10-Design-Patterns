# State Pattern

### Definition:
§ To allow an object to alter its behavior when its internal state changes
§ Alter an objects behavior when its state changes. The object will appear to change its class.

### Used when:
§ Used on approval workflows 
§ Balance statements with dynamic internal roles
§ When an object's behavior depends on its state and it must change it at runtime (depending on that state)
§ When your objects are dealing with large conditional statements that depend on the object's state

### Consequences:
• It localizes state-specific behavior and partitions behavior for different states: single responsibility principle
• New states and transitions can easily be added by defining new subclasses: open/closed principle
• The number of classes is increased, which adds additional complexity

### Related to:
• Flyweight
	• Without instance variables in the state objects, they become flyweights
• Singleton
	State objects are often singleton
• Strategy
	• Also based on composition, but solves a different problem
• Bridge
	• Also based on composition, but solves a different problem
