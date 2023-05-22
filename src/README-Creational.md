# Creational


<table>
   <thead>
      <tr>
         <th>Pattern</th>
         <th>Description / Used when</th>
      </tr>
   </thead>
   <tbody>
      <tr>
         <td width="150">Singleton</td>
         <td width="600">     
             <table>
             <tr><td width="600">
             Definition:<br>
                &nbsp;&nbsp;▪ Ensure a class of which only a single instance can exist, and provide a global point of access it<br>
	            &nbsp;&nbsp;▪ Ex. Data logs of application.<br>
                &nbsp;&nbsp;▪ The flyweight guarantees the exist of only one instance of many elements, is a bigger singleton.<br>
            </td></tr>
            <tr><td width="600">
                Consequences<br>
                &nbsp;&nbsp;▪ Strict control over how and when clients access it<br>
                &nbsp;&nbsp;▪ Avoids polluting the namespace with global variables<br>
                &nbsp;&nbsp;▪ Subclassing allows configuring the application with an instance of the class you need at runtime<br>
                &nbsp;&nbsp;▪ Multiple instances can be allowed without having to alter the client<br>
                &nbsp;&nbsp;▪ Violates the single responsibility principle<br>    
             </td></tr>
            </table>
         </td>
      </tr>
      <tr>
         <td width="150">Factory Method</td>
         <td width="600">
         <table>
            <tr><td width="600">
            Definition<br>
            &nbsp;&nbsp;▪ Define an interface for creating an object, but to let subclasses decide which class to instantiate. <br>
            &nbsp;&nbsp;▪ Lets a class defer instantiation to subclasses<br>
            &nbsp;&nbsp;▪ Separates the object construction from its representation<br>
            &nbsp;&nbsp;▪ Similar than Builder but used for static values, like DBContexts, to create, request DB connections.<br>
            &nbsp;&nbsp;▪ Related to abstract factory and prototype patterns<br>
            </td></tr>
            <tr><td width="600">
            Consequences:<br>
            &nbsp;&nbsp;▪ Eliminate need to bind application-specific classes to your code<br>
            &nbsp;&nbsp;▪ New types of products can be added without breaking client code: open/closed principle<br>
            &nbsp;&nbsp;▪ Creating products is moved to one specific place in your code, the creator: single responsibility principle<br>
            &nbsp;&nbsp;▪ Clients might need to create subclasses of the creator class just to create a particular concreteproduct object<br>
            </td></tr>
        </table>
        </td>
      </tr>
      <tr>
         <td width="150">Abstract factory</td>
         <td width="600">
         <table>
            <tr><td width="600">
            Definition<br>
                &nbsp;&nbsp;▪ Provide an interface for creating families of related or dependent objects without specifying their concrete classes<br>
                &nbsp;&nbsp;▪ tight coupling<br>
                &nbsp;&nbsp;▪ does not convey the intent that these objects belong together<br>
                &nbsp;&nbsp;▪ The client is decoupled from the concrete factory implementation<br>
            </td></tr>
            <tr><td width="600">
            Consequences:<br>
                &nbsp;&nbsp;▪ Isolate concrete classes, because it encapsulates the responsibility and the process of creating product objects<br>
                &nbsp;&nbsp;▪ New products can easily be introduced without breaking client code: open/closed principle<br>
                &nbsp;&nbsp;▪ Code to create products is contained in one place: single responsibility principle<br>
                &nbsp;&nbsp;▪ It makes exchanging product families easy<br>
                &nbsp;&nbsp;▪ Promotes consistency among products<br>
                &nbsp;&nbsp;▪ Supporting new kinds of products is rather difficult<br>
            </td></tr>
        </table>         
         </td>
      </tr>
      <tr>
         <td width="150">Builder</td>
         <td width="600">
         <table>
            <tr><td width="600">
            Definition:<br>
                &nbsp;&nbsp;▪ Separates object construction from its representation
                &nbsp;&nbsp;▪ Like when you need create a new instance of an complex class/object, with many parameters.<br>
                &nbsp;&nbsp;▪ So that, the same construction process can create different representations.<br>
                &nbsp;&nbsp;▪ Exemplo: Uma NF é um objecto complexo, possui muitos campos e outras acoes envolvidas para ser instanciado. <br>
                &nbsp;&nbsp;▪ Criar um builder facilita o entendimento do codigo<br>            
            </td></tr>
            <tr><td width="600">
            Consequences:<br>
	            &nbsp;&nbsp;▪ Lets us vary a products' internal representation<br>
	            &nbsp;&nbsp;▪ Isolates code for construction and representation<br>
	            &nbsp;&nbsp;▪ Improves modularity by encapsulating the way a complect object is constructed and represented: 
                &nbsp;&nbsp;&nbsp;&nbsp;▪ single responsibility principle<br>
	            &nbsp;&nbsp;▪ Give us finer control over the construction process<br>
	            &nbsp;&nbsp;▪ Complexity of your code base increases<br>
                <br>
            Related to:<br>
	            &nbsp;&nbsp;▪  Abstract factory<br>
		            &nbsp;&nbsp;▪ Both can be used to construct complex objects, but the builder constructs the complex objects step by step<br>
	            &nbsp;&nbsp;▪ Related to Singleton<br>
		            &nbsp;&nbsp;▪ Builder can be implemented as a singleton<br>
	            &nbsp;&nbsp;▪ Related to Composite<br>
		            &nbsp;&nbsp;▪ Composites are often built by builders<br>   
            </td></tr>
        </table>         
         </td>
      </tr>
      <tr>
         <td width="150">Prototype</td>
         <td width="600">
         <table>
            <tr><td width="600">
            Definition:<br>
                &nbsp;&nbsp;▪ Specify the kinds of objects to create using a prototypical instance, and create new objects by copying this prototype<br>
                &nbsp;&nbsp;▪ ICloneable Interface: enables us to provide a customized implementation that creates a copy of an existing object.<br>
                &nbsp;&nbsp;▪ Does not specify whether the cloning operation performs a deep copy, a shallow copy, or something in between<br>
                &nbsp;&nbsp;▪ It does not require all property values of the original instance to be copied to the new instance<br>
                &nbsp;&nbsp;▪ It returns an object, which means the client could need an additional cast<br>
            <br>
            Use when:<br>
	            &nbsp;&nbsp;▪ System should be independent of how its objects are created, 
                &nbsp;&nbsp;▪ To avoid building a set of factories that mimics the class hierarchy<br>
	            &nbsp;&nbsp;▪ When a system should be independent of how its objects are created, 
                &nbsp;&nbsp;▪ When instances of a class can have one of only a few different combinations of states<br>   
            </td></tr>
            <tr><td width="600">
            Consequences:<br>
	            &nbsp;&nbsp;▪ Prototype hides the ConcreteProduct classes from the client, 
                &nbsp;&nbsp;▪ Reduces what client needs to know<br>
	            &nbsp;&nbsp;▪ Reduced subclassing<br>
	            &nbsp;&nbsp;▪ Each implementation of the prototype base class must implement it own clone method<br>
            <br>
                Related to:<br>
	            &nbsp;&nbsp;▪ Abstract factory<br>
		            &nbsp;&nbsp;▪ A factory might store a set of prototypes from which it clones when a new instance is required<br>
	            &nbsp;&nbsp;▪ Factory method<br>
		            &nbsp;&nbsp;▪ Factory method is based on inheritance, but doesn't require an initialization step<br>
	            &nbsp;&nbsp;▪ Singleton<br>
		            &nbsp;&nbsp;▪ Prototype can be implemented as a singleton<br>
	            &nbsp;&nbsp;▪ Composite<br> 
		            &nbsp;&nbsp;▪ Can use prototype for convenient object creation<br>
	            &nbsp;&nbsp;▪ Decorator<br>
		            &nbsp;&nbsp;▪ Can use prototype for convenient object creation<br>
            </td></tr>
        </table>            
         </td>
      </tr>      
   </tbody>
</table>
</body>