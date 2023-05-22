# Structural


<table>
   <thead>
      <tr>
         <th>Pattern</th>
         <th>Description / Used when</th>
      </tr>
   </thead>
   <tbody>
      <tr>
         <td width="100">Adapter</td>
         <td width="800">     
             <table>
             <tr><td width="800">
            Definition<br>
            &nbsp;&nbsp;▪ Defines an existing interface that needs to be adapted<br>
            &nbsp;&nbsp;▪ Convert the interface of a class into another interface expect.<br>
            &nbsp;&nbsp;▪ Lets classes work together that couldn't otherwise because of incompatible interfaces<br>
            &nbsp;&nbsp;▪ Object adapter relies on composition<br>
            &nbsp;&nbsp;▪ Class adapter relies on multiple inheritance<br>
            <br>
            Use when:<br>
	        &nbsp;&nbsp;▪ When you want to use an existing class but the interface does not match the one you need<br>
	        &nbsp;&nbsp;▪ When you want to create a reusable class (the adapter) that works wit classes that don't have compatible interfaces<br>
	        &nbsp;&nbsp;▪ When you need to use several existing subclasses, <br>
                &nbsp;&nbsp;&nbsp;&nbsp;▪ Don't want create additional subclasses for each of them, but still need to adapt their interface<br>
        </td></tr>
        <tr><td width="800">
            Consequences:<br>
            &nbsp;&nbsp;▪ A single adapter can work with many adaptees, and can add functionality to all adapters at once<br>
            &nbsp;&nbsp;▪ The interface (adapter code) is separated out from the rest of the code: single responsibility principle<br>
            &nbsp;&nbsp;▪ New types of adapters can be introduced without breaking client code: `open/closed principle`<br>
            &nbsp;&nbsp;▪ The object adapter makes it hard to override adaptee behavior<br>
            &nbsp;&nbsp;▪ Additional complexity is introduced
            Related to:<br>
            &nbsp;&nbsp;▪ Bridge<br>
	        &nbsp;&nbsp;&nbsp;&nbsp;▪ Bridge separates interface from implementation, adapter changes the interface of an existing object<br>
            &nbsp;&nbsp;▪ Decorator <br>
	        &nbsp;&nbsp;&nbsp;&nbsp;▪ Decorator changes an object without changing its interface, adapter changes the interface of an existing object<br>
            &nbsp;&nbsp;▪ Façade<br>
	        &nbsp;&nbsp;&nbsp;&nbsp;▪ With façade you define a new interface for an entire system, with adapter you're making an existing interface useable via wrapping<br>
         </td></tr>
        </table>
        </td>
      </tr>
      <tr>
         <td width="100">Bridge</td>
         <td width="800">     
             <table>
             <tr><td width="800">
            Definition<br>
            &nbsp;&nbsp;▪ Decouple an abstraction from its implementation so the two can vary independently<br>
            &nbsp;&nbsp;▪ Separate abstraction from implementation<br>
	        &nbsp;&nbsp;&nbsp;&nbsp;▪ Means to replace an implementation with another implementation without modifying the abstraction<br>
            &nbsp;&nbsp;▪ Use cases:<br>
	        &nbsp;&nbsp;&nbsp;&nbsp;▪ When you want to avoid a permanent binding between an abstraction and its implementation (to enable switching implementations at runtime)<br>
	        &nbsp;&nbsp;&nbsp;&nbsp;▪ When abstraction and implementations should be extensible by subclassing<br>
            &nbsp;&nbsp;▪ When you don't want changes in the implementation of an abstraction have an impact on the client<br>
         </td></tr>
        <tr><td width="800">
           Consequences:<br>
           &nbsp;&nbsp;▪ Decoupling: the implementation isn't permanently bound to the abstraction<br>
            &nbsp;&nbsp;▪ Extensibility: as the abstraction and implementation hierarchies can evolve independently, new ones can be introduced as such: open/closed principle<br>
            &nbsp;&nbsp;▪ You can hide implementation details away from clients<br>
            &nbsp;&nbsp;▪ You can focus on high-level logic in the abstraction, and on the details in the implementation: single responsibility principle<br>
            &nbsp;&nbsp;▪ Related to:<br>
	        &nbsp;&nbsp;&nbsp;&nbsp;▪ Abstract factory<br>
		    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;▪ Factory can create and configure a bridge<br>
	        &nbsp;&nbsp;&nbsp;&nbsp;▪ Adapter<br>
		    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;▪ Adapter lets unrelated classes work together, bridge lets abstractions and implementation vary independently<br>
	        &nbsp;&nbsp;&nbsp;&nbsp;▪ Strategy<br>
		    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;▪ Based on composition, like bridge<br>
	        &nbsp;&nbsp;&nbsp;&nbsp;▪ State<br>
		    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;▪ Based on composition, like bridge<br>
         </td></tr>
        </table>
        </td>
      </tr>
      <tr>
         <td width="100">Decorator</td>
         <td width="800">     
             <table>
             <tr><td width="800">     
            Definition<br>
            &nbsp;&nbsp;▪ Attaches additional responsibilities to objects dynamically, <br>
            &nbsp;&nbsp;▪ Provide a flexible alternative to subclassing for extending functionality.<br>
            &nbsp;&nbsp;▪ Caller as wrapper <br>
            &nbsp;&nbsp;▪ Maintains a reference to a Component object, and defines an interface that conforms to Component's interface<br>
            &nbsp;&nbsp;▪ Use cases:<br>
	            &nbsp;&nbsp;▪ A series of taxes need to be calculated sequentially, you create similar templates and control the invocation by the controller<br>
	            &nbsp;&nbsp;▪ When you have need to add responsibility to individual objects dynamically (at runtime) without affecting other objects<br>
	            &nbsp;&nbsp;▪ When you need to be able to withdraw responsibilities you attached to an object<br>
            When extension by subclassing is impractical or impossible<br>
        </td></tr>
        <tr><td width="800">
            Consequences: 
            &nbsp;&nbsp;▪ More flexible than using static inheritance via subclassing: responsibilities can be added and removed at runtime ad hoc<br>
            &nbsp;&nbsp;▪ You can use the pattern to split feature-loaded classes until there's just one responsibility left per class: single responsibility principle<br>
            &nbsp;&nbsp;▪ Increased effort is required to learn the system due the amount of small, simple classes<br>
            <br>
            Related to<br>
            &nbsp;&nbsp;▪ Adapter<br>
	            &nbsp;&nbsp;▪ Adapter gives a new interface to an object, decorator only changes its responsibilities<br>
            &nbsp;&nbsp;▪ Composite<br>
	            &nbsp;&nbsp;▪ Adapter can be seen as a composite with only one component<br>
            &nbsp;&nbsp;▪ Strategy<br>
	            &nbsp;&nbsp;▪ Decorator lets you change the skin of an object, strategy lets you change its workings<br>
         </td></tr>
        </table>
        </td>
      </tr>
      <tr>
         <td width="100">Composite</td>
         <td width="800">     
             <table>
             <tr><td width="800">
            Definition<br>
            &nbsp;&nbsp;▪ Declares the interface for objects on the compositions, and contains a common operation<br>
            &nbsp;&nbsp;▪ Compose objects into tree structures to represent part-whole hierarchies<br>
            &nbsp;&nbsp;▪ Lets clients treat individual objects and compositions of objects uniformly: as If they all were<br>
            <br>
            &nbsp;&nbsp;▪ Use when<br>
	            &nbsp;&nbsp;▪ You want to represent part-whole hierarchies of objects<br>
	            &nbsp;&nbsp;▪ You want to be able to ignore the difference between compositions of objects and individual objects.<br>
        </td></tr>
        <tr><td width="800">
            Consequences:<br>
            &nbsp;&nbsp;▪ Makes the client simple<br>
            &nbsp;&nbsp;▪ It's easy to add new of components: open/closed principle<br>
            &nbsp;&nbsp;▪ It can make the overall system too generic<br>
            <br>
            Related to<br>
            &nbsp;&nbsp;▪ Chain responsibility<br>
	            &nbsp;&nbsp;▪ Leaf component can pass a request through a chain of all parent components<br>
            &nbsp;&nbsp;▪ Iterator<br>
	            &nbsp;&nbsp;▪ Can be used to traverse composites<br>
            &nbsp;&nbsp;▪ Visitor<br>
	            &nbsp;&nbsp;▪ Can be used to execute an operation over the full composite tree<br>
         </td></tr>
        </table>
        </td>
      </tr>
      <tr>
         <td width="100">Façade</td>
         <td width="800">     
             <table>
             <tr><td width="800">
            Definition<br>
            &nbsp;&nbsp;▪ Provide a unified interface to a set of interfaces in a subsystem<br>
            &nbsp;&nbsp;▪ Defines the higher-level interface that makes the subsystem easier to use<br>
            &nbsp;&nbsp;▪ Hides away the complexity and encourage reuse<br>
            &nbsp;&nbsp;▪ Façade knows which subsystem classes are responsible for a request, and delegates client requests to appropriate subsystem objects<br>
	            &nbsp;&nbsp;▪ Subsystem implement functionality but does not know about the façade <br>
            &nbsp;&nbsp;▪ Use when<br>
	            &nbsp;&nbsp;▪ You want to provide a simple interface into a complex subsystem<br>
	            &nbsp;&nbsp;▪ When there are many dependencies between a client and the implementation classes of the abstraction<br>
        </td></tr>
        <tr><td width="800">
           Consequences:<br>
            &nbsp;&nbsp;▪ The number of objects clients to deal with are reduced<br>
            &nbsp;&nbsp;▪ It promotes weak coupling between the subsystem and its clients, enabling subsystem components to vary without affecting the client: open/closed principle<br>
            &nbsp;&nbsp;▪ Clients are not forbidden to use subsystem classes<br>
            <br>
            Related to<br>
            &nbsp;&nbsp;▪ Abstract factory<br>
	            &nbsp;&nbsp;▪ Can provide an interface for creating subsystem objects<br>
            &nbsp;&nbsp;▪ Mediator<br>
	            &nbsp;&nbsp;▪ Also abstracts functionality of existing classes, but its purpose is abstracting communication between objects, while façade is about promoting easy of use.<br>
            &nbsp;&nbsp;▪ Adapter<br>
	            &nbsp;&nbsp;▪ Adapter makes existing interfaces useable by wrapping one object, while with façade you are defining a new interface for an entire subsystem.<br>
         </td></tr>
        </table>
        </td>
      </tr>
      <tr>
         <td width="100">Proxy</td>
         <td width="800">     
             <table>
             <tr><td width="800">
         Definition:<br>
            &nbsp;&nbsp;▪ Provide a surrogate or  placeholder for another object to control access it<br>
            &nbsp;&nbsp;▪ Provides an interface identical to the actual call (although this is sometimes diverted from…)<br>
            &nbsp;&nbsp;▪ Use when:<br>
	            &nbsp;&nbsp;▪ If you need to provide control access to objects<br>
	            &nbsp;&nbsp;▪ Remote proxy: to provide local representative<br>
	            &nbsp;&nbsp;▪ Virtual proxy: to expensive objects on demand<br>
	            &nbsp;&nbsp;▪ Smart proxy: to caching or locking scenario<br>
	            &nbsp;&nbsp;▪ Protection proxy: when objects need different access rules<br>
         </td></tr>
        <tr><td width="800">
            &nbsp;&nbsp;▪ Allows introducing new proxies without changing the client code: open/closed principle<br>
            &nbsp;&nbsp;▪ Added complexity because of additional classes<br>
            &nbsp;&nbsp;▪ Performance impact of passing through additional layers<br>
            <br>
            Relate to<br>
            &nbsp;&nbsp;▪ Adapter<br>
	            &nbsp;&nbsp;▪ Adapter provides a different interface, proxy provides the same interface<br>
            &nbsp;&nbsp;▪ Decorator<br>
	            &nbsp;&nbsp;▪ Decorator adds responsibilities to an object, while proxy controls access to an object<br>
         </td></tr>
        </table>
        </td>
      </tr>
      <tr>
         <td width="100">Flyweight</td>
         <td width="800">     
             <table>
             <tr><td width="800">
            Definition<br>
            &nbsp;&nbsp;▪ Declares an interface through which they can receive and act on extrinsic state<br>
            &nbsp;&nbsp;▪ A fine-grained instance used for efficient sharing to support large number of fine-grained objects efficiently.<br>
            &nbsp;&nbsp;▪ It does that by sharing parts of the state between these objects instead of keeping all that state in all of the objects.<br>
	            &nbsp;&nbsp;▪ Creating a new object instance for each character would require a log of memory<br>
            &nbsp;&nbsp;▪ Examples<br>
	            &nbsp;&nbsp;▪ A product management system with products with a fixed category that differ in weight and names<br>
	            &nbsp;&nbsp;▪ An ordering system with a few intrinsic values order<br>
	            &nbsp;&nbsp;▪ Library system<br>
            &nbsp;&nbsp;▪ Mandatory considerations<br>
	            &nbsp;&nbsp;▪ Does the application use a large number of objects<br>
	            &nbsp;&nbsp;▪ Are storage costs high because of the large amount of objects<br>
	            &nbsp;&nbsp;▪ Can most of the object state be made extrinsic?<br>
	            &nbsp;&nbsp;▪ If you remove extrinsic state, can a large group of objects be replaced by relatively few shared objects?<br>
	            &nbsp;&nbsp;▪ Does the application require object identity?<br>
            &nbsp;&nbsp;▪ Not all flyweights have to be shared<br>
	            &nbsp;&nbsp;▪ UnsharedConcreteFlyweight enables acting on extrinsic state, while having unshareable intrinsic state<br>
            <br>
            &nbsp;&nbsp;▪ Used when<br>
	            &nbsp;&nbsp;▪ When we have many instances of the same object walking through the system, and we need to save money. 
                &nbsp;&nbsp;▪ To this end, flyweight makes use of a modified factory that holds these instances.<br>
	            &nbsp;&nbsp;▪ App use large number of objects<br>
	            &nbsp;&nbsp;▪ When storage costs are high because of the large amount of objects<br>
	            &nbsp;&nbsp;▪ When most of the  object state be made extrinsic<br>
	            &nbsp;&nbsp;▪ When, if you remove extrinsic state, a large group of objects be replaced by relatively few shared objects<br>
            When de application does not require object identity<br>
         </td></tr>
        <tr><td width="800">
            Consequences:<br>
            &nbsp;&nbsp;▪ You may save a log of memory when using the pattern for an applicable use case<br>
            &nbsp;&nbsp;▪ Processing costs might go up, but that's typically offsetted by reduced storage costs<br>
            &nbsp;&nbsp;▪ The pattern is complex, which makes the code base more complicated as well<br>
            <br>
            Related to<br>
            &nbsp;&nbsp;▪ State<br>
	            &nbsp;&nbsp;▪ State without instance variables makes these objects flyweights<br>
            &nbsp;&nbsp;▪ Strategy<br>
	            &nbsp;&nbsp;▪ Strategy can be implemented as a flyweight<br>
         </td></tr>
        </table>
        </td>
      </tr>
   </tbody>
</table>
</body>