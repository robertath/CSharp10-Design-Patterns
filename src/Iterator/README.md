# Iterator Pattern

### Definition:
▪ To provide a way to access the elements of an aggregate object sequentially without exposing its underlying representation
▪ Aggregate objects (list, dictionary, stack, queue,..) keep their items in an internal structure

### Used when:
▪ You want to access an aggregate object's content without exposing its internal representation
▪ You want to support multiple ways of traversal for the same aggregate object
▪ You want to avoid code duplication in regards to traversing the aggregate object

### Consequences:
▪ Iterators simplify the interface of your aggregate structure as traversal code is separated out: single responsibility principle
▪ You can implement new types of aggregate objects an iterators without them interfering with each other: open/closed principle
▪ Iterators can exist next to each other at the same time on the same collection
▪ Can be a bit overkill when you only use simple traversals and collections

### Related to:
▪ Composite
	▪ Iterators are often used to traverse its recursive structure
▪ Memento
	▪ The memento can be used to store the state of the iterator and potentially, roll it back
▪ Visitor
	▪ You can use an iterator to traverse a potentially complex data structure, and apply logic to the items in that structure with a visitor
