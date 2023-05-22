# C# 10 Design Paterns 

## Samples
Simple codes to example the 23 Gang of Four (GoF) patterns

<br>
<table>
   <thead>
      <tr>
         <th>S.O.L.I.D Principle</th>
         <th>Description</th>
         <th>Pattern</th>
      </tr>
   </thead>
   <tbody>
    <tr>
        <td width="200">(SSP) Single responsability</td>
        <td width="500">
        &nbsp;&nbsp;▪ One responsability<br>
        &nbsp;&nbsp;▪ High cohesion<br>
        </td>
        <td width="200">
        &nbsp;&nbsp;▪ Factory Method<br>
        &nbsp;&nbsp;▪ Abstract Factory<br>
        &nbsp;&nbsp;▪ Builder<br>
        &nbsp;&nbsp;▪ Bridge<br>
        &nbsp;&nbsp;▪ Decorator<br>
        &nbsp;&nbsp;▪ Command<br>
        </td>
    </tr>
    <tr>
        <td width="200">(OOP) Open Closed</td>
        <td width="500">
        &nbsp;&nbsp;▪ Open to be extended, close to updates<br>
        </td>
        <td width="300">
        &nbsp;&nbsp;▪ Factory Method<br>
        &nbsp;&nbsp;▪ Abstract Factory<br>
        &nbsp;&nbsp;▪ Bridge<br>
        &nbsp;&nbsp;▪ Composite<br>
        &nbsp;&nbsp;▪ Façade<br>
        &nbsp;&nbsp;▪ Proxy<br>
        &nbsp;&nbsp;▪ Command<br>
        &nbsp;&nbsp;▪ Mediator<br>
        </td>
    </tr>
    <tr>
        <td width="200">(LSP) Liskov Substitution</td>
        <td width="500">
        &nbsp;&nbsp;▪ Derived class must be replaced for base or parents<br>
        </td>
        <td width="200">
        &nbsp;&nbsp;▪ <br>
        </td>
    </tr>
    <tr>
        <td width="200">(ISP) Interface Segragation</td>
        <td width="500">
        &nbsp;&nbsp;▪ Careful with cohesion and accoupling in your interfaces<br>
        &nbsp;&nbsp;▪ Do not force the implement interface method if not used<br>
        </td>
        <td width="200">
        &nbsp;&nbsp;▪ <br>
        </td>
    </tr>
    <tr>
        <td width="200">(IDP) Dependency Inversion</td>
        <td width="500">
        &nbsp;&nbsp;▪ Rely (depend) abstraction rather than concrete classes<br>
        </td>
        <td width="200">
        &nbsp;&nbsp;▪ <br>
        </td>
    </tr>
   </tbody>
</table>


## Creational

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
         <td width="800">
          Goods:<br>
          &nbsp;&nbsp;▪ Create a class which one singla instance can exist<br>
          &nbsp;&nbsp;▪ Subclasses are created to setup the instance<br>
          &nbsp;&nbsp;▪ Ex: Data logs of apps<br>
          Bads:<br>
          &nbsp;&nbsp;▪ Violates the single responsibility principle<br>
         </td>
      <tr>
         <td width="150">Factory Method</td>
         <td width="800">
         &nbsp;&nbsp;▪ Define an interface to create objects<br>
         &nbsp;&nbsp;▪ Subclasses define the implementation<br>
         &nbsp;&nbsp;▪ Used for static values
         &nbsp;&nbsp;▪ Ex: DBContexts 
         </td>
      </tr>
      <tr>
         <td width="150">Abstract factory</td>
         <td width="800">
         &nbsp;&nbsp;▪ Provide an interface for creating families of related dependence without specifyng the concrete classes<br>
         &nbsp;&nbsp;▪ Ex: Discounts/fees<br>
         </td>
      </tr>
      <tr>
         <td width="150">Builder</td>
         <td width="800">
         &nbsp;&nbsp;▪ Separate object construction from its representation<br>
         &nbsp;&nbsp;▪ Ex: Statements<br>
         </td>
      </tr>
      <tr>
         <td width="150">Prototype</td>
         <td width="800">
            &nbsp;&nbsp;▪ Create a prototype class and create new objects by copying (ICloneable)<br>
            &nbsp;&nbsp;▪ Ex: Person cloned by Manager or Employee<br>
         </td>
      </tr>      
   </tbody>
</table>
</body>



## Structural

<table>
   <thead>
      <tr>
         <th>Pattern</th>
         <th>Description / Used when</th>
      </tr>
   </thead>
   <tbody>
      <tr>
         <td width="150">Adapter</td>
         <td width="800">            
            &nbsp;&nbsp;▪ Defines an existing interface that need to be adapted<br>
            &nbsp;&nbsp;▪ Convert into another interface expected<br>
            &nbsp;&nbsp;▪ Ex: city for external service<br>
         </td>
      <tr>
         <td width="150">Bridge</td>
         <td width="800">
            &nbsp;&nbsp;▪ Decouple/Separate an abstraction from its implementation<br>
            &nbsp;&nbsp;▪ To enable switching implementations at runtime<br>
            &nbsp;&nbsp;▪ Abstraction and implementation should be extensible by subclassing<br>
            &nbsp;&nbsp;▪ Ex: coupons types, different calculations<br>
         </td>
      </tr>
      <tr>
         <td width="150">Decorator</td>
         <td width="800">
            &nbsp;&nbsp;▪ Caller as wraper<br>
            &nbsp;&nbsp;▪ Attache additional responsabilities to objects dynamically<br>
            &nbsp;&nbsp;▪ Ex: Series of taxes that need to be calculate sequentially<br>
         </td>
      </tr>
      <tr>
         <td width="150">Composite</td>
         <td width="800">
            &nbsp;&nbsp;▪ Declares a interface for objects on the composition<br>
            &nbsp;&nbsp;▪ Contains an common operation<br>
            &nbsp;&nbsp;▪ Ex: File systems, Name and GetSize() are common between file and directory, should be inherited<br>
         </td>
      </tr>
      <tr>
         <td width="150">Façade</td>
         <td width="800">            
            &nbsp;&nbsp;▪ Defines a highe-level interface that the subsystem easier to use <br>
            &nbsp;&nbsp;▪ Hide complexity and encourage reuse<br>
            &nbsp;&nbsp;▪ Ex: Discounts calculations, orders<br>
         </td>
      </tr>      
      <tr>
         <td width="150">Proxy</td>
         <td width="800">            
            &nbsp;&nbsp;▪ Provide a surrogate or new place to add controll, access control<br>
            &nbsp;&nbsp;▪ Interface are almost identical to the actual call<br>
            &nbsp;&nbsp;▪ Ex: Documents not protected or protected (require access control)<br>
         </td>
      </tr>      
      <tr>
         <td width="150">Flyweight</td>
         <td width="800">         
            &nbsp;&nbsp;▪ Declares an interface through which they can receive and act on extrinsic state<br>
            &nbsp;&nbsp;▪ Ex: file category that differ by weight and name<br>
            &nbsp;&nbsp;▪ Ex: order with products, values<br>
         </td>
      </tr>      
   </tbody>
</table>
</body>


## Behavioral

<table>
   <thead>
      <tr>
         <th>Pattern</th>
         <th>Description / Used when</th>
      </tr>
   </thead>
   <tbody>
      <tr>
         <td width="150">Template Method</td>
         <td width="800">            
            &nbsp;&nbsp;▪ Defines the skeleton of an algorithm in an operation<br>
            &nbsp;&nbsp;▪ Deferring some steps to subclasses<br>
            &nbsp;&nbsp;▪ Ex: Email parser to outlook, gmail<br>
         </td>
      <tr>
         <td width="150">Strategy</td>
         <td width="800">
            &nbsp;&nbsp;▪ Knows as policy pattern<br>
            &nbsp;&nbsp;▪ Lets you define a family of algorithms in separate classes and make the policies interchangeable<br>
            &nbsp;&nbsp;▪ Ex: Tax calculation icms, iis<br>         
         </td>
      </tr>
      <tr>
         <td width="150">Command</td>
         <td width="800">
            &nbsp;&nbsp;▪ Knows as Action or transaction pattern<br>
            &nbsp;&nbsp;▪ Used for queue or log requests<br>
            &nbsp;&nbsp;▪ To control transactions, let you undu action<br>
            &nbsp;&nbsp;▪ Ex: Used for queue or log requests<br>         
            &nbsp;&nbsp;▪ Ex: Used for execute, undu, transaction control<br>
         </td>
      </tr>
      <tr>
         <td width="150">Memento</td>
         <td width="800">
            &nbsp;&nbsp;▪ Also knows as Token pattern<br>
            &nbsp;&nbsp;▪ To capture and externalizing an object's internal state<br>
            &nbsp;&nbsp;▪ Support Undu() like `Command` parttern<br>
            &nbsp;&nbsp;▪ Ex: Control Person inputs (add/remove/update/undu all)<br>         
         </td>
      </tr>
      <tr>
         <td width="150">Mediator</td>
         <td width="800">            
            &nbsp;&nbsp;▪ Add a mediator that encapsulates how a set of objects interact.<br>
            &nbsp;&nbsp;▪ Ex: Chat room<br>
         </td>
      </tr>      
      <tr>
         <td width="150">Chain of Responsability</td>            
         <td width="800">            
            &nbsp;&nbsp;▪ Give more than one object a change to handle the request<br>
            &nbsp;&nbsp;▪ Use when the set of objects that handle a request should be specified dinamically<br>
            &nbsp;&nbsp;▪ Ex: Approvals workflows<br>         
         </td>
      </tr>      
      <tr>
         <td width="150">Observer</td>
         <td width="800">         
            &nbsp;&nbsp;▪ Also knows as publish-subscriber<br>
            &nbsp;&nbsp;▪ Lets notify multiple subscribers about any events<br>            
            &nbsp;&nbsp;▪ Ex: Notification events<br>         
         </td>
      </tr>      
      <tr>
         <td width="150">State</td>            
         <td width="800">          
            &nbsp;&nbsp;▪ To allow an object to alter its behavior when its internal state changes<br>
            &nbsp;&nbsp;▪ When an object's behavior depends on its state and it must change it at runtime (depending on that state)<br>
            &nbsp;&nbsp;▪ Ex: ▪ Used on approval workflows <br>
            &nbsp;&nbsp;      ▪ Balance statements with dynamic internal roles <br>
         </td>
      </tr>      
      <tr>
         <td width="150">Iterator</td>
         <td width="800">         
            &nbsp;&nbsp;▪ To provide a way to access the elements of an aggregate object sequentially without exposing its underlying representation<br>
            &nbsp;&nbsp;▪ Ex: to support multiple ways of traversal for the same aggregate object<br>
         </td>
      </tr>      
      <tr>
         <td width="150">Visitor</td>            
         <td width="800">            
            &nbsp;&nbsp;▪ lets you define a new operation without changing the classes of the elements on which it operates<br>
            &nbsp;&nbsp;▪ Ex: <br>
         </td>
      </tr>      
      <tr>
         <td width="150">Interpreter</td>            
         <td width="800">            
            &nbsp;&nbsp;▪ Given a language, define a representation for its grammar along with an interpreter that uses the representation to interpret sentences in the language<br>
            &nbsp;&nbsp;▪ Ex: Translators<br>
         </td>
      </tr>      
   </tbody>
</table>
</body>
