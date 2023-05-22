# Behavioral


<table>
   <thead>
      <tr>
         <th>Pattern</th>
         <th>Description / Used when</th>
         <th>Consequences / Related to</th>
      </tr>
   </thead>
   <tbody>
      <tr>
         <td width="150">Template Method</td>
         <td width="350">
            ▪ Defer the exact steps of an algorithm to a subclass<br>
            ▪ define the skeleton of an algorithm in an operation, deferring some steps to subclasses. This patter lets subclasses redefine certain steps of an algorithm without changing the algorithm's structure.<br>
            ▪ Implementation:<br>
	            ▪ Define the template method on the abstract class and don't allow overriding it<br>
	            ▪ Mark methods that differ per subclass as abstract<br>
	            ▪ Mark methods that differ for some subclasses as virtual<br>
            <br>
			▪ Use when:<br>
	            ▪ You want to implement invariant parts of an algorithm only once, and want to leave it to subclasses to implement the rest of the behavior<br>
	            ▪ You want to control which part of an algorithm subclasses can vary<br>
				▪ You have a set of algorithms that don't vary much <br>
         </td>
         <td width="350">
            ▪ Template methods are fundamental technique for code reuse<br>
            ▪ Template methods cannot be changed: the order of methods they call is fixed<br>
			<br>
            Related to:<br>
            ▪ Strategy:<br>
	            ▪ Template method allows varying part of an algorithm through inheritance: a static approach. <br>
	            ▪ Strategy allows behavior to be switched at runtime, via composition: a dynamic approach.<br>
                ▪ Used like strategy but you must create a template subtype to make extensible<br>
         </td>
      </tr>
      <tr>
         <td width="150">Strategy</td>
         <td width="350">
            ▪ Also knows as policy pattern<br>
            ▪ Lets you define a family of algorithms, put each of them into a separate class, and make their objects interchangeable.<br>
            ▪ Strategy lets the algorithm vary independently from clients that use it.<br>
            <br>
			▪ Used when:<br>
	            ▪ Example: You need to perform a taxation calc, for ICMS, ISS types of tax. So, to reusable codes, create a interface and a class for each tax type. <br>
	            ▪ When we create a hierarchy, we receive a most generic type as a parameter, to gain polymorphism on executed role. So we simplify the software evolution. <br>
	            ▪ When many related classes differ only in their behavior<br>
	            ▪ When you need different variants of an algorithm which you want to be able to switch at runtime<br>
	            ▪ When your algorithm uses data, code or dependencies that the clients shouldn't know about<br>
	            ▪ When a class defines many different behaviors which appear as a bunch of conditional statements in its methods<br>
         </td>
         <td width="350">
            ▪ If the client injects the strategy, it must be aware of how strategies differ<br>
            ▪ There's overhead in communication between the strategy and context<br>
            ▪ Additional objects are introduced which increases complexity<br>
            Relate to:<br>
            ▪ Flyweight<br>
	            ▪ Strategy objects make good flyweights<br>
            ▪ Bridge<br>
	            ▪ Also based on composition, but solves another problem<br>
            ▪ State<br>
	            ▪ Also based on composition, but solves another problem<br>
            ▪ Template method<br>
	            ▪ Template method allows varying part of an algorithm through inheritance: a static approach. Strategy allows behavior to be switched at runtime, via composition: a dynamic approach<br>
         </td>
      </tr>
      <tr>
         <td width="150">Command</td>
         <td width="350">
            ▪ Also knows as Action or transaction pattern<br>
            ▪ Encapsulate a request as an object, thereby letting you parametrize clients with different requests<br>
            ▪ Queue or log requests<br>
            ▪ support undoable operations<br>
            ▪ Allows decoupling requester of an action from the receiver<br>
            ▪ Very common in mobile or rich UI development<br>
            ▪ Use when:<br>
	            ▪ You want to parametrize objects with an action to perform<br>
	            ▪ You want to support undo<br>
	            ▪ You want to specify, queue and execute requests at different times<br>
            You need to store a list of changes to potentially reapply later on<br>
         </td>
         <td width="350">
            ▪ It decouples the class that invokes the operation from the one that knows to perform it: single responsibility principle<br>
            ▪ Commands can be manipulated and extended<br>
            ▪ Commands can be assembled into a composite command<br>
            ▪ Existing implementations don't have to be changed to add new commands: open/closed principle<br>
            ▪ Because an additional layer is added, complexity increases<br>
            <br>
            Related to:<br>
            ▪ Patterns that connect senders and receivers<br>
            ▪ Chain of responsibility<br>
	            ▪ Passes a request along a chain of receivers<br>
            ▪ Command<br>
	            ▪ Connects senders with receivers unidirectionally<br>
            ▪ Mediator<br>
	            ▪ Eliminates direct connections altogether<br>
            ▪ Observer<br>
	            ▪ Allows receivers of requests to (un)subscribe at runtime<br>
         </td>
      </tr>
      <tr>
         <td width="150">Memento</td>
         <td width="350">
            ▪ Also knows as token pattern <br>
            ▪ It's all about capturing and externalizing an object's internal state<br>
            ▪ The object can be restored to this state later, without violating encapsulation<br>
            ▪ Supporting undo when working with commands<br>
	            ▪ Consider the command as a class that has internal state that needs to be stored<br>
            ▪ Use when<br>
	            ▪ Part of an object's state must be saved so it can be restored later on<br>
            And when a direct interface to obtaining the state expose implementation details and break encapsulation<br>
         </td>
         <td width="350">
            ▪ Consequences:<br>
	            ▪ It preserves encapsulation boudaries<br>
	            ▪ It simplifies the originator<br>
	            ▪ Using mementos might be expensive<br>
	            ▪ It can introduce complexity to your code base<br>
            ▪ Related patterns:<br>
	            ▪ Command<br>
		            ▪ Can use a memento to store and restore its state<br>
	            ▪ Iterator<br>
		            ▪ Memento can be used to capture the current iteration state and potentially roll it back<br>
         </td>
      </tr>
      <tr>
         <td width="150">Mediator</td>
         <td width="350">
            Definition:<br>
            ▪ Define an object - the mediator - that encapsulates how a set of objects interact.<br>
            ▪ It does that by forcing objects to communicate via that mediator.<br>
            ▪ Alternative: MediaR<br>
            Use when: <br>
                ▪ A set of object communicate in well-defined but complex ways<br>
                ▪ When, because an object refers to and communicates with many other objects, the object is difficult to reuse<br>
                ▪ When behavior that's distributed between several classes should be customizable without a log of subclassing<br>
         </td>
         <td width="350">
            Consequences:<br>
            ▪ It limits subclassing<br>
            ▪ It decouples colleagues<br>
            ▪ It simplifies object protocols<br>
            ▪ New mediators can be introduced without having to change the components: open/closed principle<br>
            ▪ It centralizes control, which can make the mediator turn into a monolith<br>
            <br>
            Relate to:<br>
            ▪ Façade<br>
	            ▪ Mediator abstract communication objects.<br>
            ▪ Façade abstracts the interface to the subsystem objects to promote ease of use<br>
         </td>
      </tr>
      <tr>
         <td width="150">Chain of responsability</td>
         <td width="350">
            Definition:<br>
            ▪ This pattern is to avoid coupling the sender of a request to its receiver by giving more than one object a chance to handle the request.<br>
            ▪ It does that by chaining the receiving objects and passing the request along the chain until an object handles it.<br>
            ▪ Lets you pass requests along a chain of handlers. Upon receiving a request, each handler either to process the request or to pass it to the next handler in the chain.<br>
            <br>
            Use when:<br>
	            ▪ Quando voce tem uma lista de condicionais que precisam ser percorridas e checadas se devem ser executadas<br>
	            ▪ When more than one object may handle a request and the handler isn't know beforehand<br>
	            ▪ When you want to issue a request to one of several object (handlers) without specifying the receiver explicitly<br>
	            ▪ When the set of objects that handle a request should be specified dynamically<br>
         </td>
         <td width="350">
            Consequences:<br>
            ▪ It enables reduced coupling & works towards a single responsibility per class<br>
            ▪ It adds flexibility in regards to assigning responsibilities to objects<br>
            ▪ It does not guarantee receipt of the request<br>
            <br>
            Related to:<br>
            ▪ Composite<br>
	            ▪ The parent of a leaf can act as the successor<br>
            ▪ Chain of Responsibility<br>
	            ▪ Passes a request along a chain of receivers<br>
            ▪ Command<br>
	            ▪ Connects senders with receivers unidirectionally<br>
            ▪ Mediator<br>
	            ▪ Eliminates direct connections altogether<br>
            ▪ Observer<br>
	            ▪ Allows receivers of requests to (un)subscribe at runtime<br>
         </td>
      </tr>
      <tr>
         <td width="150">Observer</td>
         <td width="350">
            ▪ Also knows as publish-subscribers<br>
            ▪ Is a behavioral design pattern that lets you define a subscription mechanism to notify multiple objects about any events that happen to the object they're observing.<br>
            ▪ When something happened and you need to invoke others actions<br>
            ▪ Observer decouple the code, a object observed doesn't know the event object, its just know the action (event name) of the object observed<br>
            <br>
            Use when:
            ▪ Observables in angular
            ▪ Service communication in microservices architectures<br>
            ▪ Quando vc quer executar outros eventos depois de determinada acao.<br>
            ▪ When a change to one object requires changing others, and you don't know in advance how many objects need to be changed<br>
            ▪ When objects that observer others are not necessarily doing that for the total amount of time the application runs<br>
            ▪ When a object should be able to notify other objects without making assumptions about who those objects are<br>
         </td>
         <td width="350">
            Consequences:<br>
            ▪ It allows subjects and observers to vary independently: subclasses can be added and change without having to change others: open/closed principle<br>
            ▪ Subject and observer are loosely coupled: open/closed principle<br>
            ▪ It can lead to a cascade of unexpected updates<br>
            <br>
            Related to:<br>
            ▪ Chain of Responsibility<br>
	            ▪ Passes a request along a chain of receivers<br>
            ▪ Command<br>
	            ▪ Connects senders with receivers unidirectionally<br>
         </td>
      </tr>
      <tr>
         <td width="150">State</td>
         <td width="350">
            Definition:<br>
            ▪ To allow an object to alter its behavior when its internal state changes<br>
            ▪ Alter an objects behavior when its state changes. The object will appear to change its class.<br>
            <br>
            Used when:<br>
            ▪ Used on approval workflows <br>
            ▪ Balance statements with dynamic internal roles<br>
            ▪ When an object's behavior depends on its state and it must change it at runtime (depending on that state)<br>
            ▪ When your objects are dealing with large conditional statements that depend on the object's state<br>
         </td>
         <td width="350">
            Consequences:<br>
            ▪ It localizes state-specific behavior and partitions behavior for different states: single responsibility principle<br>
            ▪ New states and transitions can easily be added by defining new subclasses: open/closed principle<br>
            ▪ The number of classes is increased, which adds additional complexity<br>
            <br>
            Related to:<br>
            ▪ Flyweight<br>
	            ▪ Without instance variables in the state objects, they become flyweights<br>
            ▪ Singleton<br>
	            ▪ State objects are often singleton<br>
            ▪ Strategy<br>
	            ▪ Also based on composition, but solves a different problem<br>
            ▪ Bridge<br>
	            ▪ Also based on composition, but solves a different problem<br>
         </td>
      </tr>
      <tr>
         <td width="150">Iterator</td>
         <td width="350">
            Definition:<br>
            ▪ To provide a way to access the elements of an aggregate object sequentially without exposing its underlying representation<br>
            ▪ Aggregate objects (list, dictionary, stack, queue,..) keep their items in an internal structure<br>
            <br>
            Used when:<br>
            ▪ You want to access an aggregate object's content without exposing its internal representation<br>
            ▪ You want to support multiple ways of traversal for the same aggregate object<br>
            You want to avoid code duplication in regards to traversing the aggregate object<br>
         </td>
         <td width="350">
            Consequences:<br>
            ▪ Iterators simplify the interface of your aggregate structure as traversal code is separated out: single responsibility principle<br>
            ▪ You can implement new types of aggregate objects an iterators without them interfering with each other: open/closed principle<br>
            ▪ Iterators can exist next to each other at the same time on the same collection<br>
            ▪ Can be a bit overkill when you only use simple traversals and collections<br>
            <br>
            Related to:<br>
            ▪ Composite<br>
	            ▪ Iterators are often used to traverse its recursive structure<br>
            ▪ Memento<br>
	            ▪ The memento can be used to store the state of the iterator and potentially, roll it back<br>
            ▪ Visitor<br>
	            ▪ You can use an iterator to traverse a potentially complex data structure, and apply logic to the items in that structure with a visitor<br>
         </td>
      </tr>
      <tr>
         <td width="150">Visitor</td>
         <td width="350">
            Definition:<br>
            ▪ To represent an operation to be performed on the elements of an object structure.<br>
            ▪ Visitor lets you define a new operation without changing the classes of the elements on which it operates<br>
            <br>
            Used when:<br>
            ▪ When an object structure contains many classes of objects with differing interfaces, and you want to perform operations on them that depend on their concrete classes<br>
            ▪ When the classes defining your object structure don't have to change often, but you do often want to define new operations over the structure<br>
            ▪ When you've got potentially many operations that need to be performed on objects in your object structure, but not necessarily on all of them<br>
         </td>
         <td width="350">
            Consequences:<br>
            ▪ It makes new operations easy: you can define a new operation by creating a new visitor: open/closed principle<br>
            ▪ A visitor can accumulate ingo on the objects it visits<br>
            ▪ A visitor gathers related operations together (and separates unrelated ones: single responsibility principle<br>
            ▪ Adding a new ConcreteElement class be hard<br>
            ▪ It might require you to break encapsulation<br>
            <br>
            Related to:<br>
            ▪ Composite<br>
	            ▪ A visitor can be used to apply an object over an object structure defined by the composite pattern<br>
            ▪ Iterator<br>
            ▪ You can use an iterator to traverse a potentially complex data structure, and apply logic to the items in that structure with a visitor<br>
         </td>
      </tr>
      <tr>
         <td width="150">Interpreter</td>
         <td width="350">
            Definition:<br>
            ▪ Given a language, define a representation for its grammar along with an interpreter that uses the representation to interpret sentences in the language<br>
            Used when:<br>
            ▪ When there's a language you can interpret and you can represent statements in the language as abstract syntax trees<br>
            ▪ And when the grammar is simple<br>
            ▪ And when the best possible efficiency isn't required<br>
         </td>
         <td width="350">
            Consequences:<br>
            ▪ It's easy to change and extend the grammar<br>
            ▪ It's easy to implement the grammar<br>
            ▪ Complex grammars are hard to maintain<br>
            Related to:<br>
            ▪ Composite<br>
	            ▪ The abstract syntax tree is an interface of the composite pattern<br>
            ▪ Iterator<br>
	            ▪ You can use iterator to traverse the tree<br>
         </td>
      </tr>
   </tbody>
</table>
</body>